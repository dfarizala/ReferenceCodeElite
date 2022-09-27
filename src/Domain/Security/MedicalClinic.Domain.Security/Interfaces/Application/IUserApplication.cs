using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Security.Entities.Request;
using MedicalClinic.Domain.Security.Entities.Response;

namespace MedicalClinic.Domain.Security.Interfaces.Application
{
    /// <summary>
    /// Interface User App
    /// </summary>
    public interface IUserApplication
    {
        /// <summary>
        /// Task of Login
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ResponseLogin> Login(RequestLogin request);

        /// <summary>
        /// Task for restore password
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ResponseRestorePassword> RestorePassword(RequestRestorePassword request);

        /// <summary>
        /// Task of user's password update
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ResponseUpdatePassword> UpdatePassword(RequestUpdatePassword request);
    }
}
