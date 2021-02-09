using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Applications.Commands
{
    public class SendEmailCommand : IRequest
    {
        public String EmailId { get; set; }
    }
}