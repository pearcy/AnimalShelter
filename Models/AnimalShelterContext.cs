using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Type> Types { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}