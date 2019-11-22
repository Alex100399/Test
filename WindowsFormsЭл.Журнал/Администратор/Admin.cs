using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsЭл.Журнал
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void добавитьПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAdd ta = new TeacherAdd();
            ta.Show();
            this.Hide();
        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAdd sa = new StudentAdd();
            sa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            auth.Show();
            this.Hide();
        }

        private void изменитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentUpdate sup = new StudentUpdate();
            sup.Show();
            this.Hide();
        }

        private void изменитПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherUpdate teachup = new TeacherUpdate();
            teachup.Show();
            this.Hide();
        }
    }
}
