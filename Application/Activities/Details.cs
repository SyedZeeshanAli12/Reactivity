using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; } //Guid quickfix using system
        }
        public class Handler : IRequestHandler<Query, Activity>
        {    //implementing interface using quickfix
            private readonly DataContext _context;

            public Handler(DataContext context)
            { //Datacontext quickfix using persistence
                _context = context;
                // initializing field from parameter for context

            }
            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activities.FindAsync(request.Id);
            }
        }
    }
}