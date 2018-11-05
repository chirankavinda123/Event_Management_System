using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class EventsReportsForm : Form
    {
        public EventsReportsForm()
        {
            InitializeComponent();
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void EventsReportsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.sakiDataSet.Table);
            // TODO: This line of code loads data into the 'sakiDataSet.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.sakiDataSet.Event);
            EventsReport eventsReport = new EventsReport();
            eventsReport.SetDataSource(this.sakiDataSet);
            EventsReportViewer.ReportSource = eventsReport;

        }
    }
}
