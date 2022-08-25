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

namespace to_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JOHQ61G;Initial Catalog=todolist;Integrated Security=True");
                conn.Open();
                MessageBox.Show("database connected");
                string select = "select * from tasks";
                //string querry = " insert into room(roomno,roomtype,bed,price) values(207,'double','single',1700)";
                SqlCommand cmd =new  SqlCommand(select,conn);
                var result = cmd.ExecuteReader();
                /* var result = cmd.ExecuteNonQuery();  /*for rows affected;
                 var result=cmd.ExecuteScalar(); for single value
                 executereader();  --> for  data reader;
                 */
                while (result.Read())
                {
                    todolist t1 = new todolist();
                    t1.name = result["@name"].ToString();
                    t1.date = result["@dateof"].ToString();
                    t1.priority = result["@priority"].ToString();
                    t1.done = (bool)result["@done"];
                    t1.save();
                   
                }
                
                conn.Close();
                    

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Addtask_Click(object sender, EventArgs e)
        {
            todolist a = new todolist();
            dateTextbox.Text=dateTimePicker1.Value.ToString();

            a.date = dateTextbox.Text; 
            
            a.name = Activitytextbox.Text;
            a.priority = pricombobox.Text;
            a.done = taskdonevheckbox.Checked;
            a.save();
           
            data d=new data();
            d.Show();
            Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Activitytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {
            Visible = false;
            data d = new data();
            d.Show();
        }
    }
}
