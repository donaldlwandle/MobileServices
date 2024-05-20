using MobileServices.Models;
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
    public partial class RendererProfileForm : Form
    {
        int rendererID;
        public RendererProfileForm(int rendererID)
        {
            InitializeComponent();
            this.rendererID = rendererID;
            PopulateProfile();

        }

        private void PopulateProfile()
        {
            

            try
            {
                UserModel renderer = GlobalConfig.databaseConnection.GetRenderer(rendererID);

                //populate details
                nameLabel.Text = renderer.UserNames;
                lastNameLabel.Text = renderer.UserLastName;
                phoneNoLabel.Text = renderer.UserPhoneNumber;

                if (renderer.UserWhatsapp != null)
                {
                    whatsappLabel.Text = renderer.UserWhatsapp;
                }
                else
                {
                    whatsappLabel.Text = "Not available";
                }

                cityLabel.Text = renderer.UserCity;
                adressLabel.Text = renderer.UserAdress;

                if (renderer.UserReferences != null)
                {
                    referencesLabel.Text = renderer.UserReferences;
                }
                else
                {
                    referencesLabel.Text = "Not available yet";
                }


                if (renderer.UserQualifications != null)
                {
                    qualificationsLabel.Text = renderer.UserQualifications;
                }
                else
                {
                    qualificationsLabel.Text = "Not available yet";
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            PopulateServices();


        }

        private void PopulateServices()
        {
            /*List<ServiceModel> services = new List<ServiceModel>();
            services.Add(new ServiceModel("Plumbing", "Johaness", "Mahikeng"));
            services.Add(new ServiceModel("Catering", "Johaness", "Mahikeng"));
            services.Add(new ServiceModel("Grass cutting and triming", "Johaness", "Mahikeng"));
            services.Add(new ServiceModel("Cow slaughering", "Johaness", "Mahikeng"));
            services.Add(new ServiceModel("Hitman", "Johaness", "Mahikeng"));

            ServicesPopulator.Initialize(this.flowLayoutPanelProfile, services, false);*/

            try
            {
                List<ServiceModel> services = GlobalConfig.databaseConnection.GetRendererServices(this.rendererID);
                ServicesPopulator.Initialize(this.flowLayoutPanelProfile, services, false);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
