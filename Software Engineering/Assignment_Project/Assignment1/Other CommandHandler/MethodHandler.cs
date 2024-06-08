using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Class to handle method condition
    /// </summary>
    internal class MethodHandler
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
        /// individual command
        /// </summary>
        private string methodName;
        /// <summary>
        /// Regex for method defination
        /// </summary>
        private const string MethodLinePattern = @"method\s+(\w+)\s*\(([^)]*)\)\s*";
        /// <summary>
        /// regex for method invoker
        /// </summary>
        private const string ExecutionLinePattern = @"(\w+)\s*\((.*?)\)";
        /// <summary>
        /// regex for method block
        /// </summary>
        private const string MethodBlock = @"method\s+(\w+)\s*\((.*?)\)([\s\S]*?)\bendmethod\b";
        /// <summary>
        /// no of line of code in field
        /// </summary>
        private int lineCode;

        /// <summary>
        ///Constructor to initialize command, carrier and lengthOfBlock fields 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="carrier"></param>
        /// <param name="methodName"></param>
        public MethodHandler(string methodName, string command, Carrier carrier)
        {
            this.command = command;
            this.methodName = methodName;
            this.carrier = carrier;
            lineCode = 0;
        }
        /// <summary>
        /// Execute the command for method
        /// </summary>
        public void execute()
        {
            if (validate())
            {
                string[] allCommands = command.Split('\n'); //All multitext command
                string[] nameOfMethod = methodName.Split(' ');//add (1,2) execution command

                int lineNumber = carrier.MethodName[nameOfMethod[0]].Item1; //where method is
                int parameterLength = carrier.MethodName[nameOfMethod[0]].Item2;//length of parameter in method

                string code = allCommands[carrier.MethodName[nameOfMethod[0]].Item1];//method add(a,b) form mulittext

                // Extract parameters from method definition
                Regex regex = new Regex(MethodLinePattern);
                Match match = regex.Match(code.Trim());

                // Extract parameters from execution command
                Regex regex1 = new Regex(ExecutionLinePattern);
                Match match1 = regex1.Match(methodName.Trim());

                //Extract body of method
                Regex regex2 = new Regex(MethodBlock);
                Match match2 = regex2.Match(command.Trim());

                int methodParameterLength = 0;
                int methodInvokerParameterLength = 0;

                string methodParameters = match.Groups[2].Value;
                string executionParameters = match1.Groups[2].Value;

                if (methodParameters.Length > 0 && executionParameters.Length > 0)
                {
                    string[] methodArray = methodParameters.Split(new char[] { ',' });
                    methodParameterLength = methodArray.Length;

                    string[] executionArray = executionParameters.Split(new char[] { ',' });
                    methodInvokerParameterLength = executionArray.Length;

                    if (methodInvokerParameterLength == methodParameterLength)
                    {
                        for (int i = 0; i < methodParameterLength; i++)
                        {
                            carrier.Variables[methodArray[i]] = float.Parse(executionArray[i]);
                        }
                    }
                }
                string codeBlock = match2.Groups[3].Value;
                CommandParser parser = new CommandParser(carrier);
                parser.runMultiCommand(codeBlock.Trim());
            }
        }
    
     

        
        /// <summary>
        /// Show error when validating method block
        /// </summary>
        /// <param name="message">Error message</param>
        public void showError(string message)
        {
            throw new IllegalParameterException(message);
        }

        /// /// <summary>
        /// Validate the method block
        /// </summary>
        /// <returns></returns>
        public bool validate()
        {
            string[] allCommands = command.Split('\n'); //All multitext command
            
            string[] nameOfMethod = methodName.Split(' ');//add (1,2) execution command
            
            string code = allCommands[carrier.MethodName[nameOfMethod[0]].Item1];//method add(a,b) form mulittext
            

            // Extract parameters from method definition
            Regex regex = new Regex(MethodLinePattern);
            Match match = regex.Match(code.Trim());

            // Extract parameters from execution command
            Regex regex1 = new Regex(ExecutionLinePattern);
            Match match1 = regex1.Match(methodName.Trim());

            //Extract body of method
            Regex regex2 = new Regex(MethodBlock);
            Match match2 = regex2.Match(command.Trim());

            if (!match.Success)
            {
                if(!carrier.IsTest)
                {
                    showError("Error in Method Defination");
                }
                return false;
            }
            if (!match1.Success)
            {
                if (!carrier.IsTest)
                {
                    showError("Error in Method Invoker");
                }
                return false;
            }
            if (!match2.Success)
            {
                if (!carrier.IsTest)
                {
                    showError("Error in method block");
                }
                return false;
            }
            int methodParameterLength = 0;
            int methodInvokerParameterLength = 0;
            string methodParameters = match.Groups[2].Value;
            string executionParameters = match1.Groups[2].Value;

            if (methodParameters.Length > 0 && executionParameters.Length > 0)
            {
                string[] methodArray = methodParameters.Split(new char[] { ',' });
                methodParameterLength = methodArray.Length;

                string[] executionArray = executionParameters.Split(new char[] { ',' });
                methodInvokerParameterLength = executionArray.Length;

                if (!(methodInvokerParameterLength == methodParameterLength))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Parameters not equal");
                    }
                    
                    return false;
                }
                for (int i = 0; i < methodParameterLength; i++)
                {
                    if (!float.TryParse(executionArray[i], out float number))
                    {
                        if(!carrier.IsTest)
                        {
                            showError("Method Invoker parameter must be number");
                        }
                        return false;
                    }
                }
                
            }
            return true;
        }
    }
}
