using Dapper;
using MobileServices.Models;
using MobileServicesLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileServicesLibrary.DatabaseAccess
{
    public class MySQLConnector : IDatabaseConnection
    {
        private const string db = "MobileServices";

        /// <summary>
        /// saves an new service created bu its renderer to the database
        /// </summary>
        /// <param name="service"></param>
        /// <returns>the service information inclusing the unique Identifier</returns>
        public ServiceModel CreateService(ServiceModel service)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {
               
                var s = new DynamicParameters();
                s.Add("ownerIdIN", service.OwnerId);
                s.Add("serviceTitleIN", service.ServiceTitle);
                s.Add("descriptionIN", service.ServiceDescription);
                s.Add("rendererNameIN", service.ServiceOwner);
                s.Add("cityIN", service.City);
                s.Add("idOut", dbType: DbType.Int32, direction: ParameterDirection.Output);
                
                
                connection.Execute("spServices_SetService", s , commandType: CommandType.StoredProcedure);


                service.Id = s.Get<int>("@idOut");
                return service;


            }
        
            
        }

        /// <summary>
        /// Create a new default user.
        /// By default a user is a potential customer
        /// </summary>
        /// <param name="userModel"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void CreateNewUser(UserModel userModel)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {

                var newUserParam = new DynamicParameters();
                newUserParam.Add("userNamesIN", userModel.UserNames);
                newUserParam.Add("lastNameIN", userModel.UserLastName);
                newUserParam.Add("emailIn", userModel.UserEmail);
                newUserParam.Add("passwordIn", userModel.UserPassword);
                newUserParam.Add("phoneNoIn", userModel.UserPhoneNumber);
                newUserParam.Add("whatsappIn", userModel.UserWhatsapp);
                newUserParam.Add("cityIn", userModel.UserCity);
                newUserParam.Add("adress", userModel.UserAdress);



                connection.Execute("spUsers_SetNewUser", newUserParam, commandType: CommandType.StoredProcedure);

            }

        }

        /// <summary>
        /// updates the user as service renderer
        /// </summary>
        /// <param name="userModel"></param>
        public void UpdateUserAsBusiness(UserModel userModel)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {

                var updateUserParam = new DynamicParameters();
                updateUserParam.Add("userIDIn", userModel.ID);
                updateUserParam.Add("idNumberIn", userModel.UserIDNo);
                updateUserParam.Add("referencesIn", userModel.UserReferences);
                updateUserParam.Add("qualificationsIn", userModel.UserQualifications);
                updateUserParam.Add("isBusinessIn", userModel.IsBusiness);
                



                connection.Execute("spUsers_UpdateNewBusinessUser", updateUserParam, commandType: CommandType.StoredProcedure);

            }

        }

        /// <summary>
        /// Get current loged in user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void GetLoginUser(string email, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {


                var getUserParam = new DynamicParameters();
                getUserParam.Add("emailIn", email, DbType.String, ParameterDirection.Input);
                getUserParam.Add("passwordIn", password, DbType.String, ParameterDirection.Input);

                GlobalConfig.SetCurrentUser(connection.QuerySingle<UserModel>("spUsers_GetLoginUser", getUserParam, commandType: CommandType.StoredProcedure));

            }

        }

        /// <summary>
        /// Get list of all local services of the user after login
        /// </summary>
        /// <param name="localCity"></param>
        /// <returns> Liost of all local services (search by users city)</returns>
        
        public List<ServiceModel> GetLocalServices(string userCity)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {


                var getLocalServices = new DynamicParameters();
                getLocalServices.Add("userCity", userCity, DbType.String, ParameterDirection.Input);
                

                return connection.Query<ServiceModel>("spServices_GetLocalServices", getLocalServices, commandType: CommandType.StoredProcedure).ToList();

            }
        }

        public UserModel GetRenderer (int id)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {


                var getUserParam = new DynamicParameters();
                getUserParam.Add("idIN", id, DbType.Int32, ParameterDirection.Input);
                

                UserModel renderer = connection.QuerySingle<UserModel>("spUsers_GetRenderer", 
                    getUserParam, commandType: CommandType.StoredProcedure);

                return renderer;

            }
        }

        public List<ServiceModel> GetRendererServices(int rendererID)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {


                var getRendererServices = new DynamicParameters();
                getRendererServices.Add("idIn", rendererID, DbType.Int32, ParameterDirection.Input);


                return connection.Query<ServiceModel>("spServices_GetRendererServices", getRendererServices, commandType: CommandType.StoredProcedure).ToList();

            }
        }

        public List<ServiceModel> GetSearchResults(string search)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {


                var getSearchResults = new DynamicParameters();
                getSearchResults.Add("searchTerm", search, DbType.String, ParameterDirection.Input);


                return connection.Query<ServiceModel>("spServices_GetSearchServices", getSearchResults, commandType: CommandType.StoredProcedure).ToList();

            }
        }

        public void CreateNewOrder(OrderModel order)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {

                var newOrderParam = new DynamicParameters();
                newOrderParam.Add("customerIdIN", order.CustomerID);
                newOrderParam.Add("rendererIdIN", order.RendererID);
                newOrderParam.Add("titleIn", order.Title);
                newOrderParam.Add("dateIn", order.Date);
                newOrderParam.Add("statusIn", order.Status);
                newOrderParam.Add("customerNameIn", order.CustomerName);
                newOrderParam.Add("customerContactsIn", order.CustomerContacts);
                newOrderParam.Add("customerAdressIn", order.CustomerAdress);
                newOrderParam.Add("rendererNameIn",order.RendererName);




                connection.Execute("spOrders_SetNewOrder", newOrderParam, commandType: CommandType.StoredProcedure);

            }
        }

        public List<OrderModel> GetOrders(int searchID, bool isCustomer)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString(db)))
            {


                var getOrders = new DynamicParameters();
                getOrders.Add("idIn", searchID, DbType.Int32, ParameterDirection.Input);

                if (isCustomer)
                {
                    return connection.Query<OrderModel>("spOrders_GetCustomerOrders", getOrders, commandType: CommandType.StoredProcedure).ToList();

                }

                return connection.Query<OrderModel>("spOrders_GetRendererOrders", getOrders, commandType: CommandType.StoredProcedure).ToList();

            }
        }
    }
}
