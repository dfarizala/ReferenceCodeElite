using System;
using System.Collections.Generic;
using Spin.Connection.Entity;
using Spin.Connection.Entity.Attribute;

namespace MedicalClinic.Domain.Pharmacy.Entities
{
    /// <summary>
    /// Movement of article or articles
    /// </summary>
    public class Movement : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Movement()
            : base("IdMovement", "Pharmacy")
        {
        }

        [ForeignKeySpin("IdArticle")]
        public List<ArticleItem> Articles { get; set; } = new List<ArticleItem>();

        [ForeignKeySpin("IdBatch")]
        public List<BatchItem> Batches { get; set; } = new List<BatchItem>();

        [ForeignKeySpin("IdStorage")]
        public List<StorageItem> Storages { get; set; } = new List<StorageItem>();

        /// <summary>
        /// Document Id, Header
        /// </summary>
        public int IdDocument { get; set; }

        /// <summary>
        /// Movement Type
        /// </summary>
        public string MovementType { get; set; }

        /// <summary>
        /// Movemente Date
        /// </summary>
        public DateTime MovementDate { get; set; }

        /// <summary>
        /// ArticleId
        /// </summary>
        public string IdArticle { get; set; }

        /// <summary>
        /// Quantity of Article in the movement
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>   
        /// Unitary Value
        /// </summary>
        public decimal UnitaryValue { get; set; }

        /// <summary>
        /// Total Value
        /// </summary>
        public decimal TotalValue { get; set; }

        /// <summary>
        /// Initial Quantity on Storage
        /// </summary>
        public int InitialQuantity { get; set; }

        /// <summary>
        /// Final Quantity on Storage
        /// </summary>
        public int FinalQuantity { get; set; }

        /// <summary>
        /// Annulated
        /// </summary>
        public bool Annulated { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Module
        /// </summary>
        public string Module { get; set; }

        /// <summary>
        /// Modification Date
        /// </summary>
        public DateTime ModificationDate { get; set; }

        /// <summary>
        /// Debit Id
        /// </summary>
        public int DebitId { get; set; }

        /// <summary>
        /// BatchId
        /// </summary>
        
        public string BatchId { get; set; }

        /// <summary>
        /// Crossed - Validated
        /// </summary>
        public bool Crossed { get; set; }

        /// <summary>
        /// Initial Batch Quantity
        /// </summary>
        public int InitialBatchQuantity { get; set; }

        /// <summary>
        /// Final Batch Quantity
        /// </summary>
        public int FinalBatchQuantity { get; set; }

        /// <summary>
        /// StorageId
        /// </summary>
        public string StorageId { get; set; }

        /// <summary>
        /// Billed
        /// </summary>
        public bool Billed { get; set; }

        /// <summary>
        /// ChargebackId
        /// </summary>        
        public int ChargebackId { get; set; }
    }
}
