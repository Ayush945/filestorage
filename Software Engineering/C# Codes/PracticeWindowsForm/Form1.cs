using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            String registrationNumber=textRegistration.Text;
            String name=textName.Text;
            String phone=textPhone.Text;
            String email=textEmail.Text;
            String address=textAddress.Text;
            String level=textLevel.Text;
            String s_class=textClass.Text;
            
            MessageBox.Show("Registration Number: "+registrationNumber+"\nName: " + name + "\nPhone: " + phone+"\nEmail: "+email+"\nAddress: "+address+"\nLevel:"+level+"\nClass"+s_class ,"Student Detail");
        }
    }
}
