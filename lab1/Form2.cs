using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //public string _textBox
        //{
        //    set { label1.Text = value; }
        //}
        public void funData(TextBox txtForm1)
        {
            label1.Text = txtForm1.Text;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
