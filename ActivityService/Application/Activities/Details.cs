using System;
using System.Threading;
using System.Threading.Tasks;
using ActivityService.Domain;
using ActivityService.Persistence;
using MediatR;


namespace ActivityService.Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly DataContext context;

            public Handler(DataContext context)
            {
                this.context = context;
            }

            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                var activity = await context.Activities.FindAsync(request.Id);

                return activity;
            }
        }

    }
}