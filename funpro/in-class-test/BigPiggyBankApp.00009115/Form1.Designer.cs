namespace BigPiggyBankApp._00009115
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label clientName_9115Label;
            System.Windows.Forms.Label clientAddress_9115Label;
            System.Windows.Forms.Label clientDOB_9115Label;
            System.Windows.Forms.Label clientBalance_9115Label;
            System.Windows.Forms.Label clientCategory_9115Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.lbClients = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.bankDataSet = new BigPiggyBankApp._00009115.BankDataSet();
            this.tb_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ClientTableAdapter = new BigPiggyBankApp._00009115.BankDataSetTableAdapters.tb_ClientTableAdapter();
            this.tableAdapterManager = new BigPiggyBankApp._00009115.BankDataSetTableAdapters.TableAdapterManager();
            this.tb_ClientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_ClientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientName_9115TextBox = new System.Windows.Forms.TextBox();
            this.clientAddress_9115TextBox = new System.Windows.Forms.TextBox();
            this.clientDOB_9115DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbClientCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ClientCategoryTableAdapter = new BigPiggyBankApp._00009115.BankDataSetTableAdapters.tb_ClientCategoryTableAdapter();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxNewCategory = new System.Windows.Forms.ComboBox();
            this.tbClientCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxNewName = new System.Windows.Forms.TextBox();
            this.tbxNewAddress = new System.Windows.Forms.TextBox();
            this.dtpNewDOB = new System.Windows.Forms.DateTimePicker();
            this.nudNewBalance = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            clientName_9115Label = new System.Windows.Forms.Label();
            clientAddress_9115Label = new System.Windows.Forms.Label();
            clientDOB_9115Label = new System.Windows.Forms.Label();
            clientBalance_9115Label = new System.Windows.Forms.Label();
            clientCategory_9115Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClientBindingNavigator)).BeginInit();
            this.tb_ClientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientCategoryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClients
            // 
            this.lbClients.AutoSize = true;
            this.lbClients.Location = new System.Drawing.Point(54, 139);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(54, 17);
            this.lbClients.TabIndex = 0;
            this.lbClients.Text = "Clients:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tb_ClientBindingSource;
            this.listBox1.DisplayMember = "ClientName_9115";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(57, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 100);
            this.listBox1.TabIndex = 1;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnSave);
            this.gbEdit.Controls.Add(this.comboBox1);
            this.gbEdit.Controls.Add(this.numericUpDown1);
            this.gbEdit.Controls.Add(clientName_9115Label);
            this.gbEdit.Controls.Add(this.clientName_9115TextBox);
            this.gbEdit.Controls.Add(clientAddress_9115Label);
            this.gbEdit.Controls.Add(this.clientAddress_9115TextBox);
            this.gbEdit.Controls.Add(clientDOB_9115Label);
            this.gbEdit.Controls.Add(this.clientDOB_9115DateTimePicker);
            this.gbEdit.Controls.Add(clientBalance_9115Label);
            this.gbEdit.Controls.Add(clientCategory_9115Label);
            this.gbEdit.Location = new System.Drawing.Point(275, 65);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(363, 273);
            this.gbEdit.TabIndex = 2;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit Current Client:";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ClientBindingSource
            // 
            this.tb_ClientBindingSource.DataMember = "tb_Client";
            this.tb_ClientBindingSource.DataSource = this.bankDataSet;
            this.tb_ClientBindingSource.CurrentChanged += new System.EventHandler(this.tb_ClientBindingSource_CurrentChanged);
            // 
            // tb_ClientTableAdapter
            // 
            this.tb_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ClientCategoryTableAdapter = null;
            this.tableAdapterManager.tb_ClientTableAdapter = this.tb_ClientTableAdapter;
            this.tableAdapterManager.UpdateOrder = BigPiggyBankApp._00009115.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_ClientBindingNavigator
            // 
            this.tb_ClientBindingNavigator.AddNewItem = null;
            this.tb_ClientBindingNavigator.BindingSource = this.tb_ClientBindingSource;
            this.tb_ClientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ClientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ClientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tb_ClientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.tb_ClientBindingNavigatorSaveItem});
            this.tb_ClientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ClientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ClientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ClientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ClientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ClientBindingNavigator.Name = "tb_ClientBindingNavigator";
            this.tb_ClientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ClientBindingNavigator.Size = new System.Drawing.Size(1117, 27);
            this.tb_ClientBindingNavigator.TabIndex = 3;
            this.tb_ClientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tb_ClientBindingNavigatorSaveItem
            // 
            this.tb_ClientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ClientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ClientBindingNavigatorSaveItem.Image")));
            this.tb_ClientBindingNavigatorSaveItem.Name = "tb_ClientBindingNavigatorSaveItem";
            this.tb_ClientBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tb_ClientBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_ClientBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ClientBindingNavigatorSaveItem_Click);
            // 
            // clientName_9115Label
            // 
            clientName_9115Label.AutoSize = true;
            clientName_9115Label.Location = new System.Drawing.Point(21, 35);
            clientName_9115Label.Name = "clientName_9115Label";
            clientName_9115Label.Size = new System.Drawing.Size(49, 17);
            clientName_9115Label.TabIndex = 2;
            clientName_9115Label.Text = "Name:";
            // 
            // clientName_9115TextBox
            // 
            this.clientName_9115TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ClientBindingSource, "ClientName_9115", true));
            this.clientName_9115TextBox.Location = new System.Drawing.Point(139, 32);
            this.clientName_9115TextBox.Name = "clientName_9115TextBox";
            this.clientName_9115TextBox.Size = new System.Drawing.Size(200, 22);
            this.clientName_9115TextBox.TabIndex = 3;
            this.clientName_9115TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.clientName_9115TextBox_Validating);
            // 
            // clientAddress_9115Label
            // 
            clientAddress_9115Label.AutoSize = true;
            clientAddress_9115Label.Location = new System.Drawing.Point(21, 73);
            clientAddress_9115Label.Name = "clientAddress_9115Label";
            clientAddress_9115Label.Size = new System.Drawing.Size(64, 17);
            clientAddress_9115Label.TabIndex = 4;
            clientAddress_9115Label.Text = "Address:";
            // 
            // clientAddress_9115TextBox
            // 
            this.clientAddress_9115TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ClientBindingSource, "ClientAddress_9115", true));
            this.clientAddress_9115TextBox.Location = new System.Drawing.Point(139, 70);
            this.clientAddress_9115TextBox.Name = "clientAddress_9115TextBox";
            this.clientAddress_9115TextBox.Size = new System.Drawing.Size(200, 22);
            this.clientAddress_9115TextBox.TabIndex = 5;
            this.clientAddress_9115TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.clientAddress_9115TextBox_Validating);
            // 
            // clientDOB_9115Label
            // 
            clientDOB_9115Label.AutoSize = true;
            clientDOB_9115Label.Location = new System.Drawing.Point(21, 112);
            clientDOB_9115Label.Name = "clientDOB_9115Label";
            clientDOB_9115Label.Size = new System.Drawing.Size(91, 17);
            clientDOB_9115Label.TabIndex = 6;
            clientDOB_9115Label.Text = "Date of Birth:";
            // 
            // clientDOB_9115DateTimePicker
            // 
            this.clientDOB_9115DateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.clientDOB_9115DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ClientBindingSource, "ClientDOB_9115", true));
            this.clientDOB_9115DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.clientDOB_9115DateTimePicker.Location = new System.Drawing.Point(139, 108);
            this.clientDOB_9115DateTimePicker.Name = "clientDOB_9115DateTimePicker";
            this.clientDOB_9115DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.clientDOB_9115DateTimePicker.TabIndex = 7;
            this.clientDOB_9115DateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.clientDOB_9115DateTimePicker_Validating);
            // 
            // clientBalance_9115Label
            // 
            clientBalance_9115Label.AutoSize = true;
            clientBalance_9115Label.Location = new System.Drawing.Point(21, 149);
            clientBalance_9115Label.Name = "clientBalance_9115Label";
            clientBalance_9115Label.Size = new System.Drawing.Size(63, 17);
            clientBalance_9115Label.TabIndex = 8;
            clientBalance_9115Label.Text = "Balance:";
            // 
            // clientCategory_9115Label
            // 
            clientCategory_9115Label.AutoSize = true;
            clientCategory_9115Label.Location = new System.Drawing.Point(21, 187);
            clientCategory_9115Label.Name = "clientCategory_9115Label";
            clientCategory_9115Label.Size = new System.Drawing.Size(69, 17);
            clientCategory_9115Label.TabIndex = 10;
            clientCategory_9115Label.Text = "Category:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ClientBindingSource, "ClientBalance_9115", true));
            this.numericUpDown1.Location = new System.Drawing.Point(139, 146);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ClientBindingSource, "ClientCategory_9115", true));
            this.comboBox1.DataSource = this.tbClientCategoryBindingSource;
            this.comboBox1.DisplayMember = "ClientCategoryName_9115";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "ID_9115";
            // 
            // tbClientCategoryBindingSource
            // 
            this.tbClientCategoryBindingSource.DataMember = "tb_ClientCategory";
            this.tbClientCategoryBindingSource.DataSource = this.bankDataSet;
            // 
            // tb_ClientCategoryTableAdapter
            // 
            this.tb_ClientCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(57, 290);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(37, 28);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(193, 290);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(37, 28);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(102, 290);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(37, 28);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(148, 290);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 28);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudNewBalance);
            this.groupBox1.Controls.Add(this.dtpNewDOB);
            this.groupBox1.Controls.Add(this.tbxNewAddress);
            this.groupBox1.Controls.Add(this.tbxNewName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbxNewCategory);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Location = new System.Drawing.Point(691, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Client:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 17);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 17);
            label2.TabIndex = 4;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 17);
            label3.TabIndex = 6;
            label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 149);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 17);
            label4.TabIndex = 8;
            label4.Text = "Balance:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 187);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 17);
            label5.TabIndex = 10;
            label5.Text = "Category:";
            // 
            // cbxNewCategory
            // 
            this.cbxNewCategory.DataSource = this.tbClientCategoryBindingSource1;
            this.cbxNewCategory.DisplayMember = "ClientCategoryName_9115";
            this.cbxNewCategory.FormattingEnabled = true;
            this.cbxNewCategory.Location = new System.Drawing.Point(139, 184);
            this.cbxNewCategory.Name = "cbxNewCategory";
            this.cbxNewCategory.Size = new System.Drawing.Size(200, 24);
            this.cbxNewCategory.TabIndex = 13;
            // 
            // tbClientCategoryBindingSource1
            // 
            this.tbClientCategoryBindingSource1.DataMember = "tb_ClientCategory";
            this.tbClientCategoryBindingSource1.DataSource = this.bankDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxNewName
            // 
            this.tbxNewName.Location = new System.Drawing.Point(139, 32);
            this.tbxNewName.Name = "tbxNewName";
            this.tbxNewName.Size = new System.Drawing.Size(200, 22);
            this.tbxNewName.TabIndex = 15;
            // 
            // tbxNewAddress
            // 
            this.tbxNewAddress.Location = new System.Drawing.Point(139, 70);
            this.tbxNewAddress.Name = "tbxNewAddress";
            this.tbxNewAddress.Size = new System.Drawing.Size(200, 22);
            this.tbxNewAddress.TabIndex = 15;
            // 
            // dtpNewDOB
            // 
            this.dtpNewDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpNewDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDOB.Location = new System.Drawing.Point(139, 107);
            this.dtpNewDOB.Name = "dtpNewDOB";
            this.dtpNewDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpNewDOB.TabIndex = 16;
            // 
            // nudNewBalance
            // 
            this.nudNewBalance.Location = new System.Drawing.Point(139, 146);
            this.nudNewBalance.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudNewBalance.Name = "nudNewBalance";
            this.nudNewBalance.Size = new System.Drawing.Size(200, 22);
            this.nudNewBalance.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Filter:";
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(57, 94);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(173, 22);
            this.tbxFilter.TabIndex = 6;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 383);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.tb_ClientBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbClients);
            this.Name = "Form1";
            this.Text = "Big Piggy Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClientBindingNavigator)).EndInit();
            this.tb_ClientBindingNavigator.ResumeLayout(false);
            this.tb_ClientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientCategoryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClients;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbEdit;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource tb_ClientBindingSource;
        private BankDataSetTableAdapters.tb_ClientTableAdapter tb_ClientTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ClientBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_ClientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox clientName_9115TextBox;
        private System.Windows.Forms.TextBox clientAddress_9115TextBox;
        private System.Windows.Forms.DateTimePicker clientDOB_9115DateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tbClientCategoryBindingSource;
        private BankDataSetTableAdapters.tb_ClientCategoryTableAdapter tb_ClientCategoryTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxNewCategory;
        private System.Windows.Forms.BindingSource tbClientCategoryBindingSource1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudNewBalance;
        private System.Windows.Forms.DateTimePicker dtpNewDOB;
        private System.Windows.Forms.TextBox tbxNewAddress;
        private System.Windows.Forms.TextBox tbxNewName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}

