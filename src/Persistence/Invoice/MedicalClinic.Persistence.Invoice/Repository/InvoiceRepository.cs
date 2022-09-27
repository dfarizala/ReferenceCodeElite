using System;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System.Threading.Tasks;
using MedicalClinic.Domain.Invoice.Entities;
using MedicalClinic.Domain.Invoice.Interfaces;
using MedicalClinic.Domain.Invoice.Interfaces.Persistence;
using MedicalClinic.Persistence.Invoice.Contexts;
using System.Collections.Generic;

namespace MedicalClinic.Persistence.Invoice.Repository
{
    /// <summary>
    /// Invoice Repository
    /// </summary>
    public class InvoiceRepository : IInvoiceRepository
    {
        /// <summary>
        /// Context
        /// </summary>
        private InvoiceContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Context DB</param>
        public InvoiceRepository(InvoiceContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Single Account by Account number
        /// </summary>
        /// <param name="AccountID">Account Number</param>
        /// <returns></returns>
        public Task<IAccount> GetSingleInvoice(int AccountID)
            => Task.Factory.StartNew<IAccount>(() =>
            {

                var QueryResult = _context.AccountHeader.FirstOrDefault(a => a.ACCOUNT_ID == AccountID && a.ABORTED == false);
                if (QueryResult != null)
                    return QueryResult;

                return null;
            });

        /// <summary>
        /// Get multiple Accounts 
        /// </summary>
        /// <param name="PatientID">Patient internal number</param>
        /// <param name="PatientDoctype">Document type of patient</param>
        /// <param name="PatientDocNumber">Document number of the patient</param>
        /// <returns></returns>
        public Task<IAccount> GetMultipleeInvoice(int PatientID = 0, int PatientDoctype = 0, int PatientDocNumber = 0)
            => Task.Factory.StartNew<IAccount>(() =>
            {

                List<AccountHeader> QueryResult = new List<AccountHeader>();

                int QueryType = 0;

                if (PatientID != 0) QueryType = 1; else QueryType = 2;

                switch (QueryType)
                {
                    case 1:
                        return null;
                        break;
                    case 2:
                        return null;
                        break;
                    default:
                        return null;
                }
            });
        /// <summary>
        /// Create new Account
        /// </summary>
        /// <param name="ACCOUNT_ID"></param>        
        /// <returns></returns>
        public Task<IAccount> GetCreateAccount(int ACCOUNT_ID, int ADMISSION_ID, int MEDICAL_HISTORY_ID, string INVOICE_PREFIX,
                                         double INVOICE_NUMBER, int INVOICE_TYPE, DateTime ACCOUNT_DATE, DateTime INVOICE_GENERATION_DATE,
                                         DateTime INVOICE_GENERATION_TIME, string HEAD_QUARTER_ID, int RESPONSIBLE_CODE, int AGREEMENT_CODE,
                                         bool ABORTED, bool PRINTED, bool ACTIVE, bool LOCKED, bool DIVIDED_ACCOUNT, bool SOAT_INVOICE,
                                         decimal NET_VALUE, decimal COPAY_VALUE, decimal DISCOUNT, decimal TOTAL_VALUE, string LETTER_VALUE,
                                         string QR_CODE, string QR_PATH, double AUTHORIZATION_NUMBER, string PDF_PATH, bool IS_COVID,
                                         bool VERIFIED, bool SEND_MAIL, decimal ADVANCED, decimal DEBIT_NOTE, decimal CREDIT_NOTE) =>
            Task.Factory.StartNew<IAccount>(() =>
            {
                try
                {
                    AccountHeader newObject = new AccountHeader();
                    newObject.ADMISSION_ID = ADMISSION_ID;
                    newObject.MEDICAL_HISTORY_ID = MEDICAL_HISTORY_ID;
                    newObject.INVOICE_PREFIX = INVOICE_PREFIX;
                    newObject.INVOICE_NUMBER = INVOICE_NUMBER;
                    newObject.INVOICE_TYPE = INVOICE_TYPE;
                    newObject.ACCOUNT_DATE = ACCOUNT_DATE;
                    newObject.INVOICE_GENERATION_DATE = INVOICE_GENERATION_DATE;
                    newObject.INVOICE_GENERATION_TIME = INVOICE_GENERATION_TIME;
                    newObject.ABORTED = ABORTED;
                    newObject.PRINTED = PRINTED;
                    newObject.ACTIVE = ACTIVE;
                    newObject.LOCKED = LOCKED;
                    newObject.DIVIDED_ACCOUNT = DIVIDED_ACCOUNT;
                    newObject.SOAT_INVOICE = SOAT_INVOICE;
                    newObject.QR_CODE = QR_CODE;
                    newObject.QR_PATH = QR_PATH;
                    newObject.AUTHORIZATION_NUMBER = AUTHORIZATION_NUMBER;
                    newObject.PDF_PATH = PDF_PATH;
                    newObject.IS_COVID = IS_COVID;
                    newObject.VERIFIED = VERIFIED;
                    newObject.SEND_MAIL = SEND_MAIL;
                    newObject.ADVANCED = ADVANCED;
                    newObject.DEBIT_NOTE = DEBIT_NOTE;
                    newObject.CREDIT_NOTE = CREDIT_NOTE;

                    _context.AccountHeader.Add(newObject);
                    _context.SaveChanges();

                }
                catch (Exception ex)
                {
                    return null;
                }
                return null; 
            });
        /// <summary>
        /// Abort a invoice 
        /// </summary>
        /// <param name="AccountID">Patient internal number</param>
        /// <returns></returns>
        public Task<IAccount> AbortInvoice(int AccountID)
            => Task.Factory.StartNew<IAccount>(() =>
            {

                var QueryResult = _context.AccountHeader.FirstOrDefault(a => a.ACCOUNT_ID == AccountID && a.ABORTED == false );

                if (QueryResult != null)
                {

                    QueryResult.ABORTED = true;
                    QueryResult.ACTIVE = false;

                    _context.SaveChanges();
                    return QueryResult;
                }

                return null;
            });

        public Task<IAccountDetail> AddNewArticle(int ACCOUNT_DETAIL_ID) =>
        Task.Factory.StartNew<IAccountDetail>(() =>
        {
            try
            {
                AccountDetail newObject = new AccountDetail();
                newObject.ACCOUNT_DETAIL_ID = ACCOUNT_DETAIL_ID;

                _context.AccountDetail.Add(newObject);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        });
    }
}