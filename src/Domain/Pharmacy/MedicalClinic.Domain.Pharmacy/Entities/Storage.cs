using System;
using System.Collections.Generic;
using Spin.Connection.Entity;
using Spin.Connection.Entity.Attribute;

namespace MedicalClinic.Domain.Pharmacy.Entities
{
    /// <summary>
    /// Storage detail
    /// </summary>
    public class StorageItem : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public StorageItem()
            : base("IdStorage", "Pharmacy")
        {
        }

        /// <summary>
        /// Name of storage
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Module
        /// </summary>
        public string Module { get; set; }

        /// <summary>
        /// MainStorage - Main or Sub storage
        /// </summary>
        public bool MainStorage { get; set; }

        /// <summary>
        /// Storage Of Pharmacy
        /// </summary>
        public bool OfPharmacy { get; set; }

        /// <summary>
        /// Headquarters of Storage (Sede)
        /// </summary>
        public string Headquarters { get; set; }

        /// <summary>
        /// Order of storages
        /// </summary>
        public int Order { get; set; }        
    }
}
