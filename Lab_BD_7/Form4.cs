using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_BD_7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlDataAdapter2.SelectCommand.Parameters[0].Value = dataSet51.product[comboBox1.SelectedIndex].key_product;
            dataSet61.Clear();
            sqlDataAdapter2.Fill(dataSet61.order);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataSet51.Clear();
            sqlDataAdapter1.Fill(dataSet51.product);
        }
    }
}
