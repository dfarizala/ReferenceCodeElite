using System;
namespace MedicalClinic.Domain.Interfaces.Strategy
{
    /// <summary>
    /// Generic Provider for Notifications. 
    /// </summary>
    public interface INotificationStrategy
    {
        /// <summary>
        /// Send  message for Strategy Provider.
        /// </summary>
        /// <param name="value">can be: PhoneNumber,Email.</param>
        /// <param name="message">Message</param>
        void Send(string value, string message);
    }
}
