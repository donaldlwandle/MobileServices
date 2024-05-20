using MobileServices.Models;
using MobileServicesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileServicesLibrary.DatabaseAccess
{
    public interface IDatabaseConnection
    {
        ServiceModel CreateService(ServiceModel service);

        void CreateNewUser(UserModel userModel);

        void UpdateUserAsBusiness(UserModel userModel);

        void GetLoginUser(string email , string password);

        List<ServiceModel> GetLocalServices(String localCity);

        List<ServiceModel> GetSearchResults(String search);

        List<ServiceModel> GetRendererServices(int rendererID);

        UserModel GetRenderer(int id);

        void CreateNewOrder(OrderModel order);

        List<OrderModel> GetOrders(int searchID, bool isCustomer);
    }
}
