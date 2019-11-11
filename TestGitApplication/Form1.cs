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


            int[] numbers = { 1, 2, 3, 4, 5 };
            var dd = from number in numbers where (number%2)==0
                     select number;
            MyDelegate DelObj = new MyDelegate(myFun1);
            
            //DelObj += MyDelegate(myFun2);

            MessageBox.Show(DelObj("ok1\t").ToString());
            //DelObj -= (myFun1);
            DelObj += (myFun2);
            MessageBox.Show(DelObj("ok2\t").ToString());

        }
        public string myFun1(string str)
        {
            return  str+"fun1";
   
        }
        public string myFun2(string str)
        {
            return str + "fun2";
        }
        
    }
}
