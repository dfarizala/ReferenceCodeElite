using System;

namespace MedicalClinic.Domain.Pharmacy.Entities.Response.Batch
{
    /// <summary>
    /// Response Batch
    /// </summary>
    public class ResponseBatch
    {
        /// <summary>
        /// Constructor of ResponseBatch
        /// </summary>
        public ResponseBatch()
        {
        }

        /// <summary>
        /// Batch Object
        /// </summary>
        public BatchItem Batch { get; set; }
    }
}
