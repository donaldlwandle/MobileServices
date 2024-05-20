using MobileServices.Models;
using MobileServicesLibrary;
using MobileServicesLibrary.DatabaseAccess;
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
    public partial class MyServicesForm : Form
    {
        UserModel user;
        private LoadingFormFunct loadingForm = new LoadingFormFunct();
        public MyServicesForm()
        {
            InitializeComponent();
            this.user = GlobalConfig.currentUser;
            PopulateServices();

        }

        private void PopulateServices()
        {

            flowLayoutPanelMyServices.Controls.Clear();
            

            try
            {
                List<ServiceModel> services = GlobalConfig.databaseConnection.GetRendererServices(user.ID);
                
                
                ServicesPopulator.Initialize(this.flowLayoutPanelMyServices, services, false);

                if (services.Count != 0)
                {
                    resultsPanel.Hide();
                    ServicesPopulator.Initialize(this.flowLayoutPanelMyServices, services, false);


                }
                else
                {
                    
                    resultsPanel.Show();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                loadingForm.Show();
                //Add new service to database
                ServiceModel serviceModel = new ServiceModel();
                serviceModel.OwnerId = user.ID;
                serviceModel.ServiceTitle = titleInput.Text;

                if(descriptionInput.Text.Length != 0)
                {
                    serviceModel.ServiceDescription = descriptionInput.Text;
                }

                serviceModel.ServiceOwner = user.UserNames;
                serviceModel.City = user.UserCity;



                try
                {
                    IDatabaseConnection database = GlobalConfig.databaseConnection;

                    ServiceModel serviceReturn = database.CreateService(serviceModel);

                  
                    titleLabel.Text = "Enter service title e.g. Plumbing , Hair dresser , Grass cutting.";
                    titleLabel.ForeColor = Color.White;
                    titleInput.Clear();
                    descriptionInput.Clear();
                    PopulateServices();
                    loadingForm.Close();
                    MessageBox.Show("Service added succesfully.");
                }
                catch (Exception error)
                {

                    titleLabel.Text = "Something went wrong, Please try again. \n" + error.Message;
                    titleLabel.ForeColor = Color.Red;
                    titleInput.Clear();
                    descriptionInput.Clear();
                    loadingForm.Close();
                }


            }
        }

        private bool IsValid()
        {
            if(titleInput.Text.Length == 0)
            {
                titleLabel.Text = "Service title cannot be empty!";
                titleLabel.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
    }
}
