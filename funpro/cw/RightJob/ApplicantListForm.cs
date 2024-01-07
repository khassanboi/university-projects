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
    public partial class ApplicantListForm : Form
    {
        public ApplicantListForm()
        {
            InitializeComponent();
        }

        private void ApplicantListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ByAttribute selectedAttribute;
            selectedAttribute = ByAttribute.Score;

            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new ApplicantList().SortLinq(selectedAttribute);

            //sorting the applicants
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxSearch.Text)) //"if input is empty"
                    MessageBox.Show("Provide the search term");
                else
                {
                    ByAttribute selectedAttribute;
                    selectedAttribute = ByAttribute.Id;

                    dgv.DataMember = "";
                    dgv.DataSource = null;
                    dgv.DataSource = new ApplicantList().Search(tbxSearch.Text, selectedAttribute);

                    //searching an applicant by id
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new ApplicantList().GetAllApplicants();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new ApplicantEditForm();
            form.AddApplicant(); //calling the particular form
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0) //"if no row selected"
                    MessageBox.Show("Please select an applicant!");
                else
                {
                    var a = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                    new ApplicantEditForm().UpdateApplicant(a); //calling the particular method by sending the data of selected row
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
                if (dgv.SelectedRows.Count == 0) //"if no row selected"
                    MessageBox.Show("Please select an applicant");
                else
                {
                    var a = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                    new ApplicantManager().Delete(a.Id); //deleting the selected row
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) //"if no row selected"
                MessageBox.Show("Please select an applicant!");
            else
            {
                var a = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                new TakeTestForm().TakeTest(a); //calling the particular form by sending the data of selected row
            }
        }

        private void ApplicantListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!dgv.EndEdit())
            {
                e.Cancel = true;
            }
        }
    }
}
