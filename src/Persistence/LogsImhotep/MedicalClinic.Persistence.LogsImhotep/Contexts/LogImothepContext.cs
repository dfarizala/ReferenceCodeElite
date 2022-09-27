using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.LogsImhotep.Interfaces;
using MedicalClinic.Domain.LogsImhotep.Interfaces.Persistence;
using MongoDB.Driver;

namespace MedicalClinic.Persistence.LogsImhotep.Persistence
{
    /// <summary>
    /// Context Log
    /// </summary>
    public class LogImothepContext: ILogImothepContext
    {
        /// <summary>
        /// Client Mongo
        /// </summary>
        private static MongoClient _dbClient = new(Spin.Helper.Configuration.Configuration.GetConnectionString("LogImhotep").ConnectionString);

        /// <summary>
        /// Db Mongo
        /// </summary>
        private IMongoDatabase _db;

        /// <summary>
        /// Collection Mongo
        /// </summary>
        private IMongoCollection<ILogImhotep> _collection;


        /// <summary>
        /// Constructor
        /// </summary>
        public LogImothepContext()
        {
            _db = _dbClient.GetDatabase("Imothep");
            _collection = _db.GetCollection<ILogImhotep>("LogUser");
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Task Save(ILogImhotep value)
            => _collection.InsertOneAsync(value);
    }
}
