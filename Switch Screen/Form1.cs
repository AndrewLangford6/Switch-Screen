using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // f is the form that this control is on - ("this" is the current User Control)

            // Create an instance of the MainScreen
            Form f = new Form();

            // Add the User Control to the Form
            this.Controls.Add(f);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            // Create an instance of the MainScreen
            UserControl1 us = new UserControl1();

            // Add the User Control to the Form
            this.Controls.Add(us);
        }
    }
}
