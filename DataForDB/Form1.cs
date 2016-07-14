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

        private void button1_Click(object sender, EventArgs e)
        {
            string beg = "{\"Addresses\":[{\"Type\":2,\"Value\":\"rambler.ru\"}";
            string str1 = ",{\"Type\":2,\"Value\":\"rambler";
            string str2 = ".ru\"}";
          
            for (int i = 1; i <= 198; i++)
            {
                beg = beg + str1 + i + str2;
            }
            string ed = beg + "]}";
            ResultTextBox.Text = ed;
        }
    }
}
