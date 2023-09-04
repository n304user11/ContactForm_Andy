using ContactForm_Andy.Server.Services;
using ContactForm_Andy.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactForm_Andy.Server.Controllers
{
    [Route("api/form")]
    [ApiController]
    public class ContactFormController : ControllerBase
    {
        private readonly IContactFormService _contactFormService;
        public ContactFormController(IContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
        }
        [HttpGet]
        public async Task<List<ContactForm>> GetForms()
        {
            return await _contactFormService.GetForms();
        }
        [HttpGet("{email}")]
        public async Task<IActionResult> GetFormByEmail(string email)
        {
            var form = await _contactFormService.GetFormByEmail(email);
            if (form is null)
            {
                return NoContent();
            }
            return Ok(form);
        }

        [HttpPost]
        public async Task<ActionResult> SubmitForm(ContactForm form)
        {
            await _contactFormService.SubmitForm(form);
            return Ok();
        }
    }
}
