using E_Voter.Domain.Entities;
using E_Voter.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Persistence;

public static class SeedElectionPartyData
{
    public static void Add(ModelBuilder modelBuilder)
    {
        var electionParties = new List<ElectionParty>
        {
            new ElectionParty
            {
                Id = 1,
                Name = "Nepali Congress",
                Abbreviation = "NC",
                LeaderName = "Sher Bahadur Deuba",
                FoundedOn = new DateTime(1947, 1, 25),
                Status = PartyStatus.Active,
                Ideology = "Social democracy",
                PoliticalSpectrum = "Centre",
                OfficialWebsite = "https://nepalicongress.org",
                ContactEmail = "info@nepalicongress.org",
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 2,
                Name = "Communist Party of Nepal (Unified Marxist–Leninist)",
                Abbreviation = "CPN-UML",
                LeaderName = "K.P. Sharma Oli",
                FoundedOn = new DateTime(1991, 1, 6),
                Status = PartyStatus.Active,
                Ideology = "Marxism–Leninism",
                PoliticalSpectrum = "Left",
                OfficialWebsite = "https://cpnuml.org",
                ContactEmail = "contact@cpnuml.org",
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 3,
                Name = "Communist Party of Nepal (Maoist Centre)",
                Abbreviation = "CPN (Maoist Centre)",
                LeaderName = "Pushpa Kamal Dahal",
                FoundedOn = new DateTime(1994, 2, 13),
                Status = PartyStatus.Active,
                Ideology = "Maoism",
                PoliticalSpectrum = "Left",
                OfficialWebsite = "https://cpnmaoist.org",
                ContactEmail = "info@cpnmaoist.org",
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 4,
                Name = "Rastriya Swatantra Party",
                Abbreviation = "RSP",
                LeaderName = "Rabi Lamichhane",
                FoundedOn = new DateTime(2022, 7, 1),
                Status = PartyStatus.Active,
                Ideology = "Economic liberalism, progressivism",
                PoliticalSpectrum = "Centre",
                OfficialWebsite = "https://rspnepal.org",
                ContactEmail = "info@rspnepal.org",
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 5,
                Name = "Rastriya Prajatantra Party",
                Abbreviation = "RPP",
                LeaderName = "Rajendra Prasad Lingden",
                FoundedOn = new DateTime(1990, 12, 18),
                Status = PartyStatus.Active,
                Ideology = "Constitutional monarchy, Hindu nationalism",
                PoliticalSpectrum = "Right",
                OfficialWebsite = "https://rppnepal.org",
                ContactEmail = "contact@rppnepal.org",
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 6,
                Name = "Communist Party of Nepal (Unified Socialist)",
                Abbreviation = "CPN (US)",
                LeaderName = "Madhav Kumar Nepal",
                FoundedOn = new DateTime(2021, 8, 18),
                Status = PartyStatus.Active,
                Ideology = "Marxism–Leninism",
                PoliticalSpectrum = "Left",
                OfficialWebsite = null,
                ContactEmail = null,
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 7,
                Name = "Janata Samajbadi Party, Nepal",
                Abbreviation = "JSPN",
                LeaderName = "Upendra Yadav",
                FoundedOn = new DateTime(2020, 4, 22),
                Status = PartyStatus.Active,
                Ideology = "Democratic socialism",
                PoliticalSpectrum = "Centre-left",
                OfficialWebsite = null,
                ContactEmail = null,
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 8,
                Name = "Loktantrik Samajwadi Party, Nepal",
                Abbreviation = "LSP",
                LeaderName = "Mahatma Thakur",
                FoundedOn = new DateTime(2021, 8, 18),
                Status = PartyStatus.Active,
                Ideology = "Social democracy",
                PoliticalSpectrum = "Centre-left",
                OfficialWebsite = null,
                ContactEmail = null,
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 9,
                Name = "Janamat Party",
                Abbreviation = "JP",
                LeaderName = "C.K. Raut",
                FoundedOn = new DateTime(2019, 1, 10),
                Status = PartyStatus.Active,
                Ideology = "Social democracy, regionalism",
                PoliticalSpectrum = "Centre",
                OfficialWebsite = null,
                ContactEmail = null,
                IsRecognizedNationally = true
            },
            new ElectionParty
            {
                Id = 10,
                Name = "Nagrik Unmukti Party",
                Abbreviation = "NUP",
                LeaderName = "Resham Chaudhary",
                FoundedOn = new DateTime(2022, 10, 16),
                Status = PartyStatus.Active,
                Ideology = "Regionalism, social democracy",
                PoliticalSpectrum = "Centre-left",
                OfficialWebsite = null,
                ContactEmail = null,
                IsRecognizedNationally = false
            }
        };

        modelBuilder.Entity<ElectionParty>().HasData(electionParties);
    }
}