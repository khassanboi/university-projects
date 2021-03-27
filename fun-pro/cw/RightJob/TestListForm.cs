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
    public partial class TestListForm : Form
    {
        public TestListForm()
        {
            InitializeComponent();
        }

        public Test Test { get; set; }

        private void TestListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnRefreshTest_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgvTest.DataMember = "";
            dgvTest.DataSource = null;
            dgvTest.DataSource = new TestList().GetAllTests();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            var form = new TestEditForm();
            form.AddTest(); //calling the particular form
        }

        private void btnUpdateTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTest.SelectedRows.Count == 0) //"if no row selected"
                    MessageBox.Show("Please select a test!");
                else
                {
                    var t = (Test)dgvTest.SelectedRows[0].DataBoundItem;
                    new TestEditForm().UpdateTest(t); //calling the particular method by sending the data of selected row
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTest.SelectedRows.Count == 0) //"if no row selected"
                    MessageBox.Show("Please select a test!");
                else
                {
                    var t = (Test)dgvTest.SelectedRows[0].DataBoundItem;
                    new TestManager().Delete(t.Id); //deleting the selected row
                    new QuestionManager().DeleteWithTest(t.Id); //deleteing corresponding questions

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTestQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTest.SelectedRows.Count == 0) //"if no row selected"
                    MessageBox.Show("Please select a Test!");
                else
                {
                    var t = (Test)dgvTest.SelectedRows[0].DataBoundItem;
                    new QuestionAddForm().AddQuestion(t); //calling the particular method by sending the data of selected row
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TestListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dgvTest.EndEdit())
            {
                e.Cancel = true;
            }
        }
    }
}
