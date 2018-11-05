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
    public partial class FoodAndBeverageForm : Form
    {
        public FoodAndBeverageForm()
        {
            InitializeComponent();
        }

        private void foodAndBeverageSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodAndBeverageSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void FoodAndBeverageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.FoodAndBeverageSupplier' table. You can move, or remove it, as needed.
            this.foodAndBeverageSupplierTableAdapter.Fill(this.sakiDataSet.FoodAndBeverageSupplier);

        }

        public void AllowJustView()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            foodAndBeverageSupplierBindingNavigatorSaveItem.Enabled = false;
        }
    }
}
