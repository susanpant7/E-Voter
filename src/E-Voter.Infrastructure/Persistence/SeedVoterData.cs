using E_Voter.Domain.Entities;
using E_Voter.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Persistence;

public static class SeedVoterData
{
    public static void Add(ModelBuilder modelBuilder)
    {
        var voters = new List<Voter>();

        // Common Nepali male first names
        var maleFirstNames = new[] { "Ram", "Shyam", "Hari", "Krishna", "Suresh", "Bishnu", "Santosh", "Dipak", "Rajesh", "Arjun", "Prakash", "Mohan", "Gopal", "Nabin", "Bikash" };

        // Common Nepali female first names
        var femaleFirstNames = new[] { "Sita", "Gita", "Laxmi", "Sarita", "Sunita", "Radha", "Parbati", "Maya", "Sabitri", "Sarita", "Nisha", "Rupa", "Shova", "Anita", "Rekha" };

        // Common middle names (gender-specific)
        var maleMiddleNames = new[] { "Bahadur", "Kumar", "Prasad", "Singh", "Raj" };
        var femaleMiddleNames = new[] { "Devi", "Kumari", "Maya", "Laxmi", "Kumari" };

        // Common Nepali surnames
        var surnames = new[] { "Sharma", "Thapa", "Gurung", "Magar", "Rai", "Tamang", "Yadav", "Shrestha", "Karki", "Maharjan", "Khadka", "Chaudhary", "Lama", "B.K.", "Nepali" };

        // Valid Nepali mobile prefixes
        var prefixes = new[] { "984", "985", "986", "974", "975", "976", "961", "962", "963", "988", "980", "981", "982" };

        var random = Random.Shared;

        for (int votingPlaceId = 1; votingPlaceId <= 48; votingPlaceId++)
        {
            for (int i = 1; i <= 10; i++)
            {
                bool isMale = random.Next(0, 2) == 0; // 50% male/female
                Gender gender = isMale ? Gender.Male : Gender.Female;

                string firstName = isMale 
                    ? maleFirstNames[random.Next(maleFirstNames.Length)] 
                    : femaleFirstNames[random.Next(femaleFirstNames.Length)];

                string middleName = isMale 
                    ? maleMiddleNames[random.Next(maleMiddleNames.Length)] 
                    : femaleMiddleNames[random.Next(femaleMiddleNames.Length)];

                string lastName = surnames[random.Next(surnames.Length)];

                // Generate realistic Nepali mobile number
                string prefix = prefixes[random.Next(prefixes.Length)];
                int remaining = random.Next(1000000, 9999999);
                string mobileNumber = $"+977{prefix}{remaining}";

                voters.Add(new Voter
                {
                    VoterId = Guid.NewGuid(),
                    VoterCardNumber = $"NPV-{votingPlaceId:D3}-{i:D4}",
                    FirstName = firstName,
                    MiddleName = middleName,
                    LastName = lastName,
                    Gender = gender,
                    MobileNumber = mobileNumber,
                    VotingPlaceId = votingPlaceId,
                    RegisteredAt = DateTime.UtcNow.AddDays(-random.Next(1, 730)),
                    IsVerified = random.Next(0, 10) < 8, // ~80% verified
                    IsActive = true
                });
            }
        }
        modelBuilder.Entity<Voter>().HasData(voters);
    }
}