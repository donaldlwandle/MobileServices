using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileServices.Models
{
    public class UserModel
    {
        /// <summary>
        /// This object hold user details for both customer and business renderer(business owner);
        /// relevant information will be separated stored depending on whether the user is a customer or business
        /// the user can be both customer and business owner
        /// </summary>
        public int ID { get; set; }
        public string UserNames { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
       
        public string UserPassword { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserWhatsapp { get; set; }
        
        public string UserIDNo { get; set; }
        public string UserAdress { get; set; }
        public string UserCity { get; set; }
        public string  UserReferences { get; set; }
        public string UserQualifications { get; set; }
        public bool IsBusiness { get; set; }


        /// <summary>
        /// Construcor that will create a new user( default user will be created as customer).
        /// Will take the following parameters by default.
        /// </summary>
        /// <param name="names"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="city"></param>
        /// <param name="adress"></param>
        public UserModel(string names , string lastName , 
            string email , string password , string phoneNumber , string city , string adress)
        {
            this.UserNames = names;
            this.UserLastName = lastName;
            this.UserEmail = email;
            this.UserPassword=password;
            this.UserPhoneNumber = phoneNumber;
            this.UserCity = city;
            this.UserAdress = adress;

        }

        /// <summary>
        /// Model that will update the following user details if the user succesfully registers as a business
        /// </summary>
        /// <param name="idNumber"></param>
        /// <param name="references"></param>
        /// <param name="qualifications"></param>
        /// <param name="isBusiness"></param>
        public UserModel(int userID,string idNumber, string references , string qualifications , bool isBusiness)
        {
            this.ID = userID;
            this.UserIDNo = idNumber;
            this.UserReferences = references;
            this.UserQualifications = qualifications;
            this.IsBusiness = isBusiness;
        }

        public UserModel()
        {

        }



    }
}
