using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CONVERT_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(metervalues.Text);

            int ans = number1 / 1000;

            kilometervalues.Text = ans.ToString();
        }
    }
}
