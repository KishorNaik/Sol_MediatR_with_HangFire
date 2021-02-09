using Hangfire;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sol_Demo.Configurations;

namespace Sol_Demo.Configurations
{
    public static class MediatorExtensions
    {
        public static void Enqueue(this IMediator mediator, string jobName, IRequest request)
        {
            var client = new BackgroundJobClient();
            client.Enqueue<MediatorHangFireMessageBridge>(bridge => bridge.Send(jobName, request));
        }

        public static void Enqueue(this IMediator mediator, IRequest request)
        {
            var client = new BackgroundJobClient();
            client.Enqueue<MediatorHangFireMessageBridge>(bridge => bridge.Send(request));
        }
    }
}