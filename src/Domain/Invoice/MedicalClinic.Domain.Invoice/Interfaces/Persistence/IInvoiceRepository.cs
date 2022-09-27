using MedicalClinic.Domain.Invoice.CQRS.Queries.Request;
using MedicalClinic.Domain.Invoice.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Invoice.Interfaces.Persistence
{
    public interface IInvoiceRepository
    {
        /// <summary>
        /// 
        /// </summary>        
        /// <returns></returns>
        Task<IAccount> GetSingleInvoice(int AccountID);
        /// <summary>
        /// 
        /// </summary>        
        /// <returns></returns>
        Task<IAccount> GetMultipleeInvoice(int PatientID = 0, int PatientDoctype = 0, int PatientDocNumber = 0);
        /// <summary>
        /// 
        /// </summary>        
        /// <returns></returns>
        Task<IAccount> GetCreateAccount(int ACCOUNT_ID, int ADMISSION_ID, int MEDICAL_HISTORY_ID, string INVOICE_PREFIX, 
                                         double INVOICE_NUMBER, int INVOICE_TYPE, DateTime ACCOUNT_DATE, DateTime INVOICE_GENERATION_DATE, 
                                         DateTime INVOICE_GENERATION_TIME, string HEAD_QUARTER_ID, int RESPONSIBLE_CODE, int AGREEMENT_CODE, 
                                         bool ABORTED, bool PRINTED, bool ACTIVE, bool LOCKED, bool DIVIDED_ACCOUNT, bool SOAT_INVOICE, 
                                         decimal NET_VALUE, decimal COPAY_VALUE, decimal DISCOUNT, decimal TOTAL_VALUE, string LETTER_VALUE, 
                                         string QR_CODE, string QR_PATH, double AUTHORIZATION_NUMBER, string PDF_PATH, bool IS_COVID, 
                                         bool VERIFIED, bool SEND_MAIL, decimal ADVANCED, decimal DEBIT_NOTE, decimal CREDIT_NOTE);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AccountID"></param>
        /// <returns></returns>
        Task<IAccount> AbortInvoice(int AccountID);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ACCOUNT_HEADER_ID"></param>
        /// <returns></returns>
        Task<IAccountDetail> AddNewArticle(int ACCOUNT_DETAIL_ID);
        
    }
}
