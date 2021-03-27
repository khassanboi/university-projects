namespace RightJob
{
    partial class TakeTestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbApplicant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTest = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancelling = new System.Windows.Forms.Button();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applicant\'s Name:";
            // 
            // lbApplicant
            // 
            this.lbApplicant.AutoSize = true;
            this.lbApplicant.BackColor = System.Drawing.Color.White;
            this.lbApplicant.Location = new System.Drawing.Point(179, 38);
            this.lbApplicant.Name = "lbApplicant";
            this.lbApplicant.Size = new System.Drawing.Size(36, 17);
            this.lbApplicant.TabIndex = 3;
            this.lbApplicant.Text = "NaN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Test Name:";
            // 
            // cbxTest
            // 
            this.cbxTest.FormattingEnabled = true;
            this.cbxTest.Location = new System.Drawing.Point(182, 68);
            this.cbxTest.Name = "cbxTest";
            this.cbxTest.Size = new System.Drawing.Size(162, 24);
            this.cbxTest.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(122, 115);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 34);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancelling
            // 
            this.btnCancelling.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelling.Location = new System.Drawing.Point(236, 115);
            this.btnCancelling.Name = "btnCancelling";
            this.btnCancelling.Size = new System.Drawing.Size(108, 34);
            this.btnCancelling.TabIndex = 4;
            this.btnCancelling.Text = "Cancel";
            this.btnCancelling.UseVisualStyleBackColor = true;
            this.btnCancelling.Click += new System.EventHandler(this.btnCancelling_Click);
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(RightJob.DAL.Test);
            // 
            // TakeTestForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelling;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.btnCancelling);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxTest);
            this.Controls.Add(this.lbApplicant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TakeTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Test";
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbApplicant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancelling;
        private System.Windows.Forms.BindingSource testBindingSource;
    }
}