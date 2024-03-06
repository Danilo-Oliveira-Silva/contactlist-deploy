using ContactList.Models;

namespace ContactList.Repository
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetContacts();
        Contact AddContact(Contact contact);
        Contact UpdateContact(Contact contact); 
        void DeleteContact(int ContactId);
    }
}