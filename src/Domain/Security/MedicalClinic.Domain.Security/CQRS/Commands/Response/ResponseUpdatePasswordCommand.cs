using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Security.CQRS.Commands.Response
{
    /// <summary>
    /// Response for updated password request
    /// </summary>
    public class ResponseUpdatePasswordCommand : ResponseApi
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
