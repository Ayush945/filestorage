using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1.CommandHandler.Impl
{
    internal class StoreMethodHandler
    {
        /// <summary>
        /// field which stores given command
        /// </summary>
        private string command;
        /// <summary>
        /// field having current state of panel
        /// </summary>
        private Carrier carrier;
        /// <summary>
        /// Regex pattern for method defination
        /// </summary>
        private const string MethodDefinationPattern = @"method\s+(\w+)\s*\(([^)]*)\)\s*";
        /// <summary>
        /// Line number of method
        /// </summary>
        private int lineNumber;
        /// <summary>
        /// full multiline text
        /// </summary>
        private string multiLine;
        /// <summary>
        /// Regex pattern for method block
        /// </summary>
        private const string MethodBlockPattern = @"method\s+(\w+)\s*\((.*?)\)([\s\S]*?)\bendmethod\b";

        

        /// <summary>
        ///Constructor to initialize command, carrier and lengthOfBlock fields 
        /// </summary>
        /// <param name="command">command given by user</param>
        /// <param name="carrier">necessary field carrying</param>
        /// <param name="lineNumber">Line number of method</param>
        /// <param name="multiLine"></param>

        public StoreMethodHandler(string command,string multiLine, Carrier carrier,int lineNumber)
        {
            this.command = command;
            this.carrier = carrier;
            this.lineNumber=lineNumber;
            this.multiLine = multiLine;
        }
        /// <summary>
        /// getter and setter for lineNumber
        /// </summary>
        public int LineNumber { get => lineNumber; set => lineNumber = value; }
        /// <summary>
        ///method to store variable and parameters 
        /// </summary>
        public void execute()
        {
            if (validate())
            {
                Regex regex = new Regex(MethodDefinationPattern);
                Match match = regex.Match(command.Trim());
                
                string methodName = match.Groups[1].Value;
                string methodParameter = match.Groups[2].Value;
                int parameterLength=0;
                
                Regex regex1=new Regex(MethodBlockPattern);
                Match match1=regex1.Match(multiLine);
                
                if (methodParameter.Length> 0 )
                {
                    string[] parameter = methodParameter.Split(',');
                    parameterLength = parameter.Length;

                    for(int i=0; i<parameterLength; i++)
                    {
                        if (carrier.Variables.ContainsKey(parameter[i]))
                        {
                            carrier.Variables[parameter[i]] = 0;
                        }
                        else
                        {
                            carrier.Variables.Add(parameter[i], 0);
                        }
                        
                    }
                }
                if (carrier.MethodName.ContainsKey(methodName.Trim()))
                {
                    carrier.MethodName[methodName.Trim()] = (LineNumber, parameterLength);
                }
                else
                {
                    carrier.MethodName.Add(methodName.Trim(), (LineNumber, parameterLength));
                    
                }
                string codeBlock = match1.Groups[3].Value.Trim();
                string[] codes = codeBlock.Split('\n');
                LineNumber = codes.Length+1;

            }
        }
        /// <summary>
        /// Validation when storing method
        /// </summary>
        /// <returns></returns>
        public bool validate()
        {
            Regex regex = new Regex(MethodDefinationPattern);
            Match match = regex.Match(command.Trim());
            
            Regex regex1 = new Regex(MethodBlockPattern);
            Match match1 = regex1.Match(multiLine);
            
            if (!match.Success)
            {
                if (!carrier.IsTest)
                {
                    lineNumber = multiLine.Split(' ').Length;
                    showError("Error in Method Defination");
                }
                return false;
            }

            if(!match1.Success)
            {
                if (!carrier.IsTest)
                {
                    lineNumber = multiLine.Split(' ').Length;
                    showError("Error in Method Block");
                }
                return false;
            }
           
            string methodParameter = match.Groups[2].Value;
            if (methodParameter.Length > 0)
            {
                string[] parameter = methodParameter.Split(',');
                for (int i = 0; i < parameter.Length; i++)
                {
                    if (float.TryParse(parameter[i],out float number))
                    {
                        lineNumber = multiLine.Split(' ').Length;
                        if (!carrier.IsTest) { showError("Parameter must be letter"); }
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Method to throw error
        /// </summary>
        /// <param name="message"></param>
        public void showError(string message)
        {
            MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        
    }
}
