using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventManagementSystem.view;

namespace EventManagementSystem
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

       

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.sakiDataSet.Event);
            // TODO: This line of code loads data into the 'sakiDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sakiDataSet.Client);
            
            if(MaleRadioButton.Checked== false)
                FemaleRadioButton.Checked = true;

            

            if (contractConfirmedCheckBox.Checked)
                ConfirmLabel.Text = "confirmed";

            else
            {
                ConfirmLabel.ForeColor = Color.Red;
                ConfirmLabel.Text = "Pending...";
            }

        }

        public void EnableAll() {
            contractConfirmedCheckBox.Enabled = true;
            eventIdMaskedTextBox.Enabled = true;
        }


        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try {
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sakiDataSet);
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message,this.Text);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            eventIdMaskedTextBox.Text = "0".ToString();
            contractConfirmedCheckBox.Checked = false;
        }

        private void contractConfirmedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (contractConfirmedCheckBox.Checked) { 
                ConfirmLabel.ForeColor = Color.Green;
                ConfirmLabel.Text = "confirmed";
                ViewButton.Enabled = true;
              }

            else
            {
                ConfirmLabel.ForeColor = Color.Red;
                ConfirmLabel.Text = "Pending...";
            }
                
        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked == false) {
                FemaleRadioButton.Checked = true;
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            EventsForm ef = new EventsForm();
            
            ef.AllowJustView();
            

            ef.CalledByClient(eventIdMaskedTextBox.Text);
            ef.Show();
        }

        private void eventIdMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}
