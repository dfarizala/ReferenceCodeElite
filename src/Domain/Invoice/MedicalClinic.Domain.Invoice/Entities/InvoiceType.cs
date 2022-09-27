using Spin.Connection.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Invoice.Entities
{
    class InvoiceType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public InvoiceType()
                : base("INVOICE_TYPE_ID", "Invoice")
        { }

        /// <summary>
        /// Invoice Type Id
        /// </summary>
        public int INVOICE_TYPE_ID { get; set; }
        /// <summary>
        /// Type Name
        /// </summary>
        public string TYPE_NAME { get; set; }
        /// <summary>
        /// Resolution
        /// </summary>
        public string RESOLUTION { get; set; }
        /// <summary>
        /// Active
        /// </summary>
        public bool ACTIVE { get; set; }
    }
}
