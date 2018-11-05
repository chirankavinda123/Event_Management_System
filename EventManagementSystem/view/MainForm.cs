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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void AdminCreateNewMenu_Click(object sender, EventArgs e)
        {
            AccessControlForm acf = new AccessControlForm(); 
            acf.MdiParent = this;
            acf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm cf = new ClientForm();
            
            cf.MdiParent = this;
            
            if (sender.ToString() == "Modify Contract...")
            {
                cf.EnableAll();
            }

            cf.Show();

        }

        private void editDetailedEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventsForm ef = new EventsForm();
            ef.MdiParent = this;

            if (sender.ToString() == "View Events..."){
                ef.AllowJustView();
            }

            ef.Show();
        }

        private void eventStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventScheduleForm es = new EventScheduleForm();
            es.MdiParent = this;
            
            es.Show();
        }

        private void venueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VenueForm vf = new VenueForm();
            vf.MdiParent = this;
            if (sender.ToString() == "Venue Suppliers") {
                vf.AllowJustView();
            }

            vf.Show();
        }

        private void foodAndBeveragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodAndBeverageForm fb = new FoodAndBeverageForm();
            fb.MdiParent = this;

            if (sender.ToString() == "Food And Beverages Suppliers")
            {
                fb.AllowJustView();
            }

            fb.Show();
        }

        private void decorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecorsForm df = new DecorsForm();
            df.MdiParent = this;

            if (sender.ToString() == "Decors Suppliers")
            {
                df.AllowJustView();
            }

            df.Show();
        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransportForm tf = new TransportForm();
            tf.MdiParent = this;

            if (sender.ToString() == "Transport Suppliers")
            {
                tf.AllowJustView();
            }

            this.Show();
        }

        private void photographyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhotographyForm pf = new PhotographyForm();
            pf.MdiParent = this;

            if (sender.ToString() == "Photography Suppliers")
            {
                pf.AllowJustView();
            }

            pf.Show();
        }

        private void entertainmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntertainmentForm ef = new EntertainmentForm();
            ef.MdiParent = this;

            if (sender.ToString() == "Entertainment Suppliers")
            {
                ef.AllowJustView();
            }

            ef.Show();
        }

        private void createCoordinatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CoordinatorNewForm cf = new CoordinatorNewForm();
                cf.MdiParent = this;
                cf.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }


        public void GrantAccess(int type,string typeString) {
            if (type == 0)
            {
                this.modifyContractToolStripMenuItem.Enabled = false;
                this.editDetailedEventToolStripMenuItem.Enabled = false;
                this.Modify_SuppliersToolStripMenuItem.Enabled = false;
                this.UpdatePaymentsToolStripMenuItem.Enabled = false;
                this.administratorToolStripMenuItem.Enabled = false;
            }
            else if (type == 1)
            {
                this.modifyContractToolStripMenuItem.Enabled = false;
                this.editDetailedEventToolStripMenuItem.Enabled = false;
                this.Modify_SuppliersToolStripMenuItem.Enabled = false;
                this.administratorToolStripMenuItem.Enabled = false;
            }
            else if (type == 2)
            {
                this.modifyContractToolStripMenuItem.Enabled = false;
                this.administratorToolStripMenuItem.Enabled = false;

            }
            else if (type == 3)
            {

            }
            

            MessageBox.Show(typeString+" Level Access Granted",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void UpdatePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForEvent pf = new PaymentForEvent();
            if (sender.ToString() == "Payment Details...") {
             
            }

            pf.MdiParent = this;
            pf.Show();
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EventsReportsForm ef = new EventsReportsForm();
            ef.ShowDialog();
        }

        private void incomeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialAnalysisForm ff = new FinancialAnalysisForm();
            ff.ShowDialog();
        }
    }
}
