using System;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.LogsImhotep.Interfaces.Persistence
{
    /// <summary>
    /// Interface Context
    /// </summary>
    public interface ILogImothepContext
    {
        /// <summary>
        /// Save Log
        /// </summary>
        /// <param name="value">Object Imhotep</param>
        /// <returns>void</returns>
        Task Save(ILogImhotep value);
    }
}
