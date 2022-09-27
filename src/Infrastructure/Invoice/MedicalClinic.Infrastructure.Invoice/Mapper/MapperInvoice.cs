using System;
using System.Collections.Generic;
using AutoMapper;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.CQRS.Queries.Request;
using MedicalClinic.Domain.Invoice.CQRS.Queries.Response;
using MedicalClinic.Domain.Invoice.DTO;
using MedicalClinic.Domain.Invoice.DTO.Request;
using MedicalClinic.Domain.Invoice.DTO.Response;
using MedicalClinic.Domain.Invoice.Entities;
using MedicalClinic.Domain.Invoice.Entities.Request;
using MedicalClinic.Domain.Invoice.Entities.Response;

namespace MedicalClinic.Infrastructure.Invoice.Mapper
{
    public class MapperInvoice: Profile
    {
        public MapperInvoice()
        {
            #region Request
            //CreateMap<InvoiceItem, InvoiceDto>().ReverseMap();
            //CreateMap<ResponseSingleInvoice, ResponseSingleInvoiceDto>().ReverseMap();
            //CreateMap<Response<ResponseSingleInvoice>, Response<ResponseSingleInvoiceDto>>().ReverseMap();

            CreateMap<RequestSingleInvoice, RequestSingleInvoiceQuery>().ReverseMap();
            CreateMap<ResponseSingleInvoice, ResponseSingleInvoiceQuery>().ReverseMap();
            CreateMap<AccountHeader, ResponseSingleInvoiceQuery>().ReverseMap();

            CreateMap<RequestMultipleInvoice, RequestMultipleInvoiceQuery>().ReverseMap();
            CreateMap<ResponseMultipleInvoice, ResponseMultipleInvoiceQuery>().ReverseMap();            

            CreateMap<RequestCreateAccount, RequestCreateAccountQuery>().ReverseMap();
            CreateMap<ResponseCreateAccount, ResponseCreateAccountQuery>().ReverseMap();

            CreateMap<RequestAbortInvoice, RequestAbortInvoiceQuery>().ReverseMap();
            CreateMap<ResponseAbortInvoice, ResponseAbortInvoiceQuery>().ReverseMap();

            CreateMap<RequestAddNewArticle, RequestAddNewArticleQuery>().ReverseMap();
            CreateMap<ResponseAddNewArticle, ResponseAddNewArticleQuery>().ReverseMap();

            #endregion Request

        }
    }
}
