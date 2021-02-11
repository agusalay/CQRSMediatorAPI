using CQRSMediatorAPI.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorAPI.Queries
{
    public class GetValuesQuery : IRequest<IEnumerable<UserVm>>
    {
    }
}
