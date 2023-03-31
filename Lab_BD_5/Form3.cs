using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_db_5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataSet21.Clear();
            sqlDataAdapter1.Fill(dataSet21.product);
        }
    }
}
