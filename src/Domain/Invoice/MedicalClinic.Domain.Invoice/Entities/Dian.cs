using Spin.Connection.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Invoice.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Dian : BaseEntity
        {
            public Dian()
                : base("DIAN_ID", "Invoice")
            { }

        /// <summary>
        /// Dian ID
        /// </summary>
        public int DIAN_ID { get; set; }
        /// <summary>
        /// Account Header ID
        /// </summary>
        public int ACCOUNT_HEADER_ID { get; set; }
        /// <summary>
        /// Dian Code
        /// </summary>
        public decimal DIAN_CODE { get; set; }
        /// <summary>
        /// Xml Path
        /// </summary>
        public string XML_PATH { get; set; }
        /// <summary>
        /// Xml Path Red
        /// </summary>
        public string XML_PATH_RED { get; set; }
        /// <summary>
        /// Invoice Type
        /// </summary>
        public int INVOICE_TYPE { get; set; }
        /// <summary>
        /// Sent To Dian
        /// </summary>
        public bool SENT_TO_DIAN { get; set; }
        /// <summary>
        /// Definition of cufe
        /// </summary>
        public string CUFE_DEF { get; set; }
        /// <summary>
        /// Encrypted cufe
        /// </summary>
        public string CUFE_VR { get; set; }
        /// <summary>
        /// Trackif
        /// </summary>
        public string TRACKIF { get; set; }





    }
}
