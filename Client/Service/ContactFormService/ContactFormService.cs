using ContactForm_Andy.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;

namespace ContactForm_Andy.Client.Service.ContactFormService
{
    public class ContactFormService : IContactFormService
    {
        private readonly HttpClient _http;
        public ContactFormService(HttpClient http)
        {
            _http = http;
        }
        public async Task<ContactForm?> GetFormByEmail(string email)
        {
            var result = await _http.GetAsync($"api/form/{email}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<ContactForm?>();
            }
            return null;
        }

        public async Task SubmitForm(ContactForm contactForm)
        {
            try
            {
                var response = await _http.PostAsJsonAsync("api/form", contactForm);
            }
            catch (Exception ex)
            {
                var foo = ex.Message;
            }
            
        }
    }
}
