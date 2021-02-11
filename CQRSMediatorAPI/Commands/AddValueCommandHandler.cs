using CQRSMediatorAPI.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorAPI.Commands
{
    public class AddValueCommandHandler : RequestHandler<AddValueCommand>
    {
        private readonly FakeDataStore _db;

        public AddValueCommandHandler(FakeDataStore db)
        {
            _db = db;
        }

        protected override void Handle(AddValueCommand request)
        {
            var userObj = new User()
            {
                Name = request.Name,
                Age = request.Age
            };

            _db.AddValue(userObj);
        }
    }
}
