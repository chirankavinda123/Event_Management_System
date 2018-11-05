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
    public partial class AccessControlForm : Form
    {
        public AccessControlForm()
        {
            InitializeComponent();
        }

        private void accessControlTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accessControlTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void AccessControlForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.AccessControlTable' table. You can move, or remove it, as needed.
            this.accessControlTableTableAdapter.Fill(this.sakiDataSet.AccessControlTable);

        }
    }
}
