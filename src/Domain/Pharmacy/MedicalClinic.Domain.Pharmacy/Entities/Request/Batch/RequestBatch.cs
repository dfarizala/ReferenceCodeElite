using System;
using MediatR;
using MedicalClinic.Domain.Pharmacy.Entities.Response.Batch;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Pharmacy.Entities.Request.Batch
{
    /// <summary>
    /// Request of Batch
    /// </summary>
    public class RequestBatch : IRequest<Response<ResponseBatch>>
    {
        /// <summary>
        /// Constructor of Request Batch
        /// </summary>
        public RequestBatch()
        {
        }

        /// <summary>
        /// ID of batch
        /// </summary>
        public int IdBatch { get; set; }
    }
}
