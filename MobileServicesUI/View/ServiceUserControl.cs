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

namespace MobileServicesUI.Utils
{
    public partial class ServiceUserControl : UserControl
    {

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

        public string Title { get; set; }
        public string Owner { get; set; }

        public string Location { get; set; }

        public int OwnerID { get; set; }
        public ServiceUserControl(string title, string owner, string location, int ownerID)
        {
            InitializeComponent();
            Title = title;
            Owner = owner;
            Location = location;

            PopulateControl();
            OwnerID = ownerID;


            this.BorderStyle = BorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void PopulateControl()
        {
            this.titleLabel.Text = Title;
            this.owner.Text = Owner;
            this.location.Text = Location;
        }
    }
}
