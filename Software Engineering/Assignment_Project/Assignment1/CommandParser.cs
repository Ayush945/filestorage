using Assignment1.CommandHandler.Impl;
using Assignment1.ExceptionHandler;
using Assignment1.IteratorPattern;
using Assignment1.IteratorPattern.Impl;
using Assignment1.OptionClass;
using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment1
{
    /// <summary>
    /// This class parses the command in single line and multipline textbox
    /// </summary>
    public class CommandParser
    {
        private Carrier carrier;
        private CommandFactory factory;
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandParser"/> class.
        /// </summary>
        public CommandParser()
        {
            carrier = new Carrier();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandParser"/> class.
        /// </summary>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public CommandParser(Carrier carrier)
        {
            this.carrier = carrier;
            factory = new CommandFactory();
        }

        /// <summary>
        /// This method, creates the object of class according to the input command in single line command
        /// </summary>
        /// <param name="text">single line command</param>
        public void runCommand(string text)
        {
            try
            {
                factory.createInstance(text, carrier).execute();
            }
            catch (IllegalSyntaxException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IllegalParameterException message)
            {
                MessageBox.Show(message.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IllegalOperatorException message)
            {
                MessageBox.Show(message.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IllegalVariableException message)
            {
                MessageBox.Show(message.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This method, creates multiple object of class according to the input command in multi line command
        /// </summary>
        /// <param name="multiText">mutiline command</param>
        public void runMultiCommand(string multiText)
        {
            string[] commandList = multiText.Trim().Split('\n');

            for (int i = 0; i < commandList.Length && !string.IsNullOrWhiteSpace(commandList[i]); i++)
            {
                try
                {
                    if (commandList[i].Contains("method") && commandList[i].Contains("(") && commandList[i].Contains(")"))
                    {
                        StoreMethodHandler storeMethod = new StoreMethodHandler(commandList[i], multiText, carrier, i);
                        storeMethod.execute();
                        i = storeMethod.LineNumber;
                    }
                    else if (carrier.MethodName.ContainsKey(commandList[i].Split(' ')[0].Trim()) && commandList[i].Contains("(") && commandList[i].Contains(")"))
                    {
                        MethodHandler methodHandler = new MethodHandler(commandList[i], multiText, carrier);
                        methodHandler.execute();
                    }
                    else if (commandList[i].Contains("if"))
                    {
                        IfHandler ifHandler = new IfHandler(multiText, carrier);
                        ifHandler.execute();
                        i = i + ifHandler.lengthOfLine() + 1;
                    }
                    else if (commandList[i].Contains("while"))
                    {
                        WhileHandler whileHandler = new WhileHandler(multiText, carrier);
                        whileHandler.execute();
                        i = i + whileHandler.lengthOfLine() + 1;
                    }
                    else if (commandList[i].Contains("="))
                    {
                        VariableAssignmentHandler variableAssignmentHandler = new VariableAssignmentHandler(commandList[i], carrier);
                        variableAssignmentHandler.execute();
                    }
                    else
                    {
                        factory.createInstance(commandList[i], carrier).execute();
                    }
                }
                catch (IllegalSyntaxException ex)
                {
                    MessageBox.Show(" Line " + (i + 1).ToString() + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IllegalParameterException ex)
                {
                    MessageBox.Show(" Line " + (i + 1).ToString() + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IllegalOperatorException ex)
                {
                    MessageBox.Show(" Line " + (i + 1).ToString() + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IllegalVariableException ex)
                {
                    MessageBox.Show(" Line " + (i + 1).ToString() + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
        /// This method check the parameter and syntax of command in multiline text box
        /// </summary>
        /// <param name="command"></param>
        public void checkCommand(string command)
        {
            string[] commandList = command.Split('\n');
            ICommandIterator commandIterator = new CommandIterator(commandList);

            while (commandIterator.hasNext())
            {
                string currentCommand = commandIterator.next();
                try
                {
                    if (currentCommand.Contains("method") && currentCommand.Contains("(") && currentCommand.Contains(")"))
                    {
                        StoreMethodHandler storeMethod = new StoreMethodHandler(currentCommand, command, carrier, commandIterator.getCurrentIndex());
                        storeMethod.validate();
                    }
                    else if (carrier.MethodName.ContainsKey(currentCommand.Split(' ')[0].Trim()) && currentCommand.Contains("(") && currentCommand.Contains(")"))
                    {
                        MethodHandler methodHandler = new MethodHandler(currentCommand, command, carrier);
                        methodHandler.validate();
                    }
                    else if (currentCommand.Contains("if"))
                    {
                        IfHandler ifHandler = new IfHandler(command, carrier);
                        ifHandler.validate();
                    }
                    else if (currentCommand.Contains("while"))
                    {
                        WhileHandler whileHandler = new WhileHandler(command, carrier);
                        whileHandler.validate();
                    }
                    else if (currentCommand.Contains("="))
                    {
                        VariableAssignmentHandler variableAssignmentHandler = new VariableAssignmentHandler(currentCommand, carrier);
                        variableAssignmentHandler.validate();
                    }
                    else
                    {
                        factory.createInstance(currentCommand, carrier).validate();
                    }
                }
                catch (IllegalSyntaxException ex)
                {
                    MessageBox.Show(" Line " + (commandIterator.getCurrentIndex() + 1).ToString() + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IllegalParameterException ex)
                {
                    MessageBox.Show(" Line " + (commandIterator.getCurrentIndex() + 1).ToString() + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IllegalOperatorException ex)
                {
                    MessageBox.Show(" Line " + (commandIterator.getCurrentIndex() + 1).ToString() + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IllegalVariableException ex)
                {
                    MessageBox.Show(" Line " + (commandIterator.getCurrentIndex() + 1).ToString() + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// This method checks the syntax and parameters of a single-line command.
        /// </summary>
        /// <param name="command"></param>
        /// <returns>True if the command is valid, false otherwise.</returns>
        public bool checkSingleLineCommand(string command) 
        {
            CommandFactory commandFactory = new CommandFactory();
            carrier.IsTest = true;
            var instance = commandFactory.createInstance(command, carrier);
            if (instance != null && instance.validate())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Method to validate multiline command
        /// </summary>
        /// <param name="command"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool checkMultiLineCommand(string command,string text)
        {
            carrier.IsTest = true;
            if (command.Contains("="))
            {
                VariableAssignmentHandler variableAssignmentHandler = new VariableAssignmentHandler(command, carrier);
                if (variableAssignmentHandler.validate())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (command.Contains("if"))
            {
                carrier.Variables["a".Trim()] = 5;
                IfHandler ifHandler = new IfHandler(command,carrier);
                if (ifHandler.validate())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (command.Contains("while"))
            {
                carrier.Variables["a".Trim()] = 1;
                WhileHandler whileHandler = new WhileHandler(command, carrier);
                if (whileHandler.validate())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (command.Contains("method"))
            {
                StoreMethodHandler methodHandler = new StoreMethodHandler(command,text,carrier,0);
                if (methodHandler.validate())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(command.Contains("(") && command.Contains(")"))
            {
                carrier.MethodName = new Dictionary<string,(int,int)>();
                carrier.MethodName.Add("add", (0, 1));
                MethodHandler methodHandler=new MethodHandler(command,text,carrier);
                if(methodHandler.validate()) { 
                return true;}
                else { 
                    return false; 
                }
            }
            else
            {
                return false;
            }
        }
        

        /// <summary>
        /// Method to load command in textbox
        /// </summary>
        /// <param name="multiTextBox">The texbox to write command</param>
        public void loadTextFile(TextBox multiTextBox)
        {
            LoadCommand loadCommand= new LoadCommand();
            loadCommand.loadAllCommands(multiTextBox);
        }
        /// <summary>
        /// Method to save the command from textbox
        /// </summary>
        /// <param name="multiTextBoxText">Text in the multiline textbox</param>
        public void saveTextFile(string multiTextBoxText)
        {
            SaveCommand saveCommand = new SaveCommand();
            saveCommand.saveCommands(multiTextBoxText);
        }
        
        /// <summary>
        /// Parse the save image method
        /// </summary>
        /// <param name="panel">The drawing panel</param>
        /// <param name="commands">The command to draw</param>
        public void saveImageFile(Panel panel,List<string> commands)
        {
            SaveCommand saveCommand=new SaveCommand();
            saveCommand.saveImage(panel,commands);
        }
        /// <summary>
        /// Parse the load image method
        /// </summary>
        /// <param name="panel">The drawing panel</param>
        public void loadImageFile(Panel panel)
        {

        }
    }
}
