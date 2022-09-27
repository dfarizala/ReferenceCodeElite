using System;
using MedicalClinic.Domain.Security.Interfaces;

namespace MedicalClinic.Domain.Security.Entities
{
    /// <summary>
    /// User 
    /// </summary>
    public class User: IUser
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// User Name 
        /// </summary>
        public string UserName { get; set; }


        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Image User
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
    }
}
