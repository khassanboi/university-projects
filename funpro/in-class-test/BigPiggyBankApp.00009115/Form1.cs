using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPiggyBankApp._00009115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Trying to execute the following

                this.tb_ClientCategoryTableAdapter.Fill(this.bankDataSet.tb_ClientCategory);
                this.tb_ClientTableAdapter.Fill(this.bankDataSet.tb_Client);
            }
            catch (Exception ex)
            {
                // If there is any error, a message with an error will be shown and form crash will be avoided

                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Assigning custom title and icon
            }
        }


        private void tb_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveRecord();
            // Calling the function to save the record
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRecord();
            // Calling the function to save the record
        }

        private void SaveRecord()
        {
            if (this.Validate())
            {
                // if the data inserted are valid, following will be executed:

                try
                {
                    // Trying to execute the following

                    this.tb_ClientBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bankDataSet);
                    MessageBox.Show("Record has been saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
                }
                catch (Exception ex)
                {
                    // If there is any error, a message with an error will be shown and form crash will be avoided

                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Assigning custom title and icon
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tb_ClientBindingSource.MoveFirst();
            // Moving the position to the first index
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tb_ClientBindingSource.MovePrevious();
            // Moving the position to the previous index
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tb_ClientBindingSource.MoveNext();
            // Moving the position to the next index
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tb_ClientBindingSource.MoveLast();
            // Moving the position to the last index
        }

        private void ManageControlButtons()
        {

            // A function to disable/enable the controll buttons accordingly

            if (tb_ClientBindingSource.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
                // Disabling btnFirst and btnPrevious when the first item is open as there is no other items before
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                // Enabling btnFirst and btnPrevious back when there are other items before the current item
            }

            if (tb_ClientBindingSource.Position == tb_ClientBindingSource.Count - 1)
            {
                btnLast.Enabled = false;
                btnNext.Enabled = false;
                // Disabling btnLast and btnNext when the last item is open as there is no other items after
            }
            else
            {
                btnLast.Enabled = true;
                btnNext.Enabled = true;
                // Enabling btnLast and btnNext back when there are other items after the current item
            }
        }

        private void tb_ClientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            // Calling the ManageControlButtons function when there has been a change on tb_ClientBindingSource
            // Re-calling the function repeatedly each time when control-buttons are clicked is not a good experience
            // Thus CurrentChanged event of tb_ClientBindingSource can be handfull in this case to keep track of changes

            ManageControlButtons();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tb_ClientBindingSource.Count == 0)
            {
                // if there is no more record, following will be executed:

                MessageBox.Show("There is no more records", "Note!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
                btnDelete.Enabled = false;
                // Disabling the btnDelete and showing a message to the user when there's no more records
            }
            else
            {
                // else (if there is at least one more record), following will be executed:

                var userResponse = MessageBox.Show("Do you want to delete the current record?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); // Assigning custom title, icon, buttons and default button
                                                                                                                                                                                               // Assigning the result of the user to a variable

                if (userResponse == DialogResult.Yes)
                {
                    // if the response of the user is Yes, following will be executed:

                    tb_ClientBindingSource.RemoveCurrent();
                    // Deleting the current record after several confirmations
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Asking the user whether the records should be changed or not

            if (Validate())
            {
                this.tb_ClientBindingSource.EndEdit();
                if (bankDataSet.HasChanges())
                {
                    // if there has been any change, following will be executed:

                    if (MessageBox.Show("Do you want to save your records?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        // if user has responded Yes, following will be executed:

                        SaveRecord();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validating the user input

            if (tbxNewName.Text == "")
            {
                MessageBox.Show("Please, insert the Name", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
            }
            else if (tbxNewAddress.Text == "")
            {
                MessageBox.Show("Please, insert the Address", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
            }
            else if (ageCalculator(dtpNewDOB.Value) < 18)  // Using the ageCalculator function to check the age of client
            {
                MessageBox.Show("Client has to be older than 18!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
            }
            else 
            {
                var selectedCategory = ((DataRowView)cbxNewCategory.SelectedItem).Row;
                // Assigning the selected category into a variable

                bankDataSet.tb_Client.Addtb_ClientRow(
                    tbxNewName.Text,
                    tbxNewAddress.Text,
                    dtpNewDOB.Value,
                    (int)nudNewBalance.Value,
                    (BankDataSet.tb_ClientCategoryRow)selectedCategory);
                // Pushing the new record into a data-set

                MessageBox.Show("New record has been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
                // Confirming that the record has been added

                tbxNewName.Text = "";
                tbxNewAddress.Text = "";
                dtpNewDOB.Value = DateTime.Today;
                nudNewBalance.Value = 0;
                cbxNewCategory.SelectedIndex = 0;
                // Emptying and setting the default values of the inputs
            }
            
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tb_ClientBindingSource.Filter = $"ClientName_9115 LIKE ('{tbxFilter.Text}%')";
            // Filtering the list according to the name of the client
        }

        private void clientName_9115TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(clientName_9115TextBox.Text) || string.IsNullOrWhiteSpace(clientName_9115TextBox.Text))
            {
                MessageBox.Show("Name cannot be empty!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
                e.Cancel = true;
            }
        }

        private void clientAddress_9115TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(clientAddress_9115TextBox.Text) || string.IsNullOrWhiteSpace(clientAddress_9115TextBox.Text))
            {
                MessageBox.Show("Address cannot be empty!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
                e.Cancel = true;
            }
        }

        private void clientDOB_9115DateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if(ageCalculator(clientDOB_9115DateTimePicker.Value) < 18)  // Using the ageCalculator function to check the age of client
            {
                MessageBox.Show("Client has to be older than 18!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Assigning custom title and icon
                e.Cancel = true;
            }
        }

        private int ageCalculator(DateTime dob)
        {
            // A function which returns the calculated age using the date of birth

            DateTime present = DateTime.Today;  // Taking current date
            TimeSpan ts = present - dob;  // Subtracting the difference between the date of birth and current time
            return ts.Days / 365;   // Dividing the difference by 365 to get the years which is equal to the age

            // This is the best logic that I could use after researching all over the Internet, there may be a slight mistake (2-3 days)
        }
    }
}
