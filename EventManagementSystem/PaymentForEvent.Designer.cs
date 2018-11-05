namespace EventManagementSystem
{
    partial class PaymentForEvent
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
            System.Windows.Forms.Label paymentIdLabel;
            System.Windows.Forms.Label _1st_PaymentLabel;
            System.Windows.Forms.Label _2nd_PaymentLabel;
            System.Windows.Forms.Label _3rd_paymentLabel;
            System.Windows.Forms.Label totalPaidAmountLabel;
            System.Windows.Forms.Label totalBugetLabel;
            System.Windows.Forms.Label fullAmountPaidLabel;
            System.Windows.Forms.Label clientIdLabel;
            System.Windows.Forms.Label eventIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForEvent));
            this.sakiDataSet = new EventManagementSystem.SakiDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paymentIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._1st_PaymentTextBox = new System.Windows.Forms.TextBox();
            this._2nd_PaymentTextBox = new System.Windows.Forms.TextBox();
            this._3rd_paymentTextBox = new System.Windows.Forms.TextBox();
            this.totalPaidAmountTextBox = new System.Windows.Forms.TextBox();
            this.totalBugetTextBox = new System.Windows.Forms.TextBox();
            this.fullAmountPaidCheckBox = new System.Windows.Forms.CheckBox();
            this.clientIdComboBox = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventIdComboBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sakiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.ClientTableAdapter();
            this.eventTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.EventTableAdapter();
            paymentIdLabel = new System.Windows.Forms.Label();
            _1st_PaymentLabel = new System.Windows.Forms.Label();
            _2nd_PaymentLabel = new System.Windows.Forms.Label();
            _3rd_paymentLabel = new System.Windows.Forms.Label();
            totalPaidAmountLabel = new System.Windows.Forms.Label();
            totalBugetLabel = new System.Windows.Forms.Label();
            fullAmountPaidLabel = new System.Windows.Forms.Label();
            clientIdLabel = new System.Windows.Forms.Label();
            eventIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentIdLabel
            // 
            paymentIdLabel.AutoSize = true;
            paymentIdLabel.Location = new System.Drawing.Point(82, 80);
            paymentIdLabel.Name = "paymentIdLabel";
            paymentIdLabel.Size = new System.Drawing.Size(63, 13);
            paymentIdLabel.TabIndex = 1;
            paymentIdLabel.Text = "Payment Id:";
            paymentIdLabel.Click += new System.EventHandler(this.paymentIdLabel_Click);
            // 
            // _1st_PaymentLabel
            // 
            _1st_PaymentLabel.AutoSize = true;
            _1st_PaymentLabel.Location = new System.Drawing.Point(82, 106);
            _1st_PaymentLabel.Name = "_1st_PaymentLabel";
            _1st_PaymentLabel.Size = new System.Drawing.Size(68, 13);
            _1st_PaymentLabel.TabIndex = 3;
            _1st_PaymentLabel.Text = "1st Payment:";
            _1st_PaymentLabel.Click += new System.EventHandler(this._1st_PaymentLabel_Click);
            // 
            // _2nd_PaymentLabel
            // 
            _2nd_PaymentLabel.AutoSize = true;
            _2nd_PaymentLabel.Location = new System.Drawing.Point(82, 132);
            _2nd_PaymentLabel.Name = "_2nd_PaymentLabel";
            _2nd_PaymentLabel.Size = new System.Drawing.Size(72, 13);
            _2nd_PaymentLabel.TabIndex = 5;
            _2nd_PaymentLabel.Text = "2nd Payment:";
            _2nd_PaymentLabel.Click += new System.EventHandler(this._2nd_PaymentLabel_Click);
            // 
            // _3rd_paymentLabel
            // 
            _3rd_paymentLabel.AutoSize = true;
            _3rd_paymentLabel.Location = new System.Drawing.Point(82, 158);
            _3rd_paymentLabel.Name = "_3rd_paymentLabel";
            _3rd_paymentLabel.Size = new System.Drawing.Size(68, 13);
            _3rd_paymentLabel.TabIndex = 7;
            _3rd_paymentLabel.Text = "3rd payment:";
            _3rd_paymentLabel.Click += new System.EventHandler(this._3rd_paymentLabel_Click);
            // 
            // totalPaidAmountLabel
            // 
            totalPaidAmountLabel.AutoSize = true;
            totalPaidAmountLabel.Location = new System.Drawing.Point(82, 184);
            totalPaidAmountLabel.Name = "totalPaidAmountLabel";
            totalPaidAmountLabel.Size = new System.Drawing.Size(97, 13);
            totalPaidAmountLabel.TabIndex = 9;
            totalPaidAmountLabel.Text = "Total Paid Amount:";
            totalPaidAmountLabel.Click += new System.EventHandler(this.totalPaidAmountLabel_Click);
            // 
            // totalBugetLabel
            // 
            totalBugetLabel.AutoSize = true;
            totalBugetLabel.Location = new System.Drawing.Point(82, 210);
            totalBugetLabel.Name = "totalBugetLabel";
            totalBugetLabel.Size = new System.Drawing.Size(65, 13);
            totalBugetLabel.TabIndex = 11;
            totalBugetLabel.Text = "Total Buget:";
            totalBugetLabel.Click += new System.EventHandler(this.totalBugetLabel_Click);
            // 
            // fullAmountPaidLabel
            // 
            fullAmountPaidLabel.AutoSize = true;
            fullAmountPaidLabel.Location = new System.Drawing.Point(82, 238);
            fullAmountPaidLabel.Name = "fullAmountPaidLabel";
            fullAmountPaidLabel.Size = new System.Drawing.Size(89, 13);
            fullAmountPaidLabel.TabIndex = 13;
            fullAmountPaidLabel.Text = "Full Amount Paid:";
            fullAmountPaidLabel.Click += new System.EventHandler(this.fullAmountPaidLabel_Click);
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new System.Drawing.Point(82, 266);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(48, 13);
            clientIdLabel.TabIndex = 15;
            clientIdLabel.Text = "Client Id:";
            clientIdLabel.Click += new System.EventHandler(this.clientIdLabel_Click);
            // 
            // eventIdLabel
            // 
            eventIdLabel.AutoSize = true;
            eventIdLabel.Location = new System.Drawing.Point(82, 293);
            eventIdLabel.Name = "eventIdLabel";
            eventIdLabel.Size = new System.Drawing.Size(50, 13);
            eventIdLabel.TabIndex = 17;
            eventIdLabel.Text = "Event Id:";
            eventIdLabel.Click += new System.EventHandler(this.eventIdLabel_Click);
            // 
            // sakiDataSet
            // 
            this.sakiDataSet.DataSetName = "SakiDataSet";
            this.sakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.sakiDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessControlTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CoordinatiorTableAdapter = null;
            this.tableAdapterManager.CoordinatorNewTableTableAdapter = null;
            this.tableAdapterManager.DecorsSupplierTableAdapter = null;
            this.tableAdapterManager.EntertainmentSupplierTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.FoodAndBeverageSupplierTableAdapter = null;
            this.tableAdapterManager.PhotographySupplierTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.TransportSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VenueSupplierTableAdapter = null;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(369, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
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
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // paymentIdMaskedTextBox
            // 
            this.paymentIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "PaymentId", true));
            this.paymentIdMaskedTextBox.Location = new System.Drawing.Point(185, 77);
            this.paymentIdMaskedTextBox.Mask = "pmt/0000/000";
            this.paymentIdMaskedTextBox.Name = "paymentIdMaskedTextBox";
            this.paymentIdMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.paymentIdMaskedTextBox.TabIndex = 2;
            this.paymentIdMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.paymentIdMaskedTextBox_MaskInputRejected);
            // 
            // _1st_PaymentTextBox
            // 
            this._1st_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "1st_Payment", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this._1st_PaymentTextBox.Location = new System.Drawing.Point(185, 103);
            this._1st_PaymentTextBox.Name = "_1st_PaymentTextBox";
            this._1st_PaymentTextBox.Size = new System.Drawing.Size(121, 20);
            this._1st_PaymentTextBox.TabIndex = 4;
            this._1st_PaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._1st_PaymentTextBox.TextChanged += new System.EventHandler(this._1st_PaymentTextBox_TextChanged);
            // 
            // _2nd_PaymentTextBox
            // 
            this._2nd_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "2nd_Payment", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this._2nd_PaymentTextBox.Location = new System.Drawing.Point(185, 129);
            this._2nd_PaymentTextBox.Name = "_2nd_PaymentTextBox";
            this._2nd_PaymentTextBox.Size = new System.Drawing.Size(121, 20);
            this._2nd_PaymentTextBox.TabIndex = 6;
            this._2nd_PaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._2nd_PaymentTextBox.TextChanged += new System.EventHandler(this._2nd_PaymentTextBox_TextChanged);
            // 
            // _3rd_paymentTextBox
            // 
            this._3rd_paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "3rd_payment", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this._3rd_paymentTextBox.Location = new System.Drawing.Point(185, 155);
            this._3rd_paymentTextBox.Name = "_3rd_paymentTextBox";
            this._3rd_paymentTextBox.Size = new System.Drawing.Size(121, 20);
            this._3rd_paymentTextBox.TabIndex = 8;
            this._3rd_paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._3rd_paymentTextBox.TextChanged += new System.EventHandler(this._3rd_paymentTextBox_TextChanged);
            // 
            // totalPaidAmountTextBox
            // 
            this.totalPaidAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "TotalPaidAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.totalPaidAmountTextBox.Location = new System.Drawing.Point(185, 181);
            this.totalPaidAmountTextBox.Name = "totalPaidAmountTextBox";
            this.totalPaidAmountTextBox.Size = new System.Drawing.Size(121, 20);
            this.totalPaidAmountTextBox.TabIndex = 10;
            this.totalPaidAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalPaidAmountTextBox.TextChanged += new System.EventHandler(this.totalPaidAmountTextBox_TextChanged);
            // 
            // totalBugetTextBox
            // 
            this.totalBugetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "TotalBuget", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.totalBugetTextBox.Location = new System.Drawing.Point(185, 207);
            this.totalBugetTextBox.Name = "totalBugetTextBox";
            this.totalBugetTextBox.Size = new System.Drawing.Size(121, 20);
            this.totalBugetTextBox.TabIndex = 12;
            this.totalBugetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalBugetTextBox.TextChanged += new System.EventHandler(this.totalBugetTextBox_TextChanged);
            // 
            // fullAmountPaidCheckBox
            // 
            this.fullAmountPaidCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "FullAmountPaid", true));
            this.fullAmountPaidCheckBox.Location = new System.Drawing.Point(185, 233);
            this.fullAmountPaidCheckBox.Name = "fullAmountPaidCheckBox";
            this.fullAmountPaidCheckBox.Size = new System.Drawing.Size(121, 24);
            this.fullAmountPaidCheckBox.TabIndex = 14;
            this.fullAmountPaidCheckBox.UseVisualStyleBackColor = true;
            this.fullAmountPaidCheckBox.CheckedChanged += new System.EventHandler(this.fullAmountPaidCheckBox_CheckedChanged);
            // 
            // clientIdComboBox
            // 
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ClientId", true));
            this.clientIdComboBox.DataSource = this.clientBindingSource;
            this.clientIdComboBox.DisplayMember = "Name";
            this.clientIdComboBox.FormattingEnabled = true;
            this.clientIdComboBox.Location = new System.Drawing.Point(185, 263);
            this.clientIdComboBox.Name = "clientIdComboBox";
            this.clientIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.clientIdComboBox.TabIndex = 16;
            this.clientIdComboBox.ValueMember = "ClientId";
            this.clientIdComboBox.SelectedIndexChanged += new System.EventHandler(this.clientIdComboBox_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.sakiDataSet;
            // 
            // eventIdComboBox
            // 
            this.eventIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "EventId", true));
            this.eventIdComboBox.DataSource = this.eventBindingSource;
            this.eventIdComboBox.DisplayMember = "EventId";
            this.eventIdComboBox.FormattingEnabled = true;
            this.eventIdComboBox.Location = new System.Drawing.Point(185, 290);
            this.eventIdComboBox.Name = "eventIdComboBox";
            this.eventIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.eventIdComboBox.TabIndex = 18;
            this.eventIdComboBox.ValueMember = "EventId";
            this.eventIdComboBox.SelectedIndexChanged += new System.EventHandler(this.eventIdComboBox_SelectedIndexChanged);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.sakiDataSet;
            // 
            // sakiDataSetBindingSource
            // 
            this.sakiDataSetBindingSource.DataSource = this.sakiDataSet;
            this.sakiDataSetBindingSource.Position = 0;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentForEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 346);
            this.Controls.Add(paymentIdLabel);
            this.Controls.Add(this.paymentIdMaskedTextBox);
            this.Controls.Add(_1st_PaymentLabel);
            this.Controls.Add(this._1st_PaymentTextBox);
            this.Controls.Add(_2nd_PaymentLabel);
            this.Controls.Add(this._2nd_PaymentTextBox);
            this.Controls.Add(_3rd_paymentLabel);
            this.Controls.Add(this._3rd_paymentTextBox);
            this.Controls.Add(totalPaidAmountLabel);
            this.Controls.Add(this.totalPaidAmountTextBox);
            this.Controls.Add(totalBugetLabel);
            this.Controls.Add(this.totalBugetTextBox);
            this.Controls.Add(fullAmountPaidLabel);
            this.Controls.Add(this.fullAmountPaidCheckBox);
            this.Controls.Add(clientIdLabel);
            this.Controls.Add(this.clientIdComboBox);
            this.Controls.Add(eventIdLabel);
            this.Controls.Add(this.eventIdComboBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "PaymentForEvent";
            this.Text = "Saki Events - Payments";
            this.Load += new System.EventHandler(this.PaymentForEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SakiDataSet sakiDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private SakiDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private SakiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox paymentIdMaskedTextBox;
        private System.Windows.Forms.TextBox _1st_PaymentTextBox;
        private System.Windows.Forms.TextBox _2nd_PaymentTextBox;
        private System.Windows.Forms.TextBox _3rd_paymentTextBox;
        private System.Windows.Forms.TextBox totalPaidAmountTextBox;
        private System.Windows.Forms.TextBox totalBugetTextBox;
        private System.Windows.Forms.CheckBox fullAmountPaidCheckBox;
        private System.Windows.Forms.ComboBox clientIdComboBox;
        private System.Windows.Forms.ComboBox eventIdComboBox;
        private System.Windows.Forms.BindingSource sakiDataSetBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SakiDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private SakiDataSetTableAdapters.EventTableAdapter eventTableAdapter;
    }
}