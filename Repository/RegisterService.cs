using Blazored.Toast.Services;
using Microsoft.AspNetCore.Http;
using MUCOBADI.Interfaces;
using System;
using System.Net.Http;
using System.Text.Json;

namespace MUCOBADI.Repository
{
    public class RegisterService: IRegisterService
    {
        private readonly HttpClient client;
        private readonly IHttpContextAccessor httpContextAccessor;
        public RegisterService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            this.client = client;
            this.httpContextAccessor = httpContextAccessor;
        }

        public void RegisterHttpClient()
        {
            var baseUri = $"{httpContextAccessor.HttpContext?.Request.Scheme}://{httpContextAccessor.HttpContext?.Request.Host.Host}:{httpContextAccessor.HttpContext?.Request.Host.Port ?? 80}/api/";
            this.client.BaseAddress = new Uri(baseUri);
            this.client.Timeout = TimeSpan.FromMinutes(10);
        }
    }
}
