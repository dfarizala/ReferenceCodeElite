using System;

namespace MedicalClinic.Domain.Pharmacy.Entities.Response.Article
{
    /// <summary>
    /// Response Article
    /// </summary>
    public class ResponseArticle
    {
        /// <summary>
        /// Constructor of response Article
        /// </summary>
        public ResponseArticle()
        {
        }

        /// <summary>
        /// Article Oject
        /// </summary>
        public ArticleItem Article { get; set; }
    }
}
