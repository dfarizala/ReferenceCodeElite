using Spin.Connection.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Invoice.Entities
{
    class CUPS : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public CUPS()
                : base("CUPS_ID", "Invoice")
        { }

        /// <summary>
        /// Cups Id
        /// </summary>
        public int CUPS_ID { get; set; }
        /// <summary>
        /// Cups Code
        /// </summary>
        public string CUPS_CODE { get; set; }
        /// <summary>
        /// Cups Description
        /// </summary>
        public string CUPS_DESCRIPTION { get; set; }
            
    }
}
