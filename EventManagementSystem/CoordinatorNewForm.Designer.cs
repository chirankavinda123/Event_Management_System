namespace EventManagementSystem
{
    partial class CoordinatorNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinatorNewForm));
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label coordinatorNameLabel;
            System.Windows.Forms.Label coordinatorIdLabel;
            this.sakiDataSet = new EventManagementSystem.SakiDataSet();
            this.coordinatorNewTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coordinatorNewTableTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.CoordinatorNewTableTableAdapter();
            this.tableAdapterManager = new EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager();
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
            this.coordinatorNewTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coordinatorNewTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.genderRadioButton = new System.Windows.Forms.RadioButton();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.coordinatorNameTextBox = new System.Windows.Forms.TextBox();
            this.coordinatorIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            emailLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            coordinatorNameLabel = new System.Windows.Forms.Label();
            coordinatorIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorNewTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorNewTableBindingNavigator)).BeginInit();
            this.coordinatorNewTableBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sakiDataSet
            // 
            this.sakiDataSet.DataSetName = "SakiDataSet";
            this.sakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coordinatorNewTableBindingSource
            // 
            this.coordinatorNewTableBindingSource.DataMember = "CoordinatorNewTable";
            this.coordinatorNewTableBindingSource.DataSource = this.sakiDataSet;
            // 
            // coordinatorNewTableTableAdapter
            // 
            this.coordinatorNewTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessControlTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CoordinatiorTableAdapter = null;
            this.tableAdapterManager.CoordinatorNewTableTableAdapter = this.coordinatorNewTableTableAdapter;
            this.tableAdapterManager.DecorsSupplierTableAdapter = null;
            this.tableAdapterManager.EntertainmentSupplierTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.FoodAndBeverageSupplierTableAdapter = null;
            this.tableAdapterManager.PhotographySupplierTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TransportSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VenueSupplierTableAdapter = null;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // coordinatorNewTableBindingNavigatorSaveItem
            // 
            this.coordinatorNewTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coordinatorNewTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coordinatorNewTableBindingNavigatorSaveItem.Image")));
            this.coordinatorNewTableBindingNavigatorSaveItem.Name = "coordinatorNewTableBindingNavigatorSaveItem";
            this.coordinatorNewTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.coordinatorNewTableBindingNavigatorSaveItem.Text = "Save Data";
            this.coordinatorNewTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.coordinatorNewTableBindingNavigatorSaveItem_Click);
            // 
            // coordinatorNewTableBindingNavigator
            // 
            this.coordinatorNewTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coordinatorNewTableBindingNavigator.BindingSource = this.coordinatorNewTableBindingSource;
            this.coordinatorNewTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coordinatorNewTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coordinatorNewTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coordinatorNewTableBindingNavigatorSaveItem});
            this.coordinatorNewTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coordinatorNewTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coordinatorNewTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coordinatorNewTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coordinatorNewTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coordinatorNewTableBindingNavigator.Name = "coordinatorNewTableBindingNavigator";
            this.coordinatorNewTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coordinatorNewTableBindingNavigator.Size = new System.Drawing.Size(449, 25);
            this.coordinatorNewTableBindingNavigator.TabIndex = 0;
            this.coordinatorNewTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorNewTableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(215, 251);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(161, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(114, 249);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // genderRadioButton
            // 
            this.genderRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.coordinatorNewTableBindingSource, "Gender", true));
            this.genderRadioButton.Location = new System.Drawing.Point(8, 13);
            this.genderRadioButton.Name = "genderRadioButton";
            this.genderRadioButton.Size = new System.Drawing.Size(73, 24);
            this.genderRadioButton.TabIndex = 8;
            this.genderRadioButton.TabStop = true;
            this.genderRadioButton.Text = "Male";
            this.genderRadioButton.UseVisualStyleBackColor = true;
            this.genderRadioButton.CheckedChanged += new System.EventHandler(this.genderRadioButton_CheckedChanged);
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(114, 179);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorNewTableBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(215, 142);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(161, 20);
            this.ageTextBox.TabIndex = 6;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(114, 145);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age:";
            // 
            // coordinatorNameTextBox
            // 
            this.coordinatorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorNewTableBindingSource, "CoordinatorName", true));
            this.coordinatorNameTextBox.Location = new System.Drawing.Point(215, 116);
            this.coordinatorNameTextBox.Name = "coordinatorNameTextBox";
            this.coordinatorNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.coordinatorNameTextBox.TabIndex = 4;
            // 
            // coordinatorNameLabel
            // 
            coordinatorNameLabel.AutoSize = true;
            coordinatorNameLabel.Location = new System.Drawing.Point(114, 119);
            coordinatorNameLabel.Name = "coordinatorNameLabel";
            coordinatorNameLabel.Size = new System.Drawing.Size(95, 13);
            coordinatorNameLabel.TabIndex = 3;
            coordinatorNameLabel.Text = "Coordinator Name:";
            // 
            // coordinatorIdMaskedTextBox
            // 
            this.coordinatorIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorNewTableBindingSource, "CoordinatorId", true));
            this.coordinatorIdMaskedTextBox.Location = new System.Drawing.Point(215, 90);
            this.coordinatorIdMaskedTextBox.Mask = "emp/0000/000";
            this.coordinatorIdMaskedTextBox.Name = "coordinatorIdMaskedTextBox";
            this.coordinatorIdMaskedTextBox.Size = new System.Drawing.Size(161, 20);
            this.coordinatorIdMaskedTextBox.TabIndex = 2;
            // 
            // coordinatorIdLabel
            // 
            coordinatorIdLabel.AutoSize = true;
            coordinatorIdLabel.Location = new System.Drawing.Point(114, 93);
            coordinatorIdLabel.Name = "coordinatorIdLabel";
            coordinatorIdLabel.Size = new System.Drawing.Size(76, 13);
            coordinatorIdLabel.TabIndex = 1;
            coordinatorIdLabel.Text = "Coordinator Id:";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(8, 43);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 11;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderRadioButton);
            this.groupBox1.Controls.Add(this.FemaleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(209, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // CoordinatorNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(coordinatorIdLabel);
            this.Controls.Add(this.coordinatorIdMaskedTextBox);
            this.Controls.Add(coordinatorNameLabel);
            this.Controls.Add(this.coordinatorNameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.coordinatorNewTableBindingNavigator);
            this.Name = "CoordinatorNewForm";
            this.Text = "CoordinatorNewForm";
            this.Load += new System.EventHandler(this.CoordinatorNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorNewTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorNewTableBindingNavigator)).EndInit();
            this.coordinatorNewTableBindingNavigator.ResumeLayout(false);
            this.coordinatorNewTableBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SakiDataSet sakiDataSet;
        private System.Windows.Forms.BindingSource coordinatorNewTableBindingSource;
        private SakiDataSetTableAdapters.CoordinatorNewTableTableAdapter coordinatorNewTableTableAdapter;
        private SakiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton coordinatorNewTableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator coordinatorNewTableBindingNavigator;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.RadioButton genderRadioButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox coordinatorNameTextBox;
        private System.Windows.Forms.MaskedTextBox coordinatorIdMaskedTextBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}