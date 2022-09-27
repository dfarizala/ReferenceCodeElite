using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Pharmacy.DTO
{
    /// <summary>
    /// DTO Article
    /// </summary>
    public class ArticleDto
    {
        /// <summary>
        /// Id of Article
        /// </summary>
        public int IdArticle { get; set; }

        /// <summary>
        /// Internal Code of Article
        /// </summary>
        public string InternalCode { get; set; }

        /// <summary>
        /// Name of Article
        /// </summary>
        public string Name { get; set; }
    }
}
