using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Applications.Commands
{
    public class CreateUserCommand : IRequest<bool>
    {
        public String FullName { get; set; }

        public String EmailId { get; set; }
    }
}