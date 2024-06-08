using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.HelperClass
{
    /// <summary>
    /// Class to store every text run
    /// </summary>
    internal class TextStore
    {
        /// <summary>
        /// field for single text
        /// </summary>
        private List<string> singleText;
        /// <summary>
        /// field for text in first multiline text
        /// </summary>
        private List<string> firstMultiText;
        /// <summary>
        /// field for text in second multiline text
        /// </summary>
        private List<string> secondMultiText;
        /// <summary>
        /// Initialized all list
        /// </summary>
        public TextStore() 
        {
            singleText = new List<string>();
            firstMultiText = new List<string>();
            secondMultiText = new List<string>();
        }
        public List<string> SingleText { get => singleText; set => singleText = value; }
        public List<string> FirstMultiText { get => firstMultiText; set => firstMultiText = value; }
        public List<string> SecondMultiText { get => secondMultiText; set => secondMultiText = value; }
    }
}
