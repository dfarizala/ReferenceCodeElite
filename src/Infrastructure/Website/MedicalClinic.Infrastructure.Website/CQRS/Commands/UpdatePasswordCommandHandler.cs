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

namespace MedicalClinic.Infrastructure.Website.CQRS.Commands
{
    /// <summary>
    /// Update password handler
    /// </summary>
    public class UpdatePasswordCommandHandler : IRequestHandler<RequestUpdatePasswordDto, ResponseUpdatePasswordDto>
    {
        /// <summary>
        /// Http client
        /// </summary>
        private HttpClient client = new HttpClient();

        /// <summary>
        /// Mapper
        /// </summary>
        private IMapper _mapper;

        /// <summary>
        /// Constructor?
        /// </summary>
        /// <param name="mapper"></param>
        public UpdatePasswordCommandHandler(IMapper mapper)
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
        async public Task<ResponseUpdatePasswordDto> Handle(RequestUpdatePasswordDto request, CancellationToken cancellationToken)
        {
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "aplication/json");
            HttpResponseMessage response = await client.PostAsync($"Api/Security/UpdatePassword/{request.Email}/{request.token}/{request.NewPassword}", content);
            response.EnsureSuccessStatusCode();

            var strResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseUpdatePassword>(strResponse);
            return _mapper.Map<ResponseUpdatePasswordDto>(result); ;
        }
    }
}
