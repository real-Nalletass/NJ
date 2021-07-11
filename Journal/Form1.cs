using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter password..");
            }
            else if (textBox1.Text == "anbj1401")
            {
                Menu x = new Menu();
                x.Show();
            }
            else
            {
                MessageBox.Show("Wrong password!","Error");
            }
        }
    }
}
