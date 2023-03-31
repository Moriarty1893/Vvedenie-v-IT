using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_BD_8_Last
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataSet21.Clear();
            sqlDataAdapter1.Fill(dataSet21.order);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dataSet21.order);
        }
    }
}
