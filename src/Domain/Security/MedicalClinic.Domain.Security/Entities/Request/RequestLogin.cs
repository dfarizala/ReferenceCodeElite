using System;
namespace MedicalClinic.Domain.Security.Entities.Request
{
    /// <summary>
    /// Request Login 
    /// </summary>
    public class RequestLogin
    {
        /// <summary>
        /// User Name 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }
    }
}
