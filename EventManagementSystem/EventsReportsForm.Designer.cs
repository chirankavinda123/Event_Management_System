namespace EventManagementSystem
{
    partial class EventsReportsForm
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
            this.sakiDataSet = new EventManagementSystem.SakiDataSet();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.EventTableAdapter();
            this.tableAdapterManager = new EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager();
            this.tableTableAdapter = new EventManagementSystem.SakiDataSetTableAdapters.TableTableAdapter();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventsReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.TransportSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EventManagementSystem.SakiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VenueSupplierTableAdapter = null;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.sakiDataSet;
            // 
            // EventsReportViewer
            // 
            this.EventsReportViewer.ActiveViewIndex = -1;
            this.EventsReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventsReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsReportViewer.Location = new System.Drawing.Point(0, 0);
            this.EventsReportViewer.Name = "EventsReportViewer";
            this.EventsReportViewer.Size = new System.Drawing.Size(623, 442);
            this.EventsReportViewer.TabIndex = 0;
            this.EventsReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // EventsReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 442);
            this.Controls.Add(this.EventsReportViewer);
            this.Name = "EventsReportsForm";
            this.Text = "EventsReportsForm";
            this.Load += new System.EventHandler(this.EventsReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SakiDataSet sakiDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private SakiDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private SakiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SakiDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer EventsReportViewer;
    }
}