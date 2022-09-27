using System;
using System.Threading.Tasks;

namespace MedicalClinic.Domain.Security.Interfaces.Persistence
{
    /// <summary>
    /// Interface Context
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="userName">User Name</param>
        /// <param name="password">Password</param>
        /// <returns>User Information</returns>
        Task<IUser> Login(string userName, string password);

        /// <summary>
        /// Restore password of User
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        Task<IUser> RestorePassword(string Email);

        /// <summary>
        /// Update password from recovery request
        /// </summary>
        /// <param name="Email">User's mail</param>
        /// <param name="token">Token for validation</param>
        /// <param name="NewPassword">New Password for the user</param>
        /// <returns></returns>
        Task<IUser> UpdatePassword(string Email, string token, string NewPassword);        
    }
}
