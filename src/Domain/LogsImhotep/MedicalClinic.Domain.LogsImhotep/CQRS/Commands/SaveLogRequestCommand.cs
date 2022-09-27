using System;
using MediatR;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.LogsImhotep.Entities;

namespace MedicalClinic.Domain.LogsImhotep.CQRS.Commands
{
    public class SaveLogRequestCommand : IRequest<SaveLogResponseCommand>
    {
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
