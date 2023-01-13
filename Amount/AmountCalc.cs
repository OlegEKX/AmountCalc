using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amount
{
    public partial class AmountCalc : Form
    {

        

        public AmountCalc()
        {
            InitializeComponent();

            
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            
        }

        private void AmountCalc_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "шуруп", "гайка", "винт", "гвоздь", "болт" });
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonDobavki_Click(object sender, EventArgs e)
        {
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelShtuk_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Insert(1, "болт");
        }
    }
}
