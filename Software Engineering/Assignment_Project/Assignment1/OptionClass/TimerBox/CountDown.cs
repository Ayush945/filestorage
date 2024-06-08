using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Assignment1.OptionClass.TimerBox
{
    public partial class CountDown : Form
    {
        System.Timers.Timer timer;
        int h, m, s;
        /// <summary>
        /// 
        /// </summary>
        public CountDown()
        {
            InitializeComponent();
            h = 0;
            m = 0;
            s = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void CountDown_Load(object sender, EventArgs e)
        {
            timer=new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += OnTimeEvent;

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s =0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                timerText.Text = string.Format("{0}:{1}:{2}",h.ToString().PadLeft(2,'0'),m.ToString().PadLeft(2,'0'),s.ToString().PadLeft(2,'0'));
            }));
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void CountDown_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }
    }
}
