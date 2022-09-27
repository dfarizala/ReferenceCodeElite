using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Security.Entities.Response;
using MedicalClinic.Domain.Security.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;
using Spin.Base.Route;
using Spin.Modules.Entity.Controllers;

namespace Spin.MedicalClinic.Security.Spin.Module.Security.Api.Controllers
{
    /// <summary>
    /// Security Api
    /// </summary>
    [SpinRoute("Api/Security", "Api", "Security", "Security")]
    [ControllerInformation("Security")]
    public class SecurityController : SpinControllerApi
    {
        /// <summary>
        /// Application Security
        /// </summary>
        private IUserApplication _application;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="application">Application</param>
        public SecurityController(IUserApplication application)
        {
            this._application = application;
        }

        /// <summary>
        /// Login User
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        [HttpPost("Login/{user}/{password}")]
        async public Task<ResponseLogin> Login(string user, string password)
            => await _application.Login(new() { UserName = user, Password = password });

        /// <summary>
        /// Restore password request
        /// </summary>
        /// <param name="Email">User's Mail</param>
        /// <returns></returns>
        [HttpPost("RestorePassword/{Email}")]
        async public Task<ResponseRestorePassword> RestorePassword(string Email)
            => await _application.RestorePassword(new() { Email = Email });

        /// <summary>
        /// Update password from request
        /// </summary>
        /// <param name="Email">User's mail</param>
        /// <param name="token">Token for validation</param>
        /// <param name="NewPassword">New password of the user</param>
        /// <returns></returns>
        [HttpPost("UpdatePassword/{Email}/{token}/{NewPassword}")]
        async public Task<ResponseUpdatePassword> UpdatePassword(string Email, string token, string NewPassword)
            => await _application.UpdatePassword(new() { Email = Email, token = token, NewPassword = NewPassword });
        
    }
}
