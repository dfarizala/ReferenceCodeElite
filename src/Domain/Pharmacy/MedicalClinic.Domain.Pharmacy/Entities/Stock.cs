using System;
using System.Collections.Generic;
using Spin.Connection.Entity;
using Spin.Connection.Entity.Attribute;

namespace MedicalClinic.Domain.Pharmacy.Entities
{
    /// <summary>
    /// Stock Storage - Detail
    /// </summary>
    public class StockItem : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public StockItem()
            :base("IdStock","Pharmacy")
        {
        }

        [ForeignKeySpin("IdStorage")]
        public List<StorageItem> Storages { get; set; } = new List<StorageItem>();

        [ForeignKeySpin("IdArticle")]
        public List<ArticleItem> Articles { get; set; } = new List<ArticleItem>();

        /// <summary>
        /// Id Storage
        /// </summary>
        public int IdStorage { get; set; }

        /// <summary>
        /// Id Article
        /// </summary>
        public string ArticleCode { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Stock Active
        /// </summary>
        public bool Active { get; set; }
    }
}
