using RightJob.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightJob
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

        private void allApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<ApplicantListForm>().Show();
        }

        private void allTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<TestListForm>().Show();
        }

        private void newApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ApplicantEditForm();
            form.AddApplicant();
        }

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TestEditForm();
            form.AddTest();
        }

        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<QuestionListForm>().Show();
        }
    }
}
