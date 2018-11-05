namespace EventManagementSystem
{
    partial class EventsForm
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
            System.Windows.Forms.Label eventNameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label privateVenueLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label coordinatorIdLabel;
            System.Windows.Forms.Label venueIdLabel;
            System.Windows.Forms.Label foodAndBeverageIdLabel;
            System.Windows.Forms.Label decorsIdLabel;
            System.Windows.Forms.Label transportIdLabel;
            System.Windows.Forms.Label entertainmentIdLabel;
            System.Windows.Forms.Label photographyIdLabel;
            System.Windows.Forms.Label paymentIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.sakiDataSet = new EventManagementSystem.SakiDataSet();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.EventTableAdapter();
            this.tableAdapterManager = new EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager();
            this.eventBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.privateVenueCheckBox = new System.Windows.Forms.CheckBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.coordinatorIdComboBox = new System.Windows.Forms.ComboBox();
            this.coordinatiorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venueIdComboBox = new System.Windows.Forms.ComboBox();
            this.venueSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodAndBeverageIdComboBox = new System.Windows.Forms.ComboBox();
            this.foodAndBeverageSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decorsIdComboBox = new System.Windows.Forms.ComboBox();
            this.decorsSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportIdComboBox = new System.Windows.Forms.ComboBox();
            this.transportSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entertainmentIdComboBox = new System.Windows.Forms.ComboBox();
            this.entertainmentSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photographyIdComboBox = new System.Windows.Forms.ComboBox();
            this.photographySupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentIdComboBox = new System.Windows.Forms.ComboBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coordinatiorTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.CoordinatiorTableAdapter();
            this.venueSupplierTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.VenueSupplierTableAdapter();
            this.foodAndBeverageSupplierTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.FoodAndBeverageSupplierTableAdapter();
            this.decorsSupplierTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.DecorsSupplierTableAdapter();
            this.transportSupplierTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.TransportSupplierTableAdapter();
            this.decorsSupplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entertainmentSupplierTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.EntertainmentSupplierTableAdapter();
            this.photographySupplierTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.PhotographySupplierTableAdapter();
            this.FindButton = new System.Windows.Forms.Button();
            this.ViewPaymentsButton = new System.Windows.Forms.Button();
            this.tableTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.TableTableAdapter();
            eventIdLabel = new System.Windows.Forms.Label();
            eventNameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            privateVenueLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            coordinatorIdLabel = new System.Windows.Forms.Label();
            venueIdLabel = new System.Windows.Forms.Label();
            foodAndBeverageIdLabel = new System.Windows.Forms.Label();
            decorsIdLabel = new System.Windows.Forms.Label();
            transportIdLabel = new System.Windows.Forms.Label();
            entertainmentIdLabel = new System.Windows.Forms.Label();
            photographyIdLabel = new System.Windows.Forms.Label();
            paymentIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).BeginInit();
            this.eventBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatiorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodAndBeverageSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorsSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entertainmentSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographySupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorsSupplierBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventIdLabel
            // 
            eventIdLabel.AutoSize = true;
            eventIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eventIdLabel.ForeColor = System.Drawing.Color.Navy;
            eventIdLabel.Location = new System.Drawing.Point(61, 67);
            eventIdLabel.Name = "eventIdLabel";
            eventIdLabel.Size = new System.Drawing.Size(68, 16);
            eventIdLabel.TabIndex = 1;
            eventIdLabel.Text = "Event Id:";
            // 
            // eventNameLabel
            // 
            eventNameLabel.AutoSize = true;
            eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eventNameLabel.ForeColor = System.Drawing.Color.Navy;
            eventNameLabel.Location = new System.Drawing.Point(61, 93);
            eventNameLabel.Name = "eventNameLabel";
            eventNameLabel.Size = new System.Drawing.Size(96, 16);
            eventNameLabel.TabIndex = 3;
            eventNameLabel.Text = "Event Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.ForeColor = System.Drawing.Color.Navy;
            dateLabel.Location = new System.Drawing.Point(61, 120);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(45, 16);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Date:";
            // 
            // privateVenueLabel
            // 
            privateVenueLabel.AutoSize = true;
            privateVenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            privateVenueLabel.ForeColor = System.Drawing.Color.Navy;
            privateVenueLabel.Location = new System.Drawing.Point(61, 147);
            privateVenueLabel.Name = "privateVenueLabel";
            privateVenueLabel.Size = new System.Drawing.Size(109, 16);
            privateVenueLabel.TabIndex = 7;
            privateVenueLabel.Text = "Private Venue:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.ForeColor = System.Drawing.Color.Navy;
            categoryLabel.Location = new System.Drawing.Point(61, 175);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(75, 16);
            categoryLabel.TabIndex = 9;
            categoryLabel.Text = "Category:";
            // 
            // coordinatorIdLabel
            // 
            coordinatorIdLabel.AutoSize = true;
            coordinatorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coordinatorIdLabel.ForeColor = System.Drawing.Color.Navy;
            coordinatorIdLabel.Location = new System.Drawing.Point(61, 201);
            coordinatorIdLabel.Name = "coordinatorIdLabel";
            coordinatorIdLabel.Size = new System.Drawing.Size(97, 16);
            coordinatorIdLabel.TabIndex = 11;
            coordinatorIdLabel.Text = "Coordinator :";
            // 
            // venueIdLabel
            // 
            venueIdLabel.AutoSize = true;
            venueIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            venueIdLabel.ForeColor = System.Drawing.Color.Navy;
            venueIdLabel.Location = new System.Drawing.Point(61, 228);
            venueIdLabel.Name = "venueIdLabel";
            venueIdLabel.Size = new System.Drawing.Size(60, 16);
            venueIdLabel.TabIndex = 13;
            venueIdLabel.Text = "Venue :";
            // 
            // foodAndBeverageIdLabel
            // 
            foodAndBeverageIdLabel.AutoSize = true;
            foodAndBeverageIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foodAndBeverageIdLabel.ForeColor = System.Drawing.Color.Navy;
            foodAndBeverageIdLabel.Location = new System.Drawing.Point(61, 255);
            foodAndBeverageIdLabel.Name = "foodAndBeverageIdLabel";
            foodAndBeverageIdLabel.Size = new System.Drawing.Size(128, 16);
            foodAndBeverageIdLabel.TabIndex = 15;
            foodAndBeverageIdLabel.Text = "Food & Beverage :";
            // 
            // decorsIdLabel
            // 
            decorsIdLabel.AutoSize = true;
            decorsIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            decorsIdLabel.ForeColor = System.Drawing.Color.Navy;
            decorsIdLabel.Location = new System.Drawing.Point(61, 282);
            decorsIdLabel.Name = "decorsIdLabel";
            decorsIdLabel.Size = new System.Drawing.Size(66, 16);
            decorsIdLabel.TabIndex = 17;
            decorsIdLabel.Text = "Decors :";
            // 
            // transportIdLabel
            // 
            transportIdLabel.AutoSize = true;
            transportIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transportIdLabel.ForeColor = System.Drawing.Color.Navy;
            transportIdLabel.Location = new System.Drawing.Point(61, 309);
            transportIdLabel.Name = "transportIdLabel";
            transportIdLabel.Size = new System.Drawing.Size(83, 16);
            transportIdLabel.TabIndex = 19;
            transportIdLabel.Text = "Transport :";
            // 
            // entertainmentIdLabel
            // 
            entertainmentIdLabel.AutoSize = true;
            entertainmentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entertainmentIdLabel.ForeColor = System.Drawing.Color.Navy;
            entertainmentIdLabel.Location = new System.Drawing.Point(61, 336);
            entertainmentIdLabel.Name = "entertainmentIdLabel";
            entertainmentIdLabel.Size = new System.Drawing.Size(110, 16);
            entertainmentIdLabel.TabIndex = 21;
            entertainmentIdLabel.Text = "Entertainment :";
            // 
            // photographyIdLabel
            // 
            photographyIdLabel.AutoSize = true;
            photographyIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            photographyIdLabel.ForeColor = System.Drawing.Color.Navy;
            photographyIdLabel.Location = new System.Drawing.Point(61, 363);
            photographyIdLabel.Name = "photographyIdLabel";
            photographyIdLabel.Size = new System.Drawing.Size(104, 16);
            photographyIdLabel.TabIndex = 23;
            photographyIdLabel.Text = "Photography :";
            // 
            // paymentIdLabel
            // 
            paymentIdLabel.AutoSize = true;
            paymentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paymentIdLabel.ForeColor = System.Drawing.Color.Navy;
            paymentIdLabel.Location = new System.Drawing.Point(61, 390);
            paymentIdLabel.Name = "paymentIdLabel";
            paymentIdLabel.Size = new System.Drawing.Size(89, 16);
            paymentIdLabel.TabIndex = 25;
            paymentIdLabel.Text = "Payment Id:";
            // 
            // sakiDataSet
            // 
            this.sakiDataSet.DataSetName = "SakiDataSet";
            this.sakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessControlTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CoordinatiorTableAdapter = null;
            this.tableAdapterManager.CoordinatorNewTableTableAdapter = null;
            this.tableAdapterManager.DecorsSupplierTableAdapter = null;
            this.tableAdapterManager.EntertainmentSupplierTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = this.eventTableAdapter;
            this.tableAdapterManager.FoodAndBeverageSupplierTableAdapter = null;
            this.tableAdapterManager.PhotographySupplierTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TransportSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VenueSupplierTableAdapter = null;
            // 
            // eventBindingNavigator
            // 
            this.eventBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventBindingNavigator.BindingSource = this.eventBindingSource;
            this.eventBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventBindingNavigatorSaveItem});
            this.eventBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventBindingNavigator.Name = "eventBindingNavigator";
            this.eventBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.eventBindingNavigator.TabIndex = 0;
            this.eventBindingNavigator.Text = "bindingNavigator1";
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
            // eventBindingNavigatorSaveItem
            // 
            this.eventBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventBindingNavigatorSaveItem.Image")));
            this.eventBindingNavigatorSaveItem.Name = "eventBindingNavigatorSaveItem";
            this.eventBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eventBindingNavigatorSaveItem.Text = "Save Data";
            this.eventBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventBindingNavigatorSaveItem_Click);
            // 
            // eventIdMaskedTextBox
            // 
            this.eventIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EventId", true));
            this.eventIdMaskedTextBox.Location = new System.Drawing.Point(208, 66);
            this.eventIdMaskedTextBox.Mask = "event/0000/000";
            this.eventIdMaskedTextBox.Name = "eventIdMaskedTextBox";
            this.eventIdMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventIdMaskedTextBox.TabIndex = 2;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EventName", true));
            this.eventNameTextBox.Location = new System.Drawing.Point(208, 92);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventNameTextBox.TabIndex = 4;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(208, 118);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // privateVenueCheckBox
            // 
            this.privateVenueCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eventBindingSource, "PrivateVenue", true));
            this.privateVenueCheckBox.Location = new System.Drawing.Point(208, 144);
            this.privateVenueCheckBox.Name = "privateVenueCheckBox";
            this.privateVenueCheckBox.Size = new System.Drawing.Size(200, 24);
            this.privateVenueCheckBox.TabIndex = 8;
            this.privateVenueCheckBox.UseVisualStyleBackColor = true;
            this.privateVenueCheckBox.CheckedChanged += new System.EventHandler(this.privateVenueCheckBox_CheckedChanged);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(208, 174);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoryTextBox.TabIndex = 10;
            // 
            // coordinatorIdComboBox
            // 
            this.coordinatorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "CoordinatorId", true));
            this.coordinatorIdComboBox.DataSource = this.coordinatiorBindingSource;
            this.coordinatorIdComboBox.DisplayMember = "CoordinatorId";
            this.coordinatorIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coordinatorIdComboBox.FormattingEnabled = true;
            this.coordinatorIdComboBox.Location = new System.Drawing.Point(208, 200);
            this.coordinatorIdComboBox.Name = "coordinatorIdComboBox";
            this.coordinatorIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.coordinatorIdComboBox.TabIndex = 12;
            this.coordinatorIdComboBox.ValueMember = "CoordinatorId";
            this.coordinatorIdComboBox.SelectedIndexChanged += new System.EventHandler(this.coordinatorIdComboBox_SelectedIndexChanged);
            // 
            // coordinatiorBindingSource
            // 
            this.coordinatiorBindingSource.DataMember = "Coordinatior";
            this.coordinatiorBindingSource.DataSource = this.sakiDataSet;
            // 
            // venueIdComboBox
            // 
            this.venueIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "VenueId", true));
            this.venueIdComboBox.DataSource = this.venueSupplierBindingSource;
            this.venueIdComboBox.DisplayMember = "Name";
            this.venueIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueIdComboBox.FormattingEnabled = true;
            this.venueIdComboBox.Location = new System.Drawing.Point(208, 227);
            this.venueIdComboBox.Name = "venueIdComboBox";
            this.venueIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.venueIdComboBox.TabIndex = 14;
            this.venueIdComboBox.ValueMember = "SupplierId";
            this.venueIdComboBox.SelectedIndexChanged += new System.EventHandler(this.venueIdComboBox_SelectedIndexChanged);
            // 
            // venueSupplierBindingSource
            // 
            this.venueSupplierBindingSource.DataMember = "VenueSupplier";
            this.venueSupplierBindingSource.DataSource = this.sakiDataSet;
            // 
            // foodAndBeverageIdComboBox
            // 
            this.foodAndBeverageIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "FoodAndBeverageId", true));
            this.foodAndBeverageIdComboBox.DataSource = this.foodAndBeverageSupplierBindingSource;
            this.foodAndBeverageIdComboBox.DisplayMember = "Name";
            this.foodAndBeverageIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodAndBeverageIdComboBox.FormattingEnabled = true;
            this.foodAndBeverageIdComboBox.Location = new System.Drawing.Point(208, 254);
            this.foodAndBeverageIdComboBox.Name = "foodAndBeverageIdComboBox";
            this.foodAndBeverageIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.foodAndBeverageIdComboBox.TabIndex = 16;
            this.foodAndBeverageIdComboBox.ValueMember = "SupplierId";
            this.foodAndBeverageIdComboBox.SelectedIndexChanged += new System.EventHandler(this.foodAndBeverageIdComboBox_SelectedIndexChanged);
            // 
            // foodAndBeverageSupplierBindingSource
            // 
            this.foodAndBeverageSupplierBindingSource.DataMember = "FoodAndBeverageSupplier";
            this.foodAndBeverageSupplierBindingSource.DataSource = this.sakiDataSet;
            // 
            // decorsIdComboBox
            // 
            this.decorsIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "DecorsId", true));
            this.decorsIdComboBox.DataSource = this.decorsSupplierBindingSource;
            this.decorsIdComboBox.DisplayMember = "Name";
            this.decorsIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decorsIdComboBox.FormattingEnabled = true;
            this.decorsIdComboBox.Location = new System.Drawing.Point(208, 281);
            this.decorsIdComboBox.Name = "decorsIdComboBox";
            this.decorsIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.decorsIdComboBox.TabIndex = 18;
            this.decorsIdComboBox.ValueMember = "SupplierId";
            // 
            // decorsSupplierBindingSource
            // 
            this.decorsSupplierBindingSource.DataMember = "DecorsSupplier";
            this.decorsSupplierBindingSource.DataSource = this.sakiDataSet;
            // 
            // transportIdComboBox
            // 
            this.transportIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "TransportId", true));
            this.transportIdComboBox.DataSource = this.transportSupplierBindingSource;
            this.transportIdComboBox.DisplayMember = "Name";
            this.transportIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transportIdComboBox.FormattingEnabled = true;
            this.transportIdComboBox.Location = new System.Drawing.Point(208, 308);
            this.transportIdComboBox.Name = "transportIdComboBox";
            this.transportIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.transportIdComboBox.TabIndex = 20;
            this.transportIdComboBox.ValueMember = "SupplierId";
            // 
            // transportSupplierBindingSource
            // 
            this.transportSupplierBindingSource.DataMember = "TransportSupplier";
            this.transportSupplierBindingSource.DataSource = this.sakiDataSet;
            // 
            // entertainmentIdComboBox
            // 
            this.entertainmentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EntertainmentId", true));
            this.entertainmentIdComboBox.DataSource = this.entertainmentSupplierBindingSource;
            this.entertainmentIdComboBox.DisplayMember = "Name";
            this.entertainmentIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entertainmentIdComboBox.FormattingEnabled = true;
            this.entertainmentIdComboBox.Location = new System.Drawing.Point(208, 335);
            this.entertainmentIdComboBox.Name = "entertainmentIdComboBox";
            this.entertainmentIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.entertainmentIdComboBox.TabIndex = 22;
            this.entertainmentIdComboBox.ValueMember = "SupplierId";
            // 
            // entertainmentSupplierBindingSource
            // 
            this.entertainmentSupplierBindingSource.DataMember = "EntertainmentSupplier";
            this.entertainmentSupplierBindingSource.DataSource = this.sakiDataSet;
            // 
            // photographyIdComboBox
            // 
            this.photographyIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "PhotographyId", true));
            this.photographyIdComboBox.DataSource = this.photographySupplierBindingSource;
            this.photographyIdComboBox.DisplayMember = "Name";
            this.photographyIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.photographyIdComboBox.FormattingEnabled = true;
            this.photographyIdComboBox.Location = new System.Drawing.Point(208, 362);
            this.photographyIdComboBox.Name = "photographyIdComboBox";
            this.photographyIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.photographyIdComboBox.TabIndex = 24;
            this.photographyIdComboBox.ValueMember = "SupplierId";
            // 
            // photographySupplierBindingSource
            // 
            this.photographySupplierBindingSource.DataMember = "PhotographySupplier";
            this.photographySupplierBindingSource.DataSource = this.sakiDataSet;
            // 
            // paymentIdComboBox
            // 
            this.paymentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "PaymentId", true));
            this.paymentIdComboBox.DataSource = this.tableBindingSource;
            this.paymentIdComboBox.DisplayMember = "PaymentId";
            this.paymentIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentIdComboBox.FormattingEnabled = true;
            this.paymentIdComboBox.Location = new System.Drawing.Point(208, 389);
            this.paymentIdComboBox.Name = "paymentIdComboBox";
            this.paymentIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.paymentIdComboBox.TabIndex = 26;
            this.paymentIdComboBox.ValueMember = "PaymentId";
            this.paymentIdComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentIdComboBox_SelectedIndexChanged);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.sakiDataSet;
            // 
            // coordinatiorTableAdapter
            // 
            this.coordinatiorTableAdapter.ClearBeforeFill = true;
            // 
            // venueSupplierTableAdapter
            // 
            this.venueSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // foodAndBeverageSupplierTableAdapter
            // 
            this.foodAndBeverageSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // decorsSupplierTableAdapter
            // 
            this.decorsSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // transportSupplierTableAdapter
            // 
            this.transportSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // decorsSupplierBindingSource1
            // 
            this.decorsSupplierBindingSource1.DataMember = "DecorsSupplier";
            this.decorsSupplierBindingSource1.DataSource = this.sakiDataSet;
            // 
            // entertainmentSupplierTableAdapter
            // 
            this.entertainmentSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // photographySupplierTableAdapter
            // 
            this.photographySupplierTableAdapter.ClearBeforeFill = true;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.Color.Navy;
            this.FindButton.Location = new System.Drawing.Point(447, 64);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(58, 22);
            this.FindButton.TabIndex = 27;
            this.FindButton.Text = "Find...";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ViewPaymentsButton
            // 
            this.ViewPaymentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPaymentsButton.ForeColor = System.Drawing.Color.Navy;
            this.ViewPaymentsButton.Location = new System.Drawing.Point(440, 390);
            this.ViewPaymentsButton.Name = "ViewPaymentsButton";
            this.ViewPaymentsButton.Size = new System.Drawing.Size(77, 21);
            this.ViewPaymentsButton.TabIndex = 28;
            this.ViewPaymentsButton.Text = "Details...";
            this.ViewPaymentsButton.UseVisualStyleBackColor = true;
            this.ViewPaymentsButton.Click += new System.EventHandler(this.ViewPaymentsButton_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 509);
            this.Controls.Add(this.ViewPaymentsButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(eventIdLabel);
            this.Controls.Add(this.eventIdMaskedTextBox);
            this.Controls.Add(eventNameLabel);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(privateVenueLabel);
            this.Controls.Add(this.privateVenueCheckBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(coordinatorIdLabel);
            this.Controls.Add(this.coordinatorIdComboBox);
            this.Controls.Add(venueIdLabel);
            this.Controls.Add(this.venueIdComboBox);
            this.Controls.Add(foodAndBeverageIdLabel);
            this.Controls.Add(this.foodAndBeverageIdComboBox);
            this.Controls.Add(decorsIdLabel);
            this.Controls.Add(this.decorsIdComboBox);
            this.Controls.Add(transportIdLabel);
            this.Controls.Add(this.transportIdComboBox);
            this.Controls.Add(entertainmentIdLabel);
            this.Controls.Add(this.entertainmentIdComboBox);
            this.Controls.Add(photographyIdLabel);
            this.Controls.Add(this.photographyIdComboBox);
            this.Controls.Add(paymentIdLabel);
            this.Controls.Add(this.paymentIdComboBox);
            this.Controls.Add(this.eventBindingNavigator);
            this.Name = "EventsForm";
            this.Text = "Saki Events - Event Details";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).EndInit();
            this.eventBindingNavigator.ResumeLayout(false);
            this.eventBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatiorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodAndBeverageSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorsSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entertainmentSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographySupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorsSupplierBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SakiDataSet sakiDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private SakiDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private SakiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox eventIdMaskedTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.CheckBox privateVenueCheckBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.ComboBox coordinatorIdComboBox;
        private System.Windows.Forms.ComboBox venueIdComboBox;
        private System.Windows.Forms.ComboBox foodAndBeverageIdComboBox;
        private System.Windows.Forms.ComboBox decorsIdComboBox;
        private System.Windows.Forms.ComboBox transportIdComboBox;
        private System.Windows.Forms.ComboBox entertainmentIdComboBox;
        private System.Windows.Forms.ComboBox photographyIdComboBox;
        private System.Windows.Forms.ComboBox paymentIdComboBox;
        private System.Windows.Forms.BindingSource coordinatiorBindingSource;
        private SakiDataSetTableAdapters.CoordinatiorTableAdapter coordinatiorTableAdapter;
        private System.Windows.Forms.BindingSource venueSupplierBindingSource;
        private SakiDataSetTableAdapters.VenueSupplierTableAdapter venueSupplierTableAdapter;
        private System.Windows.Forms.BindingSource foodAndBeverageSupplierBindingSource;
        private SakiDataSetTableAdapters.FoodAndBeverageSupplierTableAdapter foodAndBeverageSupplierTableAdapter;
        private System.Windows.Forms.BindingSource decorsSupplierBindingSource;
        private SakiDataSetTableAdapters.DecorsSupplierTableAdapter decorsSupplierTableAdapter;
        private System.Windows.Forms.BindingSource transportSupplierBindingSource;
        private SakiDataSetTableAdapters.TransportSupplierTableAdapter transportSupplierTableAdapter;
        private System.Windows.Forms.BindingSource decorsSupplierBindingSource1;
        private System.Windows.Forms.BindingSource entertainmentSupplierBindingSource;
        private SakiDataSetTableAdapters.EntertainmentSupplierTableAdapter entertainmentSupplierTableAdapter;
        private System.Windows.Forms.BindingSource photographySupplierBindingSource;
        private SakiDataSetTableAdapters.PhotographySupplierTableAdapter photographySupplierTableAdapter;
       
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ViewPaymentsButton;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private SakiDataSetTableAdapters.TableTableAdapter tableTableAdapter;
    }
}