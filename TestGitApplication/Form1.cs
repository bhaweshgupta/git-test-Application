using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGitApplication
{
    public delegate string MyDelegate(string str);
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public void function(string str)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            //comment added
            MessageBox.Show("hello");

        }
        public string myFun2(string str)
        {
            return str + "fun2";
        }
        
    }
}
