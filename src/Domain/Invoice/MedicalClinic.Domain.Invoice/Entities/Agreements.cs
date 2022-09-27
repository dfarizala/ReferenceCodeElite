using Spin.Connection.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Invoice.Entities
{
    class Agreements : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Agreements()
                : base("AGREEMENT_ID", "Invoice")
        { }

        /// <summary>
        /// Agreements Id
        /// </summary>
        public int AGREEMENT_ID { get; set; }
        /// <summary>
        /// Agreements Name
        /// </summary>
        public string AGREEMENT_NAME { get; set; }
        /// <summary>
        /// Responsible Id
        /// </summary>
        public int RESPONSIBLE_ID { get; set; }
    }
}
