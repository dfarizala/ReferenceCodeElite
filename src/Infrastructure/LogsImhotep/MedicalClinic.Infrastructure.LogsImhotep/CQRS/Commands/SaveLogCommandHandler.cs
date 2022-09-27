using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.LogsImhotep.CQRS.Commands;
using MedicalClinic.Domain.LogsImhotep.Entities;
using MedicalClinic.Domain.LogsImhotep.Interfaces.Persistence;

namespace MedicalClinic.Infrastructure.LogsImhotep.CQRS.Commands
{
    public class SaveLogCommandHandler : IRequestHandler<SaveLogRequestCommand, SaveLogResponseCommand>
    {
        private ILogImothepContext _context;
        private IMapper _mapper;

        public SaveLogCommandHandler(ILogImothepContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        async public Task<SaveLogResponseCommand> Handle(SaveLogRequestCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _mapper.Map<LogImhotep>(request);
                result.Id = Guid.NewGuid().ToString();
                await _context.Save(result);

                return new() { Id = result.Id };
            }
            catch(Exception ex)
            {
                return new() { Error = ex.Message };
            }
        }
    }
}
