using MobileServices.Utils;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileServicesUI.View
{
    public partial class LoginForm : Form
    {
        private string emailHome;
        private LoadingFormFunct loadingForm = new LoadingFormFunct();

        public LoginForm()
        {
            InitializeComponent();
            
        }

        public LoginForm( String emailHome)
        {
            InitializeComponent();
            this.emailHome = emailHome;

            emailInput.Text = emailHome;

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isValid() )
            {
                
                loadingForm.Show();
                /*Thread.Sleep(5000);*/

                try
                {

                    //"johaness@ramanyusa.com  -"
                    IDatabaseConnection database = GlobalConfig.databaseConnection;
                    database.GetLoginUser(emailInput.Text, passwordInput.Text);

                    if (GlobalConfig.currentUser != null)
                    {
                        ///Login was succesfull
                        foreach (IUserUpdated listeningForm in UIGlobalConfig.userUpdateListeningForms)
                        {
                            listeningForm.UserUpdated();
                        }
                        loadingForm.Close();
                        this.Close();

                    }
                    else
                    {
                        loadingForm.Close();
                        MessageBox.Show("Login Failed!!!");

                    }

                }
                catch (Exception error)
                {
                    loadingForm.Close();
                    descriptionLabel.Text = "Login Failed!!, Enter correct credentials and try again \n" + error.Message;
                    descriptionLabel.ForeColor = Color.Red;

                    
                } 
            }

        }

       

        private bool isValid()
        {
            if(emailInput.Text.Length == 0)
            {
                descriptionLabel.Text = "Email cannot be empty!!";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }

            if(passwordInput.Text.Length == 0)
            {
                descriptionLabel.Text = "Password cannot be empty!!";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerText_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
