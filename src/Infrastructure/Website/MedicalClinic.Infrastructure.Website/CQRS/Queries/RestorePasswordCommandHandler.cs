using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MedicalClinic.Domain.Security.Entities.Response;
using MedicalClinic.Domain.Website.DTO.Request.Security;
using MedicalClinic.Domain.Website.DTO.Response.Security;
using Newtonsoft.Json;

namespace MedicalClinic.Infrastructure.Website.CQRS.Queries
{
    /// <summary>
    /// Restore password handler
    /// </summary>
    public class RestorePasswordCommandHandler : IRequestHandler<RequestRestorePasswordDto, ResponseRestorePasswordDto>
    {
        private HttpClient client = new HttpClient();

        private IMapper _mapper;

        /// <summary>
        /// Contructor?
        /// </summary>
        /// <param name="mapper"></param>
        public RestorePasswordCommandHandler(IMapper mapper)
        {
            this._mapper = mapper;

            client.BaseAddress = new Uri("http://localhost:3300/");
            client.DefaultRequestHeaders.Accept.Clear();
        }

        /// <summary>
        /// Execute Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        async public Task<ResponseRestorePasswordDto> Handle(RequestRestorePasswordDto request, CancellationToken cancellationToken)
        {
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "aplication/json");
            HttpResponseMessage response = await client.PostAsync($"/Api/Security/RestorePassword/{request.Email}", content);
            response.EnsureSuccessStatusCode();

            var strResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseRestorePassword>(strResponse);

            return _mapper.Map<ResponseRestorePasswordDto>(result);
        }
    }



}
