using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Assignment1.POJO
{
    /// <summary>
    /// Represents a carrier for graphical elements on a panel.
    /// </summary>
    public class Carrier
    {
        /// <summary>
        /// Dictionary to store variable and its value
        /// </summary>
        private Dictionary<string, float> variables;
        /// <summary>
        /// Dictionary to store method and its line number as well as no of parameter
        /// </summary>
        private Dictionary<string, (int,int)> methodName;
        /// <summary>
        /// Default constructor
        /// </summary>
        public Carrier()
        {
            variables=new Dictionary<string, float>();
        }
        /// <summary>
        /// Initializes a new instance of the Carrier class.
        /// </summary>
        /// <param name="positionX">The X-coordinate of the carrier.</param>
        /// <param name="positionY">The Y-coordinate of the carrier.</param>
        /// <param name="graphics">The Graphics object used for drawing.</param>
        /// <param name="panel">The Panel where the carrier is located.</param>
        /// <param name="color">The color of the carrier.</param>
        /// <param name="isFilled">Indicates whether the carrier is filled or not.</param>
        /// <param name="variables">The user defined variables</param>
        /// <param name="methodName">The user defined methods</param>
        /// <param name="isTest">If input for execution or validation</param>
        public Carrier(float positionX, float positionY, Graphics graphics, Panel panel, Color color, bool isFilled,Dictionary<string,float> variables,Dictionary<string,(int, int)> methodName,bool isTest)
        {
            // Initialize properties
            PositionX = positionX;
            PositionY = positionY;
            Graphics = graphics;
            Panel = panel;
            Color = color;
            IsFilled = isFilled;
            this.variables = variables;
            this.methodName = methodName;
            IsTest = isTest;
        }

        /// <summary>
        /// Gets or sets the Graphics object used for drawing.
        /// </summary>
        public Graphics Graphics { get; set; }

        /// <summary>
        /// Gets or sets the Panel where the carrier is located.
        /// </summary>
        public Panel Panel { get; set; }

        /// <summary>
        /// Gets or sets the color of the carrier.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the carrier is filled or not.
        /// </summary>
        public bool IsFilled { get; set; }

        /// <summary>
        /// Gets or sets the X-coordinate of the carrier.
        /// </summary>
        public float PositionX { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate of the carrier.
        /// </summary>
        public float PositionY { get; set; }

        /// <summary>
        /// Store the user defined variable
        /// </summary>
        public Dictionary<string, float> Variables { get => variables; set => variables = value; }
        
        /// <summary>
        ///store the user defined methods 
        /// </summary>
        public Dictionary<string, (int, int)> MethodName {  get=>methodName; set=>methodName=value; }
        /// <summary>
        /// store the boolean for test
        /// </summary>
        public bool IsTest { get; set; }
    }
}
