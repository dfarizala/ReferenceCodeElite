using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Security.CQRS.Queries.Response
{
    /// <summary>
    /// Response Login Query
    /// </summary>
    public class ResponseLoginQuery: ResponseApi
    {
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; set; }
    }
}
