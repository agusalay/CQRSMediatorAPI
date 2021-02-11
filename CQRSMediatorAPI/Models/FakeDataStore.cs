using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorAPI.Models
{
    public class FakeDataStore
    {
        private static List<User> _values;

        public FakeDataStore()
        {
            _values = new List<User>
        {
           new User()
           {
               Id = 1,
               Name = "User1",
               Age = 19
           },
           new User()
           {
               Id = 2,
               Name = "User2",
               Age = 16
           }
        };
        }
        public void AddValue(User value)
        {
            int id = _values.Select(a => a.Id).Max();

            value.Id = id + 1;

            _values.Add(value);
        }

        public void DeleteValue(int Id)
        {
            var obj = _values.Find(a => a.Id == Id);

            _values.Remove(obj);
        }

        public void UpdateValue(User value)
        {
            var obj = _values.FirstOrDefault(a => a.Id == value.Id);

            obj.Name = value.Name;
            obj.Age = value.Age;

        }

        public IEnumerable<User> GetAllValues()
        {
            return _values;
        }
    }
}
