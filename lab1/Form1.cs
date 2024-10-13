using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public delegate void delPassData(TextBox text);
        //public string _textBox1
        //{
        //    get { return textBox1.Text; }
        //}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //frm._textBox=textBox1.Text;
            //frm.Show();
            Form2 frm = new Form2();
            delPassData del = new delPassData(frm,funData);
        }
    }
}
