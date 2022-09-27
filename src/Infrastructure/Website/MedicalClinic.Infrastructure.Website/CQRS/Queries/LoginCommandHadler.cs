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
    /// Login Handler
    /// </summary>
    public class LoginCommandHadler : IRequestHandler<RequestLoginDto, ResponseLoginDto>
    {
        /// <summary>
        /// Http client
        /// </summary>
        private HttpClient client = new HttpClient();

        /// <summary>
        /// Mapper
        /// </summary>
        private IMapper _mapper;


        public LoginCommandHadler(IMapper mapper)
        {
            this._mapper = mapper;

            client.BaseAddress = new Uri("http://localhost:3300/");
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        /// <summary>
        /// Execute Hanndler
        /// </summary>
        /// <param name="request">Request login</param>
        /// <param name="cancellationToken">Cancel Token</param>
        /// <returns></returns>
        async public Task<ResponseLoginDto> Handle(RequestLoginDto request, CancellationToken cancellationToken)
        {
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "aplication/json");
            HttpResponseMessage response = await client.PostAsync($"Api/Security/Login/{ request.UserName}/{ request.Password}", content);
            response.EnsureSuccessStatusCode();

            var strResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseLogin>(strResponse);
            return _mapper.Map<ResponseLoginDto>(result); ;
        }
    }
}
