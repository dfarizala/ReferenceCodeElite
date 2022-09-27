using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Pharmacy.DTO.Request.Batch
{
    /// <summary>
    /// Requesto Batch Dto
    /// </summary>
    public class RequestBatchDto
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RequestBatchDto()
        {
        }

        /// <summary>
        /// Id of Batch
        /// </summary>
        public int IdBatch { get; set; }
    }
}
