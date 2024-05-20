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
    public partial class OrderServiceRendrererControl : UserControl
    {
        public int id { get; set; }
        public int customerID { get; set; }
        public string customer { get; set; }
        public string contacts { get; set; }
        public string adress { get; set; }
        public string date { get; set; }
        public OrderServiceRendrererControl(int id, int customerID ,string customer 
            ,string contacts ,string adress , string date)
        {
            InitializeComponent();
            this.id = id;
            this.customerID = customerID;
            this.customer = customer;
            this.contacts = contacts;
            this.date = date;
            this.adress = adress;


            this.BorderStyle = BorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            PopulateForm();
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

        private void PopulateForm()
        {
            customerNameLabel.Text = this.customer;
            contactsLabel.Text = this.contacts;
            adressLabel.Text = this.adress;
            dateLabel.Text = this.date;

        }

    }
}
