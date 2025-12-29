using E_Voter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        AuditInterceptor auditInterceptor) : DbContext(options)
{
    public DbSet<Province> Provinces => Set<Province>();
    public DbSet<District> Districts => Set<District>();
    public DbSet<Municipality> Municipalities => Set<Municipality>();
    public DbSet<Ward> Wards => Set<Ward>();
    public DbSet<VotingPlace> VotingPlaces => Set<VotingPlace>();
    public DbSet<Voter> Voters => Set<Voter>();
    public DbSet<ElectionParty> ElectionParties => Set<ElectionParty>();
    public DbSet<MediaFile> MediaFiles => Set<MediaFile>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(auditInterceptor);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureManyToManyEntities(modelBuilder);
        FluentApiDbConstraints.ConfigureDbConstraints(modelBuilder);
        base.OnModelCreating(modelBuilder);

        // SeedDemographicPlaceData.Add(modelBuilder);
        // SeedVoterData.Add(modelBuilder);
        // SeedElectionPartyData.Add(modelBuilder);
    }

    private static void ConfigureManyToManyEntities(ModelBuilder modelBuilder)
    {
    }
}