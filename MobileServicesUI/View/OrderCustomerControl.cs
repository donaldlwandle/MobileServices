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
    public partial class OrderCustomerControl : UserControl
    {
        public string Title { get; set; }
        public string RendererName { get; set; }

        public string Date { get; set; }

        public int Status { get; set; }

        public OrderCustomerControl(string title , string renderName ,string date ,int status)
        {
            InitializeComponent();

            this.BorderStyle = BorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            Title = title;
            RendererName = renderName;
            Date = date;
            Status = status;
            PopulateControl();


        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void PopulateControl()
        {
            titleLabel.Text = this.Title;
            rendrerLabel.Text = this.RendererName;
            dateLabel.Text = this.Date;

            if(this.Status == 1)
            {
                statusLabel.Text = "Received";
                statusPanel.BackColor = Color.FromArgb(46, 164, 79);
            }
            else
            {
                
                statusLabel.Text = "Pending";
                statusPanel.BackColor = Color.FromArgb(255, 128, 0);


            }
        }
    }
}
