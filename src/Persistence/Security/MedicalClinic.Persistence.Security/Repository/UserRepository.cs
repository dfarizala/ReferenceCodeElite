using System;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System.Threading.Tasks;
using MedicalClinic.Domain.Security.Entities;
using MedicalClinic.Domain.Security.Interfaces;
using MedicalClinic.Domain.Security.Interfaces.Persistence;
using MedicalClinic.Persistence.Security.Contexts;

namespace MedicalClinic.Persistence.Security.Repository
{
    /// <summary>
    /// User Repository
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Context
        /// </summary>
        private UserContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Context DB</param>
        public UserRepository(UserContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Login With Database
        /// </summary>
        /// <param name="UserName">User Name</param>
        /// <param name="Password">Password</param>
        /// <returns></returns>
        public Task<IUser> Login(string userName, string password)
            => Task.Factory.StartNew<IUser>(() =>
            {
                var user = _context.imhotep_usuarios.FirstOrDefault(a => a.cod_usuario == userName && a.clave_usuario == password);

                if (user != null)
                    return new User() { UserName = user.cod_usuario, Password = user.clave_usuario, FirstName = user.nom_usuario };

                return null;
            });

        /// <summary>
        /// Request restore password - For send Email
        /// </summary>
        /// <param name="Email">User Email</param>
        /// <returns></returns>
        public Task<IUser> RestorePassword(string Email)
            => Task.Factory.StartNew<IUser>(() =>
            {
                var user = _context.imhotep_usuarios.FirstOrDefault(a => a.e_mail == Email);

                if (user != null)
                {

                    //Codificar envío de correo con token de restablecimiento de contraseña
                    // Token = Nombre+**+EmailMD5
                    var token = MD5Hash(user);

                    return new User() { Email = user.e_mail };
                }

                return null;
            });

        /// <summary>
        /// Method for encrypt Mail and other things
        /// </summary>
        /// <param name="user">User object Legacy</param>
        /// <returns>EncryptedInfo</returns>
        private static string MD5Hash(MedicalClinic.Domain.Security.Entities.Legacy.imhotep_usuarios user)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            var ToEncrypt = user.nom_usuario + "**" + user.e_mail;
            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(ToEncrypt));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// Update the password through the link sent to the user by mail
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="token">Token with user information for update</param>
        /// <param name="NewPassword">New password for the User</param>
        /// <returns></returns>
        public Task<IUser> UpdatePassword(string Email, string token, string NewPassword)//Email
            => Task.Factory.StartNew<IUser>(() =>
            {
                if (Email != null && token != null && NewPassword != null)
                {
                    var user = _context.imhotep_usuarios.FirstOrDefault(a => a.e_mail == Email);

                    
                    if (user != null)
                    {
                        var tokenR = MD5Hash(user);

                        if(token == tokenR)
                        {
                            user.clave_usuario = NewPassword;
                            _context.SaveChanges();

                            return new User() { UserName = user.cod_usuario, Email = user.e_mail };
                        }                        
                    }                    
                }                    
                
                return null;
            });
    }
}
