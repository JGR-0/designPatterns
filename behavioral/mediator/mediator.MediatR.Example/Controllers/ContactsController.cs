using mediator.MediatR.Example.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mediator.MediatR.Example.Controllers;

[Route("contacts")]
public class ContactsController : Controller
{
    private readonly IMediator _mediator;

    public ContactsController(IMediator mediator){
        _mediator = mediator;
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] Query query) {
        if(!ModelState.IsValid)
        {
            return BadRequest();
        }

        var contact = await _mediator.Send(query);
        return Ok(contact);
    } 
}

public class Query : IRequest<Contact>
{
    public int Id { get; set; }
}

public class ContactHandler : IRequestHandler<Query, Contact>
{
    private readonly ContactsContext db;

    public ContactHandler(ContactsContext db) => this.db = db;

    public async Task<Contact> Handle(Query request, CancellationToken cancellationToken)
    {
        if(db is null) {
            throw new ArgumentException(nameof(db));
        }

        return await db.Contacts.SingleOrDefaultAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);
    }
}
