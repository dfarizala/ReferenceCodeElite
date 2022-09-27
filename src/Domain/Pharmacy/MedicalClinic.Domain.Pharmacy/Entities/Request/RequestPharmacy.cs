using System;
using MediatR;
using MedicalClinic.Domain.Pharmacy.Entities.Response;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Pharmacy.Entities.Request
{
    public class RequestPharmacy : IRequest<Response<ResposeSinglePharmacy>>
    {
        public RequestPharmacy()
        {
        }

        public int Id { get; set; }
    }
}
