using E_Voter.Domain.Entities;
using E_Voter.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Persistence;

public static class SeedDemographicPlaceData
{
    public static void Add(ModelBuilder modelBuilder)
    {
        // Seed Provinces
        modelBuilder.Entity<Province>().HasData(
            new Province { ProvinceId = 1, ProvinceName = "Province No. 1", ProvinceCode = "P1" },
            new Province { ProvinceId = 2, ProvinceName = "Madhesh Province", ProvinceCode = "P2" },
            new Province { ProvinceId = 3, ProvinceName = "Bagmati Province", ProvinceCode = "P3" },
            new Province { ProvinceId = 4, ProvinceName = "Gandaki Province", ProvinceCode = "P4" },
            new Province { ProvinceId = 5, ProvinceName = "Lumbini Province", ProvinceCode = "P5" },
            new Province { ProvinceId = 6, ProvinceName = "Karnali Province", ProvinceCode = "P6" },
            new Province { ProvinceId = 7, ProvinceName = "Sudurpashchim Province", ProvinceCode = "P7" }
        );

        // Seed Districts
        modelBuilder.Entity<District>().HasData(
            // Province 1 (14 districts)
            new District { DistrictId = 1, DistrictCode = "BHJ", DistrictName = "Bhojpur", ProvinceId = 1 },
            new District { DistrictId = 2, DistrictCode = "DHK", DistrictName = "Dhankuta", ProvinceId = 1 },
            new District { DistrictId = 3, DistrictCode = "ILM", DistrictName = "Ilam", ProvinceId = 1 },
            new District { DistrictId = 4, DistrictCode = "JHP", DistrictName = "Jhapa", ProvinceId = 1 },
            new District { DistrictId = 5, DistrictCode = "KHT", DistrictName = "Khotang", ProvinceId = 1 },
            new District { DistrictId = 6, DistrictCode = "MRG", DistrictName = "Morang", ProvinceId = 1 },
            new District { DistrictId = 7, DistrictCode = "OKH", DistrictName = "Okhaldhunga", ProvinceId = 1 },
            new District { DistrictId = 8, DistrictCode = "PAN", DistrictName = "Panchthar", ProvinceId = 1 },
            new District { DistrictId = 9, DistrictCode = "SKW", DistrictName = "Sankhuwasabha", ProvinceId = 1 },
            new District { DistrictId = 10, DistrictCode = "SLK", DistrictName = "Solukhumbu", ProvinceId = 1 },
            new District { DistrictId = 11, DistrictCode = "SNS", DistrictName = "Sunsari", ProvinceId = 1 },
            new District { DistrictId = 12, DistrictCode = "TPL", DistrictName = "Taplejung", ProvinceId = 1 },
            new District { DistrictId = 13, DistrictCode = "TRH", DistrictName = "Terhathum", ProvinceId = 1 },
            new District { DistrictId = 14, DistrictCode = "UDY", DistrictName = "Udayapur", ProvinceId = 1 },

            // Province 2 (8 districts)
            new District { DistrictId = 15, DistrictCode = "SPT", DistrictName = "Saptari", ProvinceId = 2 },
            new District { DistrictId = 16, DistrictCode = "SRH", DistrictName = "Siraha", ProvinceId = 2 },
            new District { DistrictId = 17, DistrictCode = "DNS", DistrictName = "Dhanusa", ProvinceId = 2 },
            new District { DistrictId = 18, DistrictCode = "MTR", DistrictName = "Mahottari", ProvinceId = 2 },
            new District { DistrictId = 19, DistrictCode = "SRL", DistrictName = "Sarlahi", ProvinceId = 2 },
            new District { DistrictId = 20, DistrictCode = "RTH", DistrictName = "Rautahat", ProvinceId = 2 },
            new District { DistrictId = 21, DistrictCode = "BAR", DistrictName = "Bara", ProvinceId = 2 },
            new District { DistrictId = 22, DistrictCode = "PRS", DistrictName = "Parsa", ProvinceId = 2 },

            // Province 3 (13 districts)
            new District { DistrictId = 23, DistrictCode = "DOL", DistrictName = "Dolakha", ProvinceId = 3 },
            new District { DistrictId = 24, DistrictCode = "SDC", DistrictName = "Sindhupalchok", ProvinceId = 3 },
            new District { DistrictId = 25, DistrictCode = "RAS", DistrictName = "Rasuwa", ProvinceId = 3 },
            new District { DistrictId = 26, DistrictCode = "DHD", DistrictName = "Dhading", ProvinceId = 3 },
            new District { DistrictId = 27, DistrictCode = "NWK", DistrictName = "Nuwakot", ProvinceId = 3 },
            new District { DistrictId = 28, DistrictCode = "KTM", DistrictName = "Kathmandu", ProvinceId = 3 },
            new District { DistrictId = 29, DistrictCode = "BKT", DistrictName = "Bhaktapur", ProvinceId = 3 },
            new District { DistrictId = 30, DistrictCode = "LTP", DistrictName = "Lalitpur", ProvinceId = 3 },
            new District { DistrictId = 31, DistrictCode = "KPL", DistrictName = "Kavrepalanchok", ProvinceId = 3 },
            new District { DistrictId = 32, DistrictCode = "RMP", DistrictName = "Ramechhap", ProvinceId = 3 },
            new District { DistrictId = 33, DistrictCode = "SDI", DistrictName = "Sindhuli", ProvinceId = 3 },
            new District { DistrictId = 34, DistrictCode = "MKW", DistrictName = "Makwanpur", ProvinceId = 3 },
            new District { DistrictId = 35, DistrictCode = "CTW", DistrictName = "Chitwan", ProvinceId = 3 },

            // Province 4 (11 districts)
            new District { DistrictId = 36, DistrictCode = "GRK", DistrictName = "Gorkha", ProvinceId = 4 },
            new District { DistrictId = 37, DistrictCode = "MNG", DistrictName = "Manang", ProvinceId = 4 },
            new District { DistrictId = 38, DistrictCode = "MST", DistrictName = "Mustang", ProvinceId = 4 },
            new District { DistrictId = 39, DistrictCode = "MGD", DistrictName = "Myagdi", ProvinceId = 4 },
            new District { DistrictId = 40, DistrictCode = "KSK", DistrictName = "Kaski", ProvinceId = 4 },
            new District { DistrictId = 41, DistrictCode = "LMJ", DistrictName = "Lamjung", ProvinceId = 4 },
            new District { DistrictId = 42, DistrictCode = "TNH", DistrictName = "Tanahun", ProvinceId = 4 },
            new District { DistrictId = 43, DistrictCode = "NLE", DistrictName = "Nawalparasi East", ProvinceId = 4 },
            new District { DistrictId = 44, DistrictCode = "SNG", DistrictName = "Syangja", ProvinceId = 4 },
            new District { DistrictId = 45, DistrictCode = "PBT", DistrictName = "Parbat", ProvinceId = 4 },
            new District { DistrictId = 46, DistrictCode = "BGL", DistrictName = "Baglung", ProvinceId = 4 },

            // Province 5 (12 districts)
            new District { DistrictId = 47, DistrictCode = "KPT", DistrictName = "Kapilvastu", ProvinceId = 5 },
            new District { DistrictId = 48, DistrictCode = "PRS", DistrictName = "Parasi", ProvinceId = 5 },
            new District { DistrictId = 49, DistrictCode = "RUP", DistrictName = "Rupandehi", ProvinceId = 5 },
            new District { DistrictId = 50, DistrictCode = "ARG", DistrictName = "Arghakhanchi", ProvinceId = 5 },
            new District { DistrictId = 51, DistrictCode = "GLM", DistrictName = "Gulmi", ProvinceId = 5 },
            new District { DistrictId = 52, DistrictCode = "PLP", DistrictName = "Palpa", ProvinceId = 5 },
            new District { DistrictId = 53, DistrictCode = "DNG", DistrictName = "Dang", ProvinceId = 5 },
            new District { DistrictId = 54, DistrictCode = "PYT", DistrictName = "Pyuthan", ProvinceId = 5 },
            new District { DistrictId = 55, DistrictCode = "RLP", DistrictName = "Rolpa", ProvinceId = 5 },
            new District { DistrictId = 56, DistrictCode = "RKT", DistrictName = "Rukum East", ProvinceId = 5 },
            new District { DistrictId = 57, DistrictCode = "BNK", DistrictName = "Banke", ProvinceId = 5 },
            new District { DistrictId = 58, DistrictCode = "BRD", DistrictName = "Bardiya", ProvinceId = 5 },

            // Province 6 (10 districts)
            new District { DistrictId = 59, DistrictCode = "DLP", DistrictName = "Dolpa", ProvinceId = 6 },
            new District { DistrictId = 60, DistrictCode = "MUG", DistrictName = "Mugu", ProvinceId = 6 },
            new District { DistrictId = 61, DistrictCode = "HML", DistrictName = "Humla", ProvinceId = 6 },
            new District { DistrictId = 62, DistrictCode = "JML", DistrictName = "Jumla", ProvinceId = 6 },
            new District { DistrictId = 63, DistrictCode = "KKT", DistrictName = "Kalikot", ProvinceId = 6 },
            new District { DistrictId = 64, DistrictCode = "DLK", DistrictName = "Dailekh", ProvinceId = 6 },
            new District { DistrictId = 65, DistrictCode = "JJK", DistrictName = "Jajarkot", ProvinceId = 6 },
            new District { DistrictId = 66, DistrictCode = "RKW", DistrictName = "Rukum West", ProvinceId = 6 },
            new District { DistrictId = 67, DistrictCode = "SLN", DistrictName = "Salyan", ProvinceId = 6 },
            new District { DistrictId = 68, DistrictCode = "SVT", DistrictName = "Surkhet", ProvinceId = 6 },

            // Province 7 (9 districts)
            new District { DistrictId = 69, DistrictCode = "BJG", DistrictName = "Bajura", ProvinceId = 7 },
            new District { DistrictId = 70, DistrictCode = "BJH", DistrictName = "Bajhang", ProvinceId = 7 },
            new District { DistrictId = 71, DistrictCode = "DRC", DistrictName = "Darchula", ProvinceId = 7 },
            new District { DistrictId = 72, DistrictCode = "BTD", DistrictName = "Baitadi", ProvinceId = 7 },
            new District { DistrictId = 73, DistrictCode = "DDL", DistrictName = "Dadeldhura", ProvinceId = 7 },
            new District { DistrictId = 74, DistrictCode = "ACH", DistrictName = "Achham", ProvinceId = 7 },
            new District { DistrictId = 75, DistrictCode = "DTI", DistrictName = "Doti", ProvinceId = 7 },
            new District { DistrictId = 76, DistrictCode = "KLI", DistrictName = "Kailali", ProvinceId = 7 },
            new District { DistrictId = 77, DistrictCode = "KCP", DistrictName = "Kanchanpur", ProvinceId = 7 }
        );

        // Seed Municipalities (with MunicipalityCode)
        modelBuilder.Entity<Municipality>().HasData(
            new Municipality { MunicipalityId = 1, MunicipalityName = "Ilam Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "ILM-001", DistrictId = 3 },
            new Municipality { MunicipalityId = 2, MunicipalityName = "Maijogmai Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "ILM-002", DistrictId = 3 },
            new Municipality { MunicipalityId = 3, MunicipalityName = "Bhadrapur Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "JHP-001", DistrictId = 4 },
            new Municipality { MunicipalityId = 4, MunicipalityName = "Shivasatakshi Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "JHP-002", DistrictId = 4 },
            new Municipality { MunicipalityId = 5, MunicipalityName = "Janakpur Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "DNS-001", DistrictId = 17 },
            new Municipality { MunicipalityId = 6, MunicipalityName = "Mithila Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "DNS-002", DistrictId = 17 },
            new Municipality { MunicipalityId = 7, MunicipalityName = "Malangwa Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "SRL-001", DistrictId = 19 },
            new Municipality { MunicipalityId = 8, MunicipalityName = "Haripur Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "SRL-002", DistrictId = 19 },
            new Municipality { MunicipalityId = 9, MunicipalityName = "Kathmandu Metropolitan", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "KTM-001", DistrictId = 28 },
            new Municipality { MunicipalityId = 10, MunicipalityName = "KMC Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "KTM-002", DistrictId = 28 },
            new Municipality { MunicipalityId = 11, MunicipalityName = "Bhaktapur Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "BKT-001", DistrictId = 29 },
            new Municipality { MunicipalityId = 12, MunicipalityName = "Changunarayan Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "BKT-002", DistrictId = 29 },
            new Municipality { MunicipalityId = 13, MunicipalityName = "Lalitpur Metropolitan", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "LTP-001", DistrictId = 30 },
            new Municipality { MunicipalityId = 14, MunicipalityName = "Godawari Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "LTP-002", DistrictId = 30 },
            new Municipality { MunicipalityId = 15, MunicipalityName = "Pokhara Metropolitan", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "KSK-001", DistrictId = 40 },
            new Municipality { MunicipalityId = 16, MunicipalityName = "Lekhnath Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "KSK-002", DistrictId = 40 },
            new Municipality { MunicipalityId = 17, MunicipalityName = "Besisahar Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "LMJ-001", DistrictId = 41 },
            new Municipality { MunicipalityId = 18, MunicipalityName = "Rainas Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "LMJ-002", DistrictId = 41 },
            new Municipality { MunicipalityId = 19, MunicipalityName = "Ghorahi Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "DNG-001", DistrictId = 53 },
            new Municipality { MunicipalityId = 20, MunicipalityName = "Tulsipur Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "DNG-002", DistrictId = 53 },
            new Municipality { MunicipalityId = 21, MunicipalityName = "Birendranagar Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "SVT-001", DistrictId = 68 },
            new Municipality { MunicipalityId = 22, MunicipalityName = "Chaukune Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "SVT-002", DistrictId = 68 },
            new Municipality { MunicipalityId = 23, MunicipalityName = "Dadeldhura Municipality", MunicipalityType = MunicipalityType.Metropolitan, MunicipalityCode = "DDL-001", DistrictId = 73 },
            new Municipality { MunicipalityId = 24, MunicipalityName = "Alital Rural", MunicipalityType = MunicipalityType.Rural, MunicipalityCode = "DDL-002", DistrictId = 73 }
        );

        // Seed Wards
        modelBuilder.Entity<Ward>().HasData(
            new Ward { WardId = 1, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 5 },
            new Ward { WardId = 2, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 5 },
            new Ward { WardId = 3, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 6 },
            new Ward { WardId = 4, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 6 },
            new Ward { WardId = 5, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 7 },
            new Ward { WardId = 6, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 7 },
            new Ward { WardId = 7, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 8 },
            new Ward { WardId = 8, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 8 },
            new Ward { WardId = 9, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 9 },
            new Ward { WardId = 10, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 9 },
            new Ward { WardId = 11, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 10 },
            new Ward { WardId = 12, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 10 },
            new Ward { WardId = 13, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 11 },
            new Ward { WardId = 14, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 11 },
            new Ward { WardId = 15, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 12 },
            new Ward { WardId = 16, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 12 },
            new Ward { WardId = 17, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 13 },
            new Ward { WardId = 18, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 13 },
            new Ward { WardId = 19, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 14 },
            new Ward { WardId = 20, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 14 },
            new Ward { WardId = 21, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 15 },
            new Ward { WardId = 22, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 15 },
            new Ward { WardId = 23, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 16 },
            new Ward { WardId = 24, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 16 },
            new Ward { WardId = 25, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 17 },
            new Ward { WardId = 26, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 17 },
            new Ward { WardId = 27, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 18 },
            new Ward { WardId = 28, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 18 },
            new Ward { WardId = 29, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 19 },
            new Ward { WardId = 30, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 19 },
            new Ward { WardId = 31, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 20 },
            new Ward { WardId = 32, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 20 },
            new Ward { WardId = 33, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 21 },
            new Ward { WardId = 34, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 21 },
            new Ward { WardId = 35, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 22 },
            new Ward { WardId = 36, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 22 },
            new Ward { WardId = 37, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 23 },
            new Ward { WardId = 38, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 23 },
            new Ward { WardId = 39, WardName = "Ward 1", WardNumber = 1, MunicipalityId = 24 },
            new Ward { WardId = 40, WardName = "Ward 2", WardNumber = 2, MunicipalityId = 24 }
        );

        // Seed VotingPlaces (with VotingPlaceAddress added)
        modelBuilder.Entity<VotingPlace>().HasData(
            new VotingPlace { VotingPlaceId = 1, VotingPlaceName = "Ilam School", VotingPlaceAddress = "Ilam Bazaar, Ilam", WardId = 1 },
            new VotingPlace { VotingPlaceId = 2, VotingPlaceName = "Ilam Community Hall", VotingPlaceAddress = "Ilam Municipality Ward Office, Ilam", WardId = 1 },
            new VotingPlace { VotingPlaceId = 3, VotingPlaceName = "Maijogmai School", VotingPlaceAddress = "Maijogmai Rural Area", WardId = 2 },
            new VotingPlace { VotingPlaceId = 4, VotingPlaceName = "Maijogmai Hall", VotingPlaceAddress = "Maijogmai Community Center", WardId = 2 },
            new VotingPlace { VotingPlaceId = 5, VotingPlaceName = "Bhadrapur School", VotingPlaceAddress = "Bhadrapur City Center", WardId = 3 },
            new VotingPlace { VotingPlaceId = 6, VotingPlaceName = "Bhadrapur Hall", VotingPlaceAddress = "Bhadrapur Municipal Hall", WardId = 3 },
            new VotingPlace { VotingPlaceId = 7, VotingPlaceName = "Shivasatakshi School", VotingPlaceAddress = "Shivasatakshi Rural School", WardId = 4 },
            new VotingPlace { VotingPlaceId = 8, VotingPlaceName = "Shivasatakshi Hall", VotingPlaceAddress = "Shivasatakshi Community Hall", WardId = 4 },
            new VotingPlace { VotingPlaceId = 9, VotingPlaceName = "Janakpur School", VotingPlaceAddress = "Janakpur City", WardId = 1 },
            new VotingPlace { VotingPlaceId = 10, VotingPlaceName = "Janakpur Hall", VotingPlaceAddress = "Janakpur Municipal Building", WardId = 2 },
            new VotingPlace { VotingPlaceId = 11, VotingPlaceName = "Mithila School", VotingPlaceAddress = "Mithila Rural Area", WardId = 3 },
            new VotingPlace { VotingPlaceId = 12, VotingPlaceName = "Mithila Hall", VotingPlaceAddress = "Mithila Community Hall", WardId = 4 },
            new VotingPlace { VotingPlaceId = 13, VotingPlaceName = "Malangwa School", VotingPlaceAddress = "Malangwa City Center", WardId = 5 },
            new VotingPlace { VotingPlaceId = 14, VotingPlaceName = "Malangwa Hall", VotingPlaceAddress = "Malangwa Municipal Office", WardId = 6 },
            new VotingPlace { VotingPlaceId = 15, VotingPlaceName = "Haripur School", VotingPlaceAddress = "Haripur Rural School", WardId = 7 },
            new VotingPlace { VotingPlaceId = 16, VotingPlaceName = "Haripur Hall", VotingPlaceAddress = "Haripur Community Center", WardId = 8 },
            new VotingPlace { VotingPlaceId = 17, VotingPlaceName = "Kathmandu School", VotingPlaceAddress = "Kathmandu Metropolitan Area", WardId = 9 },
            new VotingPlace { VotingPlaceId = 18, VotingPlaceName = "Kathmandu Hall", VotingPlaceAddress = "Kathmandu City Hall", WardId = 10 },
            new VotingPlace { VotingPlaceId = 19, VotingPlaceName = "KMC School", VotingPlaceAddress = "KMC Rural Zone", WardId = 11 },
            new VotingPlace { VotingPlaceId = 20, VotingPlaceName = "KMC Hall", VotingPlaceAddress = "KMC Rural Office", WardId = 12 },
            new VotingPlace { VotingPlaceId = 21, VotingPlaceName = "Bhaktapur School", VotingPlaceAddress = "Bhaktapur City", WardId = 13 },
            new VotingPlace { VotingPlaceId = 22, VotingPlaceName = "Bhaktapur Hall", VotingPlaceAddress = "Bhaktapur Municipal Hall", WardId = 14 },
            new VotingPlace { VotingPlaceId = 23, VotingPlaceName = "Changunarayan School", VotingPlaceAddress = "Changunarayan Rural Area", WardId = 15 },
            new VotingPlace { VotingPlaceId = 24, VotingPlaceName = "Changunarayan Hall", VotingPlaceAddress = "Changunarayan Community Center", WardId = 16 },
            new VotingPlace { VotingPlaceId = 25, VotingPlaceName = "Lalitpur School", VotingPlaceAddress = "Lalitpur Metropolitan", WardId = 17 },
            new VotingPlace { VotingPlaceId = 26, VotingPlaceName = "Lalitpur Hall", VotingPlaceAddress = "Lalitpur City Hall", WardId = 18 },
            new VotingPlace { VotingPlaceId = 27, VotingPlaceName = "Godawari School", VotingPlaceAddress = "Godawari Rural Area", WardId = 19 },
            new VotingPlace { VotingPlaceId = 28, VotingPlaceName = "Godawari Hall", VotingPlaceAddress = "Godawari Community Hall", WardId = 20 },
            new VotingPlace { VotingPlaceId = 29, VotingPlaceName = "Pokhara School", VotingPlaceAddress = "Pokhara Lakeside", WardId = 21 },
            new VotingPlace { VotingPlaceId = 30, VotingPlaceName = "Pokhara Hall", VotingPlaceAddress = "Pokhara Municipal Office", WardId = 22 },
            new VotingPlace { VotingPlaceId = 31, VotingPlaceName = "Lekhnath School", VotingPlaceAddress = "Lekhnath Area", WardId = 23 },
            new VotingPlace { VotingPlaceId = 32, VotingPlaceName = "Lekhnath Hall", VotingPlaceAddress = "Lekhnath Community Center", WardId = 24 },
            new VotingPlace { VotingPlaceId = 33, VotingPlaceName = "Besisahar School", VotingPlaceAddress = "Besisahar Town", WardId = 25 },
            new VotingPlace { VotingPlaceId = 34, VotingPlaceName = "Besisahar Hall", VotingPlaceAddress = "Besisahar Municipal Building", WardId = 26 },
            new VotingPlace { VotingPlaceId = 35, VotingPlaceName = "Rainas School", VotingPlaceAddress = "Rainas Rural Area", WardId = 27 },
            new VotingPlace { VotingPlaceId = 36, VotingPlaceName = "Rainas Hall", VotingPlaceAddress = "Rainas Community Hall", WardId = 28 },
            new VotingPlace { VotingPlaceId = 37, VotingPlaceName = "Ghorahi School", VotingPlaceAddress = "Ghorahi City", WardId = 29 },
            new VotingPlace { VotingPlaceId = 38, VotingPlaceName = "Ghorahi Hall", VotingPlaceAddress = "Ghorahi Municipal Office", WardId = 30 },
            new VotingPlace { VotingPlaceId = 39, VotingPlaceName = "Tulsipur School", VotingPlaceAddress = "Tulsipur Town", WardId = 31 },
            new VotingPlace { VotingPlaceId = 40, VotingPlaceName = "Tulsipur Hall", VotingPlaceAddress = "Tulsipur Community Center", WardId = 32 },
            new VotingPlace { VotingPlaceId = 41, VotingPlaceName = "Birendranagar School", VotingPlaceAddress = "Birendranagar City", WardId = 33 },
            new VotingPlace { VotingPlaceId = 42, VotingPlaceName = "Birendranagar Hall", VotingPlaceAddress = "Birendranagar Municipal Hall", WardId = 34 },
            new VotingPlace { VotingPlaceId = 43, VotingPlaceName = "Chaukune School", VotingPlaceAddress = "Chaukune Rural Area", WardId = 35 },
            new VotingPlace { VotingPlaceId = 44, VotingPlaceName = "Chaukune Hall", VotingPlaceAddress = "Chaukune Community Hall", WardId = 36 },
            new VotingPlace { VotingPlaceId = 45, VotingPlaceName = "Dadeldhura School", VotingPlaceAddress = "Dadeldhura Town", WardId = 37 },
            new VotingPlace { VotingPlaceId = 46, VotingPlaceName = "Dadeldhura Hall", VotingPlaceAddress = "Dadeldhura Municipal Office", WardId = 38 },
            new VotingPlace { VotingPlaceId = 47, VotingPlaceName = "Alital School", VotingPlaceAddress = "Alital Rural Area", WardId = 39 },
            new VotingPlace { VotingPlaceId = 48, VotingPlaceName = "Alital Hall", VotingPlaceAddress = "Alital Community Hall", WardId = 40 }
        );
    }

}