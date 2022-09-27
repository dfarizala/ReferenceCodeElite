using System;
using MediatR;
using MedicalClinic.Domain.Website.DTO.Response.Security;

namespace MedicalClinic.Domain.Website.DTO.Request.Security
{
    /// <summary>
    /// Request Login Dto
    /// </summary>
    public class RequestLoginDto: IRequest<ResponseLoginDto>
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
