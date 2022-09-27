using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Website.DTO.Response.Security
{
    /// <summary>
    /// Response for restore password request
    /// </summary>
    public class ResponseRestorePasswordDto : ResponseApi
    {
        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
    }
}
