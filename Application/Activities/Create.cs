using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }
        public class Handler : IRequestHandler<Command> //IRequest quickfix using implement interface
        {
            private readonly DataContext _context;
            public Handler(DataContext context) //Using persistence and initializing field from parameter
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Activities.Add(request.Activity);

                await _context.SaveChangesAsync();

                return Unit.Value; //just a way of letting know that whatever was working inside savechanges has finished.
            }
        }
    }
}