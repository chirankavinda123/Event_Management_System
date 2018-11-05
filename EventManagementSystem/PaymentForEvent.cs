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
    public partial class PaymentForEvent : Form
    {
        public PaymentForEvent()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sakiDataSet);

        }

        private void PaymentForEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.sakiDataSet.Event);
            // TODO: This line of code loads data into the 'sakiDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sakiDataSet.Client);
            // TODO: This line of code loads data into the 'sakiDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.sakiDataSet.Table);

        }

        private void paymentIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void paymentIdMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void _1st_PaymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void _1st_PaymentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void _2nd_PaymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void _2nd_PaymentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void _3rd_paymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void _3rd_paymentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalPaidAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalPaidAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalBugetLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalBugetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullAmountPaidLabel_Click(object sender, EventArgs e)
        {

        }

        private void fullAmountPaidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fullAmountPaidCheckBox.Checked == true)
            {
                fullAmountPaidCheckBox.ForeColor = Color.Green;
                fullAmountPaidCheckBox.Text = "Done!";
            }
            else {
                fullAmountPaidCheckBox.ForeColor = Color.Red;
                fullAmountPaidCheckBox.Text = "Pending!";
            }
        }

        private void clientIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void eventIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            fullAmountPaidCheckBox.Checked = false;
        }
    }
}
