﻿using ConsoleApp.Models;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleApp.Tests;

namespace ConsoleApp.Requests
{
    class CreateDocument
    {
        public static async Task<CreateDocumentsResponse> Execute(HttpClient http, CreateDocumentsRequest request)
        {
            var responseMessage = await http.PostAsJsonAsync("Documents/Create", request);

            if (!responseMessage.IsSuccessStatusCode)
                throw await ApiException.Create(responseMessage);

            return await responseMessage.Content.ReadAsAsync<CreateDocumentsResponse>();
        }
    }
}