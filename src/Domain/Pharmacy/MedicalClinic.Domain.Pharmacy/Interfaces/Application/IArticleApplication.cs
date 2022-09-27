using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Pharmacy.DTO.Response.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Request.Article;

namespace MedicalClinic.Domain.Pharmacy.Interfaces.Application
{
    public interface IArticleApplication
    {
        Task<Response<ResponseArticleDto>> GetArticle(RequestArticle request);
    }
}
