using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.LogsImhotep.Entities.Request;
using MedicalClinic.Domain.LogsImhotep.Entities.Response;

namespace MedicalClinic.Domain.LogsImhotep.Interfaces.Application
{
    /// <summary>
    /// Log Imhotep
    /// </summary>
    public interface ILogImhotepApplication
    {
        Task<ResponseLogImhotep> SaveLog(RequestLogImhotep request);
    }
}
