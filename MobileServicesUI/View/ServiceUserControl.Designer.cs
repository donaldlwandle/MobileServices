namespace MobileServicesUI.Utils
{
    partial  class ServiceUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.owner = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(24, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(312, 57);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Service title  goes here";
            // 
            // owner
            // 
            this.owner.AutoEllipsis = true;
            this.owner.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.owner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.owner.Location = new System.Drawing.Point(102, 75);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(225, 22);
            this.owner.TabIndex = 2;
            this.owner.Text = "Service owner here";
            // 
            // location
            // 
            this.location.AutoEllipsis = true;
            this.location.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(154)))), ((int)(((byte)(182)))));
            this.location.Location = new System.Drawing.Point(102, 97);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(225, 24);
            this.location.TabIndex = 3;
            this.location.Text = "location * Service location";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(29, 75);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(36, 35);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // ServiceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.location);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.Name = "ServiceUserControl";
            this.Size = new System.Drawing.Size(361, 131);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label owner;
        public System.Windows.Forms.Label location;
        public  FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
