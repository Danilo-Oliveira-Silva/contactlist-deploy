using Microsoft.EntityFrameworkCore;
using ContactList.Models;

namespace ContactList.Repository
{
    public interface IContactContext 
    {
        public DbSet<Contact> Contacts { get; set; }
        public int SaveChanges();
    }
}
