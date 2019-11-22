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
using System.IO;

namespace WindowsFormsЭл.Журнал
{
    public partial class Authorization : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SERV-SQL-09\SQLEXPRESS;Initial Catalog=user10;User ID=user10;Password=wsruser10");

        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            string Password = null;
            string Role = null;

            try
            {
                SqlCommand comm = new SqlCommand("Select * from [User_2week] where [Nik]='"+textBoxLogin.Text+"';",con);
                con.Open();
                SqlDataReader data = comm.ExecuteReader();
                if(data.Read())
                {
                    Password = data[5].ToString();
                    Role = data[6].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\nПодрабнее:\n" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            if(Password != null && Role != null)
            {
                AuthoUser(Password, Role);
            }
        }
        private void AuthoUser(string Password, string Role)
        {
            if(textBoxPassword.Text.Equals(Password))
            {
                switch (Role)
                {
                    case "2":
                    {
                            Student st = new Student();
                            st.Show();
                            this.Hide();
                            break;

                    }
                    case "3":
                    {
                            Teacher teach = new Teacher();
                            teach.Show();
                            this.Hide();
                            break;

                    }
                    case "1":
                    {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                            break;

                    }

                }
               
            }
            else
            {
                MessageBox.Show("Неверный пароль учетной записи");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
