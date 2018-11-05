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
    public partial class EntertainmentForm : Form
    {
        public EntertainmentForm()
        {
            InitializeComponent();
        }

        private void entertainmentSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entertainmentSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void EntertainmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.EntertainmentSupplier' table. You can move, or remove it, as needed.
            this.entertainmentSupplierTableAdapter.Fill(this.sakiDataSet.EntertainmentSupplier);

        }

        public void AllowJustView()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            entertainmentSupplierBindingNavigatorSaveItem.Enabled = false;
        }
    }
}
