using System;
using MedicalClinic.Domain.Common.Wrappers;


namespace MedicalClinic.Domain.Security.Entities.Response
{
    /// <summary>
    /// Response for restore password request
    /// </summary>
    public class ResponseRestorePassword : ResponseApi
    {
        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
    }
}
