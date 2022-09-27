using System;
namespace MedicalClinic.Domain.Invoice.DTO.Response
{
    public class ResponseSingleInvoiceDto
    {
        public ResponseSingleInvoiceDto()
        {
        }

        public InvoiceDto Item { get; set; }
    }
}
