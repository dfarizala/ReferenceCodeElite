using Spin.Connection.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Invoice.Entities
{
    class Rates : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Rates()
                : base("RATE_ID", "Invoice")
        { }

        /// <summary>
        /// Rate Id
        /// </summary>
        public int RATE_ID { get; set; }
        /// <summary>
        /// Rate Type
        /// </summary>
        public string RATE_TYPE { get; set; }
        /// <summary>
        /// Rate Code 
        /// </summary>
        public int RATE_CODE { get; set; }
        /// <summary>
        /// Rate Desc
        /// </summary>
        public int RATE_DESC { get; set; }
    }
}
