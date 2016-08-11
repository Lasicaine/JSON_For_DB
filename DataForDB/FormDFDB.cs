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
            var NumRec = Convert.ToInt32(numericUpDownNumRec.Value);
            progressBarGeneration.Maximum = NumRec;
            progressBarGeneration.Value = 0;
            progressBarGeneration.Step = 1;
            string begin = "{\"Addresses\":[";
            string addTemplate = "{{\"Type\":2,\"Value\":\"rambler{0}.ru\"}},";
            string end = "]}";
            var result = new StringBuilder(begin);
             
            for (int i = 1; i <= NumRec; i++)
            {
                result.AppendFormat(addTemplate, i);
                progressBarGeneration.PerformStep();
                //progressBarGeneration.Value++;
            }
            result.Length--;
            result.Append(end);
            ResultTextBox.Text = result.ToString();
        }
        private void numericUpDownNumRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }
    }
}
