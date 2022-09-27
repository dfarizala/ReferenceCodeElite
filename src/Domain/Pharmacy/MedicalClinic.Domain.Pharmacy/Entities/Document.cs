using System;
using System.Collections.Generic;
using Spin.Connection.Entity;
using Spin.Connection.Entity.Attribute;

namespace MedicalClinic.Domain.Pharmacy.Entities
{
    /// <summary>
    /// Document - Header of Movements
    /// </summary>
    class Document : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Document()
            : base("IdDocument", "Pharmacy")
        {
        }

        /// <summary>
        /// Movement Type
        /// </summary>
        public string MovementType { get; set; }

        /// <summary>
        /// Document Type
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// Admission Number
        /// </summary>
        public int AdmissionNumber { get; set; }

        /// <summary>
        /// Service - Assistencial Dependency
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Subservice
        /// </summary>
        public string Subservice { get; set; }

        /// <summary>
        /// Document Date
        /// </summary>
        public DateTime DocumentDate { get; set; }

        /// <summary>
        /// Document Details
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Annulled
        /// </summary>
        public bool Anulled { get; set; }

        /// <summary>
        /// Id User Modified Document
        /// </summary>
        public string IdUserModified { get; set; }

        /// <summary>
        /// Module
        /// </summary>
        public string Module { get; set; }

        /// <summary>
        /// Id Bed
        /// </summary>
        public string IdBed { get; set; }

        /// <summary>
        /// Id Warrant
        /// </summary>
        public int IdWarrant { get; set; }

        /// <summary>
        /// Id Init Storage
        /// </summary>
        public string IdInitStorage { get; set; }


        [ForeignKeySpin("IdStorage")]
        public List<StorageItem> Strages { get; set; } = new List<StorageItem>();

        public string InitStorage { get; set; }

        /// <summary>
        /// Id Final Storage
        /// </summary>
        public string IdFinalStorage { get; set; }

    }
}
