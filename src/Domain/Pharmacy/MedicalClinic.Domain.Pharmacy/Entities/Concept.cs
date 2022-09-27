using System;
using Spin.Connection.Entity;

namespace MedicalClinic.Domain.Pharmacy.Entities
{
    /// <summary>
    /// Concepts of articles, not only pharmacy
    /// </summary>
    public class ConceptItem : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ConceptItem()
            :base("IdConcept", "Pharmacy")
        {
        }

        /// <summary>
        /// Description of concepts
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Table/Entity - Origin of concept
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// Order of concepts
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        public bool Active { get; set; }
    }
}
