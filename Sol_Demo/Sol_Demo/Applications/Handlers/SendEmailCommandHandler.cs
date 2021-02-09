using MediatR;
using Sol_Demo.Applications.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sol_Demo.Applications.Handlers
{
    public class SendEmailCommandHandler : IRequestHandler<SendEmailCommand>
    {
        Task<Unit> IRequestHandler<SendEmailCommand, Unit>.Handle(SendEmailCommand request, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Send Email:{request.EmailId}");
            return Task.FromResult(Unit.Value);
        }
    }
}