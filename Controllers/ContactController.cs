using Microsoft.AspNetCore.Mvc;
using ContactList.Repository;
using ContactList.Models;

namespace ContactList.Controllers;

[ApiController]
[Route("contact")]
public class ContactController : ControllerBase
{
    private readonly IContactRepository _repository;
    public ContactController(IContactRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetContacts() {
        return Ok(_repository.GetContacts());
    }

    [HttpPost]
    public IActionResult PostContact([FromBody] Contact contact)
    {
        return Created("", _repository.AddContact(contact));
    }

    [HttpPut]
    public IActionResult PutContact([FromBody] Contact contact)
    {
        return Ok(_repository.UpdateContact(contact));
    }

    [HttpDelete("{ContactId}")]
    public IActionResult DeleteContact(int ContactId)
    {
        _repository.DeleteContact(ContactId);
        return NoContent();
    }

}
