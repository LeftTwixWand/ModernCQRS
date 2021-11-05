using Application.Queries;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Processing
{
    internal record MyQuery(string Text) : IQuery<string>;

    internal class MyQueryHandler : IQueryHandler<MyQuery, string>
    {
        public Task<string> Handle(MyQuery request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"MyQueryHandler result: {request.Text}");
            return Task.FromResult(request.Text);
        }
    }
}