using E_Voter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Persistence;

public static class FluentApiDbConstraints
{
    public static void ConfigureDbConstraints(ModelBuilder modelBuilder)
    {
        ConfigureUniqueIndexes(modelBuilder);
    }

    private static void ConfigureUniqueIndexes(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ElectionParty>(entity =>
        {
            // Ensures the Name is unique at the database level
            entity.HasIndex(e => e.Name)
                .IsUnique()
                .HasDatabaseName("UIX_ElectionParty_Name");

            // Ensures the Abbreviation is unique at the database level
            entity.HasIndex(e => e.Abbreviation)
                .IsUnique()
                .HasDatabaseName("UIX_ElectionParty_Abbreviation");
            
            //relationship with logo
            entity.HasOne(p => p.LogoFile)
                .WithMany()
                .HasForeignKey(p => p.LogoFileId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict); //The database blocks the deletion of the LogoFile if the id exists in election party table
        });
        
        modelBuilder.Entity<Province>()
            .HasIndex(p => p.ProvinceName)
            .IsUnique();
        modelBuilder.Entity<Province>()
            .HasIndex(p => p.ProvinceCode)
            .IsUnique();
        
        modelBuilder.Entity<District>()
            .HasIndex(p => new { p.ProvinceId, p.DistrictName})
            .IsUnique();
        modelBuilder.Entity<District>()
            .HasIndex(p => new { p.ProvinceId, p.DistrictCode})
            .IsUnique();
        
        modelBuilder.Entity<Municipality>()
            .HasIndex(p => new { p.DistrictId, p.MunicipalityName })
            .IsUnique();
        modelBuilder.Entity<Municipality>()
            .HasIndex(p => new { p.DistrictId, p.MunicipalityCode})
            .IsUnique();
        
        modelBuilder.Entity<Ward>()
            .HasIndex(p => new { p.MunicipalityId, p.WardName})
            .IsUnique();
        modelBuilder.Entity<Ward>()
            .HasIndex(p => new { p.MunicipalityId, p.WardNumber})
            .IsUnique();
        
        modelBuilder.Entity<VotingPlace>()
            .HasIndex(p => p.VotingPlaceAddress)
            .IsUnique();
    }
}

