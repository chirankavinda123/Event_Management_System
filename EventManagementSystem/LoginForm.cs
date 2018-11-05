using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EventManagementSystem
{
    public partial class LoginForm : Form
    {
        SakiDataSet sds = new SakiDataSet();
        public LoginForm()
        {
            InitializeComponent();
        }

        
        private void LoginButton_Click(object sender, EventArgs e){
            
            MainForm mf = new MainForm();
            mf.Text = mf.Text + " ["+ TypeComboBox.SelectedItem+"]";
                
                        if (UserNameTextBox.Text == "reception" && PwdTextBox.Text == "123") {
                            mf.GrantAccess(TypeComboBox.SelectedIndex,TypeComboBox.Text);
                            
                            mf.Show();
               
                            
                        }
                        
                       
                        else if (UserNameTextBox.Text == "cashier" && PwdTextBox.Text == "123"){
                                mf.GrantAccess(TypeComboBox.SelectedIndex, TypeComboBox.Text);
                                mf.Show();
                                
                        }
                       
                        else if (UserNameTextBox.Text == "coordinator" && PwdTextBox.Text == "123"){
                                mf.GrantAccess(TypeComboBox.SelectedIndex, TypeComboBox.Text);
                                mf.Show();
                                
            }
                        
                        else if (UserNameTextBox.Text == "manager" && PwdTextBox.Text == "123"){
                                mf.GrantAccess(TypeComboBox.SelectedIndex, TypeComboBox.Text);
                                mf.Show();
                                         }
                        

                        else
                            MessageBox.Show("Login Failed. Try Again!",this.Text,MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
                       
            }

            

           


        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
