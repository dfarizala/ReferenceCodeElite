using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MedicalClinic.Domain.LogsImhotep.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILogImhotep
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// Page Name
        /// </summary>
        string Page { get; set; }

        /// <summary>
        /// Action to do
        /// </summary>
        string Action { get; set; }

        /// <summary>
        /// Information additional
        /// </summary>
        string AdditionalInformation { get; set; }

        /// <summary>
        /// Created Date time
        /// </summary>
        DateTime Created { get; set; }
    }
}
