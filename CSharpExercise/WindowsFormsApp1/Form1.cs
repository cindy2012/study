using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: 这行代码将数据加载到表“adventureWorks2019DataSet.Employee”中。您可以根据需要移动或删除它。

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy(this.adventureWorks2019DataSet.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.adventureWorks2019DataSet.Employee);

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillBy(this.adventureWorks2019DataSet.Employee);
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy(this.adventureWorks2019DataSet.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
