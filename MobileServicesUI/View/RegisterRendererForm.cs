using MobileServices.Models;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileServicesUI.View
{
    public partial class RegisterRendererForm : Form
    {
        UserModel currentUser;
        private LoadingFormFunct loadingForm = new LoadingFormFunct();
        public RegisterRendererForm()
        {
            InitializeComponent();
            currentUser = GlobalConfig.currentUser;
        }

        private void RegisterRendererForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValid()
        {
            ulong id;
            if(idNoInput.Text.Length != 13 || !ulong.TryParse(idNoInput.Text , out id))
            {
                descriptionLabel.Text = "Enter valid ID number";
                descriptionLabel.ForeColor = Color.Red;
                return false;
            }

            
            return true;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                loadingForm.Show();

                try
                {
                    IDatabaseConnection database = GlobalConfig.databaseConnection;
                    UserModel user = new UserModel();

                    user.ID = currentUser.ID;
                    user.UserIDNo = idNoInput.Text;

                    if (qualificationsInput.Text.Length != 0)
                    {
                        user.UserQualifications = qualificationsInput.Text;
                    }
                    else
                    {
                        user.UserQualifications = "";
                    }

                    if (referencesInput.Text.Length != 0)
                    {
                        user.UserReferences = referencesInput.Text;
                    }
                    else
                    {
                        user.UserReferences = "";
                    }
                    user.IsBusiness = true;
                    database.UpdateUserAsBusiness(user);
                    
                    database.GetLoginUser(currentUser.UserEmail, currentUser.UserPassword);


                    foreach (IUserUpdated listeningForm in UIGlobalConfig.userUpdateListeningForms)
                    {
                        listeningForm.UserUpdated();
                    }

                    loadingForm.Close();
                    this.Close();
                }
                catch (Exception error)
                {

                    descriptionLabel.Text = "Something went wrong, try again. \n" + error.Message;
                    descriptionLabel.ForeColor = Color.Red;
                    loadingForm.Close();
                    MessageBox.Show(error.Message);
                }
            }

        }
    }
}
