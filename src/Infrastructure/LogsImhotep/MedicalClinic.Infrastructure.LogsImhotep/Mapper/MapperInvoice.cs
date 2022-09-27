using AutoMapper;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.LogsImhotep.CQRS.Commands;
using MedicalClinic.Domain.LogsImhotep.Entities;
using MedicalClinic.Domain.LogsImhotep.Entities.Request;
using MedicalClinic.Domain.LogsImhotep.Entities.Response;

namespace MedicalClinic.Infrastructure.Invoice.Mapper
{
    public class MapperInvoice: Profile
    {
        public MapperInvoice()
        {
            #region Request
            CreateMap<RequestLogImhotep, SaveLogRequestCommand>().ReverseMap();
            CreateMap<SaveLogRequestCommand, LogImhotep>().ReverseMap();
            CreateMap<ResponseLogImhotep, SaveLogResponseCommand>().ReverseMap();
            CreateMap<SaveLogResponseCommand, ResponseLogImhotep>().ReverseMap();


            #endregion Request

        }
    }
}
