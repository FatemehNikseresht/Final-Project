using Microsoft.EntityFrameworkCore;
using Model.Dtos;

namespace Model
{
    public class OnlineShopDbContext: DbContext
    {
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=OnlineShopDb;Integrated Security=True;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Person> Person { get; set; }
    }
}
