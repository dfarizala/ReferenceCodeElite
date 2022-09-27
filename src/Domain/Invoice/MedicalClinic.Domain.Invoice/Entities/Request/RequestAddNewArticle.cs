using System;
using MediatR;
using MedicalClinic.Domain.Invoice.Entities.Response;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Invoice.Entities.Request
{
    /// <summary>
    /// Request Add New Article
    /// </summary>
    public class RequestAddNewArticle
    {
        /// <summary>
        /// Account Detail Id
        /// </summary>
        /// <summary>
        /// The account ID
        /// </summary>
        public int ACCOUNT_DETAIL_ID { get; set; }
        /// <summary>
        /// ACCOUNT HEADER ID
        /// </summary>
        public int ACCOUNT_HEADER_ID { get; set; }
        /// <summary>
        /// Date the charge is added to the account or invoice
        /// </summary>
        public DateTime CHARGE_DATE { get; set; }
        /// <summary>
        /// Time in which the charge is added to the account or invoice
        /// </summary>
        public DateTime CHARGETIME { get; set; }
        /// <summary>
        /// The code that is added to the charge to the account or invoice
        /// </summary>
        public decimal CHARGE_CODE { get; set; }
        /// <summary>
        /// Attached Charge
        /// </summary>
        public decimal ATTACHED_CHARGE { get; set; }
        /// <summary>
        /// Is the type of concept that is added to the account or invoice
        /// </summary>
        public string CONCEPT_TYPE { get; set; }
        /// <summary>
        /// Unique code of procedures and services
        /// </summary>
        public string CUPS_CODE { get; set; }
        /// <summary>
        /// Item table code
        /// </summary>
        public string ARTICLE_CODE { get; set; }
        /// <summary>
        /// Code of the person responsible for payment
        /// </summary>
        public int RESPONSIBLE_CODE { get; set; }
        /// <summary>
        /// Code of the stipulated agreement
        /// </summary>
        public int AGREEMENT_CODE { get; set; }
        /// <summary>
        /// Code assigned to the rate
        /// </summary>
        public int RATE_CODE { get; set; }
        /// <summary>
        /// Quantity of articles
        /// </summary>
        public int QUANTITY { get; set; }
        /// <summary>
        /// Estimated purchase value
        /// </summary>
        public decimal PURCHASE_VALUE { get; set; }
        /// <summary>
        /// Item unit value
        /// </summary>
        public decimal UNIT_VALUE { get; set; }
        /// <summary>
        /// Total to pay
        /// </summary>
        public decimal TOTAL_VALUE { get; set; }
        /// <summary>
        /// If the invoice is canceled or not
        /// </summary>
        public bool ABORTED { get; set; }
        /// <summary>
        /// Type of service provided to the patient
        /// </summary>
        public int SERVICE_TYPE { get; set; }
        /// <summary>
        /// It is a code that is assigned to the invoice
        /// </summary>
        public string RIPS_CODE { get; set; }
        /// <summary>
        /// It is when the value of an item is changed in the rate
        /// </summary>
        public bool RATE_CHANGED { get; set; }
        /// <summary>
        /// When they request to split the account
        /// </summary>
        public bool DIVIDED { get; set; }
        /// <summary>
        /// Any kind of observation you want to add
        /// </summary>
        public string OBSERVATIONS { get; set; }
        /// <summary>
        /// Duplicated Invoice Code
        /// </summary>
        public int DUPLICATED_INVOICE_CODE { get; set; }
        /// <summary>
        /// Justification Code
        /// </summary>
        public string JUSTIFICATION_CODE { get; set; }
        /// <summary>
        /// Cost Center
        /// </summary>
        public string COST_CENTER { get; set; }
        /// <summary>
        /// Pbs Code
        /// </summary>
        public string PBS_CODE { get; set; }


    }
}
