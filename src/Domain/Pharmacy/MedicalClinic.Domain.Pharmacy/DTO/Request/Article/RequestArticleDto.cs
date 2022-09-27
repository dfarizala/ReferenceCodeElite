using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Pharmacy.DTO.Request.Article
{
    /// <summary>
    /// Request Article Dto
    /// </summary>
    public class RequestArticleDto
    {
        /// <summary>
        /// Constructor of Request Article Dto
        /// </summary>
        public RequestArticleDto()
        {
        }

        /// <summary>
        /// Id of Article
        /// </summary>
        public int IdArticle { get; set; }

        /// <summary>
        /// Name of Article
        /// </summary>
        public string Name { get; set; }
    }
}
