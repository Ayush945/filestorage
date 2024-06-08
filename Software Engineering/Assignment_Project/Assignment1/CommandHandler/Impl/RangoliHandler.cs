using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Class to draw Rangoli
    /// </summary>
    internal class RangoliHandler : ICommandHandler
    {
        /// <summary>
        /// field of carrier object
        /// </summary>
        private Carrier carrier;
        /// <summary>
        /// field of string command
        /// </summary>
        private string command;
        /// <summary>
        /// Default constructor
        /// </summary>
        public RangoliHandler() { }
        /// <summary>
        /// Initializing command and carrier
        /// </summary>
        /// <param name="command">command text</param>
        /// <param name="carrier">poco as carrier</param>
        public RangoliHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }
        /// <summary>
        /// Execute the rangoli to draw on panel
        /// </summary>
        public void execute()
        {
            int centerX = carrier.Panel.Width / 2;
            int centerY = carrier.Panel.Height / 2;
            int radius = Math.Min(carrier.Panel.Width, carrier.Panel.Height) / 4;

            carrier.Graphics.FillEllipse(Brushes.Bisque, centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            
            for (int i = 0; i < 360; i += 30)
            {
                double angle = i * Math.PI / 180;
                int x1 = centerX + (int)(radius * Math.Cos(angle));
                int y1 = centerY + (int)(radius * Math.Sin(angle));

                int x2 = centerX + (int)(2 * radius * Math.Cos(angle));
                int y2 = centerY + (int)(2 * radius * Math.Sin(angle));

                carrier.Graphics.DrawLine(Pens.Blue, x1, y1, x2, y2);

                int smallCircleRadius = radius / 4;
                int smallCircleX = centerX + (int)(1.5 * radius * Math.Cos(angle));
                int smallCircleY = centerY + (int)(1.5 * radius * Math.Sin(angle));
                carrier.Graphics.FillEllipse(Brushes.PaleTurquoise, smallCircleX - smallCircleRadius, smallCircleY - smallCircleRadius, 2 * smallCircleRadius, 2 * smallCircleRadius);
            }
        }
        /// <summary>
        /// Show Error as message
        /// </summary>
        /// <param name="message"></param>
        public void showError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool validate()
        {
            return true;
        }
    }
}
