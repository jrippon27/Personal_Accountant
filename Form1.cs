using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Accountant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            int beforeBillsAdd;
            beforeBillsAdd = int.Parse(textBox1.Text);
        }
        double sum = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            //Calculate AFTER BILLS and PERCENTAGE PIE CHART
            double total1 = 0;
        
            foreach (DataGridView column in dataGridView1.Columns)
            {
                sum += (double)column.SelectedCells[0].Value;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Displays Total BEFORE BILLS subtracted from BILLS total list

            int afterBills;
            afterBills = int.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adds Rows
            dataGridView1.Rows.Add();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }  

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int billsTotalAdd;
            billsTotalAdd = int.Parse(textBox4.Text);
        }
    }
}
