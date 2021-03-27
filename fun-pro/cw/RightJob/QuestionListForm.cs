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
    public partial class QuestionListForm : Form
    {
        public QuestionListForm()
        {
            InitializeComponent();
        }

        public Test Test { get; set; }


        private void QuestionListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        public void LoadData()
        {
            dgvQuestions.DataMember = "";
            dgvQuestions.DataSource = null;
            dgvQuestions.DataSource = new QuestionList().GetAllQuestions();

            new TestListForm().LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxTestId.Text)) //"if input is empty"
                    MessageBox.Show("Provide the search term");
                else
                {
                    ByAttribute selectedAttribute;
                    selectedAttribute = ByAttribute.TestId;

                    dgvQuestions.DataMember = "";
                    dgvQuestions.DataSource = null;
                    dgvQuestions.DataSource = new QuestionList().Search(tbxTestId.Text, selectedAttribute);

                    //searching questions by TestId
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQuestions.SelectedRows.Count == 0) //"if no row selected"
                    MessageBox.Show("Please select a question!");
                else
                {
                    var q = (Question)dgvQuestions.SelectedRows[0].DataBoundItem;
                    new QuestionEditForm().UpdateQuestion(q);  //calling the particular method by sending the data of selected row
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQuestions.SelectedRows.Count == 0) //"if no row selected"
                    MessageBox.Show("Please select a question!");
                else
                {
                    var q = (Question)dgvQuestions.SelectedRows[0].DataBoundItem;
                    new QuestionManager().Delete(q.Id); //deleting the selected row

                    Test = new Test();
                    Test.Id = q.TestId;
                    Test.QuestionsNumber = new QuestionManager().GetByTestId(Test.Id).Count(); 
                    new TestManager().UpdateQuestionsNumber(Test);

                    //updating the QuestionNumber column of Test db after question being deleted

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QuestionListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dgvQuestions.EndEdit())
            {
                e.Cancel = true;
            }
        }

        private void dgvQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
