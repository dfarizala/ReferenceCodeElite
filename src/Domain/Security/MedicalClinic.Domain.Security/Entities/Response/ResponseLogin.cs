using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Security.Entities.Response
{
    /// <summary>
    /// Rquest Login 
    /// </summary>
    public class ResponseLogin: ResponseApi
    {
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; set; }
    }
}
