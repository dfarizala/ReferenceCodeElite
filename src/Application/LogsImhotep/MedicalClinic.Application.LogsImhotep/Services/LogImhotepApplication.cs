using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.LogsImhotep.CQRS.Commands;
using MedicalClinic.Domain.LogsImhotep.Entities.Request;
using MedicalClinic.Domain.LogsImhotep.Entities.Response;
using MedicalClinic.Domain.LogsImhotep.Interfaces.Application;

namespace MedicalClinic.Application.LogsImhotep.Services
{
    public class LogImhotepApplication: ILogImhotepApplication
    {
        private readonly IExecutorOrchestrator _executor;


        public LogImhotepApplication(IExecutorOrchestrator executor)
        {
            _executor = executor;
        }

        async public Task<ResponseLogImhotep> SaveLog(RequestLogImhotep request)
            => await _executor.ProcessAndMap<RequestLogImhotep,SaveLogRequestCommand, ResponseLogImhotep, SaveLogResponseCommand >(request);
    }
}
