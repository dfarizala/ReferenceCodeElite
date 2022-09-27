using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Security.CQRS.Queries.Request;
using MedicalClinic.Domain.Security.CQRS.Queries.Response;
using MedicalClinic.Domain.Security.CQRS.Commands.Request;
using MedicalClinic.Domain.Security.CQRS.Commands.Response;
using MedicalClinic.Domain.Security.Entities.Request;
using MedicalClinic.Domain.Security.Entities.Response;
using MedicalClinic.Domain.Security.Interfaces.Application;

namespace MedicalClinic.Application.Security.Services
{
    /// <summary>
    /// Application User
    /// </summary>
    public class UserApplication:IUserApplication
    {
        /// <summary>
        /// Orchestrator Application
        /// </summary>
        private readonly IExecutorOrchestrator _executor;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="executor"></param>
        public UserApplication(IExecutorOrchestrator executor)
        {
            this._executor = executor;
        }

        /// <summary>
        /// Login User
        /// </summary>
        /// <param name="request">Information user for login</param>
        /// <returns>Basic Inforamtion to user</returns>
        async public Task<ResponseLogin> Login(RequestLogin request)
            => await _executor.ProcessAndMap<RequestLogin, RequestLoginQuery, ResponseLogin, ResponseLoginQuery>(request);

        /// <summary>
        /// Restore password
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        async public Task<ResponseRestorePassword> RestorePassword(RequestRestorePassword request)        
            => await _executor.ProcessAndMap<RequestRestorePassword, RequestRestorePasswordQuery, ResponseRestorePassword, ResponseRestorePasswordQuery>(request);

        /// <summary>
        /// Update password
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        async public Task<ResponseUpdatePassword> UpdatePassword(RequestUpdatePassword request)
            => await _executor.ProcessAndMap<RequestUpdatePassword, RequestUpdatePasswordCommand, ResponseUpdatePassword, ResponseUpdatePasswordCommand>(request);
    }
}
