using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.LogsImhotep.Entities.Response
{
    /// <summary>
    /// Response Log
    /// </summary>
    public class ResponseLogImhotep: ResponseApi
    {
        /// <summary>
        /// Cosntructor
        /// </summary>
        public ResponseLogImhotep()
        {
        }

        /// <summary>
        /// Status Message
        /// </summary>
        public string Id { get; set; }


    }
}
