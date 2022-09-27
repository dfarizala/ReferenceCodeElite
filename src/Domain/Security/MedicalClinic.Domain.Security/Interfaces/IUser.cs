using System;
namespace MedicalClinic.Domain.Security.Interfaces
{
    /// <summary>
    /// Interface User
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// User Name 
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// First Name User
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Last Name User
        /// </summary>
        string LastName { get; set; }


        /// <summary>
        /// Imagen User
        /// </summary>
        string Image { get; set; }

    }
}
