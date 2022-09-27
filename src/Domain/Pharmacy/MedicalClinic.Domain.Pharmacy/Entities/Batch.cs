using System;
using System.Collections.Generic;
using Spin.Connection.Entity;
using Spin.Connection.Entity.Attribute;

namespace MedicalClinic.Domain.Pharmacy.Entities
{
    /// <summary>
    /// Batch of articles
    /// </summary>
    public class BatchItem : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BatchItem()
            : base("IdBatch", "Pharmacy")
        {
        }

        [ForeignKeySpin("IdStorage")]
        public List<StorageItem> Storages { get; set; } = new List<StorageItem>();

        [ForeignKeySpin("IdArticle")]
        public List<ArticleItem> Articles { get; set; } = new List<ArticleItem>();

        /// <summary>
        /// Internal Code of article
        /// </summary>
        public string ArticleCode { get; set; }

        /// <summary>
        /// Batch of supplier
        /// </summary>
        public string BatchDetail { get; set; }

        /// <summary>
        /// Expiration Date of meds
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Sanitary Registry Code
        /// </summary>
        public string SanitaryRegistry { get; set; }

        /// <summary>
        /// Unique National Meds Code
        /// </summary>
        public string Cum { get; set; }

        /// <summary>
        /// Amount of Meds
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Internal Code of Storage
        /// </summary>
        public int IdStorage { get; set; }
    }
}
