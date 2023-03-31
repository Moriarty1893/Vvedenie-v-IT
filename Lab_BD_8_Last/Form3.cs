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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataSet31.Clear();
            sqlDataAdapter1.Fill(dataSet31.firm);
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            //firmBindingSource.EndEdit();
            //bindingNavigator1.EndEdit();
            sqlDataAdapter1.Update(dataSet31.firm);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
