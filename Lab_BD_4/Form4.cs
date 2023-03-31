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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet11, "order"].Position = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {          
            this.BindingContext[dataSet11, "order"].Position -= 1;
            button1.Enabled = true;
            button2.Enabled = true;
            if (this.BindingContext[dataSet11, "order"].Position == this.BindingContext[dataSet11, "order"].Count - 1)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet11, "order"].Position += 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet11, "order"].Position = this.BindingContext[dataSet11, "order"].Count - 1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataSet11.Clear();
            sqlDataAdapter1.Fill(dataSet11.order);
           // sqlDataAdapter2.Fill(dataSet11.order);

        }
    }
}
