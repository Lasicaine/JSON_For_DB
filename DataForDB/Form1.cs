using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataForDB
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            progressBarGeneration.Maximum = Convert.ToInt32(numericUpDownNumRec.Value);
            progressBarGeneration.Value = 0;
            progressBarGeneration.Step = 1;
            string beg = "{\"Addresses\":[{\"Type\":2,\"Value\":\"rambler.ru\"}";
            string str1 = ",{\"Type\":2,\"Value\":\"rambler";
            string str2 = ".ru\"}";
            StringBuilder res = new StringBuilder();

            for (int i = 1; i <= numericUpDownNumRec.Value; i++)
            {
                res.Append(beg).Append(str1).Append(i).Append(str2);
                progressBarGeneration.PerformStep();
                //progressBarGeneration.Value++;
            }

            StringBuilder ed = new StringBuilder();
            ed.Append(res + "]}");
            string resstr = ed.ToString();
            ResultTextBox.Text = resstr;
        }
        private void numericUpDownNumRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }
    }
}
