using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.DTO.Response;
using MedicalClinic.Domain.Invoice.Entities.Request;
using MedicalClinic.Domain.Invoice.Entities.Response;
using MedicalClinic.Domain.Invoice.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;
using Spin.Base.Route;
using Spin.Modules.Entity.Controllers;

namespace Spin.MedicalClinic.Invoice.Spin.Module.Invoice.Api.Controllers
{
    [SpinRoute("Api/Invoice", "Api", "Invoice", "Invoice")]
    [ControllerInformation("Estate")]
    public class InvoiceController: SpinControllerApi
    {
        private IInvoiceApplication _invoiceApplciation;


        public InvoiceController(IInvoiceApplication invoiceApplciation)
        {
            _invoiceApplciation = invoiceApplciation;
        }

        [HttpPost("GetSingleInvoice")]
        async public Task<ResponseSingleInvoice> GetSingleInvoice([FromBody] RequestSingleInvoice request)
        {
            return await _invoiceApplciation.GetSingleInvoice(request);
        }

        [HttpPost("GetMultipleInvoice")]
        async public Task<ResponseMultipleInvoice> GetMultipleInvoice([FromBody] RequestMultipleInvoice request)
        {
            return await _invoiceApplciation.GetMultipleeInvoice(request);
        }

        [HttpPost("GetCreateAccount")]
        async public Task<ResponseCreateAccount> GetCreateAccount([FromBody] RequestCreateAccount request)
        {
            return await _invoiceApplciation.GetCreateAccount(request);
        }

        [HttpPost("AbortInvoice")]
        async public Task<ResponseAbortInvoice> AbortInvoice([FromBody] RequestAbortInvoice request)
        {
            return await _invoiceApplciation.AbortInvoice(request);
        }
        [HttpPost("AddNewArticle")]
        async public Task<ResponseAddNewArticle> AddNewArticle([FromBody] RequestAddNewArticle request)
        {
            return await _invoiceApplciation.AddNewArticle(request);
        }

    }
}
