using System;
using Spin.Connection.Entity;

namespace MedicalClinic.Domain.Pharmacy.Entities
{
    /// <summary>
    /// Pharmacy Item
    /// </summary>
    public class PharmacyItem : BaseEntity
    {
        /// <summary>
        /// Basic Consructor
        /// </summary>
        public PharmacyItem()
            : base("IdPharmacy", "Pharmacy")
        {
        }

        /// <summary>
        /// Name Customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Code External system
        /// </summary>
        public string  InternalCode { get; set; }
    }
}
