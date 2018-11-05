namespace EventManagementSystem
{
    partial class ClientForm
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
            System.Windows.Forms.Label eventIdLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label nICLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label clientIdLabel;
            System.Windows.Forms.Label contractConfirmedLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.sakiDataSet = new EventManagementSystem.SakiDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.clientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nICMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.clientIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contractConfirmedCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.EventTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            eventIdLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            nICLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            clientIdLabel = new System.Windows.Forms.Label();
            contractConfirmedLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eventIdLabel
            // 
            eventIdLabel.AutoSize = true;
            eventIdLabel.Location = new System.Drawing.Point(57, 267);
            eventIdLabel.Name = "eventIdLabel";
            eventIdLabel.Size = new System.Drawing.Size(50, 13);
            eventIdLabel.TabIndex = 15;
            eventIdLabel.Text = "Event Id:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(344, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(344, 159);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 9;
            telephoneLabel.Text = "Telephone:";
            // 
            // nICLabel
            // 
            nICLabel.AutoSize = true;
            nICLabel.Location = new System.Drawing.Point(57, 104);
            nICLabel.Name = "nICLabel";
            nICLabel.Size = new System.Drawing.Size(51, 13);
            nICLabel.TabIndex = 5;
            nICLabel.Text = "NIC No. :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(57, 78);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new System.Drawing.Point(57, 52);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(48, 13);
            clientIdLabel.TabIndex = 1;
            clientIdLabel.Text = "Client Id:";
            // 
            // contractConfirmedLabel1
            // 
            contractConfirmedLabel1.AutoSize = true;
            contractConfirmedLabel1.Location = new System.Drawing.Point(57, 231);
            contractConfirmedLabel1.Name = "contractConfirmedLabel1";
            contractConfirmedLabel1.Size = new System.Drawing.Size(138, 13);
            contractConfirmedLabel1.TabIndex = 17;
            contractConfirmedLabel1.Text = "Contract confirmation status";
            // 
            // sakiDataSet
            // 
            this.sakiDataSet.DataSetName = "SakiDataSet";
            this.sakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.sakiDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessControlTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.CoordinatiorTableAdapter = null;
            this.tableAdapterManager.DecorsSupplierTableAdapter = null;
            this.tableAdapterManager.EntertainmentSupplierTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.FoodAndBeverageSupplierTableAdapter = null;
            
            this.tableAdapterManager.PhotographySupplierTableAdapter = null;
            this.tableAdapterManager.TransportSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VenueSupplierTableAdapter = null;
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientBindingNavigator.BindingSource = this.clientBindingSource;
            this.clientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.clientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientBindingNavigator.Size = new System.Drawing.Size(543, 25);
            this.clientBindingNavigator.TabIndex = 0;
            this.clientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clientBindingNavigatorSaveItem
            // 
            this.clientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientBindingNavigatorSaveItem.Image")));
            this.clientBindingNavigatorSaveItem.Name = "clientBindingNavigatorSaveItem";
            this.clientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientBindingNavigatorSaveItem.Text = "Save Data";
            this.clientBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientBindingNavigatorSaveItem_Click_1);
            // 
            // eventIdMaskedTextBox
            // 
            this.eventIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "EventId", true));
            this.eventIdMaskedTextBox.Enabled = false;
            this.eventIdMaskedTextBox.Location = new System.Drawing.Point(201, 264);
            this.eventIdMaskedTextBox.Name = "eventIdMaskedTextBox";
            this.eventIdMaskedTextBox.Size = new System.Drawing.Size(133, 20);
            this.eventIdMaskedTextBox.TabIndex = 16;
            this.eventIdMaskedTextBox.TabStop = false;
            this.eventIdMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.eventIdMaskedTextBox_MaskInputRejected);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(411, 186);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(75, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Telephone", true));
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(411, 156);
            this.telephoneMaskedTextBox.Mask = "0000000000";
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(75, 20);
            this.telephoneMaskedTextBox.TabIndex = 10;
            // 
            // nICMaskedTextBox
            // 
            this.nICMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NIC", true));
            this.nICMaskedTextBox.Location = new System.Drawing.Point(195, 104);
            this.nICMaskedTextBox.Mask = "0000000000v";
            this.nICMaskedTextBox.Name = "nICMaskedTextBox";
            this.nICMaskedTextBox.Size = new System.Drawing.Size(139, 20);
            this.nICMaskedTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(195, 78);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(139, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // clientIdMaskedTextBox
            // 
            this.clientIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientId", true));
            this.clientIdMaskedTextBox.Location = new System.Drawing.Point(195, 52);
            this.clientIdMaskedTextBox.Mask = "client/0000/000";
            this.clientIdMaskedTextBox.Name = "clientIdMaskedTextBox";
            this.clientIdMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientIdMaskedTextBox.Size = new System.Drawing.Size(139, 20);
            this.clientIdMaskedTextBox.TabIndex = 2;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.clientBindingSource, "Gender", true));
            this.MaleRadioButton.Location = new System.Drawing.Point(9, 19);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(80, 24);
            this.MaleRadioButton.TabIndex = 8;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            this.MaleRadioButton.CheckedChanged += new System.EventHandler(this.MaleRadioButton_CheckedChanged);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(9, 43);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 9;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FemaleRadioButton);
            this.groupBox1.Controls.Add(this.MaleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(195, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 66);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // contractConfirmedCheckBox
            // 
            this.contractConfirmedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientBindingSource, "ContractConfirmed", true));
            this.contractConfirmedCheckBox.Enabled = false;
            this.contractConfirmedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.contractConfirmedCheckBox.Location = new System.Drawing.Point(201, 229);
            this.contractConfirmedCheckBox.Name = "contractConfirmedCheckBox";
            this.contractConfirmedCheckBox.Size = new System.Drawing.Size(40, 19);
            this.contractConfirmedCheckBox.TabIndex = 18;
            this.contractConfirmedCheckBox.TabStop = false;
            this.contractConfirmedCheckBox.UseVisualStyleBackColor = true;
            this.contractConfirmedCheckBox.CheckedChanged += new System.EventHandler(this.contractConfirmedCheckBox_CheckedChanged);
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(217, 231);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(0, 13);
            this.ConfirmLabel.TabIndex = 19;
            // 
            // ViewButton
            // 
            this.ViewButton.Enabled = false;
            this.ViewButton.Location = new System.Drawing.Point(372, 262);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 20;
            this.ViewButton.Text = "View Event ";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.sakiDataSet;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 373);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(contractConfirmedLabel1);
            this.Controls.Add(this.contractConfirmedCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(clientIdLabel);
            this.Controls.Add(this.clientIdMaskedTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(nICLabel);
            this.Controls.Add(this.nICMaskedTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(eventIdLabel);
            this.Controls.Add(this.eventIdMaskedTextBox);
            this.Controls.Add(this.clientBindingNavigator);
            this.Name = "ClientForm";
            this.Text = "Saki Events - Clients";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SakiDataSet sakiDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SakiDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private SakiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton clientBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox eventIdMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox nICMaskedTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox clientIdMaskedTextBox;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox contractConfirmedCheckBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private SakiDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}