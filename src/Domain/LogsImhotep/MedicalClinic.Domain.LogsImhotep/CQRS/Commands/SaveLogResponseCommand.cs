using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.LogsImhotep.CQRS.Commands
{
    /// <summary>
    /// Save Log Response
    /// </summary>
    public class SaveLogResponseCommand : ResponseApi
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SaveLogResponseCommand ()
        {
        }

        /// <summary>
        /// Status Message
        /// </summary>
        public string Id { get; set; }
    }
}
