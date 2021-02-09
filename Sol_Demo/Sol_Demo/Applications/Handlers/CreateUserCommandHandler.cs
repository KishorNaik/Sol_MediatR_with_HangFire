using MediatR;
using Sol_Demo.Applications.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sol_Demo.Configurations;

namespace Sol_Demo.Applications.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IMediator mediator = null;

        public CreateUserCommandHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        Task<bool> IRequestHandler<CreateUserCommand, bool>.Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Full Name :{request.FullName}: Email Id:{request.EmailId}");
            mediator.Enqueue("Email-Send", new SendEmailCommand() { EmailId = request.EmailId });

            return Task.FromResult<bool>(true);
        }
    }
}