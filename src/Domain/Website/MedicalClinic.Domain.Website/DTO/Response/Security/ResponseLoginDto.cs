﻿using System;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Website.DTO.Response.Security
{
    /// <summary>
    /// Request login
    /// </summary>
    public class ResponseLoginDto: ResponseApi
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
