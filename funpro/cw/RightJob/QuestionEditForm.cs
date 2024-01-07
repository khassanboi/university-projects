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
    public partial class QuestionEditForm : Form
    {
        public QuestionEditForm()
        {
            InitializeComponent();
        }

        public Question Question { get; set; }

        public bool isSaved; // defining a public saved boolean which supports data change persisting function explained below

        public void UpdateQuestion(Question question)
        {
            Question = question;
            MdiParent = MyForms.GetForm<ParentForm>();

            isSaved = false; //initially, the data is not saved so setting it to false

            ShowQuestionInControls();
            Show();
        }

        private void ShowQuestionInControls()
        {
            tbxQuestionText.Text = Question.QuestionText;
            tbxAnswerText.Text = Question.Answer;

            //Setting the value of textboxes to the question and answer respectively
        }

        private void GrabUserInput()
        {
            Question.QuestionText = tbxQuestionText.Text;
            Question.Answer = tbxAnswerText.Text;

            //Grabbing the data inserted into the textboxes
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        public void SaveData()
        {
            try
            {
                GrabUserInput();
                new QuestionManager().Update(Question); //updating the question

                MyForms.GetForm<QuestionListForm>().LoadData();

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

        private void QuestionEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved || (tbxQuestionText.Text == Question.QuestionText && tbxAnswerText.Text == Question.Answer)) //"if the data are saved OR the data in both textboxes are not changed"
            {
                e.Cancel = false; //closing the form
            }
            else //"if the data are not saved OR any of the textbox value has been updated"
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
