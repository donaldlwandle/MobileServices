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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            
            
        }

        public LoadingForm(Form parent)
        {
            InitializeComponent();

            if(parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(Parent.Location.X + Parent.Width / 2 - this.Width / 2,
                Parent.Location.Y + Parent.Height / 2 - this.Height / 2);
            }
            
        }

        public void CloseLoading()
        {
            this.DialogResult = DialogResult.OK;
            if(label1.Image != null)
            {
                label1.Image.Dispose();
            }
            this.Close();
        }
    }
}
