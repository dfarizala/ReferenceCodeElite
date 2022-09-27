using System;
using System.Collections.Generic;
using Spin.Connection.Entity;
using Spin.Connection.Entity.Attribute;
using Spin.Modules.Entity.History;

namespace MedicalClinic.Domain.Pharmacy.Entities
{
    /// <summary>
    /// Article/Supplie of Pharmacy
    /// </summary>
    public class ArticleItem : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ArticleItem()
            : base("IdArticle", "Pharmacy")
        { 
        }

        [ForeignKeySpin("IdConcept")]
        public List<ConceptItem> Concepts { get; set; } = new List<ConceptItem>();

        /// <summary>
        /// Internal Code of article
        /// </summary>
        public string InternalCode { get; set; }

        /// <summary>
        /// Individual Records of Health Services Provision/RIPS (Facturation relation)
        /// </summary>
        public string RipsCode { get; set; }

        /// <summary>
        /// Article Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Generic Name (For Meds)
        /// </summary>
        public string GenericName { get; set; }

        /// <summary>
        /// Concentration
        /// </summary>
        public string Concentration { get; set; }

        /// <summary>
        /// Concept ID
        /// </summary>
        public int IdConcept { get; set; }

        /// <summary>
        /// Group, examples: ANTIVIRAL, VITAMINA, ANTIBIOTICO
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Unit Of Measure
        /// </summary>
        public string UnitMeasure { get; set; }

        /// <summary>
        /// Fraction
        /// </summary>
        public decimal Fraction { get; set; }

        /// <summary>
        /// Unit Of Fraction
        /// </summary>
        public string UnitFraction { get; set; }

        /// <summary>
        /// Controlled medication
        /// </summary>
        public bool Controlled { get; set; }

        /// <summary>
        /// Antibiotic
        /// </summary>
        public bool Antibiotic { get; set; }

        /// <summary>
        /// Health Benefits Plan (PBS)
        /// </summary>
        public bool HealthBenefitsPlan { get; set; }
                
        /// <summary>
        /// Minimum Stock
        /// </summary>
        public int MinimumStock { get; set; }

        /// <summary>
        /// Maximum Stock
        /// </summary>
        public int MaximumStock { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Unique National Meds Code
        /// </summary>
        public string Cum { get; set; }

        /// <summary>
        /// Amount Storaged
        /// </summary>
        public int AmountStoraged { get; set; }

        /// <summary>
        /// Purchase Value
        /// </summary>
        public decimal PurchaseValue { get; set; }

        /// <summary>
        /// Pharmaceutical Form
        /// </summary>
        public string PharmaceuticalForm { get; set; }

        /// <summary>
        /// Sanitary Registry Code
        /// </summary>
        public string SanitaryRegistry { get; set; }

        /// <summary>
        /// High Price
        /// </summary>
        public bool HighPrice { get; set; }

        /// <summary>
        /// Regulated
        /// </summary>
        public bool Regulated { get; set; }

        /// <summary>
        /// Report Integrated Social Protection Information System (SISPRO)
        /// </summary>
        public bool ReportSISPRO { get; set; }

        /// <summary>
        /// Value Regulated BIOMED
        /// </summary>
        public decimal ValueRegulatedBIOMED { get; set; }

        /// <summary>
        /// MIPRES Code
        /// </summary>
        public string MIPRESCode { get; set; }

        
        /// <summary>
        /// Vademecum Ambulatory
        /// </summary>
        public bool VademecumAmbulatory { get; set; }
    }
}
