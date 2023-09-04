using ContactForm_Andy.Shared.Models;

namespace ContactForm_Andy.Server.Services
{
    public interface IContactFormService
    {
        Task<List<ContactForm>> GetForms();
        Task<ContactForm?> GetFormByEmail(string email);
        Task SubmitForm(ContactForm contactForm);
    }
}
