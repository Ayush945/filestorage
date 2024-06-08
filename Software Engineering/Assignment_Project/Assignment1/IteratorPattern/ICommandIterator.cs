using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.IteratorPattern
{
    internal interface ICommandIterator
    {
        bool hasNext();
        string next();
        int getCurrentIndex();
        void skip(int count);
    }
}
