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
    public partial class ApplicantEditForm : Form
    {
        public ApplicantEditForm()
        {
            InitializeComponent();
        }

        public Applicant Applicant { get; set; }

        public FormMode Mode { get; set; }

        public bool isSaved; // defining a public saved boolean which supports data change persisting function explained below

        public void AddApplicant()
        {
            Mode = FormMode.Add; //setting the mode to Add when this method is called
            Applicant = new Applicant();
            MdiParent = MyForms.GetForm<ParentForm>();

            isSaved = false; //initially, the data is not saved so setting it to false

            Show();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            Mode = FormMode.Update; //setting the mode to Update when this method is called
            Applicant = applicant;
            ShowApplicantInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void ShowApplicantInControls()
        {
            tbxName.Text = Applicant.Name;

            //Setting the value of textbox to the name of Applicant
        }

        private void GrabUserInput()
        {
            Applicant.Name = tbxName.Text;

            //Grabbing the text inserted into the textbox
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
                var manager = new ApplicantManager();
                if (Mode == FormMode.Add) //"if the mode is Add"
                    manager.Create(Applicant); //adding new applicant
                else //"if the mode is Update"
                    manager.Update(Applicant); //updating the applicant

                MyForms.GetForm<ApplicantListForm>().LoadData(); //reloading the list

                isSaved = true; //after data are saved, resetting isSaved boolean to true

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApplicantEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved  || string.IsNullOrEmpty(tbxName.Text) || tbxName.Text == Applicant.Name) //"if the data are saved OR textbox is empty (Add mode) OR the name has not been changed (Update mode)"
            {
                e.Cancel = false; //closing the form
            }
            else //"if the data are not saved OR new name has been inserted OR name has been changed in the textbox"
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
