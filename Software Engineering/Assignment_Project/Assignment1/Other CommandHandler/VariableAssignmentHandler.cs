using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1.CommandHandler.Impl
{
    internal class VariableAssignmentHandler
    {
        private Carrier carrier;
        private string command;
        public VariableAssignmentHandler() { }
        public VariableAssignmentHandler(string command, Carrier carrier)
        {
            this.carrier = carrier;
            this.command = command;
        }

        public void execute()
        {
            if (validate())
            {
                string[] store = command.Split('=');
                if (store[1].Contains('+'))
                {
                    string[] data = store[1].Split('+');
                    float number = float.Parse(data[1]);
                    carrier.Variables[store[0]] = carrier.Variables[data[0]] + number;
                  
                }
                else if (store[1].Contains('-'))
                {
                    string[] data = store[1].Split('-');
                    float number = float.Parse(data[1]);
                    carrier.Variables[store[0]] = carrier.Variables[data[0]] - number;
                   
                }
                else if (store[1].Contains('*'))
                {
                    string[] data = store[1].Split('*');
                    float number = float.Parse(data[1]);
                    carrier.Variables[store[0]] = carrier.Variables[data[0]] * number;

                }
                else if (store[1].Contains('/'))
                {
                    string[] data = store[1].Split('/');
                    float number = float.Parse(data[1]);
                    carrier.Variables[store[0]] = carrier.Variables[data[0]] / number;

                }
                else
                {
                    float number = float.Parse(store[1]);
                    if (carrier.Variables.ContainsKey(store[0].Trim()))
                    {
                        carrier.Variables[store[0].Trim()] = number;
                    }
                    else
                    {
                        carrier.Variables.Add(store[0].Trim(), number);
                      
                    }
                }
            }
            
        }

        public void showError(string message)
        {
            throw new IllegalVariableException(message);
        }

        public bool validate()
        {
            string[] store = command.Split('=');
            
            if (store[1].Contains('+'))
            {
                string[] data = store[1].Trim().Split('+');
                
                if (string.IsNullOrEmpty(data[0]))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Need two operand");
                    }
                    return false;
                }
                if(!float.TryParse(data[1],out float number))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Third operand must be number when adding");
                    }
                    return false;
                }
                
            }
            else if (store[1].Contains('-'))
            {
                string[] data = store[1].Split('-');
                if (string.IsNullOrEmpty(data[0]))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Need two operand");
                    }
                    return false;
                }
                if (!float.TryParse(data[1], out float number))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Third operand must be number when adding");
                    }
                    return false;
                }
            }
            else if (store[1].Contains('*'))
            {
                string[] data = store[1].Split('*');
                if (string.IsNullOrEmpty(data[0]))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Need two operand");
                    }
                    return false;
                }
                if (!float.TryParse(data[1], out float number))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Third operand must be number when adding");
                    }
                    return false;
                }
            }
            else if (store[1].Contains('/'))
            {
                string[] data = store[1].Split('/');
                if (string.IsNullOrEmpty(data[0]))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Need two operand");
                    }
                    return false;
                }
                if (!float.TryParse(data[1], out float number))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Third operand must be number when adding");
                    }
                    return false;
                }
            }
            else
            {
                if (!float.TryParse(store[1], out float number))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Only numbers can be assigned");
                    }
                    return false;
                }
            }
            return true;
        }
    }
}
