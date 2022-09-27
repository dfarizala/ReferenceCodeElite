using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Pharmacy.DTO.Response;
using MedicalClinic.Domain.Pharmacy.Entities.Request;
using MedicalClinic.Domain.Pharmacy.Entities.Response;
using MedicalClinic.Domain.Pharmacy.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;
using Spin.Base.Route;
using Spin.Modules.Entity.Controllers;

namespace Spin.Module.Pharmacy.Api.Controllers
{
    [SpinRoute("Api/Pharmacy", "Api", "Pharmacy", "Pharmacy")]
    [ControllerInformation("Estate")]
    public class PharmacyController: SpinControllerApi
    {
        private IPharmacyApplication _PharmacyApplciation;


        public PharmacyController(IPharmacyApplication PharmacyApplciation)
        {
            _PharmacyApplciation = PharmacyApplciation;
        }


        [HttpPost("GetPharmacy")]
        async public Task<Response<ResponseSinglePharmacyDto>> GetPharmacy([FromBody] RequestPharmacy request)
        {

            return  await _PharmacyApplciation.GetPharmacy(request);
        }

       
    }
}
