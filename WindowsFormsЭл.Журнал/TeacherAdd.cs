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
using System.Data.SqlTypes;

namespace WindowsFormsЭл.Журнал
{
    public partial class TeacherAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SERV-SQL-09\SQLEXPRESS;Initial Catalog=user10;User ID=user10;Password=wsruser10");

        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAdd sa = new StudentAdd();
            sa.Show();
            this.Hide();
        }

        private void изменитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentUpdate su = new StudentUpdate();
            su.Show();
            this.Hide();
        }

        private void изменитПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherUpdate tu = new TeacherUpdate();
            tu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxName.Text != " " &&
              textBoxLastName.Text != "" && textBoxLastName.Text != " " &&
              textBoxMiddleName.Text != "" && textBoxMiddleName.Text != " " &&
              comboBoxGender.Text != "" && comboBoxGender.Text != " " &&
              textBoxAddress.Text != "" && textBoxAddress.Text != " " &&
              textBoxPhone.Text != "" && textBoxPhone.Text != " " &&
              textBoxMail.Text != "" && textBoxMail.Text != " " &&
              textBoxLogin.Text != "" && textBoxLogin.Text != " " &&
              textBoxPassword.Text != "" && textBoxPassword.Text != " ")
            {
              try
              {
                var query = $"INSERT INTO Teacher_2week([Name], LastName, MiddleName,[Address],Phone,Gender) VALUES('{textBoxName.Text}','{textBoxLastName.Text}','{textBoxMiddleName.Text}','{textBoxAddress.Text}','{textBoxPhone.Text}','{comboBoxGender.SelectedIndex.ToString()}')";
               // var query = $"INSERT INTO Teacher_2week([Name], LastName, MiddleName,[Address],Phone,Gender) VALUES('{textBoxName.Text}','{textBoxLastName.Text}','{textBoxMiddleName.Text}','{textBoxAddress.Text}','{textBoxPhone.Text}','{comboBoxGender.SelectedValue.ToString()}')";

                //var date = $"{dateTimePicker1.Value.Year}-{dateTimePicker1.Value.Month}-{dateTimePicker1.Value.Day}";
                //SqlCommand com = new SqlCommand("Insert into Teacher_2week([Name], LastName, MiddleName,[Address],Phone,Gender) Values('"+textBoxName.Text + "','" + textBoxLastName.Text + "','" + textBoxMiddleName.Text + "','" + textBoxAddress.Text + "','" + textBoxPhone.Text + "','" + comboBoxGender.Text + "')", con);
                SqlCommand com1 = new SqlCommand("Insert into User_2week([Name], LAstName, Nik, [E-mail], Password, Role)Values('" + textBoxName.Text + "','" + textBoxLastName.Text + "','" + textBoxMiddleName.Text + "','" + textBoxLogin.Text + "','" + textBoxPassword.Text + "', '3')", con);
                //SqlCommand com = new SqlCommand("Insert into Teacher_2week(Name, LastName, MiddleName, Birthday,Address,Phone,Gender)Values('" + textBoxName.Text + "','" + textBoxLastName.Text + "','" + textBoxMiddleName.Text + "','" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "','" + textBoxAddress.Text + "','" + textBoxPhone.Text + "','" + comboBoxGender.Text + "')", con);

                con.Open();
                var command = new SqlCommand(query, con);
                var msg = command.ExecuteNonQuery();
                com1.ExecuteNonQuery();

                MessageBox.Show("Добавлен новый преподаватель.");

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

        private void TeacherAdd_Load(object sender, EventArgs e)
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
    }
}
