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
    public partial class FinancialAnalysisForm : Form
    {
        public FinancialAnalysisForm()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void FinancialAnalysisForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sakiDataSet.Client);
            // TODO: This line of code loads data into the 'sakiDataSet.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.sakiDataSet.Event);
            // TODO: This line of code loads data into the 'sakiDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.sakiDataSet.Table);

            FinancialAnalysisReport fa = new FinancialAnalysisReport();
            fa.SetDataSource(this.sakiDataSet);
            FinancialAReportViewer.ReportSource =fa;

        }
    }
}
