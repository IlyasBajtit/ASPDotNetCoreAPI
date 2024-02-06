using Exercice01API.Models;
using Exercice01API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exercice01API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IRepository<Contact> _contactRepository;

        public ContactController(IRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var contacts = _contactRepository.GetAll();
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _contactRepository.GetById(id);

            if (contact == null)
                return NotFound(new
                {
                    Message = "Contact non trouvé !"
                });

            return Ok(new
            {
                Message = "Contact trouvé !",
                Contact = contact
            });
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            _contactRepository.Add(contact);

            return CreatedAtAction(nameof(GetById), new { id = contact.Id }, "Contact ajouté");
        }

        [HttpGet("search")]
        public IActionResult SearchByFirstName(string firstName)
        {
            var contacts = _contactRepository.GetAll(c => c.FirstName.StartsWith(firstName));
            if (contacts == null || !contacts.Any()) return NotFound();
            return Ok(contacts);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            if (id != contact.Id) return BadRequest();

            var existingContact = _contactRepository.GetById(id);
            if (existingContact == null) return NotFound();

            _contactRepository.Update(contact);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contact = _contactRepository.GetById(id);
            if (contact == null) return NotFound();

            _contactRepository.Delete(id);
            return NoContent();
        }
    }
}
