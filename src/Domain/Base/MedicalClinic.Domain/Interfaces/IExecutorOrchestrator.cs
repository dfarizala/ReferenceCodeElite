using System;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using MediatR;
using MedicalClinic.Domain.Common.Wrappers;

namespace MedicalClinic.Domain.Interfaces
{
    public interface IExecutorOrchestrator
    {
        #region General Use
        Task<TResponse> ProcessAndMap<TRequest, TRequestHandler, TResponse, TResponseHandler>(TRequest request)
            where TRequestHandler : IRequest<TResponseHandler>
            where TResponseHandler: ResponseApi
            where TResponse : ResponseApi;
        #endregion General Use
    }
}
