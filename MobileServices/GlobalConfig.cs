using MobileServices.Models;
using MobileServices.Utils;
using MobileServicesLibrary.DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileServicesLibrary
{
    public static class GlobalConfig
    {



        /// <summary>
        /// Current logged in user
        /// === null if no user is logged in
        /// </summary>
        public static UserModel currentUser { get; private set; }

        /// <summary>
        /// Database connecting interface
        /// </summary>
        public static IDatabaseConnection databaseConnection { get; private set; }

        

        public static void InitializeConnections()
        {
            // TODO - initialize mySQL connection
           

            MySQLConnector mySQLConnector = new MySQLConnector();
            databaseConnection = mySQLConnector;

            
        }

        /// <summary>
        /// get database connectin string from App Config
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Connection string</returns>
        public static string ConnectionString( string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        /// <summary>
        /// Update current user after succesful login
        /// </summary>
        /// <param name="userModel"></param>
        public static void SetCurrentUser(UserModel userModel)
        {
            currentUser = userModel;
            
        }
    }
}
