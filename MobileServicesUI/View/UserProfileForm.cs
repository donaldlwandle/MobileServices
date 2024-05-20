using MobileServices.Models;
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
    public partial class UserProfileForm : Form
    {
        UserModel user;
        public UserProfileForm(UserModel userModel)
        {
            InitializeComponent();
            this.user = userModel;
            Populateprofile();
        }

        private void Populateprofile()
        {
            usernameLabel.Text = user.UserNames;
            userLastNameLabel.Text = user.UserLastName;
            phoneNoInput.Text = user.UserPhoneNumber;

            if (user.UserWhatsapp != null)
            {
                whatsappInput.Text = user.UserWhatsapp;
            }
            else
            {
                whatsappInput.Text = "No Whatsapp provided";
            }

            townInput.Text = user.UserCity;
            adressInput.Text = user.UserAdress;

            if(user.UserReferences != null)
            {
                referencesInput.Text = user.UserReferences;
            }
            else
            {
                referencesInput.Text = "No References provided";
            }


            if (user.UserQualifications != null)
            {
                qualificationsInput.Text = user.UserQualifications;
            }
            else
            {
                qualificationsInput.Text = "No Qualifications provided";
            }
        }

        
    }
    
}
