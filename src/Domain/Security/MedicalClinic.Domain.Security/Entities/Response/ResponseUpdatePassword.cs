using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Security.Entities.Response
{
    /// <summary>
    /// Response for update password request
    /// </summary>
    public class ResponseUpdatePassword : ResponseApi
    {
        /// <summary>
        /// Returns true or false at update password
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
    }
}
