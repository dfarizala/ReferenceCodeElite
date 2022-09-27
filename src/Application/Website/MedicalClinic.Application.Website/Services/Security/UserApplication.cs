using System.Threading.Tasks;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Security.Entities.Request;
using MedicalClinic.Domain.Security.Entities.Response;
using MedicalClinic.Domain.Website.DTO.Request.Security;
using MedicalClinic.Domain.Website.DTO.Response.Security;
using MedicalClinic.Domain.Website.Interfaces.Application.Security;

namespace MedicalClinic.Application.Invoice
{
    /// <summary>
    /// Application logic about invoice
    /// </summary>
    public class UserApplication: IUserApplication
    {
        /// <summary>
        /// Executer orchestrattor
        /// </summary>
        private readonly IExecutorOrchestrator _executor;


        public UserApplication(IExecutorOrchestrator executor)
        {
            _executor = executor;
        }


        /// <summary>
        /// Login
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        async public Task<ResponseLogin> Login(RequestLogin request)
            => await _executor.ProcessAndMap< RequestLogin, RequestLoginDto, ResponseLogin, ResponseLoginDto> (request);

        /// <summary>
        /// Restore password
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        async public Task<ResponseRestorePassword> RestorePassword(RequestRestorePassword request)
            => await _executor.ProcessAndMap<RequestRestorePassword, RequestRestorePasswordDto, ResponseRestorePassword, ResponseRestorePasswordDto>(request);

        /// <summary>
        /// Update password
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        async public Task<ResponseUpdatePassword> UpdatePassword(RequestUpdatePassword request)
            => await _executor.ProcessAndMap<RequestUpdatePassword, RequestUpdatePasswordDto, ResponseUpdatePassword, ResponseUpdatePasswordDto>(request);
    }
}
