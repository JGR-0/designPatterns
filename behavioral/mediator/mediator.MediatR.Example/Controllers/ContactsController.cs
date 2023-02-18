using mediator.MediatR.Example.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mediator.MediatR.Example.Controllers
{
    [Route("contacts")]
    public class ContactsController : Controller
    {
        private IMediator _mediator;

        public ContactsController(IMediator mediator){
            _mediator = mediator;
        }

        [HttpGet("{Id}")]
        public async Task<Contact> GetById([FromRoute] Query query) => await _mediator.Send(query);
    }

    public class Query : IRequest<Contact>
    {
        public int Id { get; set; }
    }

    public class ContactHandler : IRequestHandler<Query, Contact>
    {
        private ContactsContext db;

        public ContactHandler(ContactsContext db) => this.db = db;

        public async Task<Contact> Handle(Query request, CancellationToken cancellationToken)
        {
            return await db.Contacts.SingleOrDefaultAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);
        }
    }
}
