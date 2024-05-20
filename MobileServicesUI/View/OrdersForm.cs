using MobileServices.Models;
using MobileServicesLibrary;
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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            PopulateOrders();

        }

        private void PopulateOrders()
        {
            if (GlobalConfig.currentUser != null)
            {

                this.flowLayoutPanelOrders.Controls.Clear();

                try
                {
                    List<OrderModel> orders = GlobalConfig.databaseConnection.GetOrders(GlobalConfig.currentUser.ID, true);
                    OrdersPopulator.Initialize(this.flowLayoutPanelOrders,orders, true);
                    if(orders.Count > 0)
                    {
                        resultsPanel.Hide();
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
