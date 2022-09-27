using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Security.Entities.Request
{
    /// <summary>
    /// Resquest for update passwor
    /// </summary>
    public class RequestUpdatePassword
    {
        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Token with user's information
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// Password to establish on the User
        /// </summary>
        public string NewPassword { get; set; }
    }
}
