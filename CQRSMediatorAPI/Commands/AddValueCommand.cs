using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorAPI.Commands
{
    public class AddValueCommand : IRequest
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
