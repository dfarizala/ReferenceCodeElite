using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.LogsImhotep.Entities.Request;
using MedicalClinic.Domain.LogsImhotep.Entities.Response;
using MedicalClinic.Domain.LogsImhotep.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;
using Spin.Base.Route;
using Spin.Modules.Entity.Controllers;

namespace Spin.Module.LogImhotep.Api.Controllers
{
    [SpinRoute("Api/Log", "Api", "LogImhotep", "Log")]
    [ControllerInformation("LogImhotep")]
    public class LogController: SpinControllerApi
    {
        private ILogImhotepApplication _logImhoteApplciation;


        public LogController(ILogImhotepApplication invoiceApplciation)
        {
            _logImhoteApplciation = invoiceApplciation;
        }


        [HttpPost("SaveLog")]
        async public Task<ResponseLogImhotep> GetInvoice([FromBody] RequestLogImhotep request)
        {

            return  await _logImhoteApplciation.SaveLog(request);
        }

       
    }
}
