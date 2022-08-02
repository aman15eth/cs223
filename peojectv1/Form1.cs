using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace peojectv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JOHQ61G;Initial Catalog=login;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string user = txt_username.Text;
            string password = txt_password.Text;

            if (user == "admin"&& password=="admin")
            {  main m=new main( );
                m.Show();

                Visible = false;
            }
            else
            {
                MessageBox.Show("incorrent password");
            }

               
           
           try
     
            {
                string querry = "select * from login where username='" + txt_username.Text + "'and password='" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
            }
            catch
            {
                MessageBox.Show("cant connect");

            }
         
            }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
            txt_username.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar=true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
               txt_password.UseSystemPasswordChar = false;
            }
            else
                txt_password.UseSystemPasswordChar = true;


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
