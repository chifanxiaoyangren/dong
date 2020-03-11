using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestArrayFree
{
    public partial class Form1 : Form
    {
        class A
        {
            string name;

        }

        public Form1()
        {
            InitializeComponent();
        }
        A[] array;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                array = new A[2000];
            }
        }
    }
}
