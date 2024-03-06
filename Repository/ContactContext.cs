using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using ContactList.Models;

namespace ContactList.Repository;
public class ContactContext : DbContext, IContactContext
{
    public DbSet<Contact> Contacts { get; set; } = null!;
    public ContactContext() { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured)
        {
            //var connectionString = "Server=localhost;Database=ContactList;User=SA;Password=TrybeContact!;TrustServerCertificate=True";
            //optionsBuilder.UseSqlServer(connectionString);

            //var connectionString = "Server=localhost;Database=ContactList;User Id=root;Password=123456;Port=3308";

            var connectionString = "Server=viaduct.proxy.rlwy.net;Database=railway;User Id=root;Password=fcbBhGEfE2bGBHCbb2ebGbEcFBDfEBaE;Port=16280";
            optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString),null);
        }
    }

}