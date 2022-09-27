using System;
using MedicalClinic.Domain.Common.Wrappers;
namespace MedicalClinic.Domain.Website.DTO.Response.Security
{
    /// <summary>
    /// Response user's password update
    /// </summary>
    public class ResponseUpdatePasswordDto : ResponseApi
    {
        /// <summary>
        /// Password updated Y/N
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// User's mail
        /// </summary>
        public string Email { get; set; }
    }
}
