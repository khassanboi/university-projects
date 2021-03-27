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
    public partial class TestEditForm : Form
    {
        public TestEditForm()
        {
            InitializeComponent();
        }

        public Test Test { get; set; }

        public FormMode Mode { get; set; }

        public bool isSaved; // defining a public saved boolean which supports data change persisting function explained below
        public void AddTest()
        {
            Mode = FormMode.Add; //setting the mode to Add when this method is called
            Test = new Test();
            MdiParent = MyForms.GetForm<ParentForm>();

            isSaved = false; //initially, the data is not saved so setting it to false

            Show();
        }

        public void UpdateTest(Test test)
        {
            Mode = FormMode.Update; //setting the mode to Update when this method is called
            Test = test;
            ShowTestInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void ShowTestInControls()
        {
            tbxNameTest.Text = Test.TestName;

            //Setting the value of textbox to the name of Test
        }

        private void GrabUserInput()
        {
            Test.TestName = tbxNameTest.Text;

            //Grabbing the text inserted into the textbox
        }

        private void btnCancelTest_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            SaveData();   
        }

        public void SaveData()
        {
            try
            {
                GrabUserInput();

                var manager = new TestManager();
                if (Mode == FormMode.Add) //"if the mode is Add"
                    manager.Create(Test); //adding new test
                else //"if the mode is Update"
                    manager.Update(Test); //updating the test

                MyForms.GetForm<TestListForm>().LoadData();

                isSaved = true; //after data are saved, resetting isSaved boolean to true

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TestEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved || string.IsNullOrEmpty(tbxNameTest.Text) || tbxNameTest.Text == Test.TestName) //"if the data are saved OR textbox is empty (Add mode) OR the testname has not been changed (Update mode)"
            {
                e.Cancel = false; //closing the form
            }
            else //"if the data are not saved OR new test has been inserted OR testname has been changed in the textbox"
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
