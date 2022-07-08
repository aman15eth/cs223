using labexec.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labexec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
     s   {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ITEM i = new ITEM();

            i.NUMBER = Convert.ToInt32(NUMBER.Text);
            i.DATE = DATE.Text;
            i.SKU = SKU.Text;
            i.item_name = ITEMNAME.Text;
            i.QUANTITY = Convert.ToInt32(QUANTITY.Text);
            i.price = Convert.ToDouble(PRICE.Text);




            MessageBox.Show("record saved sussesfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NUMBER.Text = null;
            DATE.Text = " ";
            SKU.Text = " ";
            ITEMNAME.Text = " ";
            QUANTITY.Text = " ";
            PRICE.Text = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
    }
}