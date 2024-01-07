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
    public partial class AnswerQuestionForm : Form
    {
        public AnswerQuestionForm()
        {
            InitializeComponent();
        }

        public Applicant Applicant { get; set; }

        public Question Question { get; set; }

        public Test Test { get; set; }

        public bool isSaved; // defining a public saved boolean which supports data change persisting function explained below

        public int index; // defining a public index integer to store the index of current iteration

        public void ReceiveAnswer(Question question, int i, Applicant applicant, Test test)
        {
            Question = new Question();
            Test = test;
            Applicant = applicant;
            Question.Answer = question.Answer;
            index = i;

            //Setting the value of properties above to the values of enumerated element of the loop in TakeTest form

            isSaved = false; //initially, the data is not saved so setting it to false

            ShowQuestionInControls(question, i);
            ShowDialog();

            //A method which receives 4 arguments: Question, index being enumerated, Applicant, Test.
        }
        private void ShowQuestionInControls(Question question, int i)
        {
            lblQuestionNumber.Text = $"Q{i+1}";
            lblQuestion.Text = question.QuestionText;

            //Setting the value of labels to the number and text of a particular question
        }

        private void GrabUserInput()
        {
            string answer = tbxAnswer.Text;

            //Grabbing the text inserted into the textbox
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();

                int score = 0;

                var manager = new QuestionManager();

                if (tbxAnswer.Text.ToLower().Trim() == Question.Answer.ToLower().Trim()) //"if the answer is correct" Validating by lowercasing and trimming whitespaces
                {
                    score++;
                }
                else if (string.IsNullOrEmpty(tbxAnswer.Text)) //"if user didn't insert any answer"
                {
                    if (MessageBox.Show("You did not answer the question! Do you want to leave the answer blank?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)//"if user says 'No, I want to insert an answer again'"
                    {
                        return; //returning in order to let the user to insert an answer again
                    }
                }


                Applicant.Score += score; //adding the earned score to the total Score of the applicant in the DB
                string testName = new TestManager().GetById(Test.Id).TestName; //receiving the name of the test by its ID number

                if (string.IsNullOrEmpty(Applicant.TestsTaken)) //"if user has no test taken yet"
                {
                    Applicant.TestsTaken += testName; //adding the name of the test
                }
                else if (!Applicant.TestsTaken.Contains(testName)) //"if user has any test taken until this moment"
                {
                    Applicant.TestsTaken += ", " + testName; //adding the name of test with comma and space before
                } 

                new ApplicantManager().Update(Applicant); //updating the applicant with changed column values

                isSaved = true; //after data are saved, resetting isSaved boolean to true

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AnswerQuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isSaved) //"if the data are saved"
            {
                e.Cancel = false; //closing the form
            }
            else //"if the data are not saved"
            {
                MessageBox.Show("You cannot finish the test before answering all questions!", "Attention!"); //showing a relevant message
                e.Cancel = true; //cancelling FormClosing event which prevents user to close the form before completing the test
            }
        }
    }
}
