using me.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
 
namespace me.Data
{
     public class meDbContext : IdentityDbContext<AppUser,AppRole,int>{
         public meDbContext(DbContextOptions<meDbContext> options):base(options){
            
         }//ef
         protected override void OnModelCreating(ModelBuilder builder)
        {
 
            base.OnModelCreating(builder);
        }
        public DbSet<AppUser> AppUsers {get;set;}
        public DbSet<Car> Car {get;set;} //this map is to create a new table called Car
         //that has the structure based  Car.cs

        public DbSet<Staff> Staff {get;set;}

        public DbSet<Customer> Customer {get;set;}
    
     }//ec
}//en