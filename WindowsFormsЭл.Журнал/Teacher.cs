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
    public partial class Teacher : Form
    {
        List<string[]> data = new List<string[]>();
        SqlConnection con = new SqlConnection(@"Data Source=SERV-SQL-09\SQLEXPRESS;Initial Catalog=user10;User ID=user10;Password=wsruser10");
        public Teacher()
        {
            InitializeComponent();
            try
            {
                SqlCommand com = new SqlCommand("Select (sd.LastName+' '+ sd.Name+' '+ sd.MiddleName),gp.Name, sb.Name, gr.Grade, (tr.Name+' '+ tr.LastName+' '+ tr.MiddleName) from Student_2week sd join GradeStudent_2week gr on (sd.IdStudent = gr.IdStudent) join Subject_2week sb on (gr.IdSubject = sb.IdSubjeсt) join Teacher_2week tr on (gr.IdTeacher = tr.IdTeachers) join Group_2week gp on (sd.IdGroup = gp.IdGroup)", con);
                con.Open();
                SqlDataReader read = com.ExecuteReader();
                while (read.Read()) 
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = read[0].ToString();
                    data[data.Count - 1][1] = read[1].ToString();
                    data[data.Count - 1][2] = read[2].ToString();
                    data[data.Count - 1][3] = read[3].ToString();
                    data[data.Count - 1][4] = read[4].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка в подключении бд. \n\n\n\n\nПодробнее:\n"+ex.ToString());
            }
            finally
            {
                con.Close();
            }
            dataGridView1.Rows.Clear();
            foreach(string[] item in data)
            {
                dataGridView1.Rows.Add(item);

            }
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            try
            {
                string queryString1 = "SELECT * FROM [Student_2week]";

                {
                    SqlCommand cmd1 = new SqlCommand(queryString1, con);
                    DataTable tbl1 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(tbl1);
                    this.comboBoxStudent.DataSource = tbl1;
                    this.comboBoxStudent.DisplayMember = "LastName";// столбец для отображения
                    this.comboBoxStudent.ValueMember = "IdStudent";//столбец с id
                    this.comboBoxStudent.SelectedIndex = 1;
                }

                string queryString2 = "SELECT IdSubjeсt, Name FROM [Subject_2week]";

                {
                    SqlCommand cmd2 = new SqlCommand(queryString2, con);
                    DataTable tbl2 = new DataTable();
                    SqlDataAdapter dap = new SqlDataAdapter(cmd2);
                    dap.Fill(tbl2);
                    this.comboBoxSubject.DataSource = tbl2;
                    this.comboBoxSubject.DisplayMember = "Name";// столбец для отображения
                    this.comboBoxSubject.ValueMember = "IdSubjeсt";//столбец с id
                    this.comboBoxSubject.SelectedIndex = 1;
                }

                string queryString3 = "SELECT * FROM [Teacher_2week]";

                {
                    SqlCommand cmd3 = new SqlCommand(queryString3, con);
                    DataTable tbl3 = new DataTable();
                    SqlDataAdapter dal = new SqlDataAdapter(cmd3);
                    dal.Fill(tbl3);
                    this.comboBoxTeacher.DataSource = tbl3;
                    this.comboBoxTeacher.DisplayMember = "LastName";// столбец для отображения
                    this.comboBoxTeacher.ValueMember = "IdTeachers";//столбец с id
                    this.comboBoxTeacher.SelectedIndex = 1;
                }

                string queryString4 = "SELECT * FROM [Grade_2week]";

                {
                    SqlCommand cmd4 = new SqlCommand(queryString4, con);
                    DataTable tbl4 = new DataTable();
                    SqlDataAdapter dapi = new SqlDataAdapter(cmd4);
                    dapi.Fill(tbl4);
                    this.comboBoxGrade.DataSource = tbl4;
                    this.comboBoxGrade.DisplayMember = "Name";// столбец для отображения
                    this.comboBoxGrade.ValueMember = "IdGrade";//столбец с id
                    this.comboBoxGrade.SelectedIndex = 1;
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

       

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (comboBoxStudent.Text != "" && comboBoxStudent.Text != " " &&
              comboBoxSubject.Text != "" && comboBoxSubject.Text != " " &&
              comboBoxTeacher.Text != "" && comboBoxTeacher.Text != " " &&
              comboBoxGrade.Text != "" && comboBoxGrade.Text != " ")
            {
               
               try
               {
                  SqlCommand com = new SqlCommand("Insert into GradeStudent_2week(IdStudent, IdSubject, IdTeacher, Grade)VALUES('"+comboBoxStudent.SelectedValue.ToString() + "','"+ comboBoxSubject.SelectedValue.ToString() + "', '"+comboBoxTeacher.SelectedValue.ToString() + "', '"+comboBoxGrade.SelectedValue.ToString() + "');",con);
                    con.Open();
                    com.ExecuteNonQuery();
                    dataGridView1.Rows.Add(comboBoxStudent.Text," ", comboBoxSubject.Text, comboBoxGrade.Text, comboBoxTeacher.Text);
                    dataGridView1.Refresh();


                }
                catch (Exception ex)
               {
                   MessageBox.Show("Ошибка в подключении бд. \n\n\n\n\nПодробнее:\n" + ex.ToString());
               }
               finally
               {
                    con.Close();
                    dataGridView1.Refresh();
                }
                


            }
            else
            {
                MessageBox.Show("Для изменения данных учетной записи заполните все необходимые поля.");
            }
        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdStudent = comboBoxStudent.SelectedValue.ToString();
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdSubject = comboBoxStudent.SelectedValue.ToString();
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdTeacher = comboBoxTeacher.SelectedValue.ToString();
        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Grade = comboBoxGrade.SelectedValue.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            auth.Show();
            this.Hide();
        }
    }   
}
