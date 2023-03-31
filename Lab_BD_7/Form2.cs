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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlDataAdapter2.SelectCommand.Parameters[0].Value = dataSet11.client[comboBox1.SelectedIndex].key_client;
            dataSet21.Clear();
            sqlDataAdapter2.Fill(dataSet21.order);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataSet11.Clear();
            sqlDataAdapter1.Fill(dataSet11.client);
        }
    }
}
