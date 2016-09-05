using System.Collections.Generic;
using PhoneNumbersMVC6API.Models;

namespace PhoneNumbersMVC6API.Repository
{
    public interface IContactsRepository
    {
        void Add(Contacts item);
        IEnumerable<Contacts> GetAll();
        Contacts Find(string key);
        void Remove(string Id);
        void Update(Contacts item);
    }
}
