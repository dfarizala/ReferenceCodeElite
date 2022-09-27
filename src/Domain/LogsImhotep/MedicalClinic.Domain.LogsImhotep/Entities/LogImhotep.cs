using System;
using MedicalClinic.Domain.LogsImhotep.Interfaces;

namespace MedicalClinic.Domain.LogsImhotep.Entities
{
    /// <summary>
    /// Log Imhotep
    /// </summary>
    public class LogImhotep: ILogImhotep
    {
        /// <summary>
        /// Unique code GUID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Page Name
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// Action to do
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Information additional
        /// </summary>
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Created Date time
        /// </summary>
        public DateTime Created { get; set; }
    }
}
