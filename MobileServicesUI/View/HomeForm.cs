using MobileServices.Utils;
using MobileServicesLibrary;
using MobileServicesLibrary.Models;
using MobileServicesUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileServicesUI.View
{
    public partial class HomeForm : Form, IUserUpdated
    {
        
        public HomeForm()
        {
            InitializeComponent();
            UIGlobalConfig.AddHomeForm(this);

            PopulateHomeForm();
        }


        // ################################################################### FORM METHODS ###########################################################
        /// <summary>
        /// Will populate User details if the user is logged in
        /// </summary>
        private void PopulateHomeForm()
        {
            
            if (GlobalConfig.currentUser != null)
            {
                //Hide login panel
                loginPanel.Visible = false;

                //get user local services and populate the list
                flowLayoutPanelHome.Controls.Clear();


                try
                {
                    List<ServiceModel> services = GlobalConfig.databaseConnection.GetLocalServices(GlobalConfig.currentUser.UserCity);
                    ServicesPopulator.Initialize(this.flowLayoutPanelHome, services, true);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }



        // ################################################################### EVENT LISTENERS ###########################################################
        /// <summary>
        /// Will triger login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signInBtn_Click(object sender, EventArgs e)
        {
            if(emailTextBox.Text.Length != 0)
            {
                // start login form
                LoginForm loginTest = new LoginForm(emailTextBox.Text);
                loginTest.ShowDialog();
            }
            else
            {
                MessageBox.Show("email cannot be empty");
            }
        }

        




        // ################################################################### USER UPDATE INTERFACE ###########################################################

        /// <summary>
        /// Event Interface will listen for sucessful user update.
        /// Will Execute when new user loggin and when existing user Succesfully Registers a business.
        /// </summary>
        public void UserUpdated()
        {
            PopulateHomeForm();
        }
    }
}
