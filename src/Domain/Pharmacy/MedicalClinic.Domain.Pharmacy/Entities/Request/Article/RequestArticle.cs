using System;
using MediatR;
using MedicalClinic.Domain.Pharmacy.Entities.Response.Article;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Pharmacy.Entities.Request.Article
{
    /// <summary>
    /// Reques of Article
    /// </summary>
    public class RequestArticle : IRequest<Response<ResponseArticle>>
    {
        /// <summary>
        /// Constructor of Request Article
        /// </summary>
        public RequestArticle()
        {
        }

        /// <summary>
        /// Id of Article
        /// </summary>
        public int IdArticle { get; set; }
    }
}
