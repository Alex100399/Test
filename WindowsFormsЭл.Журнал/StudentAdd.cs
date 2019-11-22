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

namespace WindowsFormsЭл.Журнал
{
    public partial class StudentAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SERV-SQL-09\SQLEXPRESS;Initial Catalog=user10;User ID=user10;Password=wsruser10");
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void изменитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentUpdate stup = new StudentUpdate();
            stup.Show();
            this.Hide();
        }

        private void добавитьПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAdd techad = new TeacherAdd();
            techad.Show();
            this.Hide();
        }

        private void изменитПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherUpdate teachup = new TeacherUpdate();
            teachup.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxName.Text != " " &&
             textBoxLastName.Text != "" && textBoxLastName.Text != " " &&
             textBoxMiddleName.Text != "" && textBoxMiddleName.Text != " " &&
             comboBoxGender.Text != "" && comboBoxGender.Text != " " &&
             comboBoxGroup.Text != "" && comboBoxGroup.Text != " " &&
             textBoxPhone.Text != "" && textBoxPhone.Text != " " &&
             textBoxMail.Text != "" && textBoxMail.Text != " " &&
             textBoxLogin.Text != "" && textBoxLogin.Text != " " &&
             textBoxPassword.Text != "" && textBoxPassword.Text != " ")
            {
               try
               {
                
                var query = $"INSERT INTO Student_2week([Name], LastName, MiddleName,Gender,IdGroup,Phone) VALUES('{textBoxName.Text}','{textBoxLastName.Text}','{textBoxMiddleName.Text}','{comboBoxGender.SelectedValue.ToString()}','{comboBoxGroup.SelectedValue.ToString()}','{textBoxPhone.Text}')";

                
                
                SqlCommand com1 = new SqlCommand("Insert into User_2week([Name], LAstName, Nik, [E-mail], Password, Role)Values('" + textBoxName.Text + "','" + textBoxLastName.Text + "','" + textBoxMiddleName.Text + "','" + textBoxLogin.Text + "','" + textBoxPassword.Text + "', '2')", con);
                

                con.Open();
                var command = new SqlCommand(query, con);
                var msg = command.ExecuteNonQuery();
                com1.ExecuteNonQuery();

                MessageBox.Show("Добавлен новый студент.");

               }
               catch(Exception ex)
               {
                   MessageBox.Show("Ошибка в подключении бд. \n\n\n\n\nПодробнее:\n" + ex.ToString());

               }
               finally
               {
                con.Close();

               }
            }
            else
            {
                MessageBox.Show("Для добавления данных учетной записи заполните все необходимые поля.");
            }
        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            try
            {
                string queryString1 = "SELECT * FROM [Gender_2week]";

                {
                    SqlCommand cmd1 = new SqlCommand(queryString1, con);
                    DataTable tbl1 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(tbl1);
                    this.comboBoxGender.DataSource = tbl1;
                    this.comboBoxGender.DisplayMember = "Name";// столбец для отображения
                    this.comboBoxGender.ValueMember = "IdGender";//столбец с id
                    this.comboBoxGender.SelectedIndex = 0;
                }

                string queryString2 = "SELECT * FROM [Group_2week]";

                {
                    SqlCommand cmd2 = new SqlCommand(queryString2, con);
                    DataTable tbl2 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    da.Fill(tbl2);
                    this.comboBoxGroup.DataSource = tbl2;
                    this.comboBoxGroup.DisplayMember = "Name";// столбец для отображения
                    this.comboBoxGroup.ValueMember = "IdGroup";//столбец с id
                    this.comboBoxGroup.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в подключении бд. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
