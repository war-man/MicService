﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Core.Http
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri, string authorizationToken = null, string authorizationMethod = "Bearer");
        Task<HttpResponseMessage> PutAsync<T>(string uri, T item, string authorizationToken = null, string requestId = null, string authorizationMethod = "Bearer");
        Task<HttpResponseMessage> PostAsync<T>(string uri, T item, string authorizationToken = null, string requestId = null, string authorizationMethod = "Bearer");
        Task<HttpResponseMessage> PostAsync(string uri, Dictionary<string, string> form, string authorizationToken = null, string requestId = null, string authorizationMethod = "Bearer");
    }
}
