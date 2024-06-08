using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.IteratorPattern.Impl
{
    internal class CommandIterator : ICommandIterator
    {
        string[] commands;
        private int currentIdx;
        public CommandIterator(string[] commands)
        {
            this.commands = commands;
            this.currentIdx = 0;
        }

        public int getCurrentIndex()
        {
            return currentIdx- 1;
        }

        public bool hasNext()
        {
            return currentIdx < commands.Length && !String.IsNullOrWhiteSpace(commands[currentIdx]);
        }

        public string next()
        {
            return commands[currentIdx++];
        }

        public void skip(int count)
        {
            currentIdx += count;
        }
    }
}
