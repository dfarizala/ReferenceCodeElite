using Spin.Connection.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Invoice.Entities
{
    public class Responsible : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Responsible()
                : base("RESPONSIBLE_ID", "Invoice")
        { }

        /// <summary>
        /// Responsible Id
        /// </summary>
        public int RESPONSIBLE_ID { get; set; }
        /// <summary>
        /// Responsible Name
        /// </summary>
        public string RESPONSIBLE_NAME { get; set; }
        /// <summary>
        /// Responsible Nit
        /// </summary>
        public string RESPONSIBLE_NIT { get; set; }
        /// <summary>
        /// Responsible Code
        /// </summary>
        public string RESPONSIBLE_CODE { get; set; }
    }
}
