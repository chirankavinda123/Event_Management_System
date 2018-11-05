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
    public partial class VenueForm : Form
    {
        public VenueForm()
        {
            InitializeComponent();
        }

        private void venueSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.venueSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void VenueForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.VenueSupplier' table. You can move, or remove it, as needed.
            this.venueSupplierTableAdapter.Fill(this.sakiDataSet.VenueSupplier);

        }

        public void AllowJustView()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            venueSupplierBindingNavigatorSaveItem.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String val;
            int index;

            val = Microsoft.VisualBasic.Interaction.InputBox("VenueID:","Search for Venue");
            index = venueSupplierBindingSource.Find("SupplierId",val);
            venueSupplierBindingSource.Position = index;
        }
    }
}
