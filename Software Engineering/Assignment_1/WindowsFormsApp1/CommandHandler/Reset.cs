﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Reset : ICommand
    {
        public ICommand resetPosition(Graphics graphics,Panel panel)
        {
            graphics.ResetTransform();
            return null;
        }
    }
}
