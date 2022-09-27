using MedicalClinic.Domain.Common.Wrappers;
using System;

namespace MedicalClinic.Domain.Security.Entities.Request
{
    /// <summary>
    /// Request for restore password
    /// </summary>
    public class RequestRestorePassword
    {
        /// <summary>
        /// Required email for send token for restore password
        /// </summary>
        public string Email { get; set; }
    }
}
