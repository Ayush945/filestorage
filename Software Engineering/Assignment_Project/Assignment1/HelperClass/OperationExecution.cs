using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.HelperClass
{
    /// <summary>
    /// Helper class for operation execution
    /// </summary>
    internal class OperationExecution
    {
        /// <summary>
        /// Carrier field
        /// </summary>
        private Carrier carrier;
        public OperationExecution(Carrier carrier) { 
            this.carrier = carrier;
        } 
        /// <summary>
        /// Method to check condition for loop and if
        /// </summary>
        /// <param name="firstOperand">Variable defined</param>
        /// <param name="operation">Operator to carry operation</param>
        /// <param name="second">Value to compare to</param>
        /// <returns>True or False based on result</returns>
        /// <exception cref="IllegalVariableException">If the second operand is variable</exception>
        /// <exception cref="IllegalOperatorException">If the operator is not recognized</exception>
        public bool executeOperation(string firstOperand,string operation, float second)
        {
            if (!carrier.Variables.ContainsKey(firstOperand))
            {
                return false;
            }
            float first = carrier.Variables[firstOperand];
            switch (operation)
            {
                case "==":
                    return first == second;
                case "!=":
                    return first != second;
                case "<":
                    return first < second;
                case ">":
                    return first > second;
                case "<=":
                    return first <= second;
                case ">=":
                    return first >= second;
                default:
                    return false;
            }
        }
        
    }
}
