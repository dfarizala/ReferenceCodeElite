using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Pharmacy.DTO.Response;
using MedicalClinic.Domain.Pharmacy.Entities.Request;

namespace MedicalClinic.Domain.Pharmacy.Interfaces.Application
{
    public interface IPharmacyApplication
    {
        Task<Response<ResponseSinglePharmacyDto>> GetPharmacy(RequestPharmacy request);
    }

    
}
