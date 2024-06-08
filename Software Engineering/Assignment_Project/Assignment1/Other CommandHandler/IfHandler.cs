using Assignment1.ExceptionHandler;
using Assignment1.HelperClass;
using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Class to handle if method
    /// </summary>
    internal class IfHandler
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
        /// Length of block of if condition
        /// </summary>
        int lengthOfBlock;
        /// <summary>
        /// Regex pattern for If block
        /// </summary>
        private const string IfBlockPattern = @"if\s([^\s]+)\s([!=<>]=?|<>)\s([^\s]+)(.*?)\bendif\b";
        /// <summary>
        ///Constructor to initialize command, carrier and lengthOfBlock fields 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="carrier"></param>
        public IfHandler(string command,Carrier carrier) 
        {
            this.command = command;
            this.carrier = carrier;
            lengthOfBlock = 0;
        }
        /// <summary>
        /// Execute the command for if
        /// </summary>
        public void execute()
        {
            Regex regex = new Regex(IfBlockPattern, RegexOptions.Singleline);
            MatchCollection matches = regex.Matches(command);
            if (validate())
            {
                foreach (Match match in matches)
                {
                    string firstOperand = match.Groups[1].Value;
                    string operation = match.Groups[2].Value;
                    string secondOperand = match.Groups[3].Value;
                    string codeBlock = match.Groups[4].Value.Trim();
                    float second = float.Parse(secondOperand);
                    
                    OperationExecution operationExecution = new OperationExecution(carrier);
                    if (operationExecution.executeOperation(firstOperand, operation, second))
                    {
                        CommandParser parser = new CommandParser(carrier);
                        parser.runMultiCommand(codeBlock);
                    }
                }
            }
            

        }
        /// <summary>
        /// Show error when validating if block
        /// </summary>
        /// <param name="message">Error message</param>
        public void showError(string message)
        {
            MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        /// <summary>
        /// Validate the if block
        /// </summary>
        /// <returns></returns>
        public bool validate()
        {
            Regex regex = new Regex(IfBlockPattern, RegexOptions.Singleline);
            MatchCollection matches = regex.Matches(command);
            if (matches.Count == 0)
            {
                if (!carrier.IsTest)
                {
                    string[] count = command.Split('\n');
                    lengthOfBlock = count.Length - 2;
                    showError("Error in IF Block");
                }
                return false;
            }
            foreach (Match match in matches)
            {
                string firstOperand = match.Groups[1].Value;
                string operation = match.Groups[2].Value;
                string secondOperand = match.Groups[3].Value;
                string codeBlock = match.Groups[4].Value.Trim();
                string[] block = codeBlock.Split('\n');
                lengthOfBlock = block.Length;
                
                if (!float.TryParse(secondOperand, out float second))
                {
                    if (!carrier.IsTest)
                    {
                        string[] count = command.Split('\n');
                        lengthOfBlock = count.Length - 2;
                        showError("Second Operand must be number");
                    }
                    return false;
                }
                if (!carrier.Variables.ContainsKey(firstOperand))
                {
                    if (!carrier.IsTest)
                    {
                        string[] count = command.Split('\n');
                        lengthOfBlock = count.Length - 2;
                        showError("First operator is not a variable");
                    }
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// method to return no of lines inside block
        /// </summary>
        /// <returns>interger as number of lines</returns>
        public int lengthOfLine()
        {
            return lengthOfBlock;
        }
    }
}
