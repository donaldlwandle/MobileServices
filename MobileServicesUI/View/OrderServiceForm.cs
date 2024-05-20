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
    public partial class OrderServiceForm : Form
    {
        ServiceModel service;
        UserModel currentUser;
        private LoadingFormFunct loadingForm = new LoadingFormFunct();
        public OrderServiceForm(ServiceModel service)
        {
            InitializeComponent();
            this.service = service;
            currentUser = GlobalConfig.currentUser;

            PopulateForm();
        }

        private void PopulateForm()
        {
            titleLabel.Text = service.ServiceTitle;
            nameLabel.Text = service.ServiceOwner;
            cityLabel.Text = service.City;
            descriptionLabel.Text = service.ServiceDescription;
        }

        private void OrderService()
        {
            loadingForm.Show();
            try
            {
                DateTime date = DateTime.UtcNow.Date;
                string customerContacts = $"Phone ({currentUser.UserPhoneNumber})";
                if(currentUser.UserWhatsapp != null)
                {
                    customerContacts = $"Phone ({currentUser.UserPhoneNumber}) \n WhatsApp({currentUser.UserWhatsapp})";
                }
                OrderModel order = new OrderModel(currentUser.ID, service.OwnerId, service.ServiceTitle,
                    date.ToString("yyyy-MM-dd"), 0, currentUser.UserNames, customerContacts, currentUser.UserAdress, service.ServiceOwner);

                IDatabaseConnection database = GlobalConfig.databaseConnection;

                database.CreateNewOrder(order);

                loadingForm.Close();

                this.Close();


                
            }
            catch (Exception error)
            {
                loadingForm.Close();
                MessageBox.Show("Something went wrong, Please try again. \n" + error.Message);
            }
        }

        private void orderServiceBtn_Click(object sender, EventArgs e)
        {
            OrderService();
        }
    }
}
