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
    // public delegate string MyDelegate(string str);
    public delegate bool IsPromotable(Employee emp);
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { Id = 1, Name = "sivakumar", Experience = 8 });
            emplist.Add(new Employee() { Id = 2, Name = "Aravind", Experience = 2 });
            emplist.Add(new Employee() { Id = 3, Name = "jagadeesh", Experience = 1 });
            emplist.Add(new Employee() { Id = 4, Name = "subbalakshmi", Experience = 9 });

            IsPromotable isPromotableobj = new IsPromotable(checkinMain);


        }

        private bool checkinMain(Employee emp)
        {
            if (emp.Experience > 5)
            {
                return true;
            }
            else
                return false;
        }
    }
}
