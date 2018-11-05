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
    public partial class EventScheduleForm : Form
    {
        public EventScheduleForm()
        {
            InitializeComponent();
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void EventScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.sakiDataSet.Event);

            EventDataGridView.ReadOnly = true;
            eventBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;

        }
    }
}
