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
    }
}

