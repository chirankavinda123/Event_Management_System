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
    public partial class EventsForm : Form
    {
       
        public EventsForm()
        {
            InitializeComponent();
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.eventBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sakiDataSet);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakiDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.sakiDataSet.Table);
            // TODO: This line of code loads data into the 'sakiDataSet.Payment' table. You can move, or remove it, as needed.
            // this.paymentTableAdapter.Fill(this.sakiDataSet.Payment);
            // TODO: This line of code loads data into the 'sakiDataSet.PhotographySupplier' table. You can move, or remove it, as needed.
            this.photographySupplierTableAdapter.Fill(this.sakiDataSet.PhotographySupplier);
            // TODO: This line of code loads data into the 'sakiDataSet.EntertainmentSupplier' table. You can move, or remove it, as needed.
            this.entertainmentSupplierTableAdapter.Fill(this.sakiDataSet.EntertainmentSupplier);
            // TODO: This line of code loads data into the 'sakiDataSet.TransportSupplier' table. You can move, or remove it, as needed.
            this.transportSupplierTableAdapter.Fill(this.sakiDataSet.TransportSupplier);
            // TODO: This line of code loads data into the 'sakiDataSet.DecorsSupplier' table. You can move, or remove it, as needed.
            this.decorsSupplierTableAdapter.Fill(this.sakiDataSet.DecorsSupplier);
            // TODO: This line of code loads data into the 'sakiDataSet.FoodAndBeverageSupplier' table. You can move, or remove it, as needed.
            this.foodAndBeverageSupplierTableAdapter.Fill(this.sakiDataSet.FoodAndBeverageSupplier);
            // TODO: This line of code loads data into the 'sakiDataSet.VenueSupplier' table. You can move, or remove it, as needed.
            this.venueSupplierTableAdapter.Fill(this.sakiDataSet.VenueSupplier);
            // TODO: This line of code loads data into the 'sakiDataSet.Coordinatior' table. You can move, or remove it, as needed.
            this.coordinatiorTableAdapter.Fill(this.sakiDataSet.Coordinatior);
            // TODO: This line of code loads data into the 'sakiDataSet.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.sakiDataSet.Event);

            
           /* eventIdMaskedTextBox.Clear();
            eventNameTextBox.Clear();
            dateDateTimePicker.Text = DateTime.Today.ToString();
            privateVenueCheckBox.Checked = false;
            coordinatorIdMaskedTextBox.Clear();
            venueIdMaskedTextBox.Clear();
            foodAndBeverageIdMaskedTextBox.Clear();
            decorsIdMaskedTextBox.Clear();*/


        }

        public void AllowJustView() {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            eventBindingNavigatorSaveItem.Enabled = false;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string val;
            int index;
            val = Microsoft.VisualBasic.Interaction.InputBox("Event ID:","Search event");
            index = eventBindingSource.Find("EventId",val);
            eventBindingSource.Position = index;
        }

        public void CalledByClient(String str) {
            eventBindingNavigator.PositionItem.Text = str;

        }

        private void ViewPaymentsButton_Click(object sender, EventArgs e)
        {
            int index;
            PaymentForEvent pf = new PaymentForEvent();
            pf.Show();
            index = tableBindingSource.Find("PaymentId",paymentIdComboBox.Text);
            tableBindingSource.Position = index;
        }

        private void paymentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coordinatorIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            privateVenueCheckBox.Checked = false;

        }

        private void privateVenueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (privateVenueCheckBox.Checked == true)
            {
                privateVenueCheckBox.ForeColor = Color.BlueViolet;
                privateVenueCheckBox.Text = "Yes!";
                venueIdComboBox.Enabled = false;
            }
            else {
                privateVenueCheckBox.ForeColor = Color.Blue;
                privateVenueCheckBox.Text = "No!";
                venueIdComboBox.Enabled = true;
            }
        }

        private void venueIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void foodAndBeverageIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
