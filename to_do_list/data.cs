using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list
{
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
           
            
            
           
            
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void data_Load(object sender, EventArgs e)
        {
            todolist t = new todolist();
            

            bunifuDataGridView1.DataSource = null;
            bunifuDataGridView1.DataSource = t.getallitems();
            bunifuCircleProgress1.Value = 0;

             t.done = true;

           


            int count = 0;
            foreach ( var item in t.getallitems())
            {
                if(item.done == true)
                {
                    count++; 
                }

            }
            int rowcount, percent;
            rowcount = bunifuDataGridView1.RowCount;

            percent = count / rowcount * 100;

            bunifuCircleProgress1.Value = percent;



            // bunifuCircleProgress1.Value = 0;




        }


        private void timer1_Tick(object sender, EventArgs e)
        {





        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Visible = false;

        }
        public void  percentage()
        {
            
                for (int i = 0; i < bunifuDataGridView1.Rows.Count; i++)
                       {
                    bunifuCircleProgress1.Value=i;
                    
                }
            
        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
