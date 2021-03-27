namespace RightJob
{
    partial class TestEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNameTest = new System.Windows.Forms.TextBox();
            this.btnCancelTest = new System.Windows.Forms.Button();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Name:";
            // 
            // tbxNameTest
            // 
            this.tbxNameTest.Location = new System.Drawing.Point(126, 44);
            this.tbxNameTest.Name = "tbxNameTest";
            this.tbxNameTest.Size = new System.Drawing.Size(206, 22);
            this.tbxNameTest.TabIndex = 0;
            // 
            // btnCancelTest
            // 
            this.btnCancelTest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelTest.Location = new System.Drawing.Point(232, 77);
            this.btnCancelTest.Name = "btnCancelTest";
            this.btnCancelTest.Size = new System.Drawing.Size(100, 34);
            this.btnCancelTest.TabIndex = 2;
            this.btnCancelTest.Text = "Cancel";
            this.btnCancelTest.UseVisualStyleBackColor = true;
            this.btnCancelTest.Click += new System.EventHandler(this.btnCancelTest_Click);
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(126, 77);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(100, 34);
            this.btnSaveTest.TabIndex = 1;
            this.btnSaveTest.Text = "Save";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // TestEditForm
            // 
            this.AcceptButton = this.btnSaveTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelTest;
            this.ClientSize = new System.Drawing.Size(390, 145);
            this.Controls.Add(this.btnSaveTest);
            this.Controls.Add(this.btnCancelTest);
            this.Controls.Add(this.tbxNameTest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestEditForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNameTest;
        private System.Windows.Forms.Button btnCancelTest;
        private System.Windows.Forms.Button btnSaveTest;
    }
}