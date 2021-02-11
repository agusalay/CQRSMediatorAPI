using CQRSMediatorAPI.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CQRSMediatorAPI.Queries.GetValuesQuery;

namespace CQRSMediatorAPI.Queries
{
    public class GetValuesQueryHandler : RequestHandler<GetValuesQuery, IEnumerable<UserVm>>
        {
            private readonly FakeDataStore _db;

            public GetValuesQueryHandler(FakeDataStore db)
            {
                _db = db;
            }

            protected override IEnumerable<UserVm> Handle(GetValuesQuery request)
            {
                List<UserVm> listofUser = new List<UserVm>();
                var a = _db.GetAllValues();

                foreach (var item in a)
                {
                    listofUser.Add(new UserVm()
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                }

                return listofUser;
            }
        }
    }

