using ContactForm_Andy.Server.Data;
using ContactForm_Andy.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactForm_Andy.Server.Services
{
    public class ContactFormService : IContactFormService
    {
        private readonly DataContext _context;

        public ContactFormService(DataContext context)
        {
            _context = context;
        }
        public async Task<ContactForm?> GetFormByEmail(string email)
        {
            var form = await _context.ContactForms.FirstOrDefaultAsync(x => x.Email == email);
            return form;
        }

        public async Task<List<ContactForm>> GetForms()
        {
            var forms = await _context.ContactForms.ToListAsync();
            return forms;
        }

        public async Task SubmitForm(ContactForm contactForm)
        {
            _context.ContactForms.Add(contactForm);
            await _context.SaveChangesAsync();
        }
    }
}
