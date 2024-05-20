namespace MobileServicesUI.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelCompletedBtn = new FontAwesome.Sharp.IconButton();
            this.registerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.registerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelReceivedOrdersBtn = new FontAwesome.Sharp.IconButton();
            this.panelMyServicesBtn = new FontAwesome.Sharp.IconButton();
            this.panelPendingBtn = new FontAwesome.Sharp.IconButton();
            this.panelHomeBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.titleBar = new System.Windows.Forms.Panel();
            this.signInOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.profileLabel = new System.Windows.Forms.Panel();
            this.profileIcon = new FontAwesome.Sharp.IconPictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.searchBtn = new FontAwesome.Sharp.IconPictureBox();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.notification = new System.Windows.Forms.PictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.titleBar.SuspendLayout();
            this.profileLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.panelCompletedBtn);
            this.panelMenu.Controls.Add(this.registerPanel);
            this.panelMenu.Controls.Add(this.panelReceivedOrdersBtn);
            this.panelMenu.Controls.Add(this.panelMyServicesBtn);
            this.panelMenu.Controls.Add(this.panelPendingBtn);
            this.panelMenu.Controls.Add(this.panelHomeBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 661);
            this.panelMenu.TabIndex = 0;
            // 
            // panelCompletedBtn
            // 
            this.panelCompletedBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompletedBtn.FlatAppearance.BorderSize = 0;
            this.panelCompletedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelCompletedBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCompletedBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.panelCompletedBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.panelCompletedBtn.IconColor = System.Drawing.Color.White;
            this.panelCompletedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelCompletedBtn.IconSize = 40;
            this.panelCompletedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelCompletedBtn.Location = new System.Drawing.Point(0, 395);
            this.panelCompletedBtn.Name = "panelCompletedBtn";
            this.panelCompletedBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelCompletedBtn.Size = new System.Drawing.Size(220, 60);
            this.panelCompletedBtn.TabIndex = 7;
            this.panelCompletedBtn.Text = "Completed Orders";
            this.panelCompletedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelCompletedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.panelCompletedBtn.UseVisualStyleBackColor = true;
            this.panelCompletedBtn.Visible = false;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.Transparent;
            this.registerPanel.BorderColor = System.Drawing.Color.Silver;
            this.registerPanel.BorderRadius = 7;
            this.registerPanel.BorderThickness = 1;
            this.registerPanel.Controls.Add(this.titleLabel);
            this.registerPanel.Controls.Add(this.registerBtn);
            this.registerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.registerPanel.Location = new System.Drawing.Point(12, 471);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(197, 122);
            this.registerPanel.TabIndex = 0;
            this.registerPanel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = false;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(15, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(171, 37);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Register as a service renderer below.";
            this.titleLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBtn.BorderRadius = 7;
            this.registerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(164)))), ((int)(((byte)(79)))));
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(15, 76);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(167, 31);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // panelReceivedOrdersBtn
            // 
            this.panelReceivedOrdersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceivedOrdersBtn.FlatAppearance.BorderSize = 0;
            this.panelReceivedOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelReceivedOrdersBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReceivedOrdersBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.panelReceivedOrdersBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.panelReceivedOrdersBtn.IconColor = System.Drawing.Color.White;
            this.panelReceivedOrdersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelReceivedOrdersBtn.IconSize = 40;
            this.panelReceivedOrdersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelReceivedOrdersBtn.Location = new System.Drawing.Point(0, 335);
            this.panelReceivedOrdersBtn.Name = "panelReceivedOrdersBtn";
            this.panelReceivedOrdersBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelReceivedOrdersBtn.Size = new System.Drawing.Size(220, 60);
            this.panelReceivedOrdersBtn.TabIndex = 6;
            this.panelReceivedOrdersBtn.Text = "Received Orders";
            this.panelReceivedOrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelReceivedOrdersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.panelReceivedOrdersBtn.UseVisualStyleBackColor = true;
            this.panelReceivedOrdersBtn.Visible = false;
            this.panelReceivedOrdersBtn.Click += new System.EventHandler(this.panelReceivedOrdersBtn_Click);
            // 
            // panelMyServicesBtn
            // 
            this.panelMyServicesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMyServicesBtn.FlatAppearance.BorderSize = 0;
            this.panelMyServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelMyServicesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMyServicesBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.panelMyServicesBtn.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.panelMyServicesBtn.IconColor = System.Drawing.Color.White;
            this.panelMyServicesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelMyServicesBtn.IconSize = 40;
            this.panelMyServicesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelMyServicesBtn.Location = new System.Drawing.Point(0, 275);
            this.panelMyServicesBtn.Name = "panelMyServicesBtn";
            this.panelMyServicesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelMyServicesBtn.Size = new System.Drawing.Size(220, 60);
            this.panelMyServicesBtn.TabIndex = 5;
            this.panelMyServicesBtn.Text = "My Services";
            this.panelMyServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelMyServicesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.panelMyServicesBtn.UseVisualStyleBackColor = true;
            this.panelMyServicesBtn.Visible = false;
            this.panelMyServicesBtn.Click += new System.EventHandler(this.panelMyServicesBtn_Click);
            // 
            // panelPendingBtn
            // 
            this.panelPendingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPendingBtn.FlatAppearance.BorderSize = 0;
            this.panelPendingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelPendingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPendingBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.panelPendingBtn.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.panelPendingBtn.IconColor = System.Drawing.Color.White;
            this.panelPendingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelPendingBtn.IconSize = 40;
            this.panelPendingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelPendingBtn.Location = new System.Drawing.Point(0, 215);
            this.panelPendingBtn.Name = "panelPendingBtn";
            this.panelPendingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelPendingBtn.Size = new System.Drawing.Size(220, 60);
            this.panelPendingBtn.TabIndex = 3;
            this.panelPendingBtn.Text = "My orders";
            this.panelPendingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelPendingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.panelPendingBtn.UseVisualStyleBackColor = true;
            this.panelPendingBtn.Click += new System.EventHandler(this.panelPendingBtn_Click);
            // 
            // panelHomeBtn
            // 
            this.panelHomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeBtn.FlatAppearance.BorderSize = 0;
            this.panelHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelHomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHomeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.panelHomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.panelHomeBtn.IconColor = System.Drawing.Color.White;
            this.panelHomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelHomeBtn.IconSize = 40;
            this.panelHomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelHomeBtn.Location = new System.Drawing.Point(0, 155);
            this.panelHomeBtn.Name = "panelHomeBtn";
            this.panelHomeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelHomeBtn.Size = new System.Drawing.Size(220, 60);
            this.panelHomeBtn.TabIndex = 2;
            this.panelHomeBtn.Text = "Home";
            this.panelHomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelHomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.panelHomeBtn.UseVisualStyleBackColor = true;
            this.panelHomeBtn.Click += new System.EventHandler(this.panelHomeBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.guna2PictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 155);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(154)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Helping Hand ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::MobileServicesUI.Properties.Resources.mbsvs_Logopng;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(49, 29);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(85, 70);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Controls.Add(this.signInOutBtn);
            this.titleBar.Controls.Add(this.profileLabel);
            this.titleBar.Controls.Add(this.guna2Panel1);
            this.titleBar.Controls.Add(this.notification);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(220, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(877, 85);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // signInOutBtn
            // 
            this.signInOutBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.signInOutBtn.BorderRadius = 10;
            this.signInOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInOutBtn.FillColor = System.Drawing.Color.White;
            this.signInOutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.signInOutBtn.Location = new System.Drawing.Point(106, 29);
            this.signInOutBtn.Name = "signInOutBtn";
            this.signInOutBtn.Size = new System.Drawing.Size(96, 30);
            this.signInOutBtn.TabIndex = 5;
            this.signInOutBtn.Text = "Sign in";
            this.signInOutBtn.Click += new System.EventHandler(this.signInOutBtn_Click);
            // 
            // profileLabel
            // 
            this.profileLabel.Controls.Add(this.profileIcon);
            this.profileLabel.Controls.Add(this.usernameLabel);
            this.profileLabel.Location = new System.Drawing.Point(717, 12);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(104, 73);
            this.profileLabel.TabIndex = 4;
            this.profileLabel.Click += new System.EventHandler(this.profileLabel_Click);
            // 
            // profileIcon
            // 
            this.profileIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.profileIcon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.profileIcon.IconColor = System.Drawing.Color.White;
            this.profileIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profileIcon.IconSize = 40;
            this.profileIcon.Location = new System.Drawing.Point(28, 10);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(40, 40);
            this.profileIcon.TabIndex = 0;
            this.profileIcon.TabStop = false;
            this.profileIcon.Click += new System.EventHandler(this.profileIcon_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoEllipsis = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(8, 50);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.usernameLabel.Size = new System.Drawing.Size(96, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.usernameLabel.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.searchBtn);
            this.guna2Panel1.Controls.Add(this.searchInput);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.guna2Panel1.Location = new System.Drawing.Point(242, 29);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(409, 30);
            this.guna2Panel1.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.White;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 22;
            this.searchBtn.Location = new System.Drawing.Point(367, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(22, 22);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Animated = true;
            this.searchInput.BackColor = System.Drawing.Color.Transparent;
            this.searchInput.BorderColor = System.Drawing.Color.Transparent;
            this.searchInput.BorderRadius = 10;
            this.searchInput.BorderThickness = 0;
            this.searchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInput.DefaultText = "";
            this.searchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.searchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.searchInput.ForeColor = System.Drawing.Color.White;
            this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchInput.Location = new System.Drawing.Point(3, 5);
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderText = "Search for  services...";
            this.searchInput.SelectedText = "";
            this.searchInput.Size = new System.Drawing.Size(324, 22);
            this.searchInput.TabIndex = 0;
            // 
            // notification
            // 
            this.notification.Image = global::MobileServicesUI.Properties.Resources.bell;
            this.notification.Location = new System.Drawing.Point(24, 29);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(30, 30);
            this.notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notification.TabIndex = 2;
            this.notification.TabStop = false;
            this.notification.Click += new System.EventHandler(this.notification_Click);
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(220, 85);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(877, 576);
            this.childFormPanel.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 25;
            this.closeBtn.Location = new System.Drawing.Point(849, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 661);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.registerPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.profileLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton panelHomeBtn;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton panelReceivedOrdersBtn;
        private FontAwesome.Sharp.IconButton panelMyServicesBtn;
        private FontAwesome.Sharp.IconButton panelPendingBtn;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label usernameLabel;
        private FontAwesome.Sharp.IconPictureBox profileIcon;
        private System.Windows.Forms.PictureBox notification;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconPictureBox searchBtn;
        private System.Windows.Forms.Panel profileLabel;
        private Guna.UI2.WinForms.Guna2Panel registerPanel;
        private Guna.UI2.WinForms.Guna2Button registerBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Button signInOutBtn;
        private FontAwesome.Sharp.IconButton panelCompletedBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
    }
}