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
    public class RestorePasswordQueryHandler : IRequestHandler<RequestRestorePasswordQuery, ResponseRestorePasswordQuery>
    {
        private IUserRepository _context;
        private IMapper _mapper;

        public RestorePasswordQueryHandler(IUserRepository context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        async public Task<ResponseRestorePasswordQuery> Handle(RequestRestorePasswordQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _context.RestorePassword(request.Email);
                return _mapper.Map<ResponseRestorePasswordQuery>(result);
            }
            catch (Exception ex)
            {
                return new() { Error = ex.Message };
            }
        }
    }
}
