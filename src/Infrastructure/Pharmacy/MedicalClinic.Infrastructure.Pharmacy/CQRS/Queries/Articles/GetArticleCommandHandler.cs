using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Pharmacy.Entities;
using MedicalClinic.Domain.Pharmacy.Entities.Request;
using MedicalClinic.Domain.Pharmacy.Entities.Request.Article;
using MedicalClinic.Domain.Pharmacy.Entities.Response;
using MedicalClinic.Domain.Pharmacy.Entities.Response.Article;
using MedicalClinic.Domain.Pharmacy.Interfaces.Persistence;

namespace MedicalClinic.Infrastructure.Pharmacy.CQRS.Queries.Articles
{
    public class GetArticleCommandHandler : IRequestHandler<RequestArticle, Response<ResponseArticle>>
    {
        private readonly IMapper _mapper;
        private readonly IArticleContext _context;

        public GetArticleCommandHandler(IMapper mapper, IArticleContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        async public Task<Response<ResponseArticle>> Handle(RequestArticle request, CancellationToken cancellationToken)
        {
            var data = _context.Select(request.IdArticle).FirstOrDefault();
            try
            {
                return new() { Data = _mapper.Map<ResponseArticle>(data) };
            }
            catch(Exception ex)
            {
                return new() { Succeeded = false, Error =  ex.Message };
            }
        }
    }
}
