using FontAwesome.Sharp;
using MobileServices.Models;
using MobileServices.Utils;
using MobileServicesLibrary;
using MobileServicesUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileServicesUI.View
{
    public partial class MainForm : Form, IUserUpdated
    {
        private IconButton currentButton;
        private Panel leftBorderBar;
        private Form currentChildForm;
        private bool isSignedIn = false;
        private LoadingFormFunct loadingForm = new LoadingFormFunct();

        public MainForm()
        {
            InitializeComponent();

            // Initializing variables
            leftBorderBar  = new Panel();
            leftBorderBar.Size = new Size(7, 60);

            // 
            panelMenu.Controls.Add(leftBorderBar);

            //adjust form settings
            this.DoubleBuffered = true;

            //Launch the home form to the form switch panel
            OpenChildForm(new HomeForm());

            // Sending the Form to list of User update liatners.
            UIGlobalConfig.AddMainForm(this);
        }


       

        // ################################################################### EVENT LISTENERS ###########################################################
        private void panelHomeBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new HomeForm());
        }

        private void panelPendingBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new OrdersForm());
        }


        private void panelMyServicesBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new MyServicesForm());
        }
        private void panelReceivedOrdersBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new ReceivedOrdersForm());
        }



        private void panelLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void profileLabel_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.currentUser != null)
            {
                //Go to profile
                OpenChildForm(new UserProfileForm(GlobalConfig.currentUser));
            }
            else{

                Login();
            }
        }

        private void notification_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.currentUser != null)
            {
                //Go to notifications
            }
            else
            {

                Login();
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.currentUser != null)
            {
                //Go to search
                if(searchInput.Text.Length != 0)
                {
                    
                    OpenChildForm(new SearchForm(searchInput.Text));

                }
            }
            else
            {
                Login();


            }

        }

        private void Login()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void profileIcon_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.currentUser != null)
            {
                //Go to profile
                OpenChildForm(new UserProfileForm(GlobalConfig.currentUser));
            }
            else
            {

                Login();
            }

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterRendererForm registerRenderer =new RegisterRendererForm();
            registerRenderer.ShowDialog();
        }

        private void signInOutBtn_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.currentUser != null)
            {
                //sign Out
                loadingForm.Show();
                GlobalConfig.SetCurrentUser(null);
                foreach (IUserUpdated listeningForm in UIGlobalConfig.userUpdateListeningForms)
                {
                    listeningForm.UserUpdated();
                }
                OpenChildForm(new HomeForm());
                loadingForm.Close();

            }
            else
            {
                Login();
            }
            

        }





        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
           
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        // ################################################################### FORM METHODS ###########################################################


        /// <summary>
        /// Setting up Navigation sidebar  Highlighting Effect
        /// </summary>
        /// <param name="clickedBtn"></param>
        private void ActivateBtn(object clickedBtn)
        {
            if (clickedBtn != null)
            {
                DisableBtn();
                currentButton = (IconButton)clickedBtn;
                currentButton.BackColor = Color.FromArgb(22, 24, 25);
                currentButton.ForeColor = Color.FromArgb(252, 206, 255);
                currentButton.IconColor = Color.FromArgb(252, 206, 255);
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                //Buton left bar
                leftBorderBar.BackColor = Color.FromArgb(252, 206, 255);
                leftBorderBar.Location = new Point(0, currentButton.Location.Y);
                leftBorderBar.Visible = true;
                leftBorderBar.BringToFront();

            }

        }

        /// <summary>
        /// Disabling Higlighting Effect Effect
        /// </summary>
        private void DisableBtn()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(50, 51, 55);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }


        /// <summary>
        /// Will Reset the highlight selection
        /// </summary>
        private void Reset()
        {
            DisableBtn();
            leftBorderBar.Visible = false;
        }


        /// <summary>
        /// Will Add The Form to the Panel and launch it.
        /// Will be executed during Navigation on the left Panel
        /// </summary>
        /// <param name="childForm"></param>
        private void OpenChildForm(Form childForm)
        {
           

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       

        /// <summary>
        /// Will populate main form and set UI to fit the type of user currently loged in.
        /// Current user is either default user(Customer) or Business (Service renderer).
        /// </summary>
        private void PopulateMainForm()
        {
            if(GlobalConfig.currentUser != null)
            {
                UserModel user = GlobalConfig.currentUser;
                usernameLabel.Visible = true;
                if (user.IsBusiness)
                {
                    // Adjust UI to Busines View
                    panelMyServicesBtn.Visible = true;
                    panelReceivedOrdersBtn.Visible = true;
                    registerPanel.Visible = false;
                    


                }
                else
                {
                    /// Adjust Ui to default user
                    panelMyServicesBtn.Visible = false;
                    panelReceivedOrdersBtn.Visible = false;
                    registerPanel.Visible = true;
                }


                //Populate user details
                usernameLabel.Text = user.UserNames;

                signInOutBtn.Text = "Sign Out";
            }
            else
            {
                /// Adjust Ui to default user
                panelMyServicesBtn.Visible = false;
                panelReceivedOrdersBtn.Visible = false;
                registerPanel.Visible = true;
                signInOutBtn.Text = "Sign in";

                //Populate user details
                usernameLabel.Text = "";


            }

            
        }

        // ################################################################### USER UPDATE INTERFACE ###########################################################
        /// <summary>
        /// Event Interface will listen for sucessful user update.
        /// Will Execute when new user loggin and when existing user Succesfully Registers a business.
        /// </summary>
        public void UserUpdated()
        {
            PopulateMainForm();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
