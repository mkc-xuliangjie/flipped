using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ActivityService.Domain;
using ActivityService.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace ActivityService.Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> {}

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataContext context;

            public Handler(DataContext context)
            {
                this.context = context;
            }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await context.Activities.ToListAsync();

                return activities;
            }
        }
    }
}