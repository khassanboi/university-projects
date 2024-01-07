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
    public partial class QuestionAddForm : Form
    {
        public QuestionAddForm()
        {
            InitializeComponent();
        }

        public Question Question { get; set; }

        public Test Test { get; set; }

        public bool isSaved; // defining a public saved boolean which supports data change persisting function explained below

        public void AddQuestion(Test test)
        {
            Test = test;
            Question = new Question();
            MdiParent = MyForms.GetForm<ParentForm>();

            isSaved = false; //initially, the data is not saved so setting it to false

            ShowTestInControls();
            Show();
        }

        private void ShowTestInControls()
        {
            lblTestName.Text = Test.TestName;

            //Setting the value of label to the name of the Test
        }

        private void GrabUserInput()
        {
            Question.TestId = Test.Id;
            Question.QuestionText = tbxQuestionText.Text;
            Question.Answer = tbxAnswerText.Text;

            //Grabbing the data inserted into the textbox
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        public void SaveData()
        {
            try
            {
                GrabUserInput();

                new QuestionManager().Create(Test, Question);
                Test = new Test();
                Test.Id = Question.TestId;
                Test.QuestionsNumber = new QuestionManager().GetByTestId(Test.Id).Count();

                //setting the values of Test properly

                new TestManager().UpdateQuestionsNumber(Test); //updating particular Test

                MyForms.GetForm<QuestionListForm>().LoadData();
                MyForms.GetForm<TestListForm>().LoadData();

                isSaved = true; //after data are saved, resetting isSaved boolean to true

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuestionAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved || (string.IsNullOrEmpty(tbxQuestionText.Text) && string.IsNullOrEmpty(tbxAnswerText.Text))) //"if the data are saved OR both textboxes are empty"
            {
                e.Cancel = false; //closing the form
            }
            else //"if the data are not saved OR textboxes have been inserted a value"
            {
                var confirmation = MessageBox.Show("You are trying to close a form with unsaved data! Do you want to save them?", "Attention!", MessageBoxButtons.YesNo); //asking the user to confirm if he want to save unsaved changes

                if (confirmation == DialogResult.Yes) //"if user says 'Yes, I want to save them'"
                {
                    SaveData(); //saving thr data which resets isSaved to true allowing the form to be closed
                }
                else if (confirmation == DialogResult.No) //"if user says 'No, I don't want to save them'"
                {
                    isSaved = true; //resetting the isSaved to true (even if it is not logical in human language) in order to allow the form to be closed
                    e.Cancel = false; //not cancelling the FormClosing event
                }
                else //"if user somehow cancelled the event"
                {
                    e.Cancel = true; //cancelling the FormClosing event which refers back to the form
                }
            }
        }
    }
}
