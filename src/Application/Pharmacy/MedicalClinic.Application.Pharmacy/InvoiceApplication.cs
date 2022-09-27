using System;
using System.Threading.Tasks;
using MediatR;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Pharmacy.DTO.Response;
using MedicalClinic.Domain.Pharmacy.Entities.Request;
using MedicalClinic.Domain.Pharmacy.Entities.Response;
using MedicalClinic.Domain.Pharmacy.Entities.Request.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Request.Batch;
using MedicalClinic.Domain.Pharmacy.Entities.Response.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Response.Batch;
using MedicalClinic.Domain.Pharmacy.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;
using Spin.Helper.Injection;

namespace MedicalClinic.Application.Pharmacy
{
    /// <summary>
    /// Application logic about Pharmacy
    /// </summary>
    public class PharmacyApplication : IPharmacyApplication
    {
        /// <summary>
        /// Executer orchestrattor
        /// </summary>
        private readonly IExecutorOrchestrator _executor;


        public PharmacyApplication(IExecutorOrchestrator executor)
        {
            _executor = executor;
        }

        /// <summary>
        /// Get Pharmacy
        /// </summary>
        /// <param name="id">Code Pharmacy</param>
        /// <returns></returns>
        async public Task<Response<ResponseSinglePharmacyDto>> GetPharmacy(RequestPharmacy request)
        {
            Response<ResponseSinglePharmacyDto> response = null;
            try
            {
                //var aaa = SpinServiceCollection.ServiceProvider.GetRequiredService<IMediator>();

                response = await _executor.ProcessAndMap<RequestPharmacy, Response<ResponseSinglePharmacyDto>, Response<ResposeSinglePharmacy>>(request);
            }
            catch (Exception ex)
            {

            }

            return response;
        }
    }
}
