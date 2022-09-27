using Spin.Connection.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Invoice.Entities
{
    public class Articles : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Articles()
                : base("ARTICLE_ID", "Invoice")
        { }

        /// <summary>
        /// Agreements Id
        /// </summary>
        public int ARTICLE_ID { get; set; }
        /// <summary>
        /// Agreements Name
        /// </summary>
        public string ARTICLE_CODE { get; set; }
        /// <summary>
        /// Responsible Id
        /// </summary>
        public int ARTICLE_DESC { get; set; }
    }
}
