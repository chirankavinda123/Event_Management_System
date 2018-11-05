namespace EventManagementSystem.view
{
    partial class AccessControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessControlForm));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label officeIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label accessTypeLabel;
            this.sakiDataSet = new EventManagementSystem.SakiDataSet();
            this.accessControlTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessControlTableTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.AccessControlTableTableAdapter();
            this.tableAdapterManager = new EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager();
            this.accessControlTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.accessControlTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.officeIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accessTypeComboBox = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            officeIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            accessTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlTableBindingNavigator)).BeginInit();
            this.accessControlTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sakiDataSet
            // 
            this.sakiDataSet.DataSetName = "SakiDataSet";
            this.sakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accessControlTableBindingSource
            // 
            this.accessControlTableBindingSource.DataMember = "AccessControlTable";
            this.accessControlTableBindingSource.DataSource = this.sakiDataSet;
            // 
            // accessControlTableTableAdapter
            // 
            this.accessControlTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessControlTableTableAdapter = this.accessControlTableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accessControlTableBindingNavigator
            // 
            this.accessControlTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accessControlTableBindingNavigator.BindingSource = this.accessControlTableBindingSource;
            this.accessControlTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accessControlTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accessControlTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.accessControlTableBindingNavigatorSaveItem});
            this.accessControlTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accessControlTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accessControlTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accessControlTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accessControlTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accessControlTableBindingNavigator.Name = "accessControlTableBindingNavigator";
            this.accessControlTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accessControlTableBindingNavigator.Size = new System.Drawing.Size(344, 25);
            this.accessControlTableBindingNavigator.TabIndex = 0;
            this.accessControlTableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // accessControlTableBindingNavigatorSaveItem
            // 
            this.accessControlTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accessControlTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accessControlTableBindingNavigatorSaveItem.Image")));
            this.accessControlTableBindingNavigatorSaveItem.Name = "accessControlTableBindingNavigatorSaveItem";
            this.accessControlTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.accessControlTableBindingNavigatorSaveItem.Text = "Save Data";
            this.accessControlTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.accessControlTableBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(50, 59);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessControlTableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(128, 56);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // officeIdLabel
            // 
            officeIdLabel.AutoSize = true;
            officeIdLabel.Location = new System.Drawing.Point(50, 85);
            officeIdLabel.Name = "officeIdLabel";
            officeIdLabel.Size = new System.Drawing.Size(50, 13);
            officeIdLabel.TabIndex = 3;
            officeIdLabel.Text = "Office Id:";
            // 
            // officeIdMaskedTextBox
            // 
            this.officeIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessControlTableBindingSource, "OfficeId", true));
            this.officeIdMaskedTextBox.Location = new System.Drawing.Point(128, 82);
            this.officeIdMaskedTextBox.Mask = "LL-0000-000";
            this.officeIdMaskedTextBox.Name = "officeIdMaskedTextBox";
            this.officeIdMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.officeIdMaskedTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(50, 111);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessControlTableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(128, 108);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(50, 137);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "Age:";
            // 
            // ageMaskedTextBox
            // 
            this.ageMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessControlTableBindingSource, "Age", true));
            this.ageMaskedTextBox.Location = new System.Drawing.Point(128, 134);
            this.ageMaskedTextBox.Name = "ageMaskedTextBox";
            this.ageMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.ageMaskedTextBox.TabIndex = 8;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(50, 163);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 9;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessControlTableBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(128, 160);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.userNameTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(50, 189);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessControlTableBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(128, 186);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // accessTypeLabel
            // 
            accessTypeLabel.AutoSize = true;
            accessTypeLabel.Location = new System.Drawing.Point(50, 215);
            accessTypeLabel.Name = "accessTypeLabel";
            accessTypeLabel.Size = new System.Drawing.Size(72, 13);
            accessTypeLabel.TabIndex = 13;
            accessTypeLabel.Text = "Access Type:";
            // 
            // accessTypeComboBox
            // 
            this.accessTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessControlTableBindingSource, "AccessType", true));
            this.accessTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessTypeComboBox.FormattingEnabled = true;
            this.accessTypeComboBox.Items.AddRange(new object[] {
            "RECEPTION",
            "CASHIER",
            "COORDINATOR",
            "ADMINISTRATOR"});
            this.accessTypeComboBox.Location = new System.Drawing.Point(128, 212);
            this.accessTypeComboBox.Name = "accessTypeComboBox";
            this.accessTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.accessTypeComboBox.TabIndex = 14;
            // 
            // AccessControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 324);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(officeIdLabel);
            this.Controls.Add(this.officeIdMaskedTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageMaskedTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(accessTypeLabel);
            this.Controls.Add(this.accessTypeComboBox);
            this.Controls.Add(this.accessControlTableBindingNavigator);
            this.Name = "AccessControlForm";
            this.Text = "Saki Events - Access Control";
            this.Load += new System.EventHandler(this.AccessControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlTableBindingNavigator)).EndInit();
            this.accessControlTableBindingNavigator.ResumeLayout(false);
            this.accessControlTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SakiDataSet sakiDataSet;
        private System.Windows.Forms.BindingSource accessControlTableBindingSource;
        private SakiDataSetTableAdapters.AccessControlTableTableAdapter accessControlTableTableAdapter;
        private SakiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accessControlTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton accessControlTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.MaskedTextBox officeIdMaskedTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox ageMaskedTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox accessTypeComboBox;
    }
}