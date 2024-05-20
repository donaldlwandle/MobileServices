namespace MobileServicesUI.View
{
    partial class OrderServiceForm
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.orderServiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.phoneNoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 7;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // orderServiceBtn
            // 
            this.orderServiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderServiceBtn.BorderRadius = 10;
            this.orderServiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderServiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderServiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderServiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderServiceBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.orderServiceBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.orderServiceBtn.ForeColor = System.Drawing.Color.White;
            this.orderServiceBtn.Location = new System.Drawing.Point(58, 414);
            this.orderServiceBtn.Name = "orderServiceBtn";
            this.orderServiceBtn.Size = new System.Drawing.Size(306, 37);
            this.orderServiceBtn.TabIndex = 1;
            this.orderServiceBtn.Text = "Order service";
            this.orderServiceBtn.Click += new System.EventHandler(this.orderServiceBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = false;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.titleLabel.Location = new System.Drawing.Point(58, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(298, 72);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Service title.";
            // 
            // phoneNoLabel
            // 
            this.phoneNoLabel.AutoEllipsis = true;
            this.phoneNoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.phoneNoLabel.ForeColor = System.Drawing.Color.Gray;
            this.phoneNoLabel.Location = new System.Drawing.Point(54, 136);
            this.phoneNoLabel.Name = "phoneNoLabel";
            this.phoneNoLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.phoneNoLabel.Size = new System.Drawing.Size(266, 22);
            this.phoneNoLabel.TabIndex = 16;
            this.phoneNoLabel.Text = "Offered by:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.nameLabel.Location = new System.Drawing.Point(53, 158);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.nameLabel.Size = new System.Drawing.Size(311, 28);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Name(s)";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoEllipsis = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.cityLabel.Location = new System.Drawing.Point(53, 221);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cityLabel.Size = new System.Drawing.Size(311, 28);
            this.cityLabel.TabIndex = 19;
            this.cityLabel.Text = "Town or City";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(54, 199);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(266, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "From:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = false;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.descriptionLabel.Location = new System.Drawing.Point(58, 280);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(306, 103);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Description";
            // 
            // OrderServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 487);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneNoLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.orderServiceBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderServiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button orderServiceBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private System.Windows.Forms.Label phoneNoLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
    }
}