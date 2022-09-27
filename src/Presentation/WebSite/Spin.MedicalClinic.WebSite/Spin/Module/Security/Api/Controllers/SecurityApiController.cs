using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Security.Entities.Request;
using MedicalClinic.Domain.Security.Entities.Response;
using MedicalClinic.Domain.Website.Interfaces.Application.Security;
using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;
using Spin.Base.Route;
using Spin.Modules.Entity.Controllers;

namespace Spin.MedicalClinic.WebSite.Spin.Module.Security.Api.Controllers
{
    [SpinRoute("Api/Security", "Api", "Security", "Security")]
    [ControllerInformation("Security")]
    public class SecurityApiController : SpinControllerApi
    {
        /// <summary>
        /// Application Security
        /// </summary>
        private IUserApplication _application;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="application">Application</param>
        public SecurityApiController(IUserApplication application)
        {
            this._application = application;
        }


        /// <summary>
        /// Login User
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        [HttpPost("Login")]
        async public Task<ResponseLogin> Login([FromBody]RequestLogin request)
            => await _application.Login(request);

        /// <summary>
        /// Restore user's password
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("RestorePassword")]
        async public Task<ResponseRestorePassword> RestorePassword([FromBody] RequestRestorePassword request)
            => await _application.RestorePassword(request);

        /// <summary>
        /// Update user's password
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("UpdatePassword")]
        async public Task<ResponseUpdatePassword> UpdatePassword([FromBody] RequestUpdatePassword request)
            => await _application.UpdatePassword(request);
    }
}
