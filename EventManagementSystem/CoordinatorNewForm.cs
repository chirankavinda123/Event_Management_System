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
    public partial class CoordinatorNewForm : Form
    {
        public CoordinatorNewForm()
        {
            InitializeComponent();
        }

        private void coordinatorNewTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coordinatorNewTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void CoordinatorNewForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sakiDataSet.CoordinatorNewTable' table. You can move, or remove it, as needed.
                this.coordinatorNewTableTableAdapter.Fill(this.sakiDataSet.CoordinatorNewTable);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void genderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (genderRadioButton.Checked == true)
            {

            }
            else
                FemaleRadioButton.Checked = true;
        }
    }
}
