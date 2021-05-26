using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> { }; //using 

        public class Handler : IRequestHandler<Query, List<Activity>>//using domain quickfix and and implement interface quickfix here
        {
            private readonly DataContext _context;
            public Handler(DataContext context) //using persistence quickfix and intializing field from parameter
            {
                _context = context;
            }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activities.ToListAsync();//using microsoft entity framework core
            }
        }
    }
}