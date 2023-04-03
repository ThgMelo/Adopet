using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class TutorContext : DbContext
{
    public TutorContext(DbContextOptions<TutorContext> opts) : base(opts)
    {

    }

    public DbSet<Tutor> Tutores { get; set; }
}
