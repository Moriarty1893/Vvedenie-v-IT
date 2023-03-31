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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlDataAdapter2.SelectCommand.Parameters[0].Value = dataSet31.product[comboBox1.SelectedIndex].name_product;
            dataSet41.Clear();
            sqlDataAdapter2.Fill(dataSet41.order);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataSet31.Clear();
            sqlDataAdapter1.Fill(dataSet31.product);
        }
    }
}
