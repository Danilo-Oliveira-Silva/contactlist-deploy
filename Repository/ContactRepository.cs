using ContactList.Models;

namespace ContactList.Repository
{
    public class ContactRepository : IContactRepository
    {
        protected readonly IContactContext _context;

        public ContactRepository(IContactContext context)
        {
            _context = context;
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _context.Contacts;
        }
        public Contact AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return contact;
        }
        public Contact UpdateContact(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return contact;
        }
        public void DeleteContact(int ContactId)
        {
            Contact contact = _context.Contacts.Find(ContactId);
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
        }   
    }
}