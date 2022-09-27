using System;
using AutoMapper;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Pharmacy.DTO;
using MedicalClinic.Domain.Pharmacy.DTO.Request;
using MedicalClinic.Domain.Pharmacy.DTO.Request.Article;
using MedicalClinic.Domain.Pharmacy.DTO.Request.Batch;
using MedicalClinic.Domain.Pharmacy.DTO.Response.Batch;
using MedicalClinic.Domain.Pharmacy.Entities;
using MedicalClinic.Domain.Pharmacy.Entities.Request;
using MedicalClinic.Domain.Pharmacy.Entities.Request.Batch;
using MedicalClinic.Domain.Pharmacy.Entities.Request.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Response;
using MedicalClinic.Domain.Pharmacy.DTO.Response;
using MedicalClinic.Domain.Pharmacy.Entities.Response.Batch;
using MedicalClinic.Domain.Pharmacy.Entities.Response.Article;
using MedicalClinic.Domain.Pharmacy.DTO.Response.Article;

namespace MedicalClinic.Infrastructure.Pharmacy.Mapper
{
    public class MapperPharmacy: Profile
    {
        public MapperPharmacy()
        {
            #region Request
            CreateMap<RequestPharmacy, RequestPharmacyDto>().ReverseMap();
            CreateMap<RequestArticle, RequestArticleDto>().ReverseMap();
            CreateMap<RequestBatch, RequestBatchDto>().ReverseMap();
            CreateMap<PharmacyItem, PharmacyDto>().ReverseMap();
            #endregion Request
            #region Response
            CreateMap<ResposeSinglePharmacy, ResponseSinglePharmacyDto>().ReverseMap();
            CreateMap<Response<ResposeSinglePharmacy>, Response<ResponseSinglePharmacyDto>>().ReverseMap();
            CreateMap<Response<ResponseArticle>, Response<ResponseArticleDto>>().ReverseMap();
            CreateMap<Response<ResponseBatch>, Response<ResponseBatchDto>>().ReverseMap();
            #endregion Response

        }
    }
}
