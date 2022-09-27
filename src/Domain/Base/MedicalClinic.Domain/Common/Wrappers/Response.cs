using System;
using MedicalClinic.Domain.Common.Enums;

namespace MedicalClinic.Domain.Common.Wrappers
{
    /// <summary>
    /// Generic wrapper response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Response<T>
    {

        public Response()
        {
        }

        public Response(T data, string message = "")
        {
            Succeeded = true;
            Data = data;
            Error = message;
            ErrorCode = 0;
        }

        /// <summary>
        /// Process was succeeded
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Error code for every request.
        /// </summary>
        public ResponseErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public T Data { get; set; }
    }
}
