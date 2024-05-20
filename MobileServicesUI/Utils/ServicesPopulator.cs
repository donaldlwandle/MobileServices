using MobileServicesLibrary.Models;
using MobileServicesUI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileServicesUI.Utils
{
    public static class ServicesPopulator
    {
        static FlowLayoutPanel layoutPanel;
        
        

        public static void Initialize(FlowLayoutPanel panel , List<ServiceModel> services , bool isHOME)
        {
            layoutPanel= panel;
           
            

            

            if (services.Count != 0)
            {
                for (int i = 0; i < services.Count; i++)
                {
                    // Initialize service data object and service Ui controler
                    ServiceModel service = services[i];
                    ServiceUserControl serviceUserControl = new ServiceUserControl(
                        service.ServiceTitle,
                        service.ServiceOwner,
                        service.City,
                        service.OwnerId);

                    //Add item to the flow controler
                    layoutPanel.Controls.Add(serviceUserControl);

                    /*serviceUserControl.iconPictureBox1.Click += new System.EventHandler(ServiceUserControl_ProfileClick );*/
                    serviceUserControl.iconPictureBox1.Click += (sender, e) => ServiceUserControl_ProfileClick(service.OwnerId, isHOME);
                    serviceUserControl.titleLabel.Click += (sender, e) => ServiceItemClick(service);
                    serviceUserControl.owner.Click += (sender, e) => ServiceUserControl_ProfileClick(service.OwnerId ,isHOME);
                    serviceUserControl.location.Click += (sender, e) => ServiceItemClick(service);
                    serviceUserControl.Click += (sender, e) => ServiceItemClick(service);
                }
            }
        }


        private static void ServiceItemClick(ServiceModel serviceModel )
        {
            OrderServiceForm orderServiceForm = new OrderServiceForm(serviceModel);
            orderServiceForm.ShowDialog();
        }

        private static void ServiceUserControl_ProfileClick(int id ,bool isHome)
        {

            if (isHome)
            {
                RendererProfileForm rendererProfile = new RendererProfileForm(id);
                rendererProfile.ShowDialog(); 
            }
        }






    }

    
}
