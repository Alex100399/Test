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
    public partial class Student : Form
    {
        List<string[]> data = new List<string[]>();
        SqlConnection con = new SqlConnection(@"Data Source=SERV-SQL-09\SQLEXPRESS;Initial Catalog=user10;User ID=user10;Password=wsruser10");
        
        public Student()
        {
            InitializeComponent();
            try
            {
                SqlCommand com = new SqlCommand("Select (sd.LastName+' '+ sd.Name+' '+ sd.MiddleName),gp.Name, sb.Name, gr.Grade, (tr.Name+' '+ tr.LastName+' '+ tr.MiddleName) from Student_2week sd join GradeStudent_2week gr on (sd.IdStudent = gr.IdStudent) join Subject_2week sb on (gr.IdSubject = sb.IdSubjeсt) join Teacher_2week tr on (gr.IdTeacher = tr.IdTeachers) join Group_2week gp on (sd.IdGroup = gp.IdGroup); ", con);
                con.Open();
                SqlDataReader read = com.ExecuteReader();
                while(read.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = read[0].ToString();
                    data[data.Count - 1][1] = read[1].ToString();
                    data[data.Count - 1][2] = read[2].ToString();
                    data[data.Count - 1][3] = read[3].ToString();
                    data[data.Count - 1][4] = read[4].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Authorization aut = new Authorization();
            aut.Show();
            this.Hide();
        }
    }
}
