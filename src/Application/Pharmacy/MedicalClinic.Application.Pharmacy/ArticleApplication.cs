using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Pharmacy.DTO.Response.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Request.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Response.Article;
using MedicalClinic.Domain.Pharmacy.Interfaces.Application;

namespace MedicalClinic.Application.Pharmacy
{
    public class ArticleApplication: IArticleApplication
    {
        /// <summary>
        /// Executer orchestrattor
        /// </summary>
        private readonly IExecutorOrchestrator _executor;


        public ArticleApplication(IExecutorOrchestrator executor)
        {
            _executor = executor;
        }

        /// <summary>
        /// Get Pharmacy
        /// </summary>
        /// <param name="id">Code Pharmacy</param>
        /// <returns></returns>
        async public Task<Response<ResponseArticleDto>> GetArticle(RequestArticle request)
        {
            Response<ResponseArticleDto> response = null;
            try
            {
                response = await _executor.ProcessAndMap<RequestArticle, Response<ResponseArticleDto>, Response<ResponseArticle>>(request);
            }
            catch (Exception ex)
            {

            }

            return response;
        }
    }
}
