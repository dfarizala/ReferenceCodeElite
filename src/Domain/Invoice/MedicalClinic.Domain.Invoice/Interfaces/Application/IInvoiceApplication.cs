using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.DTO.Response;
using MedicalClinic.Domain.Invoice.Entities;
using MedicalClinic.Domain.Invoice.Entities.Request;
using MedicalClinic.Domain.Invoice.Entities.Response;

namespace MedicalClinic.Domain.Invoice.Interfaces.Application
{
    public interface IInvoiceApplication
    {
        //Task<Response<ResponseSingleInvoiceDto>> GetInvoice(RequestInvoice request);
        Task<ResponseSingleInvoice> GetSingleInvoice(RequestSingleInvoice request);
        Task<ResponseMultipleInvoice> GetMultipleeInvoice(RequestMultipleInvoice request);
        Task<ResponseCreateAccount> GetCreateAccount(RequestCreateAccount request);
        Task<ResponseAbortInvoice> AbortInvoice(RequestAbortInvoice request);
        Task<ResponseAddNewArticle> AddNewArticle(RequestAddNewArticle request);
    }
}
