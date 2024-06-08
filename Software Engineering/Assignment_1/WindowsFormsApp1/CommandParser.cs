using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using WindowsFormsApp1.POJO;

namespace WindowsFormsApp1
{
    internal class CommandParser
    {
        private Carrier carrier;
        public CommandParser(Carrier carrier) {
            this.carrier = carrier; 
        }
        

        public void runCommand(String text)
        {
            CommandFactory factory = new CommandFactory();
            ICommand command = factory.createCommand(text, carrier);
            command.Execute();
        }
    }
}
