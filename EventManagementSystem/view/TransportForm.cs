using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem.view
{
    public partial class TransportForm : Form
    {
        public TransportForm()
        {
            InitializeComponent();
        }

        private void transportSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transportSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void TransportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.TransportSupplier' table. You can move, or remove it, as needed.
            this.transportSupplierTableAdapter.Fill(this.sakiDataSet.TransportSupplier);

        }

        public void AllowJustView()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            transportSupplierBindingNavigatorSaveItem.Enabled = false;
        }
    }
}
