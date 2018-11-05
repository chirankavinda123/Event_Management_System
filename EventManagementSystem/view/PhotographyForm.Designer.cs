namespace EventManagementSystem.view
{
    partial class PhotographyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotographyForm));
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label detailsLabel;
            this.sakiDataSet = new EventManagementSystem.SakiDataSet();
            this.photographySupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photographySupplierTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.PhotographySupplierTableAdapter();
            this.tableAdapterManager = new EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager();
            this.photographySupplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.photographySupplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.supplierIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.photographySupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            detailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographySupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographySupplierBindingNavigator)).BeginInit();
            this.photographySupplierBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographySupplierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sakiDataSet
            // 
            this.sakiDataSet.DataSetName = "SakiDataSet";
            this.sakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // photographySupplierBindingSource
            // 
            this.photographySupplierBindingSource.DataMember = "PhotographySupplier";
            this.photographySupplierBindingSource.DataSource = this.sakiDataSet;
            // 
            // photographySupplierTableAdapter
            // 
            this.photographySupplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessControlTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CoordinatiorTableAdapter = null;
            this.tableAdapterManager.DecorsSupplierTableAdapter = null;
            this.tableAdapterManager.EntertainmentSupplierTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.FoodAndBeverageSupplierTableAdapter = null;
            
            this.tableAdapterManager.PhotographySupplierTableAdapter = this.photographySupplierTableAdapter;
            this.tableAdapterManager.TransportSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VenueSupplierTableAdapter = null;
            // 
            // photographySupplierBindingNavigator
            // 
            this.photographySupplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.photographySupplierBindingNavigator.BindingSource = this.photographySupplierBindingSource;
            this.photographySupplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.photographySupplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.photographySupplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.photographySupplierBindingNavigatorSaveItem});
            this.photographySupplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.photographySupplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.photographySupplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.photographySupplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.photographySupplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.photographySupplierBindingNavigator.Name = "photographySupplierBindingNavigator";
            this.photographySupplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.photographySupplierBindingNavigator.Size = new System.Drawing.Size(428, 25);
            this.photographySupplierBindingNavigator.TabIndex = 0;
            this.photographySupplierBindingNavigator.Text = "bindingNavigator1";
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
            // photographySupplierBindingNavigatorSaveItem
            // 
            this.photographySupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photographySupplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("photographySupplierBindingNavigatorSaveItem.Image")));
            this.photographySupplierBindingNavigatorSaveItem.Name = "photographySupplierBindingNavigatorSaveItem";
            this.photographySupplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.photographySupplierBindingNavigatorSaveItem.Text = "Save Data";
            this.photographySupplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.photographySupplierBindingNavigatorSaveItem_Click);
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(26, 69);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(60, 13);
            supplierIdLabel.TabIndex = 1;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // supplierIdMaskedTextBox
            // 
            this.supplierIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photographySupplierBindingSource, "SupplierId", true));
            this.supplierIdMaskedTextBox.Location = new System.Drawing.Point(93, 66);
            this.supplierIdMaskedTextBox.Name = "supplierIdMaskedTextBox";
            this.supplierIdMaskedTextBox.Size = new System.Drawing.Size(142, 20);
            this.supplierIdMaskedTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(26, 98);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photographySupplierBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(93, 95);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(26, 128);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 5;
            telephoneLabel.Text = "Telephone:";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photographySupplierBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(93, 125);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(142, 20);
            this.telephoneTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(26, 160);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photographySupplierBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(93, 157);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(142, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(241, 66);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 9;
            imageLabel.Text = "Image:";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photographySupplierBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(244, 84);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(106, 99);
            this.imagePictureBox.TabIndex = 10;
            this.imagePictureBox.TabStop = false;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Location = new System.Drawing.Point(26, 196);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new System.Drawing.Size(42, 13);
            detailsLabel.TabIndex = 11;
            detailsLabel.Text = "Details:";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photographySupplierBindingSource, "Details", true));
            this.detailsTextBox.Location = new System.Drawing.Point(93, 193);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(257, 46);
            this.detailsTextBox.TabIndex = 12;
            // 
            // photographySupplierDataGridView
            // 
            this.photographySupplierDataGridView.AutoGenerateColumns = false;
            this.photographySupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photographySupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn5});
            this.photographySupplierDataGridView.DataSource = this.photographySupplierBindingSource;
            this.photographySupplierDataGridView.Location = new System.Drawing.Point(29, 282);
            this.photographySupplierDataGridView.Name = "photographySupplierDataGridView";
            this.photographySupplierDataGridView.Size = new System.Drawing.Size(321, 169);
            this.photographySupplierDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn1.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Details";
            this.dataGridViewTextBoxColumn5.HeaderText = "Details";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // PhotographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 456);
            this.Controls.Add(this.photographySupplierDataGridView);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdMaskedTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(detailsLabel);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.photographySupplierBindingNavigator);
            this.Name = "PhotographyForm";
            this.Text = "Saki Events -Photography Suppliers";
            this.Load += new System.EventHandler(this.PhotographyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographySupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographySupplierBindingNavigator)).EndInit();
            this.photographySupplierBindingNavigator.ResumeLayout(false);
            this.photographySupplierBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographySupplierDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SakiDataSet sakiDataSet;
        private System.Windows.Forms.BindingSource photographySupplierBindingSource;
        private SakiDataSetTableAdapters.PhotographySupplierTableAdapter photographySupplierTableAdapter;
        private SakiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator photographySupplierBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton photographySupplierBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox supplierIdMaskedTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.DataGridView photographySupplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}