using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MedicalClinic.Domain.Security.CQRS.Commands.Request;
using MedicalClinic.Domain.Security.CQRS.Commands.Response;
using MedicalClinic.Domain.Security.Interfaces.Persistence;


namespace MedicalClinic.Infrastructure.Security.CQRS.Commands
{
    public class UpdatePasswordCommandHandler : IRequestHandler<RequestUpdatePasswordCommand, ResponseUpdatePasswordCommand>
    {
        private IUserRepository _context;
        private IMapper _mapper;

        public UpdatePasswordCommandHandler(IUserRepository context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        async public Task<ResponseUpdatePasswordCommand> Handle(RequestUpdatePasswordCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _context.UpdatePassword(request.Email, request.token, request.NewPassword);
                return _mapper.Map<ResponseUpdatePasswordCommand>(result);
            }
            catch (Exception ex)
            {
                return new() { Error = ex.Message };
            }
        }
    }
}
