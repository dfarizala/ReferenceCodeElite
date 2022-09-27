using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Pharmacy.DTO.Response;
using MedicalClinic.Domain.Pharmacy.DTO.Response.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Request;
using MedicalClinic.Domain.Pharmacy.Entities.Request.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Response;
using MedicalClinic.Domain.Pharmacy.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;
using Spin.Base.Route;
using Spin.Modules.Entity.Controllers;

namespace Spin.Module.Pharmacy.Api.Controllers
{
    [SpinRoute("Api/Pharmacy/Article", "Api", "Pharmacy", "Article")]
    [ControllerInformation("Article")]
    /// <summary>
    /// Controller of ArticleItem
    /// </summary>
    public class ArticleController : SpinControllerApi
    {
        private IArticleApplication _articleApplication;
        /// <summary>
        /// Constructor of Controller
        /// </summary>
        /// <param name="PharmacyArticle"></param>
        public ArticleController(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        [HttpPost("GetArticle")]
        async public Task<Response<ResponseArticleDto>> GetArticle([FromBody] RequestArticle request)
        {
            return await _articleApplication.GetArticle(request);
        }
    }
}
