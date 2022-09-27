using System;
using Spin.Connection.Entity;

namespace MedicalClinic.Domain.Invoice.Entities
{
    /// <summary>
    /// Invoice Item
    /// </summary>
    public class InvoiceItem : BaseEntity
    {
        /// <summary>
        /// Basic Consructor
        /// </summary>
        public InvoiceItem()
            : base("IdInvoice", "Invoice")
        {
        }

        /// <summary>
        /// Name Customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Code External system
        /// </summary>
        public string  InternalCode { get; set; }
    }
}
