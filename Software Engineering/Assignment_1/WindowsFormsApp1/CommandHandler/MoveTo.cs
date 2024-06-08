using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.POJO;
using WindowsFormsApp1.Validation;

namespace WindowsFormsApp1
{
    internal class MoveTo : ICommand
    {
        private double x;
        private double y;
        private Graphics graphics;

        private string command;
        Carrier carrier;
        public MoveTo()
        {

        }
        public MoveTo(string command,Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }
        public void Execute()
        {
            ValidateInteger interger = new ValidateInteger();
           
            if (interger.checkParameterForMoveTo(command))
            {
                graphics.TranslateTransform(1,2);
            }
           
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
