using System;
namespace MedicalClinic.Domain.Entities.Services
{
    /// <summary>
    /// Exception when exists problem with Channel connections
    /// </summary>
    [Serializable]
    public class ChannelInformation
    {
        #region Constuctor

        #endregion Constuctor

        #region Property

        /// <summary>
        /// Name channel
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Port connection
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Host channel
        /// </summary>
        public string Host { get; set; }

        #endregion Property

        #region CompleteHost

        /// <summary>
        /// Return information completed
        /// </summary>
        /// <returns>
        /// Complete information host
        /// </returns>
        public string CompleteHost()
        {
            return $"{this.Host}:{this.Port}";
        }

        #endregion CompleteHost

        #region ToString

        /// <summary>
        /// Change ToString Method
        /// </summary>
        /// <returns>
        /// return information Name + Host + Port
        /// </returns>
        public override string ToString()
        {
            return $"{this.Name} => {this.Host}:{this.Port}";
        }

        #endregion ToString
    }
}
