using RightJob.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RightJob
{
    public partial class TakeTestForm : Form 
    {
        public TakeTestForm()
        {
            InitializeComponent();
        }

        public Applicant Applicant { get; set; }

        public Test Test { get; set; }

        public void TakeTest(Applicant applicant)
        {
            try
            {
                if (new TestManager().GetAll().Any()) //"if there is any Test in DB"
                {
                    Applicant = applicant;
                    bool testAvailable = false; //creating a bool in order to define whether function should proceed or not. Initially it is false

                    foreach (var test in new TestManager().GetAll()) //looping through the tests exisitng in the DB
                    {
                        if (!Applicant.TestsTaken.Contains(test.TestName)) //"if the applicant has not taken the iterated test"
                        {
                            testAvailable = true;
                        }

                        //the loop iterates all tests added to the DB and checks if TestsTaken column of selected Applicant contains it.
                        //when loop identifies any test that has not been taken yet, it resets the bool of testAvailable to true
                    }

                    if (testAvailable) //"if there's any test that applicant has not taken yet"
                    {

                        if (new QuestionManager().GetAll().Any()) //"if there is any question" ...
                        {
                            //"...tha main part of the form will be executed"

                            MdiParent = MyForms.GetForm<ParentForm>();
                            InitializeControls();
                            ShowApplicantInControls();
                            Show();
                        }
                        else //"if there is no question in the DB"
                        {
                            MessageBox.Show("There is no available question for any of the tests. Please, add a question to all tests before starting to take a test!");
                            return;
                        }

                        /*
                            I will be honest, even after researching for hours, I could not implement the best validation in terms of question availability.
                            Form not allowing the applicant to open this form if the available tests have no question (empty) would be a great approach.

                            So far, the validation I have implemented does not let the applicant to open TakeTest form if there is NO (0) question in the DB.
                            But, if there was any other question of the tests that have not been deleted, the form will run which is not proper.
                            I hope it is not a big deal for now since I will have a chance of learning it in a real life projects with mentors.
                         */
                    }
                    else //"if applicant has taken all tests"
                    {
                        MessageBox.Show("No available tests for this applicant. Add some!");
                        return;
                    }
                }
                else //"if there is no test in the DB"
                {
                    MessageBox.Show("No available tests. Add some!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeControls()
        {
            try
            {
                var manager = new TestManager();
                List<string> availableTests = new List<string>(); //new empty list

                foreach (var test in manager.GetAll()) //looping through the tests exisitng in the DB
                {
                    if (!Applicant.TestsTaken.Contains(test.TestName.ToString())) //"if the applicant has not taken the iterated test..."
                    {
                        availableTests.Add(test.TestName.ToString()); //"...this test will be added to the test"
                    }

                    //this loop identifies the tests that the selected applicant has not taken yet
                    //the available tests will be pushed to initially created list in order to use afterwards
                }

                cbxTest.DataSource = availableTests; //setting the values of combobox to availableTests list created above
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowApplicantInControls()
        {
            lbApplicant.Text = Applicant.Name;

            //Setting the value of label to the name of Applicant
        }

        private void btnCancelling_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                string testName = cbxTest.SelectedItem.ToString();
                Test = new Test();
                Test.Id = new TestManager().GetByName(testName).Id;
                var questions = new QuestionManager().GetByTestId(Test.Id); //getting all questions with given TestId
                int testLength = questions.Count();

                for (int i = 0; i < testLength; i++) //loop which continues from 0 to (the number of questions in selected test = testLength)
                {
                    var form = new AnswerQuestionForm();
                    form.ReceiveAnswer(questions[i], i, Applicant, Test); //calling the particular w=form with required arguments: current question, current index, selected Applicant and Test
                }

                MyForms.GetForm<ApplicantListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
