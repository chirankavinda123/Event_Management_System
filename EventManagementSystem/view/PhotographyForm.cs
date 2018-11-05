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
    public partial class PhotographyForm : Form
    {
        public PhotographyForm()
        {
            InitializeComponent();
        }

        private void photographySupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photographySupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void PhotographyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.PhotographySupplier' table. You can move, or remove it, as needed.
            this.photographySupplierTableAdapter.Fill(this.sakiDataSet.PhotographySupplier);

        }

        public void AllowJustView()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            photographySupplierBindingNavigatorSaveItem.Enabled = false;
        }
    }
}
