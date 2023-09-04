using ContactForm_Andy.Shared.Models;

namespace ContactForm_Andy.Client.Service.ContactFormService
{
    public interface IContactFormService
    {
        Task<ContactForm?> GetFormByEmail(string email);
        Task SubmitForm(ContactForm contactForm);
    }
}
