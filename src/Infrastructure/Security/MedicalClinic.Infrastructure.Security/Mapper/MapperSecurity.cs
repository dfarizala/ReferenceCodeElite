using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MedicalClinic.Domain.Security.CQRS.Queries.Request;
using MedicalClinic.Domain.Security.CQRS.Queries.Response;
using MedicalClinic.Domain.Security.CQRS.Commands.Request;
using MedicalClinic.Domain.Security.CQRS.Commands.Response;
using MedicalClinic.Domain.Security.Entities;
using MedicalClinic.Domain.Security.Entities.Request;
using MedicalClinic.Domain.Security.Entities.Response;
using MedicalClinic.Domain.Security.Interfaces.Persistence;

namespace MedicalClinic.Infrastructure.Security.Mapper
{
    /// <summary>
    /// Mapper Security
    /// </summary>
    public class MapperSecurity: Profile
    {
        /// <summary>
        /// Mapper Security Constructor
        /// </summary>
        public MapperSecurity()
        {

            CreateMap<RequestLogin, RequestLoginQuery>().ReverseMap();
            CreateMap<ResponseLogin, ResponseLoginQuery>().ReverseMap();
            CreateMap<User, ResponseLoginQuery>().ReverseMap();
            CreateMap<RequestRestorePassword, RequestRestorePasswordQuery>().ReverseMap();
            CreateMap<ResponseRestorePassword, ResponseRestorePasswordQuery>().ReverseMap();
            CreateMap<User, ResponseRestorePasswordQuery>().ReverseMap();
            CreateMap<RequestUpdatePassword, RequestUpdatePasswordCommand>().ReverseMap();
            CreateMap<ResponseUpdatePassword, ResponseUpdatePasswordCommand>().ReverseMap();
            CreateMap<User, ResponseUpdatePasswordCommand>().ReverseMap();
        }

    }
}
