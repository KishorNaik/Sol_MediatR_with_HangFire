using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Configurations
{
    public class MediatorHangFireMessageBridge
    {
        private readonly IMediator mediator = null;

        public MediatorHangFireMessageBridge(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task Send(IRequest request)
        {
            await this.mediator.Send(request);
        }

        public async Task Send(string jobName, IRequest request)
        {
            await this.mediator.Send(request);
        }
    }
}