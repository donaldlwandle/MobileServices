using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileServices.Models
{
    

    public class OrderModel
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int RendererID { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public int Status { get; set; }
        public string CustomerName { get; set; }
        public string  CustomerContacts { get; set; }
        public string CustomerAdress { get; set; }
        public string RendererName { get; set; }

        public OrderModel()
        {

        }

        public OrderModel( int customerID, int rendererID, string title, string date, int status, string customerName, string customerContacts, string customerAdress, string rendererName)
        {
            
            CustomerID = customerID;
            RendererID = rendererID;
            Title = title;
            Date = date;
            Status = status;
            CustomerName = customerName;
            CustomerContacts = customerContacts;
            CustomerAdress = customerAdress;
            RendererName = rendererName;
        }
    }
}
