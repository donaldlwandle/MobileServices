using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileServicesLibrary.Models
{
    public class ServiceModel
    {
        
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }

        public string ServiceOwner { get; set; }
        public string City { get; set; }

        


        public ServiceModel()
        {

        }

        public ServiceModel( string title , string  serviceOwner , string location)
        {
            this.ServiceTitle = title;
            this.ServiceOwner = serviceOwner;
            this.City = location;

        }

        public ServiceModel( int ownerId,string title, string serviceDescription, string serviceOwner, string location )
        {
            this.ServiceTitle = title;
            this.ServiceOwner = serviceOwner;
            this.OwnerId = ownerId;
            this.ServiceDescription = serviceDescription;
            this.City = location;
           

        }
    }
}
