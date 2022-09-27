using System;
using System.Collections.Generic;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Invoice.Entities;


namespace MedicalClinic.Domain.Invoice.CQRS.Queries.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class ResponseAddNewArticleQuery : ResponseApi
    {
        /// <summary>
        /// ARTICLE ID
        /// </summary>
        public int ACCOUNT_DETAIL_ID { get; set; }
    }
}
