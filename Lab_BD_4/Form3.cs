using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_db_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.sale1DataSet.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet1.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet1.order);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet1, "order"].Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet1, "order"].Position -= 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet1, "order"].Position += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet1, "order"].Position = this.BindingContext[dataSet1, "order"].Count - 1;
        }
    }
}
