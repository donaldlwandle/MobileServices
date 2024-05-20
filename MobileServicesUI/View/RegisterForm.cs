using MobileServices.Models;
using MobileServicesLibrary;
using MobileServicesLibrary.DatabaseAccess;
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
    public partial class RegisterForm : Form
    {
        private LoadingFormFunct loadingForm = new LoadingFormFunct();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private bool isValid1()
        {
            if(namesInput.Text.Length == 0)
            {
                descriptionLabel.Text = "Names cannot be empty!";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }

            if (lastNameInput.Text.Length == 0)
            {
                descriptionLabel.Text = "Last name cannot be empty!";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }

            if (phoneNumberInput.Text.Length == 0)
            {
                descriptionLabel.Text = "Phone number cannot be empty";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }

            ulong phoneNo;
            if (phoneNumberInput.Text.Length != 0 && !ulong.TryParse(phoneNumberInput.Text, out phoneNo))
            {
                descriptionLabel.Text = "Enter valid Phone number";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }


            ulong whatsapp;
            if (whatsappInput.Text.Length != 0 && !ulong.TryParse(whatsappInput.Text, out whatsapp))
            {
                descriptionLabel.Text = "Enter valid whatsapp number";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }

            if (cityInput.Text.Length == 0)
            {
                descriptionLabel.Text = "Please provide your city or town!";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }

            if (adressInput.Text.Length == 0)
            {
                descriptionLabel.Text = "Adress cannot be empty!";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }


            

            return true;
        }

        

        private bool isValid2()
        {
            if(emailInput.Text.Length == 0)
            {
                descriptionLabel.Text = "Email cannot be empty!";
                descriptionLabel.ForeColor = Color.Red;
                return false;

            }

            if (!emailInput.Text.ToLower().Contains("@") || !emailInput.Text.ToLower().Contains("."))
            {
                descriptionLabel.Text = "Please enter a valid email!";
                descriptionLabel.ForeColor = Color.Red;
                return false;

            }


            if (passwordInput.Text.Length == 0 || confirmPassword.Text.Length == 0)
            {
                descriptionLabel.Text = "Password cannot be empty!";
                descriptionLabel.ForeColor = Color.Red;
                return false;

            }

            if (confirmPassword.Text != passwordInput.Text)
            {
                descriptionLabel.Text = "Passwords do not match!";
                descriptionLabel.ForeColor = Color.Red;
                return false;

            }

            if(passwordInput.Text.Length < 8)
            {
                descriptionLabel.Text = "Passwords must atleast be 8 characters";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }

            return true;
        }



        private void nextButton_Click(object sender, EventArgs e)
        {
            if (isValid1())
            {

                descriptionLabel.Text = "These details will help with providing the  best user experience";
                descriptionLabel.ForeColor = Color.White;
                nextButton.Hide();
                registerBtn.Show();

                panel1.Hide();
                panel1.Visible = false;
                panel2.Visible = true;
                registerBtn.Visible = true;

                panel2.Show();
            }
        }



        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (isValid2())
            {
                loadingForm.Show();

                descriptionLabel.Text = "These details will help with providing the  best user experience";
                descriptionLabel.ForeColor = Color.White;
                //Add details to object

                UserModel user = new UserModel(namesInput.Text, lastNameInput.Text, emailInput.Text, passwordInput.Text,

                                    phoneNumberInput.Text, cityInput.Text, adressInput.Text);

                if (whatsappInput.Text.Length > 0)
                {
                    user.UserWhatsapp = whatsappInput.Text;
                }

                //try to register new user
                try
                {
                    

                    IDatabaseConnection database = GlobalConfig.databaseConnection;
                    database.CreateNewUser(user);

                    loadingForm.Close();
                    this.Close();

                }
                catch (Exception error)
                {

                    descriptionLabel.Text = "Creating account failed!, \n" + error.Message;
                    descriptionLabel.ForeColor = Color.Red;
                    loadingForm.Close();


                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
