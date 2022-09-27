using System;
using System.Threading.Tasks;
using MediatR;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Invoice.DTO.Response;
using MedicalClinic.Domain.Invoice.CQRS.Queries.Request;
using MedicalClinic.Domain.Invoice.CQRS.Queries.Response;
using MedicalClinic.Domain.Invoice.Entities.Request;
using MedicalClinic.Domain.Invoice.Entities.Response;
using MedicalClinic.Domain.Invoice.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;
using Spin.Helper.Injection;

namespace MedicalClinic.Application.Invoice
{
    /// <summary>
    /// Application logic about invoice
    /// </summary>
    public class InvoiceApplication : IInvoiceApplication
    {
        /// <summary>
        /// Executer orchestrattor
        /// </summary>
        public IExecutorOrchestrator _executor;


        public InvoiceApplication(IExecutorOrchestrator executor)
        {
            _executor = executor;
        }


        /// <summary>
        /// Get Single Invoice
        /// </summary>
        /// <param AccountID="id">Code Invoice</param>
        /// <returns></returns>

        async public Task<ResponseSingleInvoice> GetSingleInvoice(RequestSingleInvoice request)
            => await _executor.ProcessAndMap<RequestSingleInvoice, RequestSingleInvoiceQuery, ResponseSingleInvoice, ResponseSingleInvoiceQuery>(request);

        /// <summary>
        /// Get Multiple Invoices
        /// </summary>
        /// <param PatientID="id">Patient ID</param>
        /// <param PatientDocType="id">Patient Document Type</param>
        /// <param PatientDocNumber="id">PAtient Document Number</param>
        /// <returns></returns>

        async public Task<ResponseMultipleInvoice> GetMultipleeInvoice(RequestMultipleInvoice request)
            => await _executor.ProcessAndMap<RequestMultipleInvoice, RequestMultipleInvoiceQuery, ResponseMultipleInvoice, ResponseMultipleInvoiceQuery>(request);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        async public Task<ResponseCreateAccount> GetCreateAccount(RequestCreateAccount request)
            => await _executor.ProcessAndMap<RequestCreateAccount, RequestCreateAccountQuery, ResponseCreateAccount, ResponseCreateAccountQuery>(request);

        /// <summary>
        /// Aborts active Invoice
        /// </summary>
        /// <param AccountID="id">Code Invoice</param>
        /// <returns></returns>
        async public Task<ResponseAbortInvoice> AbortInvoice(RequestAbortInvoice request)
            => await _executor.ProcessAndMap<RequestAbortInvoice, RequestAbortInvoiceQuery, ResponseAbortInvoice, ResponseAbortInvoiceQuery>(request);
        /// <summary>
        /// Aborts active Invoice
        /// </summary>
        /// <param AccountID="id">Code Invoice</param>
        /// <returns></returns>
        async public Task<ResponseAddNewArticle> AddNewArticle(RequestAddNewArticle request)
            => await _executor.ProcessAndMap<RequestAddNewArticle, RequestAddNewArticleQuery, ResponseAddNewArticle, ResponseAddNewArticleQuery>(request);
    }
}