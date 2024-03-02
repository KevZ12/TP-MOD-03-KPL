using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MOD3_1302223027_Kevin_Albany
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Halo "+textBox1.Text;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }
    

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
