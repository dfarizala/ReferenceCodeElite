using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MedicalClinic.Domain.Security.CQRS.Queries.Request;
using MedicalClinic.Domain.Security.CQRS.Queries.Response;
using MedicalClinic.Domain.Security.Interfaces.Persistence;


namespace MedicalClinic.Infrastructure.Security.CQRS.Queries
{
    public class LoginQueryHandler : IRequestHandler<RequestLoginQuery, ResponseLoginQuery>
    {
        private IUserRepository _context;
        private IMapper _mapper;


        public LoginQueryHandler(IUserRepository context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        async public Task<ResponseLoginQuery> Handle(RequestLoginQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _context.Login(request.UserName, request.Password);
                return _mapper.Map<ResponseLoginQuery>(result);
            }
            catch (Exception ex)
            {
                return new() { Error = ex.Message };
            }
        }
    }
}
