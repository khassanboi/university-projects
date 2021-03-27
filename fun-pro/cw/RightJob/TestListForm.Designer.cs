namespace RightJob
{
    partial class TestListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefreshTest = new System.Windows.Forms.Button();
            this.btnDeleteTest = new System.Windows.Forms.Button();
            this.btnUpdateTest = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.btnAddTestQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTest.AutoGenerateColumns = false;
            this.dgvTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.testNameDataGridViewTextBoxColumn,
            this.questionsNumberDataGridViewTextBoxColumn});
            this.dgvTest.DataSource = this.testBindingSource1;
            this.dgvTest.Location = new System.Drawing.Point(12, 12);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.RowHeadersWidth = 51;
            this.dgvTest.RowTemplate.Height = 24;
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(795, 479);
            this.dgvTest.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 48;
            // 
            // testNameDataGridViewTextBoxColumn
            // 
            this.testNameDataGridViewTextBoxColumn.DataPropertyName = "TestName";
            this.testNameDataGridViewTextBoxColumn.HeaderText = "TestName";
            this.testNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testNameDataGridViewTextBoxColumn.Name = "testNameDataGridViewTextBoxColumn";
            this.testNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.testNameDataGridViewTextBoxColumn.Width = 102;
            // 
            // questionsNumberDataGridViewTextBoxColumn
            // 
            this.questionsNumberDataGridViewTextBoxColumn.DataPropertyName = "QuestionsNumber";
            this.questionsNumberDataGridViewTextBoxColumn.HeaderText = "QuestionsNumber";
            this.questionsNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionsNumberDataGridViewTextBoxColumn.Name = "questionsNumberDataGridViewTextBoxColumn";
            this.questionsNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionsNumberDataGridViewTextBoxColumn.Width = 151;
            // 
            // testBindingSource1
            // 
            this.testBindingSource1.DataSource = typeof(RightJob.DAL.Test);
            // 
            // btnRefreshTest
            // 
            this.btnRefreshTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshTest.Location = new System.Drawing.Point(813, 180);
            this.btnRefreshTest.Name = "btnRefreshTest";
            this.btnRefreshTest.Size = new System.Drawing.Size(158, 36);
            this.btnRefreshTest.TabIndex = 2;
            this.btnRefreshTest.Text = "Refresh";
            this.btnRefreshTest.UseVisualStyleBackColor = true;
            this.btnRefreshTest.Click += new System.EventHandler(this.btnRefreshTest_Click);
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTest.Location = new System.Drawing.Point(813, 138);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(158, 36);
            this.btnDeleteTest.TabIndex = 3;
            this.btnDeleteTest.Text = "Delete";
            this.btnDeleteTest.UseVisualStyleBackColor = true;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_Click);
            // 
            // btnUpdateTest
            // 
            this.btnUpdateTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateTest.Location = new System.Drawing.Point(813, 96);
            this.btnUpdateTest.Name = "btnUpdateTest";
            this.btnUpdateTest.Size = new System.Drawing.Size(158, 36);
            this.btnUpdateTest.TabIndex = 4;
            this.btnUpdateTest.Text = "Update Test";
            this.btnUpdateTest.UseVisualStyleBackColor = true;
            this.btnUpdateTest.Click += new System.EventHandler(this.btnUpdateTest_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTest.Location = new System.Drawing.Point(813, 12);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(158, 36);
            this.btnAddTest.TabIndex = 5;
            this.btnAddTest.Text = "Add Test";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // btnAddTestQuestion
            // 
            this.btnAddTestQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTestQuestion.Location = new System.Drawing.Point(813, 54);
            this.btnAddTestQuestion.Name = "btnAddTestQuestion";
            this.btnAddTestQuestion.Size = new System.Drawing.Size(158, 36);
            this.btnAddTestQuestion.TabIndex = 2;
            this.btnAddTestQuestion.Text = "Add Question";
            this.btnAddTestQuestion.UseVisualStyleBackColor = true;
            this.btnAddTestQuestion.Click += new System.EventHandler(this.btnAddTestQuestion_Click);
            // 
            // TestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.btnAddTestQuestion);
            this.Controls.Add(this.btnRefreshTest);
            this.Controls.Add(this.btnDeleteTest);
            this.Controls.Add(this.btnUpdateTest);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.dgvTest);
            this.Name = "TestListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tests";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestListForm_FormClosing);
            this.Load += new System.EventHandler(this.TestListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionOneAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTwoAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionThreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionThreeAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefreshTest;
        private System.Windows.Forms.Button btnDeleteTest;
        private System.Windows.Forms.Button btnUpdateTest;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.BindingSource testBindingSource1;
        private System.Windows.Forms.Button btnAddTestQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionsNumberDataGridViewTextBoxColumn;
    }
}