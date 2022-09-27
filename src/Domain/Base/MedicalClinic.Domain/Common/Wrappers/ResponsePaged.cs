using System;
namespace MedicalClinic.Domain.Common.Wrappers
{
    /// <summary>
    /// Wrapper when needs use Paginator.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponsePaged<T> : Response<T>
    {
        /// <summary>
        /// When it be necessary.
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// Total items (List count).
        /// </summary>
        public int TotalItems { get; set; }
    }
}
