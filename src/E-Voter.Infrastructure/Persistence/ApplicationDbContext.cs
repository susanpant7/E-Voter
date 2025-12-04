using E_Voter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}

    public DbSet<Voter> Voters => Set<Voter>();
}