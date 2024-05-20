using MobileServices.Models;
using MobileServicesUI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileServicesUI.Utils
{
    public static class OrdersPopulator
    {
        static FlowLayoutPanel layoutPanel;

        public static void Initialize(FlowLayoutPanel panel, List<OrderModel> orders, bool isCustomer)
        {
            layoutPanel = panel;

            if(orders.Count != 0)
            {
                if (isCustomer)
                {
                    for(int i = 0; i < orders.Count; i++)
                    {
                        OrderModel order = orders[i];
                        OrderCustomerControl customerControl = new OrderCustomerControl(order.Title,
                            order.RendererName, order.Date, order.Status);
                        
                        layoutPanel.Controls.Add(customerControl);
                    }
                }
                else
                {
                    for (int i = 0; i < orders.Count; i++)
                    {
                        OrderModel order = orders[i];
                        OrderServiceRendrererControl rendrererControl = new OrderServiceRendrererControl(order.ID, order.CustomerID,
                            order.CustomerName, order.CustomerContacts, order.CustomerAdress, order.Date);

                        layoutPanel.Controls.Add(rendrererControl);

                        //Event listeners
                        rendrererControl.acceptBtn.Click += (sender, e) => AcceptOrder();
                        rendrererControl.dismissBtn.Click += (sender, e) => DismisOrder();
                    }

                }
            }

        }

        private static void DismisOrder()
        {

        }

        private static void AcceptOrder()
        {

        }

    }
}
