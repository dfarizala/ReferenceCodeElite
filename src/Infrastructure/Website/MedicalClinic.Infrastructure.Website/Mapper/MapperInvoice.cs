using AutoMapper;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.DTO;
using MedicalClinic.Domain.Security.Entities.Request;
using MedicalClinic.Domain.Security.Entities.Response;
using MedicalClinic.Domain.Website.DTO.Request.Security;
using MedicalClinic.Domain.Website.DTO.Response.Security;

namespace MedicalClinic.Infrastructure.Invoice.Mapper
{
    public class MapperInvoice: Profile
    {
        public MapperInvoice()
        {
            #region Request
            CreateMap<RequestLogin, RequestLoginDto>().ReverseMap();
            CreateMap<ResponseLogin, ResponseLoginDto>().ReverseMap();
            #endregion Request

        }
    }
}
