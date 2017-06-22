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

        }
        private void button6_Click(object sender, EventArgs e)
        {
            //Calculate AFTER BILLS and PERCENTAGE PIE CHART
            int sum= 0;
        
            for (int i=0 ; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            MessageBox.Show(sum.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Displays Total BEFORE BILLS subtracted from BILLS total list

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adds Rows
            //dataGridView1.Rows.Add();
            
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
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Expenses Calculate Button
            int sum = 0;
            int sum2 = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
            }
            MessageBox.Show(sum.ToString());
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int beforeBills;
            int afterBills;
            int total;

            beforeBills = int.Parse(textBox1.Text);
            afterBills = int.Parse(textBox4.Text);

            total = beforeBills - afterBills;
            MessageBox.Show(total.ToString());

            
        }
    }
}
