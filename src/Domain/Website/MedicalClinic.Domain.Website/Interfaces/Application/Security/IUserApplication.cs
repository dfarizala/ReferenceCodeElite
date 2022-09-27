using System.Threading.Tasks;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Security.Entities.Request;
using MedicalClinic.Domain.Security.Entities.Response;

namespace MedicalClinic.Domain.Website.Interfaces.Application.Security
{
    public interface IUserApplication
    {
        Task<ResponseLogin> Login(RequestLogin request);
        Task<ResponseRestorePassword> RestorePassword(RequestRestorePassword request);
        Task<ResponseUpdatePassword> UpdatePassword(RequestUpdatePassword request);
    }
}
