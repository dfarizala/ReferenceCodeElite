using System;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using MediatR;
using MedicalClinic.Domain.Common.Enums;
using MedicalClinic.Domain.Common.Wrappers;
using MedicalClinic.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace MedicalClinic.Infrastructure.Helper.Services
{
    public class ExecutorOrchestrator : IExecutorOrchestrator
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly ILogger<ExecutorOrchestrator> _logger;



        public ExecutorOrchestrator(IMapper mapper, ILogger<ExecutorOrchestrator> logger)
        {
            _logger = logger;
            _mapper = mapper;
        }


        public ExecutorOrchestrator(IMapper mapper, IMediator mediator, ILogger<ExecutorOrchestrator> logger)
        {
            _logger = logger;
            _mapper = mapper;
            _mediator = mediator;
        }


        #region General Use
        async public Task<TResponse> ProcessAndMap<TRequest, TRequestHandler, TResponse, TResponseHandler>(TRequest request)
            where TRequestHandler : IRequest<TResponseHandler>
            where TResponseHandler : ResponseApi
            where TResponse : ResponseApi
        {
            try
            {
                var command = _mapper.Map<TRequestHandler>(request);
                _logger.LogDebug("MediatR ExecutorOrchestrator: {@Method}, Request: {@request}", typeof(TRequest).Name, request);
                var responseHandle = await _mediator.Send(command);
                _logger.LogDebug("Execute ExecutorOrchestrator: {@Method}, Request: {@request}", typeof(TRequest).Name, responseHandle);
                var response = _mapper.Map<TResponse>(responseHandle);
                _logger.LogDebug("MediatR ExecutorOrchestrator: {@Method}, Response: {@request}", typeof(TRequest).Name, response);

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogDebug("[Error] MediatR ExecutorOrchestrator: {@Method}, error: {@error}", typeof(TRequest).Name, ex);
            }

            return null;
        }
        #endregion General Use
    }
}
