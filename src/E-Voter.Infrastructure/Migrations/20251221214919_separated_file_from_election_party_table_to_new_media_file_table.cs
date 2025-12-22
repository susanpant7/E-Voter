using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Voter.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class separated_file_from_election_party_table_to_new_media_file_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("000fbdd2-5586-4dfc-b0f1-eae294e1e748"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("00208455-01d7-4e4c-82bd-00686f7d3aae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("00233d24-4101-4e55-a623-a566e404290b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0024b770-632f-4170-bfbf-7010cc646b9a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("002b188c-9837-41fd-addd-a15e2bc70d9d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("00d2a84a-e244-49f4-b377-85072259f0d7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("010fd42b-9c90-4915-9eb0-1b2af35f4bf1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("01478f13-543e-43d6-8d40-8afaf980d0b2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0176d23c-53fd-4f0b-bb57-a05547a8bf03"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("019522be-ebef-49f4-a70c-d9877be87146"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("02cd5533-ca99-4493-a640-f8cbd93e049d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("04116eb4-4f28-4006-ae8b-e27e691329b8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0441049f-288d-4355-8bb4-f12382c16696"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("047f3c0d-c030-4b10-8316-1e8cb830d43e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0587cec7-4c90-43cf-86c6-8f9432824422"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("05c03f20-f254-4998-a7ac-d619e33a900b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0630a847-cc4b-4c39-ba1d-20293ac7f06f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("076207ff-ca19-42ef-91bd-ca87d39e557d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("079ecc06-55c9-427b-9d93-cff58b478478"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("08534da4-6a8e-4ef3-bfe5-0c54767c6111"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0865a445-328e-45b3-a1f6-904dce8fb021"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("099e7547-870b-4060-986a-fcc793a9c2f7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0a0d3773-1de8-4be1-9537-c753d4904af4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0a8d8f05-950d-4f8e-839b-81a933712e51"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0b9f82cd-0fe0-41e6-974e-e9ec73bf33dc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0bf3ee67-e61c-4c6d-bb59-d62e8be765d1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0c945825-6c3a-441a-a026-353d3555d6dd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0cc57c70-9578-48e1-a0e5-ba2bcd425a52"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0d8ad21b-c66d-402e-946e-8b397488b8ae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0e06bc8a-5d5c-4419-9c2a-93da347c8888"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0ec5a5a3-8064-4c02-892c-8dd52848e528"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0ee3594c-6b99-46f8-96d8-080576a5c6b6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0f48e397-2fff-4119-bac7-9bba864010d7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0f941bc7-7b6e-41ad-9e5f-f00f4c86a58b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0ffd8bb9-9a62-4aa1-b318-75cf60a4f3e2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("114afccc-9151-40a3-b2f4-ba9d07fe68f9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("11bbccd0-fd0c-409d-86a3-a36336a22527"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("13f24807-100e-4df7-be41-38a88a466a38"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("14b4f7a3-bc37-4e9d-8379-ca2f700874f3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1592d560-bcd7-48e4-a5f2-ffb148b5b12f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("164d6ac2-f5d4-4dc2-a884-722b258a406e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("16a90bea-76d0-4e27-915d-6eff3a798517"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("17a8fb01-3323-4327-9d0e-ec93db2b1863"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("17f3ee80-8744-4bca-9a02-9847689eaa26"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("196c84d7-bf8c-4ab1-964e-4135288e1df4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("19711f96-f9a5-44da-aa5f-396f67f0e79c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("197b3ed8-9e95-45f2-af0b-32fd1959020d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1a092b96-5764-4e79-86f3-85f742564c5f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1a19f32e-6cd6-4070-82dd-f43791dcb012"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1a26e50c-c494-414c-ba5f-3ade7eed7d84"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1a53a9c3-2c26-41e9-95e0-cbdca31a3a80"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1a5ed1ea-4cca-4dc0-bc77-48cf43741929"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1befe9c8-9545-40c2-9c72-7d4b14bc498b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1c4fabfe-6bef-40e6-ae63-33f24bf89a56"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1d021a83-4161-4d05-9c36-c836235d2fac"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1ebbe052-5f41-478f-974e-9e22aa0b544c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1ee5a71c-ee09-4d41-bb25-73090e0317bf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1f9c8791-a197-4434-b58d-629b79c8af13"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1fb5933e-14b8-48f4-9bbc-cbbc37700ea8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("20d03353-add1-4468-8bec-c3711863aad7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2217054a-8162-4d56-b382-57307938b103"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2262a11e-22f8-4c21-8cfb-dc6e5630424b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2286566e-89e0-44e6-894f-8e375fef2c32"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("23f9e834-6724-4086-9a30-91c825894ad5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2478c127-01b2-4c98-b924-1a13079614c3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("25ca2474-a523-4d97-ba1c-f1f785772842"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("26a7bb4e-a52e-4d61-82fd-b89ee150795b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2835159d-3f56-4747-b870-2ded00e4785c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("28541e8e-f9b7-4450-949d-12e9f494b633"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("29ff74e2-1932-4215-818a-16461d1b6eac"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2ae592b8-f243-449f-beb0-e5ec17fc7252"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2b4ffbf0-0fc3-46a1-a7dc-072eb4e95a32"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2b7e32db-19a6-486c-a2c7-be02d5236e86"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2ba91ae4-14bb-4909-9cb6-4b191f696bb2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2c6091da-83e1-46cf-952a-82a423fe674d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2c77a5d8-8479-4e0b-b83c-63f46b9fe738"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2d05881c-3cf7-4ac9-91c3-49458aa99ad2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2d1044ae-41f1-4b87-9757-214f52631e25"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2d57c7e2-f62f-4e57-a4da-d361d678f130"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2d8ecd7d-ce84-43c6-9c06-00245d98d53d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2f351979-614c-4606-9c67-7d4ced2fee4c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3081602b-b5e6-43ec-970e-cde71dffbff5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("31d925ed-be15-41d1-b729-2f6268649069"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("33b941a6-d960-41dd-8a54-f5b0d785ccae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("343ef34c-042b-431c-8497-a947a049bb92"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("35c6c85c-95a5-473e-9775-c61b47fc1802"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3662eb1c-af76-4bd0-8bf1-5ff263dec5f9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("36692b2f-122c-4bde-bd23-8c62194141fa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("36b159b5-a308-411d-ab8b-7a8d9d905511"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("36d00bb2-afea-4b5c-ba2e-c16f6ea83c2f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3767ebfe-bec3-423f-aed6-508fc9c161db"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("37844a02-55a7-4788-8209-740a6ea9ecdb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("37f84403-237d-45c4-8cf8-4fea51a98815"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3803c50e-3cf3-4b87-8187-558f77548ba4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("380fe920-0071-48cc-8732-e0be8037dfe3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("38a1f344-8ac1-4810-8584-c9369c7758e2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("38beaa41-99f3-4c83-9896-bd3b65403262"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("38c79515-12ec-46f0-824b-f66ef357c674"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("392eaf5e-5111-45df-b4cd-5d8faf8d13e7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("393d9246-1e04-49df-828d-3141d4f62db8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3a6cec46-82ab-4f4e-a52f-0ffef659684f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3a8ec36d-7d58-44db-a28e-19fc7ab60153"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3c09400c-1cae-492d-a1b9-90c996c50f19"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3c2b1602-4e15-407a-96da-56af6a7ab930"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3cfcaba7-6d74-42af-b453-39c18189e79a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3db138ad-3032-46cf-9461-ff57923a8fe9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3e0f2512-483c-467a-9e2a-05e3eb3accd7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3e5e3a0f-b1ca-4a9d-ad80-333ef76042ee"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3f6326e0-ce2b-4326-9a2f-94bd84c9c831"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3ffd8301-0a00-43cf-b7da-a0bf35b3c779"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4054babb-226b-466d-b2f9-8ee07f0d06a4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4083e273-035b-41e8-8847-14bdf73f2a6e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4083f04c-d5a5-4ee5-ab7e-912e57ab3c02"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("41b065a5-979d-406d-9dbd-b5c207da49d5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("42066e00-859e-4d86-8c98-6737a2d61cf1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("42e8ad3f-0e2b-4247-9eee-808f3164886d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("435857bd-6bc7-41c4-bafe-ba64cedf6a13"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("436a79ca-fb50-4a89-bcc7-923e1df3ee06"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("43795be1-1c59-4ca6-9e5c-a9ad59313108"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("43823cde-4142-4755-9ce7-13e8bfc13265"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("43c58681-e5d2-46cf-8cab-053c509a581a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("43e46d1a-1c73-463b-9f3a-ed732ff15f80"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("43f5c418-1b91-424a-80fc-ff7e2246797f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("44161be6-fd0e-49d4-a4b2-e5966f8f3cf3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("44305360-d183-474c-8169-95e9599a3fc2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4442fd6e-cd41-42d1-bd17-803219df6297"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("44d0eb84-3d97-4ba2-a7b4-9afcad650957"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("44f5f490-ff2e-46f7-a180-67c35e5a65ab"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("450370ef-7dbe-48b8-8181-4a1c4ac366a2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("45067207-1b9e-4fdf-a36a-94113e269d8d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4567e79f-7375-49e4-8499-c3eeb647248c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("45d257f2-aa1c-4766-b71d-15ab0f5c91fc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("49449066-adb0-496e-926b-a53cf74e2321"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("49d8a8ad-7d6c-4ed5-938a-101f11ab3a2f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4a0166e8-451d-4512-a0f5-773ea9102c20"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4a2aa2eb-1e3f-40e1-8f8e-483b2b580a76"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4b1fe7a0-de5e-46c8-8b3f-16acbc13e279"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4b4ffc62-3a8d-4c3a-97c1-8c9e6497a1a3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4c10a770-2fb0-4496-a1f3-ee2a0e023ea9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4c7ef636-7031-439c-9d26-2b48fbe98d8e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4ca0b6d6-a67c-4ebc-a325-5ae644c3ccb3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4ce8207c-f2f6-44e8-89b7-e2abb769b723"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4d308d09-ccd1-4e05-b85a-bee4ce75bfe1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4d88a77f-f26a-4313-b976-c3089925f18a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4de18a6a-9ddd-4d69-8b73-118f157d7a9e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4e18b60a-19f1-4611-af6e-d9a76f50f54a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4f1dc3bd-f27c-4ab5-bdd6-d214fb2c226d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("50261993-9558-46fb-97b5-f8c4f365ce9d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("507c0edf-cda1-47ec-a8ad-d1927733484f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("511fd45d-36e3-4957-b9b3-a8749e3ea780"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("51a5c8c5-158a-4d7d-8db7-f1ec2bb9eb04"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("51bb5b52-dd2d-4620-afbd-46af862861e2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("525354ae-b6f1-40f4-8a69-70d3d78d7c84"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("526983d5-c902-4f8c-83f0-e9a3087e272f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("52ba2c12-90d8-40a7-a15b-90fa52fe87b9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("53a5d720-d5a8-4764-a3a5-d66e787849d9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5426e125-011d-477e-ad48-74bb8e555818"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5523b28f-8034-4fa0-a0fd-17c16968bcd3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5572447f-2987-4547-9e4d-04de3514609a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("55b92406-8b75-40d6-a124-251deec98fba"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("56648429-9b7d-4afb-88e2-2556661a4f5e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("56a95200-e2e9-47f4-94a7-b9d7d07905a9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("57099844-dad8-406f-9190-ca9c32e4e33b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("57b6f238-1f78-43a9-99e8-4d972605200a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("57ce4e7c-9402-4ef4-bc0c-cc6ff9d11534"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("58063dfd-a1de-4676-badc-2346f02714e0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("581fe582-f89d-427a-a2af-64b62084dd0c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("585133af-d17f-4391-b3bb-edc671ae783d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("58a2f10a-d37a-4a35-b421-2fb9ea31026f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("594660fb-e7c3-4198-bed5-28c66bfaca7f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5a4c2288-6367-4c13-95a1-a1fc6ef2a97b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5a52bb9a-ffd3-4523-9b2d-acb97274b153"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5a669c1f-ad05-4f30-ae8d-a446a38584fa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5ad9080d-8396-4b08-9df9-a1b01e3d25c7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5ba89840-e670-4008-aa73-f1bb8267aaac"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5bfc9579-ea72-4e6c-8549-cc8c8be7ee1d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c23cc92-daca-4978-8ae2-021da298f36e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c26eb94-3b48-4bd5-a765-dcc77c88dcb3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c33382a-0122-49c3-b9e6-50400a35cbdf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c3416da-da71-4479-993d-022ca49b5e32"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5cb38115-b464-4d9f-acd2-3f1f79d63236"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5cbd48ad-51f8-4631-bc6c-a04b2d32a16a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5cd8d431-0f22-4b8c-9f47-907f28127493"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5d5afecb-ab6c-4c2f-8760-1d5f33517c0d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5dc06fe9-5f50-44b6-9120-485967161a99"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5dc8b4c3-0db6-4c32-8066-96f003ca17a6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5e0acae4-8f13-4146-aae1-ecca96ae16bb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5ec0f08d-7cfd-48d0-8373-8387bb98fa8a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5f6445af-3252-4606-a6db-855418de4dd6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5ffff54e-c3fe-4cf6-abcb-806a36dde624"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("60468723-1e39-4835-be5a-603e7c6eab7f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("608ad8e7-7a77-4386-bc51-6e6d02ef8143"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("616cf646-cbb5-4518-b4b2-f578089cc19a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("62000069-7229-4406-a8ea-114f15cbd44d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("63345bf2-2070-471d-bb22-6a42572335dc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6350e25a-ff54-4595-b422-5aa52a27aa65"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6398cc98-6411-431e-88e6-622d16a5e832"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("640719cc-7687-4d1a-bbba-2df2a44e53ef"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6477def8-0d8b-4015-bc8c-0ff9b5bbf84d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("64d7609c-c767-4d0c-bbb9-354c0c098e47"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("656b0bd6-704a-45cb-9036-b0b6e88e499b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("664a958d-f804-49a7-9915-6676a7f5fe9c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6665a251-d818-4a84-a0b7-512cc6c58c06"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("669a933b-f65b-491f-a5f8-777f627f9892"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("66ea3aeb-a745-4633-8709-0cc13732e25a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("675d0480-3511-46c1-ac93-19cc8c50c7de"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6808f496-8e9a-44b9-b239-7b3a1dfab8a5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6827ce8a-7411-4924-9c43-8eb5ff1d09f2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("682838bc-5d71-44ef-b27a-8621ee37f756"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("68d091b1-07f0-439a-bea4-bf05facc13de"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("68fb8bef-d74d-480f-ac1f-61ca32f7084c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("69312e8a-bd2e-4e91-8329-1c0fd2cac210"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("69ae6ab6-b350-4326-83aa-59b460187e92"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6c37ee2f-cf1c-4150-a97c-1f3e99d6a158"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6dcf8786-fc58-49ce-8e87-72f383d58bb7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6e905f5d-bcac-4a98-9ba7-3e63b6d304d9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6eb2daf4-f910-44ad-bddf-940d0318531f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6f20f3b9-bbd6-450b-9a9f-6c260865602f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6f3d585e-aef4-4ee7-88a9-de3055897f32"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6f4fdb08-d48d-4c3b-b2d5-2f3d754faed1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6f5775e7-ef78-46f8-91e2-175bbe766d73"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6f797c90-4006-41f1-8ea8-4923f063941d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6fd4307b-3244-46aa-85ef-b44d37db735a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("70ba5d1b-d988-47e9-90f1-15791ecc789e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7142a478-4cde-4f7e-b697-e990c657bd1f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7147f8ba-e610-4b1a-8c72-2c0f6a4cd3f6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7160376f-e60f-4cee-866a-685d7f06b934"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("721ab76c-134b-45ad-869c-c8190f413868"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("722c5c50-5bf4-4dde-a25d-7cd6a81c7146"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("72615e09-578f-47c7-9a18-89bebbdcd1df"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("728b61fc-b04e-4618-b1b2-bd449c41a53b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("72938716-f473-4a68-9894-2acee0d40ef5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("735586cd-151b-4a91-945d-1910b3a932a5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7378430c-0a0c-4e19-8e85-b7e2d13ffccc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("73da4cea-f958-4a20-b6a9-c76fccec937f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7428c176-08c6-46a1-8e42-1417a1678d5c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("758cf61f-6328-44c5-ac92-b0e75dccfe39"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("75ca3c14-8506-4be1-a968-718879bb529a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("763fa937-10c3-4ca7-8033-782adf13fc3b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("77ac1ea8-54e3-4529-9052-b8d7b10ad841"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("788bbb83-1cf8-4946-9d57-b87dedab3421"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("79e0b88c-9af7-40ab-a0c7-b7c3ad5e58c5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7a8b10f1-10d6-4964-9c4d-dc4971164458"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7b18601a-2701-46d6-b0a3-45915fe4eda8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7bf7f849-ebf7-4240-807b-fcbb425dda93"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7c569e67-7a18-461c-bb36-d5e757a55a75"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7c5e5895-3940-42cb-a978-f2611bf14bf2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7c982572-2337-46fb-b10e-b3e4b6ed6c96"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7d2ee968-6e5c-4f23-9d9f-9e909a1667ea"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7d3d3285-5567-4f9f-9e16-dcfa91bcf8de"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7e4ee587-0abb-4934-bdd7-0de5e06ef784"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7f97594b-d027-4915-9af6-c1da6ad84302"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8379a936-6adc-4ff6-9d46-c2230d7d4779"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("84daa9e4-a21e-495c-8f3e-07b75aacad03"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8522981a-c01c-4368-80cd-41b4c85017eb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("85efe9c1-795a-403f-bc36-28914b8e1bd9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("85f16f84-77e0-4671-9028-80b54acc6b16"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("85f290b6-994d-4496-80c1-6bb6803c718e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("87196d34-bf5f-4c65-a7b5-b308ed7fcff0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("87679ab9-bbdf-4930-bb77-68355438b4d2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("87cecf04-6203-423b-b887-1bb6bd8e9403"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("88b4cdd9-1abd-46d6-9679-c79c9f36eac3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("88d5642c-6608-43d3-9891-8010b4cfb040"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("895ed9bb-39c0-4f96-aae1-ff59c29a4f13"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8a238ac4-d67e-471a-9c66-6d51ff033f40"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8a4dfb0a-bde2-4234-a679-fe82e4d7adcc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8a988f7e-b914-4045-a6f9-549feb264068"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8a9eb6b3-d0e2-4f20-97e5-f228301b9ea4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8af4b20d-2652-47a8-808a-a760c84d4c27"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8b167d3f-7444-4434-935a-aca6d3906c79"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8b4ff7c9-04d8-4022-b350-787625ac519f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8b6ea6b9-3e7f-4c32-b7e1-c1c04bc0a972"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8b72e9cc-4892-46b8-87a6-62d552c70809"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8c6e5630-9cf6-4862-8f36-2e683cf4c46e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8cb53ffd-34b1-41be-9270-448388b2d0d2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8cca5312-9e14-46d1-a099-82d701f5fa13"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8e11eaa7-65ad-48e3-b714-5a27fbade753"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8f07e01f-51f1-42aa-b43b-66bca94490a2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8f26f21c-069d-45e2-8e21-b51efe384e86"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8f57ab02-e589-4152-bfb9-082038f4187b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8f8266fd-8f51-4ec3-ad83-cfc6a5783fe9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8fa778b6-8110-47d4-8720-93fe7556271a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("90e30218-9b9e-478f-8a0f-fc147facf8b9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("92f47e50-9231-48db-a364-f9b38daba7b5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("930bd336-ec35-4bfb-8de8-c1d4263cb998"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("93ce41c8-0532-41c8-8d72-aadcdfd959d7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("94203c5a-d4b2-41f0-af58-4a2d0d9e95cd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("94733f68-3a79-4936-8268-4f9eff4779cd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("94d2d79d-9d4a-4bb9-8c21-b77f35d0d834"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9543a1c5-20d2-40a0-8ee6-574cd830f698"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9563dab7-20ae-4c84-9ddd-004cac1aa238"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("965a30e0-d9ca-47a7-a7d2-efff72d76acd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("972fa20f-76ee-4191-b003-704d3860f847"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("97b73b50-10da-4611-aa6a-8bb9644cc51c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9807c611-fe29-4002-8419-951fed3ae8c1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("98406176-afcf-42cb-b277-10957b89845a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("98c55289-4ff7-4beb-81fe-6ffe5d64d706"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("992875d2-edc1-45f5-a5ce-978227162ab2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9985ec91-4582-4d42-acd6-43e22d1caef9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9a6ddfe4-d357-4388-bed0-700f8ff101a8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9ad72346-f96d-4a79-b158-ca7441829f92"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9afcf075-8653-48f3-ae87-8887aae14761"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9b05fa75-a4e8-4f5e-94fc-af1bf935ad07"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9becbc07-5be4-4e0b-bb5b-ccc1eff82611"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9cca1e23-f67a-44fd-a542-f9f44187cda8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9ceaae22-f8ea-44cd-a478-979132c99307"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9d02fc78-514e-4d5d-83b0-d372db50574c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9d452f27-f6de-4eba-b894-c95591b7e886"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9d9a2967-c768-4f71-988e-5720740bab7f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9e1f0576-e42a-4104-bd4f-bed72ba44358"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9e94a5cc-ec9a-4523-b325-029f8a9978c6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9fcfbc4b-20ee-4982-bc80-3576eca2e2d1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9fe4ac53-ad1a-4244-b06f-04076107c035"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9ff14ba0-facd-4bab-84e6-e656f858ab2f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a02339cd-040e-4b83-a8d8-6824563b69b0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a0c26130-f747-4342-a540-615ddaafa725"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a2ef2c35-255a-4be6-871f-5cc67b139b6e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a4030f29-50e0-4ff8-9c39-c01e67c67ea0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a44c77ee-cf30-42f4-8cad-030b6477c4ca"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a512943f-7135-47b1-a748-ca0479509972"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a54a6f4a-81af-466e-b799-7f0f2b7c7b53"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a6a157ca-982e-4bb2-ad1e-e7f40696db90"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a6e2933a-243b-473d-8697-c9caa18deb53"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a6e4dfd5-75b8-43b9-be5b-35c4fb82ce36"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a729048a-4f54-4009-8eed-72ea2245b1b8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a76df46d-f6ad-44bf-992d-05b64bd983fd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a7b269a7-d981-41a1-a2ac-2a7d72934bc3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a7d8d40f-21ec-4224-8581-454dcca0bae9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a8539bfa-3db0-488e-a797-5536a5430fda"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a924f979-782d-48d8-9656-c94e06b13856"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a9952659-226f-4f38-951f-77cbbf626f13"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a9ae93aa-58cb-40bb-8e71-ba32e89a2550"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a9d630ee-1196-49a8-a678-27f20b3e740f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a9fde7cd-1edf-4115-9728-d03124618e26"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aa2e9cb3-6cf7-49ba-8092-0322e95e8110"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aa3581a2-5ab5-4264-9cc4-c596c79bf47e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aa91247e-870a-4d0f-8000-bfd5bdce0a32"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aade1d7d-95b7-41ae-a891-52b7c86a9144"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("abb3545b-d6c4-4bf3-96fe-0789b3b9c4b4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ac14aaf7-9088-490c-ae72-eedbfad146db"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ac7ee192-892b-42b4-a65d-511897233fd1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ad0a0f9a-333a-45d4-b556-78606fe129ee"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ad6805ab-a17d-467a-a134-97deb06ba739"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ae4016d7-0d01-4ea0-b613-54070f7bc1c9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ae7eb216-6e3a-4e69-ae61-e41bce68c0a9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("af5cbf22-7897-4445-8351-fb717ae315fa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b0027644-f952-4f5e-a483-2c67c4d1c8bb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b11cf2f1-9713-42e9-8a4f-85a9359d35ca"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b12c5397-ff07-4a91-8345-355a89e8768b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b13a520e-d722-4b59-861c-4f97a8865025"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b14cee9b-47ba-4a38-a225-e0700db68a2c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b161a2ce-e823-44f8-b611-886c80e83a2a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b274c86b-ac8a-43c5-ba21-cade3fa3d4dd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b33387a7-0dbf-4b12-8725-2c91ec5741c4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b366bcff-1940-4488-b029-1117b41cd929"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b3dd55b1-1af2-40e3-9945-51d7d2b10b44"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b4602cf0-4aaa-4599-9fa7-19a30887e381"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b519a8a0-d2e3-4eb1-af1f-7d93163d1ed2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b56fe07e-19e2-48b2-abc7-6d19fb51534f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b5dc5a9a-0b2c-4613-a849-1721c0325f72"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b65566b3-86de-402f-9464-4894a703af7e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b66fa75a-c147-450b-abbf-8de1e970e4f7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b8261e6e-6ac6-4683-beab-ca25fd6f9f5e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b873b3d3-715c-48a0-af20-dd6393b7a868"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b89d295b-384a-40ae-9187-d65a1d3cea77"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b8d4b339-87fe-425f-a2fe-631b548c8f9c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b9d9813a-ce28-47cc-96a5-458e769220e4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ba09494b-1798-491f-b7d5-4d20192f8bd9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bb8d24b8-ea9e-4770-85a4-e8f396045d2e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bbda2981-cc88-49e4-acaa-20e224d84ea6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bc7c0ea9-8047-4d5e-a134-b62535c71b58"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bd353d99-322c-4af1-b9f2-484c4e063b09"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bd53824c-8669-4650-807d-2ab52026e312"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bd99a37b-80b2-415a-ab49-265330ff9d81"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bdb94a95-4c55-45bf-907c-7e107a0fd1ae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bdbd156f-2ff6-4ce1-8c64-f9938ccf568e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("be56df04-103a-455e-a3cd-4dcc3a1ab70a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("be5e975a-92c0-4f51-bad1-91980001ea63"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("beb0806a-2d0b-4460-9660-5989b8d9e089"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bf09a2c0-e903-4442-849a-de611848a74a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bf807f75-948b-4938-8ac9-6e68aa5c9f96"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c10fbb65-7895-40da-be60-0ce9515da996"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c11fe15e-c395-4c45-9df9-4be2f9130fd4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c3692dcb-6657-43bc-b990-c7760ba8a187"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c4262e55-6c46-4496-a39c-6e7c7e057638"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c44beb8e-21a8-471e-b313-73d8d6748fae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c5dc1d87-4a01-4ecc-b38c-1987283971e7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c6faf413-bd2c-4fff-bbfc-be260f0e43ab"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c7d64769-e619-4bba-9cf5-4b98bf04c088"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c89721e4-dbde-4ce4-aec6-a782d7a40599"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c89812e1-728f-4398-a5b2-cf8652394939"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c8a3e30f-8025-4d0a-b9e3-4233776039e1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c912fc86-a14b-4619-9b5d-3a0791656087"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c91aa773-ec8b-451c-bc60-729ee2795fae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cb836e34-4b86-4dd5-a713-0bb18d4fbfbe"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cb9161ba-f792-4d27-a4a8-53989884c80d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cc40f930-2d8a-4c43-b0f7-01daf822fa8e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cd4caa97-8d0f-4b46-87f9-040e6f84b317"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ce45dd22-c18d-415b-b301-661e315e8fcb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cec64d21-0dbc-4845-a9a5-20de0071f2d2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cef32485-dde8-457d-bf04-7f5c9d5b591a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cf2f997d-34cb-4c96-8dd4-1ae654913a5c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d0a8d518-4570-48f9-85f8-7306651d5124"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d155459c-1b6f-4580-8dd7-eba327b45ab3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d16250e4-f4a2-4724-8a09-b9d2ef5e03d9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d2da34f8-729e-42f2-9b74-78af1c7d600c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d2f12985-2b0a-4b18-9027-d3d56e063db1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d4b342ec-29a2-4b19-a693-3ecb6d0d9ba8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d56ad508-68a9-4544-9767-eee4efc41920"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d635069c-eea2-4480-9211-a8b4dea872f6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d6fbf3b0-30a9-44ec-aa9d-0a1919aa6a85"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d73ab184-6cd2-4505-a641-de1e028b901d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d7c2f5f1-cace-4157-bf36-32b8e5597a33"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d8c791bc-07c9-4496-91e5-cc48b00f5fcb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d8f252be-97a8-47b4-a07a-5035861259db"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d902979d-5ffb-4d2f-b5e9-e392317d769f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d9285da6-f8c4-4b8a-9315-1202d87acc35"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("da1f7c1b-b411-4f45-b9bf-d9b0889c2a8e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("da31829e-c145-4cf0-b46c-22fcf372eda6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("da922def-31cf-42f1-afaf-ed940793bf8d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("db373d77-b678-43f6-a5d9-a4315e42d9e4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dbcad8a0-fa7d-49d7-8624-d060eabb1ed3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dbd695c8-9988-4911-88dc-0a90458982d4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dc5e553f-43e9-400d-acb2-69de7f98ea8c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dc9e1905-107c-451e-915c-63c5bb9a28f1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dca1a39e-15e9-415f-a4ae-62126559c981"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dceee0e9-139f-4d68-b2bf-86d5db4ee4ff"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("de1c15de-20fc-40a8-a09b-df62011dae9b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("de3d87cc-0141-41af-b781-926785c624d6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("df405ecf-6f45-46cb-a3d1-a2d36a3e8c20"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e0396370-2361-4f6b-88d6-4e12da1b6fdb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e04719b4-b5f9-4ca5-9f95-48de2100b258"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e1272df2-0ef7-4b15-ab50-0eb9f669491b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e20bffe1-570b-4253-bce5-04c7245a8af4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e2f55dd7-6900-4990-84c6-9fbc9367fb0b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e312b9b5-f03d-469d-8eda-96d2432ca5f7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e369350c-231a-45c3-90fe-04016b8e9e24"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e37a19bd-8fc6-4edb-b593-ef5466aaebb0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e3984cc9-452a-4457-a6bd-5f55e290633a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e422731f-6678-453e-936e-840531597881"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e434ee53-5a79-4b3d-b210-cbb5b175eac1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e4a8c818-86fe-417c-aa87-69e493204d0c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e4e1dc3e-539b-4947-a62f-05d524eafafe"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e4e639dd-4f46-4977-affc-3a95762c04f1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e5361b8a-41f0-43c6-9752-c8f5dc45dfb3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e550e4a6-0184-4470-a98e-42cb204b95fa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e68bee12-45d7-4e3f-a1e4-a6f29e1d1210"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e754f5fd-456d-4543-ae23-d24f69209896"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e76df00d-32fe-462d-b520-4fa67b51e7d9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e83d56c3-b28d-4a9c-ab00-fb6c10250167"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ea9f1120-d751-43ac-a1a2-abe2f2c75875"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ead98b01-f228-4731-8ee2-620ebf317b2e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eb787543-ddcf-4930-9bb6-7536f433eb59"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ebe93bb3-96a2-4fa8-9771-9a083cc05f89"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ec1a4438-44e6-4289-acda-bb25e24e62ca"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ed04a357-df21-40d8-b44b-897577c13fa4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eda85106-9055-40c1-9587-4d4c6ddeec51"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("edaa0578-e07a-4195-b78d-3759ccfa1a99"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("edc51ff4-39ec-4861-93e2-ce1e2bb97e54"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eee5f981-d2fc-4adb-85ba-f908db6705aa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f09d5943-c3d6-4915-a455-06242f8ec60e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f0c2f46a-21b4-49ae-b113-a80a10721309"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f1188189-2081-4ae4-a9fa-34b84484e7e9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f127d0ec-5f06-48cd-9e8d-ac4618754e83"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f1d3de2a-b522-4b9b-a606-a89c68f14347"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f1f35836-fcba-4c07-a81c-a1afc403adc2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f3e1dfb7-10aa-4430-ae65-c7beed7396bc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f5194610-45c0-43ae-9592-adec7eb72a4c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f687b9bc-e36d-434d-9e2c-e203f41e88fa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f71b0901-ce9e-4ebe-894a-1013f42e2dbf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f7570f03-b803-4d4b-a065-008aa02f2244"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f7d227c9-3ffd-4541-99ee-8f50c9985506"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f8eb0f7a-e20c-4422-84c5-b4bcdde1265c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fa768f85-fd1a-4dbb-8bae-816c881e1705"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fabda38b-efc9-406b-b5c7-f7e3d5a8cfcd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fb4daf5d-e463-45b5-be85-5648330ddc05"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fc488e15-2ece-442c-9dab-9306d9d35f5c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fcc57b1c-f73a-452b-a837-408c9b59d69e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("feb3dac9-1996-44e4-984f-131f0dcdfbd3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("feecd9fd-2025-4a44-91e9-d77328981879"));

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "ElectionParties");

            migrationBuilder.DropColumn(
                name: "LogoContentType",
                table: "ElectionParties");

            migrationBuilder.DropColumn(
                name: "LogoFileName",
                table: "ElectionParties");

            migrationBuilder.AddColumn<int>(
                name: "LogoFileId",
                table: "ElectionParties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MediaFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    UploadedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFiles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 4,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 5,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 6,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 7,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 8,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 9,
                column: "LogoFileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 10,
                column: "LogoFileId",
                value: null);

            migrationBuilder.InsertData(
                table: "Voters",
                columns: new[] { "VoterId", "FirstName", "Gender", "IsActive", "IsVerified", "LastName", "MiddleName", "MobileNumber", "RegisteredAt", "VoterCardNumber", "VotingPlaceId" },
                values: new object[,]
                {
                    { new Guid("020dc498-c5c8-44de-8e38-85585df2e2ae"), "Dipak", 1, true, true, "Maharjan", "Kumar", "+9779762590702", new DateTime(2024, 6, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2480), "NPV-003-0004", 3 },
                    { new Guid("032bfc4c-5bcc-4019-8a39-f2c72dca3dfa"), "Radha", 2, true, false, "B.K.", "Laxmi", "+9779805668330", new DateTime(2025, 6, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2540), "NPV-003-0008", 3 },
                    { new Guid("03f63268-91bf-497c-814b-2ea275940e18"), "Sabitri", 2, true, true, "Gurung", "Kumari", "+9779841979282", new DateTime(2025, 6, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2760), "NPV-005-0002", 5 },
                    { new Guid("0444f195-7c58-4347-8930-395b73929980"), "Bikash", 1, true, true, "Nepali", "Raj", "+9779882448020", new DateTime(2024, 5, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9570), "NPV-041-0004", 41 },
                    { new Guid("0480774f-18f0-4d58-901c-b00894621d60"), "Shova", 2, true, false, "Rai", "Laxmi", "+9779628108717", new DateTime(2024, 9, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9040), "NPV-038-0006", 38 },
                    { new Guid("05705747-2310-4d73-b132-5374ea73dd9d"), "Sabitri", 2, true, true, "Sharma", "Maya", "+9779752321078", new DateTime(2024, 1, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9330), "NPV-040-0006", 40 },
                    { new Guid("057c1b8f-ebb5-4cc5-9c25-487e768bd893"), "Gopal", 1, true, true, "Gurung", "Bahadur", "+9779865896197", new DateTime(2025, 4, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3070), "NPV-006-0004", 6 },
                    { new Guid("05a994dc-60e7-47e0-befa-7ee312ccd6c5"), "Hari", 1, true, true, "B.K.", "Raj", "+9779628218388", new DateTime(2024, 8, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3860), "NPV-010-0007", 10 },
                    { new Guid("05e3e9a3-f697-427d-ad8b-ade5802eb453"), "Nisha", 2, true, true, "Sharma", "Kumari", "+9779638812054", new DateTime(2025, 8, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8990), "NPV-038-0003", 38 },
                    { new Guid("060b1af1-3cd9-4ad1-b0c8-33d636c43b84"), "Gita", 2, true, true, "Karki", "Devi", "+9779631740561", new DateTime(2025, 10, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6030), "NPV-022-0002", 22 },
                    { new Guid("06317653-3530-448f-b49b-8d6ce18c7822"), "Ram", 1, true, false, "B.K.", "Bahadur", "+9779745615255", new DateTime(2024, 3, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6520), "NPV-024-0009", 24 },
                    { new Guid("06cab003-aa73-4545-8680-bc61aa1e31f9"), "Radha", 2, true, true, "Maharjan", "Devi", "+9779851805641", new DateTime(2024, 3, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6330), "NPV-023-0005", 23 },
                    { new Guid("071e4af7-7b51-4c38-8b18-c237a9b48634"), "Rekha", 2, true, true, "Thapa", "Maya", "+9779747840958", new DateTime(2025, 10, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7810), "NPV-031-0008", 31 },
                    { new Guid("0763c529-11f3-4bba-a2d7-8cec3ae6924e"), "Shyam", 1, true, true, "Rai", "Singh", "+9779621156798", new DateTime(2025, 10, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8860), "NPV-037-0004", 37 },
                    { new Guid("07f7b3d8-af4c-45fc-8e73-f44f0c93d55e"), "Gita", 2, true, false, "Sharma", "Kumari", "+9779763278062", new DateTime(2025, 1, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8370), "NPV-034-0008", 34 },
                    { new Guid("0830a120-8c90-48b0-a194-bfa30ec6727a"), "Gopal", 1, true, true, "Karki", "Raj", "+9779768413946", new DateTime(2025, 1, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4310), "NPV-012-0008", 12 },
                    { new Guid("08658bd8-801d-46c9-92c4-957f97aeef69"), "Mohan", 1, true, true, "Maharjan", "Prasad", "+9779887436570", new DateTime(2025, 11, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5950), "NPV-021-0006", 21 },
                    { new Guid("093c03ec-0d7e-463d-8b21-c61827a357ba"), "Santosh", 1, true, true, "Thapa", "Singh", "+9779883306167", new DateTime(2024, 3, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5300), "NPV-018-0004", 18 },
                    { new Guid("09b2b6df-df92-43ec-be7a-d8805afb4dc3"), "Dipak", 1, true, true, "Sharma", "Kumar", "+9779812807950", new DateTime(2025, 1, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6990), "NPV-027-0001", 27 },
                    { new Guid("0a9fd801-0c4a-4d08-9044-0524ddb3edee"), "Bishnu", 1, true, true, "Chaudhary", "Bahadur", "+9779827784041", new DateTime(2024, 3, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6500), "NPV-024-0007", 24 },
                    { new Guid("0b8af4eb-394a-406a-bcad-a8ee34b84f9d"), "Rajesh", 1, true, true, "Tamang", "Bahadur", "+9779826038731", new DateTime(2024, 3, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8560), "NPV-036-0001", 36 },
                    { new Guid("0b9af398-1983-47d4-b114-4ea387ab5876"), "Bikash", 1, true, false, "Gurung", "Prasad", "+9779811419296", new DateTime(2024, 2, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3840), "NPV-010-0006", 10 },
                    { new Guid("0bb9a89e-8914-4307-9d10-9fa9526c1284"), "Sarita", 2, true, true, "Tamang", "Kumari", "+9779638025890", new DateTime(2025, 10, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8690), "NPV-036-0010", 36 },
                    { new Guid("0bf8b906-4f73-4b7e-8819-9796088cea47"), "Radha", 2, true, true, "Thapa", "Kumari", "+9779863714022", new DateTime(2024, 2, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8020), "NPV-033-0001", 33 },
                    { new Guid("0bff68cd-90f8-4c75-a18b-0680442955bf"), "Shyam", 1, true, true, "Thapa", "Bahadur", "+9779751050640", new DateTime(2025, 9, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7120), "NPV-027-0010", 27 },
                    { new Guid("0c1c3033-e851-4add-818d-46cc6510af81"), "Parbati", 2, true, true, "Gurung", "Kumari", "+9779761120720", new DateTime(2024, 3, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4470), "NPV-013-0009", 13 },
                    { new Guid("0d35de9b-78b8-4a58-9b6a-856745c3bef8"), "Bishnu", 1, true, true, "Magar", "Singh", "+9779611630560", new DateTime(2024, 4, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8830), "NPV-037-0002", 37 },
                    { new Guid("0d459a34-7791-4020-a262-c66f9e28dc12"), "Shyam", 1, true, true, "Rai", "Kumar", "+9779865680487", new DateTime(2024, 4, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2450), "NPV-003-0002", 3 },
                    { new Guid("0dcfbd17-6ff9-4132-80a4-12d0b8fb23dd"), "Bishnu", 1, true, true, "Nepali", "Bahadur", "+9779866987848", new DateTime(2025, 6, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6670), "NPV-025-0009", 25 },
                    { new Guid("0e68c4f4-71f6-428e-a00f-0ccf06ebaa9b"), "Sita", 2, true, true, "Yadav", "Laxmi", "+9779853779141", new DateTime(2025, 1, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3230), "NPV-007-0005", 7 },
                    { new Guid("1063f379-245d-4f13-bafb-e8b0e81dd442"), "Bishnu", 1, true, true, "B.K.", "Singh", "+9779759356609", new DateTime(2025, 12, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7210), "NPV-028-0006", 28 },
                    { new Guid("1109b501-0215-4d8d-9908-e575bd262b86"), "Bishnu", 1, true, true, "Chaudhary", "Raj", "+9779842414946", new DateTime(2025, 9, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8400), "NPV-034-0010", 34 },
                    { new Guid("11172831-6da4-425f-bd7c-2d77a85948b6"), "Gopal", 1, true, true, "Chaudhary", "Prasad", "+9779754462834", new DateTime(2024, 10, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3200), "NPV-007-0003", 7 },
                    { new Guid("11553ae3-c214-4ceb-a0ea-b7d708d9d394"), "Sita", 2, true, false, "Karki", "Devi", "+9779769470665", new DateTime(2024, 8, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9800), "NPV-042-0009", 42 },
                    { new Guid("12b91007-4ce7-4a67-84b2-e3a9da2c0c3b"), "Maya", 2, true, true, "Lama", "Kumari", "+9779744734527", new DateTime(2025, 3, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3730), "NPV-009-0009", 9 },
                    { new Guid("136c4276-a276-4a3f-81e0-9339a96cb755"), "Sarita", 2, true, true, "Sharma", "Kumari", "+9779827688568", new DateTime(2023, 12, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9940), "NPV-043-0008", 43 },
                    { new Guid("136e822d-dded-4f84-b636-346cc10ff68e"), "Shyam", 1, true, true, "Lama", "Bahadur", "+9779848830157", new DateTime(2024, 12, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3390), "NPV-008-0004", 8 },
                    { new Guid("14168ec5-bdca-4cd4-ab4b-704715bca831"), "Gopal", 1, true, true, "Sharma", "Prasad", "+9779633068716", new DateTime(2025, 11, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6770), "NPV-026-0006", 26 },
                    { new Guid("1457fd6a-9715-45cc-afc5-877ca2250762"), "Bikash", 1, true, true, "Khadka", "Raj", "+9779817103881", new DateTime(2025, 2, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7880), "NPV-032-0002", 32 },
                    { new Guid("156d9f2a-134c-44b7-8be5-74271d7d87c9"), "Bishnu", 1, true, true, "Maharjan", "Singh", "+9779817376060", new DateTime(2025, 11, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4410), "NPV-013-0005", 13 },
                    { new Guid("16409c8f-8ba4-4030-8136-09a8ae494fcc"), "Dipak", 1, true, true, "Thapa", "Raj", "+9779625500953", new DateTime(2024, 10, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5760), "NPV-020-0004", 20 },
                    { new Guid("16e5f6a1-926c-404d-858e-85aea4323c19"), "Radha", 2, true, true, "Shrestha", "Kumari", "+9779869590047", new DateTime(2025, 2, 25, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(810), "NPV-048-0002", 48 },
                    { new Guid("16f25406-c909-471b-9ff5-e326f1db1fa4"), "Sita", 2, true, true, "Magar", "Kumari", "+9779631821409", new DateTime(2025, 12, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2670), "NPV-004-0006", 4 },
                    { new Guid("170531bc-1ff1-4c0c-a529-fdebee90d752"), "Sunita", 2, true, true, "Lama", "Devi", "+9779623147918", new DateTime(2025, 3, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5100), "NPV-016-0010", 16 },
                    { new Guid("195d3428-f0a4-41dd-8291-e9ea137b8fed"), "Radha", 2, true, true, "Sharma", "Laxmi", "+9779623380315", new DateTime(2025, 3, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8570), "NPV-036-0002", 36 },
                    { new Guid("1a23138e-c10d-441d-9a8e-bb089fffcf73"), "Parbati", 2, true, true, "Karki", "Maya", "+9779859690873", new DateTime(2025, 6, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9140), "NPV-039-0003", 39 },
                    { new Guid("1a41157d-bd9e-4a2e-a4ce-3274edf1607e"), "Santosh", 1, true, true, "Rai", "Raj", "+9779864012331", new DateTime(2025, 10, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9130), "NPV-039-0002", 39 },
                    { new Guid("1a4f159c-b002-4467-a17b-863cee22fcdc"), "Bishnu", 1, true, true, "Khadka", "Raj", "+9779755847200", new DateTime(2025, 10, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6610), "NPV-025-0005", 25 },
                    { new Guid("1bbff0bd-d253-4d1c-ab65-4695c9e05b60"), "Rajesh", 1, true, false, "Lama", "Kumar", "+9779637200717", new DateTime(2024, 10, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4910), "NPV-015-0007", 15 },
                    { new Guid("1cee99b4-f2d7-44ab-a521-baae969a8e83"), "Shyam", 1, true, true, "Karki", "Raj", "+9779621367941", new DateTime(2024, 8, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6450), "NPV-024-0004", 24 },
                    { new Guid("1d229b6f-b16f-485b-a5d9-a0c41896686e"), "Rajesh", 1, true, true, "Yadav", "Prasad", "+9779889353384", new DateTime(2024, 4, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2570), "NPV-003-0010", 3 },
                    { new Guid("1d2e82cd-c539-413a-b45b-8191f36e0be7"), "Sunita", 2, true, true, "Maharjan", "Kumari", "+9779762418078", new DateTime(2024, 7, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6740), "NPV-026-0004", 26 },
                    { new Guid("1d6b21d1-82fb-4cb9-9235-e2e0a2e60637"), "Bikash", 1, true, false, "Gurung", "Prasad", "+9779849222524", new DateTime(2025, 12, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5680), "NPV-019-0009", 19 },
                    { new Guid("1d822b7f-9004-4dca-937c-281ce45c8858"), "Nisha", 2, true, true, "Khadka", "Kumari", "+9779639030389", new DateTime(2025, 2, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8450), "NPV-035-0003", 35 },
                    { new Guid("1d9fb088-7040-4346-8902-9cf98f1d7ec0"), "Maya", 2, true, true, "Khadka", "Kumari", "+9779825303800", new DateTime(2025, 5, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6120), "NPV-022-0008", 22 },
                    { new Guid("1dad3b3c-6614-40d1-8871-1b5ed9d79c15"), "Sabitri", 2, true, true, "B.K.", "Kumari", "+9779853061653", new DateTime(2024, 12, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7940), "NPV-032-0006", 32 },
                    { new Guid("1e4372cc-cfc9-45f9-a7f9-8657d3bae0ac"), "Rajesh", 1, true, true, "Khadka", "Prasad", "+9779639363611", new DateTime(2025, 7, 10, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(1030), "NPV-048-0009", 48 },
                    { new Guid("1f5c359a-e212-4e9a-bf69-07c24c1bb17c"), "Ram", 1, true, true, "Sharma", "Raj", "+9779629069920", new DateTime(2025, 5, 16, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(660), "NPV-047-0003", 47 },
                    { new Guid("21c4da0d-e4df-4727-a295-285411626d02"), "Ram", 1, true, true, "Nepali", "Bahadur", "+9779755954499", new DateTime(2024, 9, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8660), "NPV-036-0008", 36 },
                    { new Guid("2208683f-9d1c-49fc-a72d-0db22520f48a"), "Ram", 1, true, true, "Lama", "Prasad", "+9779865877038", new DateTime(2024, 3, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2340), "NPV-002-0005", 2 },
                    { new Guid("25b56a10-99a1-4a13-b95e-76ba40975245"), "Sunita", 2, true, true, "Magar", "Devi", "+9779767659972", new DateTime(2025, 12, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8950), "NPV-037-0010", 37 },
                    { new Guid("25cf84a4-3219-477c-b5af-1d42a2e193e5"), "Mohan", 1, true, true, "Maharjan", "Raj", "+9779747128562", new DateTime(2025, 2, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7160), "NPV-028-0003", 28 },
                    { new Guid("260172bc-8eae-4811-994b-48ca3eaced49"), "Rupa", 2, true, true, "Magar", "Laxmi", "+9779809349122", new DateTime(2025, 2, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6160), "NPV-023-0001", 23 },
                    { new Guid("26061a64-a57d-4cd5-9d20-5b13d0d234a4"), "Nabin", 1, true, true, "B.K.", "Prasad", "+9779611707788", new DateTime(2024, 11, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9210), "NPV-039-0008", 39 },
                    { new Guid("265c25df-e539-4f17-81ae-de2edbd7f7d3"), "Krishna", 1, true, true, "Sharma", "Raj", "+9779821029298", new DateTime(2025, 8, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3190), "NPV-007-0002", 7 },
                    { new Guid("26a5195f-da62-4a8c-adb9-7a33bc7941c7"), "Anita", 2, true, false, "B.K.", "Laxmi", "+9779612940039", new DateTime(2025, 6, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6710), "NPV-026-0002", 26 },
                    { new Guid("292de35c-ba00-4d29-be1a-44d8a4b0f410"), "Sita", 2, true, true, "Gurung", "Kumari", "+9779822957827", new DateTime(2025, 9, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2280), "NPV-002-0001", 2 },
                    { new Guid("298eb06a-64dd-469f-878e-1feadd541c49"), "Gopal", 1, true, true, "Nepali", "Raj", "+9779842419000", new DateTime(2024, 3, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7070), "NPV-027-0006", 27 },
                    { new Guid("299ff111-e74b-4639-abe7-bfad336afc7a"), "Sabitri", 2, true, true, "Rai", "Laxmi", "+9779743844955", new DateTime(2025, 10, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7110), "NPV-027-0009", 27 },
                    { new Guid("29bcc4a0-29cd-40bd-b46b-1caf1d8b4b70"), "Ram", 1, true, true, "Tamang", "Bahadur", "+9779852194904", new DateTime(2024, 1, 7, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(300), "NPV-045-0001", 45 },
                    { new Guid("2a23c562-218b-40c8-a1b7-cb3d871dcdb7"), "Dipak", 1, true, true, "Lama", "Kumar", "+9779826995308", new DateTime(2024, 6, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9260), "NPV-040-0001", 40 },
                    { new Guid("2aaae39d-4d79-47c1-9868-4fb2aec833b6"), "Radha", 2, true, false, "Maharjan", "Kumari", "+9779805488737", new DateTime(2025, 1, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2730), "NPV-004-0010", 4 },
                    { new Guid("2b88076c-a7ea-4975-8524-6431b2d8792a"), "Gopal", 1, true, true, "Chaudhary", "Singh", "+9779746931350", new DateTime(2025, 1, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3880), "NPV-010-0009", 10 },
                    { new Guid("2be1134d-409d-473e-8756-d2d01260bf32"), "Ram", 1, true, true, "Lama", "Kumar", "+9779882183136", new DateTime(2025, 11, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6470), "NPV-024-0005", 24 },
                    { new Guid("2c51fc82-e2ba-4f9f-8fe2-ad3d00c8d6d0"), "Ram", 1, true, true, "Rai", "Prasad", "+9779764361417", new DateTime(2024, 2, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5870), "NPV-021-0001", 21 },
                    { new Guid("2d91cf39-69cd-4fe9-a312-9d110d9f18cc"), "Bishnu", 1, true, true, "Yadav", "Kumar", "+9779823965840", new DateTime(2024, 7, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8650), "NPV-036-0007", 36 },
                    { new Guid("2eccb4d9-53bf-4688-8983-93be42f2be93"), "Dipak", 1, true, false, "Chaudhary", "Singh", "+9779636251069", new DateTime(2025, 8, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9720), "NPV-042-0004", 42 },
                    { new Guid("3061b092-4a7d-4a7d-a790-b34a12c36ac0"), "Gita", 2, true, true, "Nepali", "Kumari", "+9779888094330", new DateTime(2024, 9, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4120), "NPV-012-0004", 12 },
                    { new Guid("309a991f-7513-4f9a-84bc-9d59a0e07922"), "Shova", 2, true, true, "B.K.", "Laxmi", "+9779762789599", new DateTime(2024, 2, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2510), "NPV-003-0006", 3 },
                    { new Guid("30c3203b-c033-4f41-969e-b2301fda9139"), "Shova", 2, true, true, "Gurung", "Devi", "+9779742215216", new DateTime(2025, 1, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9850), "NPV-043-0002", 43 },
                    { new Guid("32679f05-dd6d-42fb-8a9a-d87d7acf80ec"), "Bikash", 1, true, true, "B.K.", "Bahadur", "+9779613603203", new DateTime(2025, 9, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4870), "NPV-015-0005", 15 },
                    { new Guid("3274a90c-8b70-4e59-ac97-40bac1292579"), "Anita", 2, true, true, "Tamang", "Kumari", "+9779764958240", new DateTime(2025, 3, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3930), "NPV-011-0002", 11 },
                    { new Guid("341f371f-b3fc-4390-a12d-97002ebf4810"), "Maya", 2, true, false, "Yadav", "Laxmi", "+9779819714067", new DateTime(2025, 7, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2680), "NPV-004-0007", 4 },
                    { new Guid("34b000b6-f540-4dc7-ada3-db3d28d274c5"), "Shyam", 1, true, true, "Magar", "Prasad", "+9779887547224", new DateTime(2025, 1, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4430), "NPV-013-0006", 13 },
                    { new Guid("35778ca2-e446-48b6-af90-b351a4b0dd4b"), "Prakash", 1, true, true, "Maharjan", "Bahadur", "+9779745342480", new DateTime(2025, 6, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6480), "NPV-024-0006", 24 },
                    { new Guid("36403d99-4cb0-4f57-ba1b-da33578c86a2"), "Maya", 2, true, true, "Khadka", "Laxmi", "+9779802254096", new DateTime(2024, 7, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6620), "NPV-025-0006", 25 },
                    { new Guid("37ad9353-1ccf-4dd2-ad21-2dc4845f9021"), "Sabitri", 2, true, true, "Gurung", "Laxmi", "+9779625646208", new DateTime(2025, 9, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8390), "NPV-034-0009", 34 },
                    { new Guid("386faac2-17f7-4bb9-a092-90ff7690985e"), "Shova", 2, true, false, "Maharjan", "Laxmi", "+9779769239953", new DateTime(2024, 9, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8420), "NPV-035-0001", 35 },
                    { new Guid("38d1f036-bb84-44f4-8ca5-7539256d7806"), "Hari", 1, true, false, "Sharma", "Singh", "+9779809939482", new DateTime(2024, 12, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6340), "NPV-023-0006", 23 },
                    { new Guid("390030f0-b4f4-4b4e-b6b9-663d2d501b1b"), "Rekha", 2, true, true, "Thapa", "Kumari", "+9779611056439", new DateTime(2024, 10, 21, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(800), "NPV-048-0001", 48 },
                    { new Guid("398f9bb4-6e42-4dfe-930f-829ba3b20c32"), "Bikash", 1, true, true, "Magar", "Singh", "+9779638261832", new DateTime(2024, 11, 17, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(440), "NPV-045-0010", 45 },
                    { new Guid("3a14d202-d2cf-4b23-9565-c4181c042191"), "Gopal", 1, true, true, "Gurung", "Bahadur", "+9779824675059", new DateTime(2024, 11, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4490), "NPV-013-0010", 13 },
                    { new Guid("3b3847b3-77d4-40b2-b4b7-a89c6ccd5da4"), "Sunita", 2, true, true, "Khadka", "Laxmi", "+9779821393017", new DateTime(2024, 5, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9820), "NPV-042-0010", 42 },
                    { new Guid("3b427167-38f8-43d9-a397-93c3d084c0ad"), "Sabitri", 2, true, true, "Thapa", "Kumari", "+9779826682361", new DateTime(2025, 6, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9750), "NPV-042-0006", 42 },
                    { new Guid("3cae04b5-e3ff-4b9d-8eb3-be0b17b3262e"), "Sunita", 2, true, false, "Khadka", "Laxmi", "+9779863020689", new DateTime(2025, 5, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3580), "NPV-008-0009", 8 },
                    { new Guid("3cd02f5f-1213-4233-9452-80a6a5a2b2bb"), "Anita", 2, true, true, "B.K.", "Kumari", "+9779758390867", new DateTime(2025, 8, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9020), "NPV-038-0005", 38 },
                    { new Guid("3d045488-d7bf-4970-b07f-5056c28a8690"), "Radha", 2, true, false, "Sharma", "Kumari", "+9779826519930", new DateTime(2025, 1, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9150), "NPV-039-0004", 39 },
                    { new Guid("3d07bcd5-459b-4149-be92-dc4c85fba8c8"), "Bishnu", 1, true, true, "Chaudhary", "Singh", "+9779842115314", new DateTime(2025, 5, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4050), "NPV-011-0010", 11 },
                    { new Guid("3d70e6b8-7f61-48fe-bfdb-bfdd9448d605"), "Nabin", 1, true, true, "Maharjan", "Bahadur", "+9779827013524", new DateTime(2024, 3, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9690), "NPV-042-0002", 42 },
                    { new Guid("3dafd6d2-4829-419b-b0c4-6993c1b57cfc"), "Shyam", 1, true, true, "Nepali", "Prasad", "+9779844566196", new DateTime(2024, 1, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9200), "NPV-039-0007", 39 },
                    { new Guid("3fc1da2a-2808-4aa3-a047-b4bf8d3c94fd"), "Santosh", 1, true, false, "Nepali", "Raj", "+9779624138123", new DateTime(2025, 7, 26, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(480), "NPV-046-0002", 46 },
                    { new Guid("3ff5bc0b-4b32-41be-95c5-281c5e3376aa"), "Parbati", 2, true, false, "Gurung", "Laxmi", "+9779889373699", new DateTime(2025, 7, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6050), "NPV-022-0003", 22 },
                    { new Guid("400cdb43-977f-430e-8457-39a4bec573b9"), "Parbati", 2, true, true, "Thapa", "Maya", "+9779827110133", new DateTime(2024, 12, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3830), "NPV-010-0005", 10 },
                    { new Guid("40ae0066-43a5-43df-9e27-580055dc4501"), "Dipak", 1, true, true, "B.K.", "Kumar", "+9779814560505", new DateTime(2024, 3, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5980), "NPV-021-0008", 21 },
                    { new Guid("40b2262d-9560-4001-b164-72d41c8d84dd"), "Rupa", 2, true, true, "Thapa", "Maya", "+9779824102219", new DateTime(2025, 1, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6410), "NPV-024-0001", 24 },
                    { new Guid("4136186f-6d0b-4e83-838e-3d93ecc921bd"), "Sita", 2, true, true, "Thapa", "Devi", "+9779744211371", new DateTime(2024, 10, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9560), "NPV-041-0003", 41 },
                    { new Guid("41c0e76c-d389-4680-9b7d-17ec1f88f627"), "Suresh", 1, true, true, "Thapa", "Raj", "+9779852455075", new DateTime(2025, 5, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6510), "NPV-024-0008", 24 },
                    { new Guid("41da7afd-571b-4a1d-8f32-9d32778501d0"), "Gita", 2, true, true, "Rai", "Maya", "+9779764620081", new DateTime(2024, 10, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3910), "NPV-011-0001", 11 },
                    { new Guid("41ec21e6-84b9-4d98-b362-ee95d8273a98"), "Gita", 2, true, false, "Shrestha", "Kumari", "+9779817120593", new DateTime(2025, 5, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7690), "NPV-030-0010", 30 },
                    { new Guid("430f81bf-08d4-4995-b814-eaea9a04646f"), "Santosh", 1, true, false, "Nepali", "Raj", "+9779759448155", new DateTime(2025, 8, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5140), "NPV-017-0003", 17 },
                    { new Guid("432fbabd-cbf4-481b-a9f7-d05ffe64e687"), "Laxmi", 2, true, true, "Karki", "Laxmi", "+9779813163326", new DateTime(2024, 10, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6380), "NPV-023-0009", 23 },
                    { new Guid("443da11f-203e-4c91-83b0-03d1d0c2b888"), "Ram", 1, true, false, "Shrestha", "Singh", "+9779882693427", new DateTime(2025, 8, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5330), "NPV-018-0006", 18 },
                    { new Guid("44483ce7-319c-4621-af3a-bddb437e5949"), "Gopal", 1, true, true, "Maharjan", "Raj", "+9779616404465", new DateTime(2024, 2, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2420), "NPV-002-0010", 2 },
                    { new Guid("448f8169-eee9-43e5-8e3e-c46eec5b931d"), "Bishnu", 1, true, false, "Shrestha", "Kumar", "+9779816270086", new DateTime(2024, 2, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7240), "NPV-028-0008", 28 },
                    { new Guid("4526a9a6-78db-4373-aabd-27661be86d0e"), "Parbati", 2, true, true, "Chaudhary", "Devi", "+9779761043318", new DateTime(2025, 10, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8240), "NPV-033-0009", 33 },
                    { new Guid("45742502-803c-4852-b7a8-cbf6ec93a8d5"), "Prakash", 1, true, true, "Thapa", "Prasad", "+9779616878405", new DateTime(2023, 12, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3990), "NPV-011-0006", 11 },
                    { new Guid("46b7794e-442d-433a-946e-414b7067f9a7"), "Rajesh", 1, true, true, "Gurung", "Bahadur", "+9779615492809", new DateTime(2025, 3, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9320), "NPV-040-0005", 40 },
                    { new Guid("4751cffa-7d02-4933-a4e4-cdbff7fe6c69"), "Krishna", 1, true, true, "Karki", "Singh", "+9779636234769", new DateTime(2024, 7, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6100), "NPV-022-0007", 22 },
                    { new Guid("47df5947-f4bf-4b10-bc33-841c90d30742"), "Arjun", 1, true, true, "B.K.", "Bahadur", "+9779827802060", new DateTime(2025, 12, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7720), "NPV-031-0002", 31 },
                    { new Guid("4838723b-711f-48b4-951e-80b2c1a87d40"), "Bishnu", 1, true, true, "Chaudhary", "Raj", "+9779632179567", new DateTime(2024, 7, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8330), "NPV-034-0005", 34 },
                    { new Guid("484e2f36-5908-4282-a92f-6b91fb55a8bf"), "Ram", 1, true, true, "Thapa", "Kumar", "+9779854954145", new DateTime(2025, 11, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7890), "NPV-032-0003", 32 },
                    { new Guid("484e4179-aa2a-4af4-b362-eece210c4cc1"), "Shova", 2, true, true, "Karki", "Kumari", "+9779638565745", new DateTime(2025, 8, 17, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(40), "NPV-044-0005", 44 },
                    { new Guid("48df1a17-c9d2-41b2-b922-3ff534efe46d"), "Krishna", 1, true, true, "Nepali", "Raj", "+9779611482291", new DateTime(2025, 9, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9050), "NPV-038-0007", 38 },
                    { new Guid("494c63f8-b42c-49b3-81e0-402615084731"), "Sarita", 2, true, false, "Sharma", "Laxmi", "+9779628368224", new DateTime(2024, 6, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4980), "NPV-016-0002", 16 },
                    { new Guid("49ddce0e-4bf1-4a23-8856-9e1ab71b6fff"), "Santosh", 1, true, false, "Karki", "Bahadur", "+9779829209934", new DateTime(2025, 10, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9670), "NPV-042-0001", 42 },
                    { new Guid("49e1f0f4-e73e-4b57-895c-eb27400385ea"), "Santosh", 1, true, false, "Karki", "Raj", "+9779818135634", new DateTime(2025, 7, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9290), "NPV-040-0003", 40 },
                    { new Guid("4b26411e-f5fb-4c5e-a35d-9a23e3c72dd0"), "Sunita", 2, true, true, "Chaudhary", "Maya", "+9779887233188", new DateTime(2024, 7, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5410), "NPV-019-0002", 19 },
                    { new Guid("4c22410d-d92e-4567-bb35-c0319b89c880"), "Dipak", 1, true, true, "Chaudhary", "Kumar", "+9779823535133", new DateTime(2024, 3, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3800), "NPV-010-0003", 10 },
                    { new Guid("4ce8f350-257e-4897-85b1-940df3bc0c9d"), "Krishna", 1, true, true, "Rai", "Prasad", "+9779886514375", new DateTime(2025, 9, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5640), "NPV-019-0007", 19 },
                    { new Guid("4cf2ae5a-ae3f-4b20-b7d2-dcd03f4284c9"), "Prakash", 1, true, true, "B.K.", "Prasad", "+9779633372794", new DateTime(2024, 4, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7200), "NPV-028-0005", 28 },
                    { new Guid("4cf93cda-0a7c-4313-b9a8-5c9734734981"), "Arjun", 1, true, false, "Sharma", "Prasad", "+9779826160367", new DateTime(2025, 12, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7960), "NPV-032-0007", 32 },
                    { new Guid("4e11f172-f663-4ab9-baa9-535cfa451faa"), "Nisha", 2, true, true, "Yadav", "Maya", "+9779814628188", new DateTime(2024, 10, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6580), "NPV-025-0003", 25 },
                    { new Guid("4e337c78-1545-48a3-8795-30c8c6895dc0"), "Prakash", 1, true, true, "Rai", "Bahadur", "+9779746266751", new DateTime(2025, 2, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9710), "NPV-042-0003", 42 },
                    { new Guid("4e962327-897a-44c5-803e-571e66dd21c8"), "Sabitri", 2, true, true, "Magar", "Kumari", "+9779741524077", new DateTime(2025, 10, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4500), "NPV-014-0001", 14 },
                    { new Guid("4eaac5ab-a746-46cc-9703-929babd566ed"), "Parbati", 2, true, true, "Thapa", "Maya", "+9779855267272", new DateTime(2024, 6, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6310), "NPV-023-0004", 23 },
                    { new Guid("4eb57dab-8296-41aa-8647-dd5a6a64e750"), "Laxmi", 2, true, true, "Magar", "Devi", "+9779819883714", new DateTime(2025, 10, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7770), "NPV-031-0005", 31 },
                    { new Guid("4ef14049-1114-4d0d-89cf-c60b4cac7adb"), "Shova", 2, true, false, "Maharjan", "Maya", "+9779813189341", new DateTime(2025, 4, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8630), "NPV-036-0006", 36 },
                    { new Guid("4f27c055-8949-450b-b287-0f56fbf57b99"), "Sunita", 2, true, true, "Magar", "Devi", "+9779889406403", new DateTime(2024, 4, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7470), "NPV-029-0006", 29 },
                    { new Guid("4f4c953b-b575-4c11-9dea-9fa9c73c4741"), "Sita", 2, true, true, "Tamang", "Maya", "+9779857287686", new DateTime(2024, 5, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3370), "NPV-008-0003", 8 },
                    { new Guid("4f52b74e-b649-4d2d-b821-1ef5e6525aae"), "Laxmi", 2, true, true, "Thapa", "Kumari", "+9779853137437", new DateTime(2025, 10, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6680), "NPV-025-0010", 25 },
                    { new Guid("50db2be3-89ec-4b7f-9cf1-637ff403f9ed"), "Sarita", 2, true, true, "Karki", "Kumari", "+9779747480151", new DateTime(2024, 6, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2900), "NPV-005-0003", 5 },
                    { new Guid("516ad07d-2808-41a4-baf7-39a94c892264"), "Shova", 2, true, true, "Magar", "Kumari", "+9779756220463", new DateTime(2024, 12, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7010), "NPV-027-0002", 27 },
                    { new Guid("51acc85a-c6d9-4e37-aebc-0404478bca17"), "Shova", 2, true, false, "Lama", "Maya", "+9779636658929", new DateTime(2024, 5, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6550), "NPV-025-0001", 25 },
                    { new Guid("51e843f1-274d-49c7-9ca9-5ab6b507d876"), "Parbati", 2, true, true, "Lama", "Devi", "+9779846867876", new DateTime(2025, 10, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4350), "NPV-013-0001", 13 },
                    { new Guid("52023c37-8012-4c1e-b867-ad14d1da8402"), "Santosh", 1, true, true, "Khadka", "Bahadur", "+9779805262357", new DateTime(2024, 10, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7040), "NPV-027-0004", 27 },
                    { new Guid("5255b623-9319-4b69-a7fd-ecdc64913d81"), "Suresh", 1, true, true, "Shrestha", "Singh", "+9779819450926", new DateTime(2025, 1, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7800), "NPV-031-0007", 31 },
                    { new Guid("532598b0-e2f5-4b6d-962b-df4c93c558ad"), "Prakash", 1, true, false, "Tamang", "Bahadur", "+9779869976367", new DateTime(2025, 6, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5210), "NPV-017-0008", 17 },
                    { new Guid("537347d8-c12d-4e65-aa19-ceb01fb5542a"), "Sunita", 2, true, false, "Magar", "Kumari", "+9779632932609", new DateTime(2025, 3, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4630), "NPV-014-0010", 14 },
                    { new Guid("54772b2a-56c0-435e-a6f6-3194d43723ca"), "Shyam", 1, true, true, "Karki", "Prasad", "+9779807845660", new DateTime(2025, 7, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5170), "NPV-017-0005", 17 },
                    { new Guid("547bb22c-6f09-4c8f-9fd3-cae5ecf8d6df"), "Rupa", 2, true, true, "Magar", "Maya", "+9779756487432", new DateTime(2024, 2, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2230), "NPV-001-0008", 1 },
                    { new Guid("54b0390f-773c-4a87-8f4e-bf1afcf24235"), "Gopal", 1, true, true, "Gurung", "Prasad", "+9779814784300", new DateTime(2025, 4, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3060), "NPV-006-0003", 6 },
                    { new Guid("55c2c332-324d-4ffd-8169-a7725ec87b70"), "Sarita", 2, true, false, "Maharjan", "Devi", "+9779745664760", new DateTime(2024, 12, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6180), "NPV-023-0002", 23 },
                    { new Guid("563d396f-346c-485d-bcd1-1296f0b8ee8c"), "Shyam", 1, true, true, "Maharjan", "Kumar", "+9779626014449", new DateTime(2024, 4, 4, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(80), "NPV-044-0007", 44 },
                    { new Guid("57496853-1463-42b3-b32b-10d082ea04ed"), "Shova", 2, true, true, "Maharjan", "Kumari", "+9779611271224", new DateTime(2024, 8, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5010), "NPV-016-0004", 16 },
                    { new Guid("5776fe6b-a4a4-4466-8f36-2d01b334d1b3"), "Bishnu", 1, true, false, "Thapa", "Singh", "+9779637772725", new DateTime(2025, 3, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4150), "NPV-012-0006", 12 },
                    { new Guid("57fd32db-c847-4de0-83cb-df601caff002"), "Anita", 2, true, true, "Sharma", "Laxmi", "+9779849943394", new DateTime(2024, 5, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9630), "NPV-041-0008", 41 },
                    { new Guid("584f6a10-6877-4811-8c15-f501b2e2fb79"), "Dipak", 1, true, false, "Nepali", "Raj", "+9779815149616", new DateTime(2024, 5, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3700), "NPV-009-0007", 9 },
                    { new Guid("5860fe38-d6fc-4290-9b2e-64bdf9653f8f"), "Sarita", 2, true, true, "Lama", "Devi", "+9779618531494", new DateTime(2025, 5, 3, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(840), "NPV-048-0004", 48 },
                    { new Guid("58b6ce7b-aa40-4cb5-a06c-cfe0407c6a5f"), "Nisha", 2, true, true, "Lama", "Maya", "+9779751337765", new DateTime(2024, 9, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8320), "NPV-034-0004", 34 },
                    { new Guid("599c3f38-8739-4273-b489-97b1a2469ed7"), "Rupa", 2, true, false, "Sharma", "Kumari", "+9779743653445", new DateTime(2024, 8, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8810), "NPV-037-0001", 37 },
                    { new Guid("5a325a3a-8742-4f4d-adb8-48ee45239f0c"), "Sarita", 2, true, true, "Shrestha", "Kumari", "+9779865149133", new DateTime(2024, 6, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3260), "NPV-007-0006", 7 },
                    { new Guid("5aee250d-2ee6-4a87-8c62-c3cb9c187712"), "Sunita", 2, true, true, "Sharma", "Kumari", "+9779858415667", new DateTime(2024, 9, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9180), "NPV-039-0006", 39 },
                    { new Guid("5b0ae4f1-9e9d-48cd-8f29-7e6c46d5e9bb"), "Parbati", 2, true, true, "Chaudhary", "Devi", "+9779628663531", new DateTime(2024, 7, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4650), "NPV-015-0001", 15 },
                    { new Guid("5c4b5e0c-a604-4ba9-9f8a-59b2512c7095"), "Sabitri", 2, true, true, "B.K.", "Laxmi", "+9779762647248", new DateTime(2024, 2, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9890), "NPV-043-0005", 43 },
                    { new Guid("5cfbf8b8-5775-46fb-9296-28ae45f13e39"), "Sita", 2, true, false, "B.K.", "Kumari", "+9779867389698", new DateTime(2025, 3, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9610), "NPV-041-0007", 41 },
                    { new Guid("5d382ca0-3d60-459d-824a-925d494ae8bc"), "Sarita", 2, true, true, "Sharma", "Laxmi", "+9779636650272", new DateTime(2024, 12, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5260), "NPV-018-0001", 18 },
                    { new Guid("5d8544f7-3398-4aa9-bc8d-65f9c4d03eb8"), "Gopal", 1, true, false, "Lama", "Raj", "+9779852379977", new DateTime(2024, 8, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5790), "NPV-020-0006", 20 },
                    { new Guid("5dd5dcf9-e6d3-45cc-b104-b727e041edda"), "Sarita", 2, true, true, "Sharma", "Devi", "+9779758007648", new DateTime(2025, 3, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8490), "NPV-035-0006", 35 },
                    { new Guid("5de53c4d-78fe-4570-a303-a891fc00b4c4"), "Shova", 2, true, true, "Thapa", "Maya", "+9779613942257", new DateTime(2025, 10, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2700), "NPV-004-0008", 4 },
                    { new Guid("5e6a62fd-c64b-410f-ad8e-b915cb1e3282"), "Rajesh", 1, true, false, "Karki", "Bahadur", "+9779759914675", new DateTime(2024, 9, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3640), "NPV-009-0003", 9 },
                    { new Guid("5e8af7d6-7f28-4813-9a4a-a43ce38a29c7"), "Maya", 2, true, true, "Tamang", "Devi", "+9779808176782", new DateTime(2024, 12, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7270), "NPV-028-0010", 28 },
                    { new Guid("5ff9b414-6878-421a-9b51-79daa9cffa95"), "Sabitri", 2, true, false, "Nepali", "Laxmi", "+9779743500794", new DateTime(2025, 12, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9970), "NPV-043-0010", 43 },
                    { new Guid("60f7e3a5-913f-47c4-9172-f93a9a671d03"), "Hari", 1, true, false, "Khadka", "Kumar", "+9779618319944", new DateTime(2025, 1, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5660), "NPV-019-0008", 19 },
                    { new Guid("61580600-7d09-4f38-94a4-dfc90339f045"), "Sunita", 2, true, true, "B.K.", "Laxmi", "+9779882653617", new DateTime(2025, 10, 16, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(380), "NPV-045-0006", 45 },
                    { new Guid("6240c9de-d113-4914-ae2f-e399ab52d46a"), "Maya", 2, true, true, "Nepali", "Kumari", "+9779629883455", new DateTime(2024, 1, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4580), "NPV-014-0006", 14 },
                    { new Guid("62ef75c7-a133-41d3-ba38-441be07eb050"), "Nabin", 1, true, false, "Nepali", "Raj", "+9779801589874", new DateTime(2025, 6, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3710), "NPV-009-0008", 9 },
                    { new Guid("630a2d2e-2f2c-4f9d-b724-5a9f5dac4a97"), "Nabin", 1, true, true, "B.K.", "Bahadur", "+9779887599014", new DateTime(2024, 10, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3340), "NPV-008-0001", 8 },
                    { new Guid("6366245b-74de-446f-95f3-3606616aa194"), "Mohan", 1, true, false, "Chaudhary", "Prasad", "+9779744390712", new DateTime(2025, 6, 3, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(390), "NPV-045-0007", 45 },
                    { new Guid("63ae58f3-53e7-4157-b442-c75fb8f82808"), "Radha", 2, true, true, "Karki", "Kumari", "+9779826612545", new DateTime(2025, 2, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9360), "NPV-040-0008", 40 },
                    { new Guid("643a2ceb-0a64-438d-8f26-4fed6f83f305"), "Sarita", 2, true, true, "Lama", "Devi", "+9779634313708", new DateTime(2024, 6, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8980), "NPV-038-0002", 38 },
                    { new Guid("6494b1de-899d-4696-825e-c2a3047cbc8b"), "Shyam", 1, true, false, "Nepali", "Raj", "+9779634359290", new DateTime(2024, 5, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7580), "NPV-030-0003", 30 },
                    { new Guid("660b01d2-2579-40ab-8522-2f92ca86cb2e"), "Bikash", 1, true, false, "Nepali", "Kumar", "+9779621770418", new DateTime(2025, 8, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2930), "NPV-005-0005", 5 },
                    { new Guid("66a663a6-477d-4e44-9041-87a3a4c9a916"), "Krishna", 1, true, true, "Magar", "Singh", "+9779813831812", new DateTime(2024, 7, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8680), "NPV-036-0009", 36 },
                    { new Guid("66b0a2b3-d361-410d-85a9-b00dcdeeb519"), "Krishna", 1, true, true, "Tamang", "Raj", "+9779753639412", new DateTime(2025, 10, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6780), "NPV-026-0007", 26 },
                    { new Guid("66d422d5-8221-4229-9f27-6576803d2e94"), "Sunita", 2, true, true, "Chaudhary", "Maya", "+9779631507313", new DateTime(2024, 11, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5710), "NPV-020-0001", 20 },
                    { new Guid("674aa07c-c053-4bf6-b5b8-ffb663394c4a"), "Sabitri", 2, true, true, "Karki", "Laxmi", "+9779633855422", new DateTime(2025, 7, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2360), "NPV-002-0006", 2 },
                    { new Guid("67ef173e-abd5-45f4-8307-5d65340dee17"), "Arjun", 1, true, true, "Khadka", "Raj", "+9779821934368", new DateTime(2025, 8, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9230), "NPV-039-0009", 39 },
                    { new Guid("681bef7a-ad6d-4a4c-8811-650606bb90e2"), "Shyam", 1, true, false, "Nepali", "Prasad", "+9779612308340", new DateTime(2025, 6, 26, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(320), "NPV-045-0002", 45 },
                    { new Guid("68a55042-0d33-4ec6-af09-3356030fb54c"), "Shyam", 1, true, true, "Gurung", "Bahadur", "+9779756999547", new DateTime(2024, 12, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7480), "NPV-029-0007", 29 },
                    { new Guid("68fa1b9f-b0bc-4f1e-af97-8839b0df5452"), "Sita", 2, true, true, "Chaudhary", "Maya", "+9779851968669", new DateTime(2025, 8, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9640), "NPV-041-0009", 41 },
                    { new Guid("69e847ec-46d3-436a-bb37-98512a170771"), "Ram", 1, true, true, "Shrestha", "Kumar", "+9779751713182", new DateTime(2025, 2, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7980), "NPV-032-0008", 32 },
                    { new Guid("6aa2236c-fd59-4302-b54c-db401cd6aefa"), "Sunita", 2, true, true, "Maharjan", "Kumari", "+9779751387908", new DateTime(2024, 7, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3320), "NPV-007-0010", 7 },
                    { new Guid("6b135ef8-e23e-4a05-a2bb-c0fc05aa905c"), "Mohan", 1, true, true, "Thapa", "Kumar", "+9779849972304", new DateTime(2025, 8, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8160), "NPV-033-0003", 33 },
                    { new Guid("6b8d3d40-c08a-4b7b-b2c2-83455c8d16a5"), "Nabin", 1, true, true, "Magar", "Singh", "+9779851786343", new DateTime(2024, 3, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7550), "NPV-030-0001", 30 },
                    { new Guid("6d49bd66-f96c-4e92-b12e-7a98f082802e"), "Radha", 2, true, true, "Karki", "Kumari", "+9779611509249", new DateTime(2025, 1, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3600), "NPV-008-0010", 8 },
                    { new Guid("6d8162c9-c6b0-474d-ae86-15a75650667c"), "Prakash", 1, true, true, "Sharma", "Raj", "+9779762399593", new DateTime(2024, 11, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7610), "NPV-030-0005", 30 },
                    { new Guid("6d8506fd-3dce-4d24-89ef-a8ff2528fe45"), "Rajesh", 1, true, true, "Yadav", "Bahadur", "+9779623546690", new DateTime(2024, 10, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5020), "NPV-016-0005", 16 },
                    { new Guid("6e13a23f-ecec-4acb-9f24-6d374407999e"), "Shova", 2, true, true, "Nepali", "Laxmi", "+9779613066651", new DateTime(2025, 1, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8170), "NPV-033-0004", 33 },
                    { new Guid("6ea2fe75-ab76-4acd-bd62-602db6d85015"), "Gita", 2, true, true, "Yadav", "Devi", "+9779849135246", new DateTime(2025, 6, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3750), "NPV-009-0010", 9 },
                    { new Guid("6ebd7e67-c071-4722-8969-c720261a0efc"), "Sunita", 2, true, true, "Thapa", "Kumari", "+9779625610666", new DateTime(2024, 6, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3010), "NPV-005-0010", 5 },
                    { new Guid("6fc77978-1772-4359-9183-210a020684ff"), "Ram", 1, true, true, "Nepali", "Raj", "+9779818032685", new DateTime(2024, 5, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5590), "NPV-019-0004", 19 },
                    { new Guid("71245c72-ed43-4b6a-bd42-4cf19a1fc16e"), "Sunita", 2, true, false, "Karki", "Maya", "+9779853005057", new DateTime(2025, 7, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5920), "NPV-021-0004", 21 },
                    { new Guid("7266507e-fefd-44a4-869d-8ce3c9cb4375"), "Santosh", 1, true, true, "Chaudhary", "Bahadur", "+9779745625168", new DateTime(2024, 7, 15, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(690), "NPV-047-0005", 47 },
                    { new Guid("72d9dfad-90cc-495a-97a4-11f2e10ce00f"), "Suresh", 1, true, true, "Chaudhary", "Bahadur", "+9779827176326", new DateTime(2024, 7, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6010), "NPV-021-0010", 21 },
                    { new Guid("73bab120-f80d-4b57-966b-a3f88245a159"), "Bishnu", 1, true, true, "Karki", "Kumar", "+9779888689829", new DateTime(2025, 6, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5840), "NPV-020-0009", 20 },
                    { new Guid("746453dd-38ba-46ee-bece-8bd1c4bcd576"), "Bikash", 1, true, true, "Yadav", "Kumar", "+9779887598241", new DateTime(2024, 5, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6640), "NPV-025-0007", 25 },
                    { new Guid("748444bb-0ea2-426d-a3b1-f92daf360580"), "Sunita", 2, true, true, "Shrestha", "Devi", "+9779889489107", new DateTime(2024, 4, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9070), "NPV-038-0008", 38 },
                    { new Guid("74a7ade9-9ef2-4df0-a327-6b007b044c17"), "Dipak", 1, true, true, "Nepali", "Raj", "+9779818102043", new DateTime(2024, 1, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4920), "NPV-015-0008", 15 },
                    { new Guid("74bfcb9f-7ce4-4aa0-bd71-6ebb2f8c96cf"), "Shova", 2, true, true, "Thapa", "Laxmi", "+9779622229260", new DateTime(2025, 1, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5940), "NPV-021-0005", 21 },
                    { new Guid("75ec4ab2-d7f6-4387-9a91-e68549178693"), "Hari", 1, true, false, "Magar", "Bahadur", "+9779807868916", new DateTime(2025, 5, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5080), "NPV-016-0009", 16 },
                    { new Guid("776cd855-5242-4000-97b6-8d0463da3fbb"), "Arjun", 1, true, false, "Khadka", "Kumar", "+9779864269972", new DateTime(2024, 6, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4530), "NPV-014-0003", 14 },
                    { new Guid("77949866-cd59-4f9f-ba43-fc2b6b811d29"), "Prakash", 1, true, false, "Lama", "Kumar", "+9779626821766", new DateTime(2024, 9, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2550), "NPV-003-0009", 3 },
                    { new Guid("77da6022-eb6c-4a66-b052-5a10a6cc45b1"), "Shyam", 1, true, true, "Tamang", "Kumar", "+9779626129259", new DateTime(2025, 8, 17, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(670), "NPV-047-0004", 47 },
                    { new Guid("78701a68-22e2-4291-9267-a30e36a5805f"), "Bishnu", 1, true, false, "Yadav", "Singh", "+9779829951037", new DateTime(2024, 1, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4450), "NPV-013-0008", 13 },
                    { new Guid("78c15be9-7858-4cc7-958f-25a893a17e6b"), "Anita", 2, true, true, "Rai", "Kumari", "+9779633307762", new DateTime(2025, 11, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4660), "NPV-015-0002", 15 },
                    { new Guid("78f864d1-f573-481a-be82-303068d24db6"), "Rekha", 2, true, true, "Yadav", "Kumari", "+9779888242803", new DateTime(2024, 4, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4010), "NPV-011-0008", 11 },
                    { new Guid("79f5d786-41c1-477d-81b3-fe8de9ad2cb1"), "Hari", 1, true, true, "Thapa", "Raj", "+9779742664276", new DateTime(2025, 6, 21, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(270), "NPV-044-0009", 44 },
                    { new Guid("7a3c4673-a1f4-40c6-8ab4-70a4f18267ed"), "Mohan", 1, true, false, "Rai", "Bahadur", "+9779846857284", new DateTime(2025, 2, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4400), "NPV-013-0004", 13 },
                    { new Guid("7a6df614-785a-4d8c-b111-38cac085f5b5"), "Suresh", 1, true, true, "Lama", "Kumar", "+9779741404831", new DateTime(2025, 3, 31, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(830), "NPV-048-0003", 48 },
                    { new Guid("7b91a94b-056e-4478-89a5-b031efc31b89"), "Laxmi", 2, true, true, "Yadav", "Maya", "+9779639763549", new DateTime(2025, 12, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9860), "NPV-043-0003", 43 },
                    { new Guid("7bec5706-b94e-4712-b053-8b77bfd6b898"), "Nabin", 1, true, false, "Gurung", "Prasad", "+9779801935371", new DateTime(2025, 4, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7560), "NPV-030-0002", 30 },
                    { new Guid("7d74722d-8937-4122-b8e3-43452c3b9061"), "Hari", 1, true, true, "Lama", "Kumar", "+9779881044009", new DateTime(2024, 9, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9980), "NPV-044-0001", 44 },
                    { new Guid("7eb41a7e-373d-4636-9ed2-8abd15de6775"), "Sabitri", 2, true, true, "Tamang", "Devi", "+9779629425438", new DateTime(2024, 2, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5610), "NPV-019-0005", 19 },
                    { new Guid("7f2a2232-6677-4255-a786-04c1c43c0464"), "Nisha", 2, true, true, "Maharjan", "Laxmi", "+9779843849336", new DateTime(2024, 1, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9920), "NPV-043-0007", 43 },
                    { new Guid("7f64a9ac-8661-4482-9a64-1ada18ff073a"), "Radha", 2, true, true, "Magar", "Laxmi", "+9779806061375", new DateTime(2024, 11, 19, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(780), "NPV-047-0010", 47 },
                    { new Guid("809d26b9-9f4a-4780-9e4a-acf14a5949cb"), "Anita", 2, true, true, "Nepali", "Kumari", "+9779613863597", new DateTime(2024, 6, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9780), "NPV-042-0008", 42 },
                    { new Guid("819ece2b-21ad-4671-af2d-601e3907de29"), "Mohan", 1, true, true, "Yadav", "Singh", "+9779748600922", new DateTime(2025, 9, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8350), "NPV-034-0006", 34 },
                    { new Guid("81b57fc8-9dab-4aa9-a500-3cc41e0f4e9b"), "Sabitri", 2, true, true, "Khadka", "Devi", "+9779845384203", new DateTime(2025, 5, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3020), "NPV-006-0001", 6 },
                    { new Guid("81e6c9e6-640c-41ad-888f-93af8321b57a"), "Gopal", 1, true, false, "Chaudhary", "Singh", "+9779761537712", new DateTime(2024, 2, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3760), "NPV-010-0001", 10 },
                    { new Guid("81f70903-4c50-43aa-889f-ddf68e571c73"), "Rupa", 2, true, true, "Karki", "Kumari", "+9779751241543", new DateTime(2024, 8, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9660), "NPV-041-0010", 41 },
                    { new Guid("821734d3-72ab-4d17-9ad0-ae71eab810b3"), "Radha", 2, true, true, "Maharjan", "Laxmi", "+9779622826642", new DateTime(2024, 1, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5070), "NPV-016-0008", 16 },
                    { new Guid("8251f1e0-bd7b-4411-8e0a-3dc586b1861b"), "Laxmi", 2, true, true, "Rai", "Laxmi", "+9779825224241", new DateTime(2024, 1, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2650), "NPV-004-0005", 4 },
                    { new Guid("827af319-b26b-45b9-9e91-e38bad3fd945"), "Arjun", 1, true, true, "Karki", "Singh", "+9779639572600", new DateTime(2024, 6, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3550), "NPV-008-0007", 8 },
                    { new Guid("828c3560-910b-406e-b825-9170fd85c2f3"), "Nisha", 2, true, true, "B.K.", "Laxmi", "+9779749306751", new DateTime(2024, 8, 26, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(90), "NPV-044-0008", 44 },
                    { new Guid("8312aebd-f824-428a-a6d8-ec7375d1abcd"), "Anita", 2, true, true, "Lama", "Kumari", "+9779637606869", new DateTime(2024, 11, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3950), "NPV-011-0004", 11 },
                    { new Guid("8464b2df-8734-4989-9c04-a4918157d97d"), "Dipak", 1, true, false, "Sharma", "Kumar", "+9779754666451", new DateTime(2025, 5, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8460), "NPV-035-0004", 35 },
                    { new Guid("85bb944e-783f-4823-807f-d80f5157ca1e"), "Rekha", 2, true, false, "Maharjan", "Maya", "+9779636574597", new DateTime(2025, 9, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9950), "NPV-043-0009", 43 },
                    { new Guid("85dc8a25-0a37-4e2b-95de-01b95c5c82c6"), "Hari", 1, true, false, "Nepali", "Raj", "+9779744018192", new DateTime(2025, 4, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5040), "NPV-016-0006", 16 },
                    { new Guid("8750d217-c66c-426f-8b0d-87dbe08e922a"), "Gita", 2, true, true, "B.K.", "Kumari", "+9779808118088", new DateTime(2025, 8, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4100), "NPV-012-0003", 12 },
                    { new Guid("8781284c-258a-4f21-9f36-901f9ca36f42"), "Arjun", 1, true, true, "Shrestha", "Raj", "+9779638432033", new DateTime(2025, 7, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2390), "NPV-002-0008", 2 },
                    { new Guid("87bfb692-4e44-48be-a7e6-c8c2dc1ee4f5"), "Laxmi", 2, true, true, "Gurung", "Kumari", "+9779821762249", new DateTime(2024, 2, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5310), "NPV-018-0005", 18 },
                    { new Guid("87e4676f-30b1-48b4-b4a2-4f21e1791c1a"), "Nabin", 1, true, true, "Nepali", "Singh", "+9779628279423", new DateTime(2025, 7, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8470), "NPV-035-0005", 35 },
                    { new Guid("88584078-8550-43ac-9c0f-4a6836305011"), "Prakash", 1, true, true, "Sharma", "Bahadur", "+9779761814535", new DateTime(2025, 1, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6700), "NPV-026-0001", 26 },
                    { new Guid("88c6dc6e-f1ef-434b-b39c-9abd1e9d75f1"), "Rajesh", 1, true, true, "Nepali", "Kumar", "+9779864244117", new DateTime(2025, 6, 8, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(430), "NPV-045-0009", 45 },
                    { new Guid("891854bc-0ac4-4326-a20e-bba0ca6f17f9"), "Shova", 2, true, false, "Chaudhary", "Kumari", "+9779812398044", new DateTime(2024, 3, 7, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(460), "NPV-046-0001", 46 },
                    { new Guid("89a77c6e-9090-4b80-a3cc-c18186878b98"), "Rupa", 2, true, true, "Karki", "Kumari", "+9779862363493", new DateTime(2024, 2, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5370), "NPV-018-0009", 18 },
                    { new Guid("89e229bd-ae99-4901-8dc8-4d8039ff496e"), "Laxmi", 2, true, true, "B.K.", "Kumari", "+9779848748600", new DateTime(2025, 11, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8260), "NPV-033-0010", 33 },
                    { new Guid("8a7a0cd2-d236-49d5-9a5a-dda6878f52c4"), "Dipak", 1, true, true, "Yadav", "Kumar", "+9779819377469", new DateTime(2025, 5, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7220), "NPV-028-0007", 28 },
                    { new Guid("8b4bbba1-eec1-4069-a7e0-e1248ce7ec6f"), "Sarita", 2, true, true, "Chaudhary", "Laxmi", "+9779762260279", new DateTime(2024, 4, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9600), "NPV-041-0006", 41 },
                    { new Guid("8bbd66a2-6754-4229-b3cb-fe91fbd60eaf"), "Radha", 2, true, false, "Shrestha", "Devi", "+9779822857432", new DateTime(2024, 7, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3120), "NPV-006-0007", 6 },
                    { new Guid("8df962d2-8f41-484f-87b0-6a0ae8bfd855"), "Laxmi", 2, true, false, "Magar", "Devi", "+9779818221600", new DateTime(2025, 10, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6440), "NPV-024-0003", 24 },
                    { new Guid("8e8671fd-8f9c-43a6-9413-3c771808ccd0"), "Shova", 2, true, false, "Thapa", "Kumari", "+9779809782395", new DateTime(2025, 11, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3810), "NPV-010-0004", 10 },
                    { new Guid("8e9449de-d7eb-4e11-b8cc-91b6a6acbbe2"), "Bishnu", 1, true, true, "Gurung", "Bahadur", "+9779814148611", new DateTime(2025, 4, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9540), "NPV-041-0002", 41 },
                    { new Guid("8f5a3097-54ef-48d3-bf0b-952596ca9387"), "Sarita", 2, true, true, "Khadka", "Laxmi", "+9779809641898", new DateTime(2025, 4, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9770), "NPV-042-0007", 42 },
                    { new Guid("8f74a43e-1239-407c-8f1e-075b7dcca670"), "Radha", 2, true, true, "B.K.", "Laxmi", "+9779881510397", new DateTime(2024, 11, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6980), "NPV-026-0010", 26 },
                    { new Guid("900d3f42-3f66-422a-84e9-e909ba2c4ba9"), "Maya", 2, true, true, "Magar", "Laxmi", "+9779805447652", new DateTime(2024, 1, 10, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(730), "NPV-047-0007", 47 },
                    { new Guid("9031e582-0b06-47b3-9fad-8ea91063fca7"), "Dipak", 1, true, false, "Karki", "Prasad", "+9779841476527", new DateTime(2024, 8, 14, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(880), "NPV-048-0007", 48 },
                    { new Guid("9090a653-e0c4-4322-8313-5b7da66ca00f"), "Maya", 2, true, false, "Chaudhary", "Devi", "+9779818292182", new DateTime(2024, 1, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7910), "NPV-032-0004", 32 },
                    { new Guid("90c1cef0-ac3d-42fc-9b67-1f7606c0a561"), "Sabitri", 2, true, true, "Sharma", "Kumari", "+9779759420776", new DateTime(2025, 7, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5960), "NPV-021-0007", 21 },
                    { new Guid("9102460e-0b30-4e11-9cf7-ade100ab9a78"), "Ram", 1, true, true, "Shrestha", "Raj", "+9779748625840", new DateTime(2024, 11, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7830), "NPV-031-0009", 31 },
                    { new Guid("920a8dd1-6b01-4a25-ba79-c17e46480e85"), "Rupa", 2, true, true, "Karki", "Kumari", "+9779801282497", new DateTime(2025, 9, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5730), "NPV-020-0002", 20 },
                    { new Guid("9233989c-5b47-4809-aafb-2fa24843ca24"), "Rekha", 2, true, true, "Tamang", "Devi", "+9779749237434", new DateTime(2025, 2, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7180), "NPV-028-0004", 28 },
                    { new Guid("9244e701-cae8-4b7e-bbec-659e28538111"), "Hari", 1, true, true, "Thapa", "Kumar", "+9779808606226", new DateTime(2024, 9, 15, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(30), "NPV-044-0004", 44 },
                    { new Guid("929644f9-f16a-41d7-9d74-9bbf1cac37ed"), "Shova", 2, true, true, "B.K.", "Laxmi", "+9779859165317", new DateTime(2024, 5, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7050), "NPV-027-0005", 27 },
                    { new Guid("92e50e79-d2e0-4995-90fe-8b611ecedf68"), "Sita", 2, true, true, "Chaudhary", "Kumari", "+9779864417574", new DateTime(2024, 11, 10, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(410), "NPV-045-0008", 45 },
                    { new Guid("92fec424-6c22-4df1-8e00-be38690548fb"), "Sarita", 2, true, true, "Rai", "Devi", "+9779869334487", new DateTime(2024, 4, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4890), "NPV-015-0006", 15 },
                    { new Guid("93422a18-07dc-404c-a73c-c496619a26b6"), "Nisha", 2, true, true, "Tamang", "Kumari", "+9779631363103", new DateTime(2024, 3, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3780), "NPV-010-0002", 10 },
                    { new Guid("953260bc-7703-4b46-94ce-2c7d3bdead0d"), "Maya", 2, true, true, "Karki", "Kumari", "+9779764142955", new DateTime(2025, 2, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3670), "NPV-009-0005", 9 },
                    { new Guid("95344c42-d9d3-4951-9a9a-ab7b6f18f5aa"), "Arjun", 1, true, false, "Gurung", "Bahadur", "+9779868966929", new DateTime(2024, 1, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6960), "NPV-026-0009", 26 },
                    { new Guid("95c5bdef-c420-4042-8a6c-086765c75131"), "Bishnu", 1, true, true, "Rai", "Singh", "+9779617719822", new DateTime(2024, 3, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5110), "NPV-017-0001", 17 },
                    { new Guid("9635ae06-3816-4084-b57c-db9706f48649"), "Ram", 1, true, true, "Shrestha", "Bahadur", "+9779841381351", new DateTime(2024, 9, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2440), "NPV-003-0001", 3 },
                    { new Guid("96528e9f-748b-40d4-9314-c030f77e2dff"), "Anita", 2, true, true, "Maharjan", "Kumari", "+9779846922110", new DateTime(2025, 7, 23, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(10), "NPV-044-0003", 44 },
                    { new Guid("96b53b2f-29e3-422a-b541-57222a08c0be"), "Santosh", 1, true, true, "Nepali", "Singh", "+9779826639912", new DateTime(2025, 11, 8, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(850), "NPV-048-0005", 48 },
                    { new Guid("96ca76e9-4642-47a3-b400-aad97218abed"), "Shyam", 1, true, true, "Karki", "Prasad", "+9779813881145", new DateTime(2025, 4, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(1930), "NPV-001-0005", 1 },
                    { new Guid("973ec65b-7cfb-46e0-8600-583302bb3849"), "Sita", 2, true, true, "Sharma", "Kumari", "+9779825774007", new DateTime(2024, 3, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8200), "NPV-033-0006", 33 },
                    { new Guid("97de5bb2-9f1f-474c-939f-4c8565d8c032"), "Maya", 2, true, true, "Yadav", "Laxmi", "+9779869442621", new DateTime(2025, 7, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7530), "NPV-029-0010", 29 },
                    { new Guid("988edde6-672e-4ea6-bc60-1822bc3ed63d"), "Sabitri", 2, true, true, "Shrestha", "Kumari", "+9779752047309", new DateTime(2024, 3, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5860), "NPV-020-0010", 20 },
                    { new Guid("98c4b7bc-d1ed-4385-a398-18f55df55b76"), "Krishna", 1, true, true, "Khadka", "Singh", "+9779743338315", new DateTime(2025, 9, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2300), "NPV-002-0002", 2 },
                    { new Guid("99812c29-6622-4474-bda1-e708ee151643"), "Dipak", 1, true, false, "Lama", "Kumar", "+9779817766522", new DateTime(2025, 10, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3690), "NPV-009-0006", 9 },
                    { new Guid("99c8c2a8-d135-446a-b6f2-8f329d2c502b"), "Hari", 1, true, false, "Rai", "Kumar", "+9779638798936", new DateTime(2025, 2, 5, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(610), "NPV-046-0010", 46 },
                    { new Guid("9a8d0413-eb77-4297-9a21-53b61dd7f6c4"), "Rajesh", 1, true, true, "Thapa", "Bahadur", "+9779857297031", new DateTime(2025, 4, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5340), "NPV-018-0007", 18 },
                    { new Guid("9b03247a-412a-4d9d-bed2-c3f66e0df473"), "Santosh", 1, true, true, "Magar", "Raj", "+9779843007455", new DateTime(2025, 2, 26, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(360), "NPV-045-0005", 45 },
                    { new Guid("9b19cbbd-8263-4555-a125-cbe9df5fbb9b"), "Rekha", 2, true, true, "Gurung", "Devi", "+9779886036169", new DateTime(2025, 6, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9830), "NPV-043-0001", 43 },
                    { new Guid("9bd43250-8bef-44b6-af27-d5910a8eaa2d"), "Sarita", 2, true, true, "Tamang", "Kumari", "+9779757340123", new DateTime(2025, 11, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9910), "NPV-043-0006", 43 },
                    { new Guid("9ced8047-c745-474f-9e1e-e811f0acef30"), "Rajesh", 1, true, true, "Rai", "Bahadur", "+9779743421810", new DateTime(2025, 8, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7090), "NPV-027-0008", 27 },
                    { new Guid("9d0e1181-8fba-4430-a89e-7ad463fe40fd"), "Hari", 1, true, false, "Rai", "Raj", "+9779816212416", new DateTime(2025, 5, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2310), "NPV-002-0003", 2 },
                    { new Guid("9d2c2bd2-7a6d-4935-93d0-eab78bb02659"), "Gopal", 1, true, true, "Magar", "Kumar", "+9779763238010", new DateTime(2024, 1, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5240), "NPV-017-0010", 17 },
                    { new Guid("9e082f33-2205-4d2f-bc45-85666622d81b"), "Radha", 2, true, true, "Sharma", "Kumari", "+9779846486353", new DateTime(2025, 2, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8210), "NPV-033-0007", 33 },
                    { new Guid("9e21cf42-1f6a-4113-943b-5439f458e941"), "Arjun", 1, true, true, "Shrestha", "Prasad", "+9779619663606", new DateTime(2024, 1, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4620), "NPV-014-0009", 14 },
                    { new Guid("9e3fb2f5-f90d-4dd4-8a61-e9da80658fa2"), "Prakash", 1, true, true, "Maharjan", "Bahadur", "+9779765638705", new DateTime(2024, 3, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5200), "NPV-017-0007", 17 },
                    { new Guid("9e655511-3c8d-42e8-94d3-8b550f944f81"), "Gopal", 1, true, true, "Magar", "Singh", "+9779849089789", new DateTime(2024, 4, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5360), "NPV-018-0008", 18 },
                    { new Guid("9f423ea2-4bf4-4d0c-931c-419a3f31338f"), "Maya", 2, true, true, "Tamang", "Devi", "+9779867325732", new DateTime(2024, 10, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8360), "NPV-034-0007", 34 },
                    { new Guid("9f4fed6a-9076-41cc-b1cf-d7edb333fa86"), "Maya", 2, true, true, "Gurung", "Kumari", "+9779762580487", new DateTime(2025, 10, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3170), "NPV-007-0001", 7 },
                    { new Guid("9f8de9bb-5c4a-4f24-b3ed-a77ca6cf4601"), "Dipak", 1, true, true, "B.K.", "Singh", "+9779855575794", new DateTime(2024, 5, 6, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(350), "NPV-045-0004", 45 },
                    { new Guid("a06606c4-f73a-4143-a6bd-b5e8f1d22754"), "Sunita", 2, true, false, "Tamang", "Kumari", "+9779829079022", new DateTime(2024, 3, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3400), "NPV-008-0005", 8 },
                    { new Guid("a0e6f4c1-c1cf-44cb-9764-63bd153a5c26"), "Sita", 2, true, true, "Karki", "Devi", "+9779743392296", new DateTime(2024, 6, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7500), "NPV-029-0008", 29 },
                    { new Guid("a123553f-dbc8-4027-bab5-d62adddb1e4f"), "Sabitri", 2, true, false, "Rai", "Kumari", "+9779743112464", new DateTime(2024, 10, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6020), "NPV-022-0001", 22 },
                    { new Guid("a1d4bbe6-5388-4406-b30a-e8a62c6da125"), "Ram", 1, true, true, "Yadav", "Singh", "+9779856449095", new DateTime(2024, 9, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7670), "NPV-030-0009", 30 },
                    { new Guid("a2fecec3-9fe0-43b0-b9cd-8d9bcaa2800c"), "Nisha", 2, true, true, "Shrestha", "Laxmi", "+9779828840985", new DateTime(2024, 12, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6130), "NPV-022-0009", 22 },
                    { new Guid("a36e7476-3666-4152-9384-3d2c513f642f"), "Radha", 2, true, true, "Magar", "Maya", "+9779842767114", new DateTime(2025, 6, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2580), "NPV-004-0001", 4 },
                    { new Guid("a3a399dd-e0d0-44e2-8ec6-04c77817fbf0"), "Shyam", 1, true, true, "Tamang", "Raj", "+9779818109061", new DateTime(2025, 3, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3100), "NPV-006-0006", 6 },
                    { new Guid("a74fe4a8-4f1b-482a-8849-caa8a87391b2"), "Radha", 2, true, false, "Karki", "Devi", "+9779884832193", new DateTime(2024, 6, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6400), "NPV-023-0010", 23 },
                    { new Guid("a76d9dc8-09cf-40bb-be9f-d7eee06ba997"), "Sabitri", 2, true, true, "Tamang", "Kumari", "+9779768452034", new DateTime(2025, 1, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8290), "NPV-034-0002", 34 },
                    { new Guid("a79f096f-0d9b-4940-bac7-533edfa4edcf"), "Sunita", 2, true, true, "Gurung", "Devi", "+9779765291480", new DateTime(2025, 5, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3280), "NPV-007-0007", 7 },
                    { new Guid("a878d6ba-d370-4037-befa-363867eb2d07"), "Sarita", 2, true, true, "Sharma", "Kumari", "+9779766495778", new DateTime(2024, 11, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3310), "NPV-007-0009", 7 },
                    { new Guid("a887b3d7-5810-41d8-8808-5fa649329704"), "Mohan", 1, true, true, "Khadka", "Raj", "+9779866080571", new DateTime(2025, 2, 15, 21, 49, 16, 493, DateTimeKind.Utc).AddTicks(9040), "NPV-001-0001", 1 },
                    { new Guid("a91307fc-d1bd-4f4a-adee-13847c2c092a"), "Bikash", 1, true, true, "Lama", "Prasad", "+9779818298314", new DateTime(2024, 7, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6350), "NPV-023-0007", 23 },
                    { new Guid("a91dea0b-21e1-46b5-a721-239d8354e273"), "Sita", 2, true, true, "Khadka", "Kumari", "+9779844329781", new DateTime(2025, 1, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7080), "NPV-027-0007", 27 },
                    { new Guid("a9f22df9-af17-4cfc-a074-789797053f4b"), "Gita", 2, true, true, "Khadka", "Laxmi", "+9779862711102", new DateTime(2024, 6, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4290), "NPV-012-0007", 12 },
                    { new Guid("aaef549c-c9df-44c0-ae75-4e24173d3acf"), "Santosh", 1, true, true, "Magar", "Bahadur", "+9779639426104", new DateTime(2025, 10, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3290), "NPV-007-0008", 7 },
                    { new Guid("ac9c5d33-230a-4c5f-a9b0-bd05d319ed4f"), "Santosh", 1, true, true, "Shrestha", "Singh", "+9779805092928", new DateTime(2025, 7, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3660), "NPV-009-0004", 9 },
                    { new Guid("ad4afd63-97f6-4ca7-a180-7301bd55f6ab"), "Ram", 1, true, false, "Lama", "Raj", "+9779817331004", new DateTime(2024, 7, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4940), "NPV-015-0009", 15 },
                    { new Guid("ad5cd739-c8f8-4ded-9c79-71ce074a1d2d"), "Shyam", 1, true, true, "Sharma", "Kumar", "+9779754548018", new DateTime(2024, 10, 24, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9240), "NPV-039-0010", 39 },
                    { new Guid("aded748d-0850-4127-9319-1debe20cdd57"), "Krishna", 1, true, true, "Rai", "Bahadur", "+9779769797251", new DateTime(2024, 7, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8870), "NPV-037-0005", 37 },
                    { new Guid("ae5b4171-21e1-4995-a799-5894ca4ae8c6"), "Gopal", 1, true, true, "Rai", "Kumar", "+9779614145815", new DateTime(2025, 7, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5400), "NPV-019-0001", 19 },
                    { new Guid("ae9c4a43-aff8-406c-bf7f-2eceb3639374"), "Arjun", 1, true, true, "B.K.", "Singh", "+9779615932437", new DateTime(2025, 5, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7750), "NPV-031-0004", 31 },
                    { new Guid("aeeebed0-1691-428b-9c5a-3a06aa9215b4"), "Shova", 2, true, true, "Chaudhary", "Devi", "+9779762781008", new DateTime(2024, 6, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6190), "NPV-023-0003", 23 },
                    { new Guid("af8fb256-e952-48eb-a7e2-3bad623c435c"), "Ram", 1, true, false, "Chaudhary", "Bahadur", "+9779804285408", new DateTime(2024, 3, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5750), "NPV-020-0003", 20 },
                    { new Guid("afd6e6ad-942e-438f-ab58-54e7034cc098"), "Krishna", 1, true, true, "Lama", "Kumar", "+9779743962673", new DateTime(2024, 4, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6950), "NPV-026-0008", 26 },
                    { new Guid("aff51b88-5ee9-454d-bc40-5e99397c44bd"), "Sarita", 2, true, false, "Maharjan", "Devi", "+9779624137705", new DateTime(2025, 6, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2410), "NPV-002-0009", 2 },
                    { new Guid("b02be99a-1c86-4174-8e49-3d8c813585a0"), "Nabin", 1, true, false, "Karki", "Kumar", "+9779865133684", new DateTime(2025, 11, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2740), "NPV-005-0001", 5 },
                    { new Guid("b0dbf643-fe6c-461e-9c1b-c5713b8949e4"), "Arjun", 1, true, false, "Tamang", "Kumar", "+9779743735203", new DateTime(2024, 7, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7590), "NPV-030-0004", 30 },
                    { new Guid("b135389e-a03c-448b-a97e-739add904ced"), "Gita", 2, true, true, "Chaudhary", "Laxmi", "+9779846168003", new DateTime(2024, 7, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3900), "NPV-010-0010", 10 },
                    { new Guid("b1a0e87d-56ab-4842-b440-62309f095c2c"), "Sarita", 2, true, true, "Maharjan", "Maya", "+9779861764328", new DateTime(2024, 1, 7, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(560), "NPV-046-0007", 46 },
                    { new Guid("b1b2d37a-81f7-47b6-b77d-cb255e62c2b3"), "Bishnu", 1, true, false, "Chaudhary", "Prasad", "+9779826451673", new DateTime(2024, 4, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6060), "NPV-022-0004", 22 },
                    { new Guid("b1eab6a2-87a5-4652-890e-da5c6cad461d"), "Maya", 2, true, true, "Magar", "Laxmi", "+9779857198468", new DateTime(2024, 4, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4080), "NPV-012-0002", 12 },
                    { new Guid("b2369157-0e66-4cb2-ae51-9ae43abab8ae"), "Rekha", 2, true, false, "Thapa", "Kumari", "+9779863942976", new DateTime(2025, 12, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4550), "NPV-014-0004", 14 },
                    { new Guid("b2f80017-3fbe-429c-9575-96f78a07985e"), "Krishna", 1, true, true, "Lama", "Singh", "+9779885820956", new DateTime(2025, 1, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7300), "NPV-029-0002", 29 },
                    { new Guid("b3e93305-bed4-4e6b-93e4-662803b6f522"), "Santosh", 1, true, true, "Tamang", "Raj", "+9779808942445", new DateTime(2024, 8, 28, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(750), "NPV-047-0008", 47 },
                    { new Guid("b4a53b92-fc1f-4a3e-92dc-dc68dd0c093d"), "Mohan", 1, true, true, "Sharma", "Raj", "+9779887557475", new DateTime(2024, 12, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2980), "NPV-005-0008", 5 },
                    { new Guid("b4cad353-82d7-4d48-b151-18a1e07e49ba"), "Shyam", 1, true, false, "Nepali", "Kumar", "+9779889682720", new DateTime(2024, 4, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2990), "NPV-005-0009", 5 },
                    { new Guid("b55ced4f-ccc7-41be-ae76-8f60a9efa704"), "Radha", 2, true, true, "Tamang", "Devi", "+9779752905859", new DateTime(2025, 5, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7660), "NPV-030-0008", 30 },
                    { new Guid("b6cbb38d-7cda-4109-93fa-54ab6ec325a3"), "Hari", 1, true, true, "Magar", "Raj", "+9779865659019", new DateTime(2024, 12, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3130), "NPV-006-0008", 6 },
                    { new Guid("b7f4c885-58b6-4262-b41c-a6976badfbb0"), "Santosh", 1, true, true, "Karki", "Bahadur", "+9779749982392", new DateTime(2024, 1, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6370), "NPV-023-0008", 23 },
                    { new Guid("b804886b-1ea0-47a1-8cee-26472b8684a2"), "Arjun", 1, true, true, "Sharma", "Bahadur", "+9779766937179", new DateTime(2025, 3, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7990), "NPV-032-0009", 32 },
                    { new Guid("b8c73cf1-b84e-48c3-baf4-7e66d6f3ac18"), "Sarita", 2, true, true, "Shrestha", "Kumari", "+9779866529730", new DateTime(2025, 9, 7, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(870), "NPV-048-0006", 48 },
                    { new Guid("b988014c-7959-4619-b5a6-1a32f4813eb5"), "Hari", 1, true, true, "Yadav", "Raj", "+9779629964835", new DateTime(2024, 9, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7740), "NPV-031-0003", 31 },
                    { new Guid("b9e5a91f-ca33-4bfc-afca-f23b9bffa5f7"), "Suresh", 1, true, true, "Chaudhary", "Bahadur", "+9779753881235", new DateTime(2025, 7, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8270), "NPV-034-0001", 34 },
                    { new Guid("b9ed1481-9cf5-4f83-86fc-e66d34b26787"), "Prakash", 1, true, true, "Yadav", "Bahadur", "+9779854621634", new DateTime(2025, 3, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4130), "NPV-012-0005", 12 },
                    { new Guid("ba594f72-4873-4a9b-a0e0-986b4192d4cf"), "Krishna", 1, true, false, "Gurung", "Prasad", "+9779846699722", new DateTime(2024, 1, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5230), "NPV-017-0009", 17 },
                    { new Guid("ba9a3553-518f-4ad6-957a-b742b61fa1e7"), "Laxmi", 2, true, true, "Gurung", "Kumari", "+9779759057644", new DateTime(2025, 6, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5120), "NPV-017-0002", 17 },
                    { new Guid("bac25d89-58de-4430-962c-cdde8e0482db"), "Sarita", 2, true, false, "Khadka", "Laxmi", "+9779616957733", new DateTime(2024, 8, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7280), "NPV-029-0001", 29 },
                    { new Guid("bb46ffa9-dbfd-486c-abf4-e6c0e74b2a6f"), "Mohan", 1, true, true, "Chaudhary", "Kumar", "+9779755147096", new DateTime(2025, 4, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9270), "NPV-040-0002", 40 },
                    { new Guid("bb6dbbf6-9ead-462e-9167-9ed911441d9d"), "Nabin", 1, true, true, "Shrestha", "Prasad", "+9779639556579", new DateTime(2024, 12, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9010), "NPV-038-0004", 38 },
                    { new Guid("bb8e978c-fdce-4c4d-9a16-3dbb9b2e121c"), "Santosh", 1, true, true, "Sharma", "Kumar", "+9779814978351", new DateTime(2024, 10, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3410), "NPV-008-0006", 8 },
                    { new Guid("bd1df4df-2174-4920-a6ad-55b8a19d4e61"), "Rupa", 2, true, true, "Karki", "Devi", "+9779632247709", new DateTime(2025, 12, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2250), "NPV-001-0009", 1 },
                    { new Guid("bdf5fc64-0b1c-4259-988b-053c3ed128e6"), "Sarita", 2, true, true, "Chaudhary", "Laxmi", "+9779749745285", new DateTime(2024, 4, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3610), "NPV-009-0001", 9 },
                    { new Guid("be3478ca-9160-49f9-9b91-a9ab353d02ae"), "Sabitri", 2, true, true, "Yadav", "Laxmi", "+9779809396696", new DateTime(2025, 11, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9400), "NPV-040-0010", 40 },
                    { new Guid("bea23f09-a79a-41d7-b4c0-af91219e46fb"), "Nabin", 1, true, true, "Nepali", "Kumar", "+9779883817395", new DateTime(2024, 11, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3040), "NPV-006-0002", 6 },
                    { new Guid("beba460c-70ee-469e-ac78-a60066fc321d"), "Krishna", 1, true, true, "Karki", "Bahadur", "+9779842031273", new DateTime(2025, 6, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8300), "NPV-034-0003", 34 },
                    { new Guid("bed55e4d-5b26-4022-8e2f-b929282d9e53"), "Anita", 2, true, true, "Thapa", "Kumari", "+9779761176961", new DateTime(2024, 11, 1, 21, 49, 16, 495, DateTimeKind.Utc), "NPV-044-0002", 44 },
                    { new Guid("c0227594-eaa3-470d-818c-d368f04f3e54"), "Rajesh", 1, true, true, "Maharjan", "Prasad", "+9779882173719", new DateTime(2025, 12, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5270), "NPV-018-0002", 18 },
                    { new Guid("c0b3cb90-acb7-4b7e-839f-8c9b53057a74"), "Dipak", 1, true, true, "B.K.", "Prasad", "+9779746188847", new DateTime(2024, 8, 6, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9520), "NPV-041-0001", 41 },
                    { new Guid("c0cab6c9-d31d-4a4f-b0a1-9c87148ea646"), "Mohan", 1, true, true, "Maharjan", "Prasad", "+9779843798719", new DateTime(2025, 4, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7250), "NPV-028-0009", 28 },
                    { new Guid("c240281e-f559-4df7-84d5-9fe6b1b74cb3"), "Krishna", 1, true, true, "Chaudhary", "Raj", "+9779614266437", new DateTime(2024, 4, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2490), "NPV-003-0005", 3 },
                    { new Guid("c2d69f76-55f5-43dd-bf59-c70e4e3613c7"), "Shova", 2, true, true, "Yadav", "Kumari", "+9779889182526", new DateTime(2024, 7, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6600), "NPV-025-0004", 25 },
                    { new Guid("c3535130-3862-4dc2-945a-cead271f0052"), "Prakash", 1, true, true, "Lama", "Raj", "+9779746234166", new DateTime(2025, 3, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3220), "NPV-007-0004", 7 },
                    { new Guid("c385e061-b1fc-4912-8769-2e2eac9e7466"), "Nabin", 1, true, true, "Rai", "Prasad", "+9779763222987", new DateTime(2025, 5, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7440), "NPV-029-0004", 29 },
                    { new Guid("c52919bf-0d23-4a66-860e-e87e762c0588"), "Sita", 2, true, true, "Gurung", "Kumari", "+9779744769389", new DateTime(2025, 4, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2710), "NPV-004-0009", 4 },
                    { new Guid("c53d8db4-f1dd-46f3-9949-492d5585ea45"), "Gopal", 1, true, false, "Khadka", "Prasad", "+9779634911838", new DateTime(2024, 9, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4000), "NPV-011-0007", 11 },
                    { new Guid("c53e0cbb-b6de-472e-ad3f-5da98512b880"), "Sarita", 2, true, true, "Sharma", "Kumari", "+9779624940983", new DateTime(2024, 2, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4380), "NPV-013-0003", 13 },
                    { new Guid("c59a1cad-dd28-47d9-8b1a-c383e7a20c91"), "Santosh", 1, true, true, "Thapa", "Raj", "+9779868813237", new DateTime(2024, 8, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4030), "NPV-011-0009", 11 },
                    { new Guid("c6b1fdb9-f352-460c-871d-52c24c529b4f"), "Parbati", 2, true, false, "Maharjan", "Kumari", "+9779755843042", new DateTime(2024, 12, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6650), "NPV-025-0008", 25 },
                    { new Guid("c6b83853-f8ee-4aad-9fbb-132be23af1c0"), "Sabitri", 2, true, true, "Yadav", "Kumari", "+9779743310807", new DateTime(2024, 5, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5630), "NPV-019-0006", 19 },
                    { new Guid("c7463fdc-0a0e-43ee-8a85-20fd17377ecf"), "Rajesh", 1, true, true, "Gurung", "Singh", "+9779823795573", new DateTime(2024, 3, 21, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(580), "NPV-046-0008", 46 },
                    { new Guid("c7e15f2d-5390-4fd4-99e3-8f957b31323f"), "Dipak", 1, true, true, "Rai", "Raj", "+9779858640826", new DateTime(2025, 5, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2370), "NPV-002-0007", 2 },
                    { new Guid("c88a75a1-7669-4593-b5a9-84ce72df8566"), "Sita", 2, true, false, "Chaudhary", "Devi", "+9779889991089", new DateTime(2024, 12, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6090), "NPV-022-0006", 22 },
                    { new Guid("c89019a6-4fd3-45de-aee5-dfdecd02552a"), "Gita", 2, true, true, "Nepali", "Kumari", "+9779765689063", new DateTime(2025, 7, 28, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5380), "NPV-018-0010", 18 },
                    { new Guid("c8ddafbc-3e14-4bc6-9b9f-0e56b035c298"), "Bishnu", 1, true, false, "Lama", "Singh", "+9779634842493", new DateTime(2025, 3, 7, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(290), "NPV-044-0010", 44 },
                    { new Guid("c9eef962-5fd8-47a4-9c56-5fd2d8f79bc7"), "Sabitri", 2, true, true, "Shrestha", "Laxmi", "+9779632827266", new DateTime(2025, 2, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9580), "NPV-041-0005", 41 },
                    { new Guid("ca0e3ce3-0d4d-4a51-8c55-4cc02376403e"), "Shyam", 1, true, true, "Thapa", "Kumar", "+9779763378055", new DateTime(2025, 1, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4950), "NPV-015-0010", 15 },
                    { new Guid("ca381e83-a283-492e-91c8-3c2bec36201a"), "Sarita", 2, true, true, "Karki", "Kumari", "+9779747745813", new DateTime(2025, 9, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4320), "NPV-012-0009", 12 },
                    { new Guid("ca7fcaa1-9a39-40f6-b533-e70913d12895"), "Anita", 2, true, true, "Sharma", "Devi", "+9779612805873", new DateTime(2025, 9, 8, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(710), "NPV-047-0006", 47 },
                    { new Guid("cab3c910-b082-4666-ab41-f757a918b959"), "Bishnu", 1, true, true, "Lama", "Prasad", "+9779768078726", new DateTime(2024, 6, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4600), "NPV-014-0008", 14 },
                    { new Guid("cc009212-c5a2-4258-a6d5-673934e3a17d"), "Arjun", 1, true, true, "Lama", "Singh", "+9779801097227", new DateTime(2025, 8, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4560), "NPV-014-0005", 14 },
                    { new Guid("cc395650-97bb-473e-a9e0-26ae00678cf5"), "Arjun", 1, true, true, "Sharma", "Raj", "+9779862828983", new DateTime(2024, 1, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6150), "NPV-022-0010", 22 },
                    { new Guid("cce12b78-dfda-4fb8-b6aa-02b149de655a"), "Rajesh", 1, true, true, "Tamang", "Prasad", "+9779859784945", new DateTime(2024, 8, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6540), "NPV-024-0010", 24 },
                    { new Guid("cdf525ed-b137-42cd-abf3-bd7c33ce0b65"), "Suresh", 1, true, true, "Karki", "Prasad", "+9779883033624", new DateTime(2025, 3, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3140), "NPV-006-0009", 6 },
                    { new Guid("ce0f04d2-98f7-430a-a129-46b39feedd6f"), "Bishnu", 1, true, true, "Nepali", "Raj", "+9779615382670", new DateTime(2025, 11, 15, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(630), "NPV-047-0001", 47 },
                    { new Guid("ce8c40a6-4d74-458a-a0e2-5851c194cf64"), "Sabitri", 2, true, true, "Nepali", "Maya", "+9779621830319", new DateTime(2024, 2, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4060), "NPV-012-0001", 12 },
                    { new Guid("ce94612e-dc98-40c9-982c-f2d212ce9673"), "Laxmi", 2, true, true, "Chaudhary", "Maya", "+9779753007256", new DateTime(2024, 8, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5050), "NPV-016-0007", 16 },
                    { new Guid("cec53a4d-8d7b-4d37-b21a-3fdf80a67a80"), "Arjun", 1, true, true, "Rai", "Singh", "+9779751343531", new DateTime(2024, 6, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8920), "NPV-037-0008", 37 },
                    { new Guid("cef659bf-3870-45f7-83e9-668e93641be9"), "Shova", 2, true, true, "Tamang", "Kumari", "+9779843557948", new DateTime(2025, 7, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7930), "NPV-032-0005", 32 },
                    { new Guid("cffe1ccc-55a3-4dcd-b1de-77c925352a2f"), "Sunita", 2, true, true, "Tamang", "Kumari", "+9779804428430", new DateTime(2025, 7, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7850), "NPV-031-0010", 31 },
                    { new Guid("d013cf2a-1281-4357-844b-7f2e236beed5"), "Dipak", 1, true, true, "Khadka", "Prasad", "+9779828427900", new DateTime(2024, 2, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5990), "NPV-021-0009", 21 },
                    { new Guid("d0470b36-af62-40df-b564-1970a35b5c14"), "Bishnu", 1, true, false, "Sharma", "Prasad", "+9779856452292", new DateTime(2025, 6, 3, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(510), "NPV-046-0004", 46 },
                    { new Guid("d0fabaf7-077b-481a-9a32-d13e8c4faaad"), "Laxmi", 2, true, true, "B.K.", "Kumari", "+9779619970833", new DateTime(2025, 12, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2520), "NPV-003-0007", 3 },
                    { new Guid("d19fd602-8672-40d3-aa26-05029f6eac19"), "Sarita", 2, true, true, "Khadka", "Laxmi", "+9779611447903", new DateTime(2025, 8, 9, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2640), "NPV-004-0004", 4 },
                    { new Guid("d1f364cf-2449-49cd-bfd4-1e4d389692f9"), "Gopal", 1, true, true, "Nepali", "Raj", "+9779766026469", new DateTime(2025, 9, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7630), "NPV-030-0006", 30 },
                    { new Guid("d2139f05-6bcb-40d5-8ea6-c87021bcc8b4"), "Rekha", 2, true, true, "Sharma", "Maya", "+9779806194305", new DateTime(2025, 3, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5810), "NPV-020-0007", 20 },
                    { new Guid("d2bf0204-afec-459f-bea6-edafd57fc519"), "Nisha", 2, true, true, "Gurung", "Kumari", "+9779743064767", new DateTime(2025, 11, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(1860), "NPV-001-0002", 1 },
                    { new Guid("d3ea82d2-24bb-4bd8-854f-4b18df550f6e"), "Maya", 2, true, false, "Gurung", "Kumari", "+9779805796751", new DateTime(2025, 8, 27, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(60), "NPV-044-0006", 44 },
                    { new Guid("d45c321a-ba20-475d-8962-400a0d15949e"), "Parbati", 2, true, true, "Gurung", "Laxmi", "+9779743075582", new DateTime(2025, 10, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4990), "NPV-016-0003", 16 },
                    { new Guid("d483e4ae-7b51-43de-816e-484ffdc55be1"), "Sita", 2, true, true, "Rai", "Kumari", "+9779824915076", new DateTime(2025, 9, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8010), "NPV-032-0010", 32 },
                    { new Guid("d4bbf147-5d2d-4eeb-9efd-f09720c0b51c"), "Arjun", 1, true, true, "Nepali", "Bahadur", "+9779887003504", new DateTime(2024, 10, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9300), "NPV-040-0004", 40 },
                    { new Guid("d4e58cd6-6365-49c0-9a8a-8d0e166de191"), "Mohan", 1, true, true, "Magar", "Bahadur", "+9779749258350", new DateTime(2025, 6, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4440), "NPV-013-0007", 13 },
                    { new Guid("d60d6cc7-e29a-4c94-894a-5a9656ebb74f"), "Sarita", 2, true, true, "Gurung", "Kumari", "+9779844911887", new DateTime(2025, 12, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8190), "NPV-033-0005", 33 },
                    { new Guid("d73eb2b5-f47f-46ab-a489-46f24c1fde7f"), "Mohan", 1, true, false, "Gurung", "Singh", "+9779617571147", new DateTime(2025, 10, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4960), "NPV-016-0001", 16 },
                    { new Guid("d7f76a26-e038-444e-8e23-71545c64c6b3"), "Gita", 2, true, true, "Gurung", "Devi", "+9779821998331", new DateTime(2024, 10, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8540), "NPV-035-0010", 35 },
                    { new Guid("d931efb1-a7a8-4442-ad3e-bb5ad830d2fb"), "Ram", 1, true, true, "Shrestha", "Prasad", "+9779812951493", new DateTime(2024, 12, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5430), "NPV-019-0003", 19 },
                    { new Guid("d9ae3e90-9a9f-4df9-8ad6-6cf8eedd9243"), "Rupa", 2, true, true, "Tamang", "Maya", "+9779822965398", new DateTime(2024, 10, 29, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(330), "NPV-045-0003", 45 },
                    { new Guid("da599875-ee6a-4aac-af5e-9534179044ed"), "Santosh", 1, true, true, "Lama", "Prasad", "+9779822050745", new DateTime(2025, 7, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5150), "NPV-017-0004", 17 },
                    { new Guid("db0e3872-147c-4b53-8561-23346f8e4985"), "Suresh", 1, true, false, "Sharma", "Prasad", "+9779819870066", new DateTime(2025, 8, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6420), "NPV-024-0002", 24 },
                    { new Guid("db3ae708-c65b-4707-8f2b-0a7d4be4c0de"), "Gopal", 1, true, true, "Gurung", "Raj", "+9779801508974", new DateTime(2024, 10, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3940), "NPV-011-0003", 11 },
                    { new Guid("db4fbff7-737c-4c60-a8d1-c3864641d8a0"), "Maya", 2, true, true, "Tamang", "Kumari", "+9779819737288", new DateTime(2025, 10, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8890), "NPV-037-0006", 37 },
                    { new Guid("db963cdc-fe15-491d-b70a-aff16303270a"), "Bikash", 1, true, true, "Magar", "Prasad", "+9779639885460", new DateTime(2024, 5, 15, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7020), "NPV-027-0003", 27 },
                    { new Guid("dbe085ee-9d94-46d8-972f-15063c943658"), "Rupa", 2, true, true, "Tamang", "Kumari", "+9779855922498", new DateTime(2024, 9, 5, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(1920), "NPV-001-0004", 1 },
                    { new Guid("dc176e22-72b1-4cf8-b342-72f922147d0b"), "Ram", 1, true, true, "Nepali", "Singh", "+9779809881190", new DateTime(2024, 10, 2, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4370), "NPV-013-0002", 13 },
                    { new Guid("dc23188b-b851-4693-99bc-afe1eb5c5a5a"), "Mohan", 1, true, true, "Gurung", "Kumar", "+9779619785204", new DateTime(2024, 7, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2950), "NPV-005-0006", 5 },
                    { new Guid("dc84797f-cd58-46e5-97f4-d8d22669110f"), "Sita", 2, true, true, "Thapa", "Kumari", "+9779816920623", new DateTime(2025, 8, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5780), "NPV-020-0005", 20 },
                    { new Guid("dcd71bca-d897-440a-bd2e-014c6fb21b78"), "Nisha", 2, true, true, "Lama", "Kumari", "+9779638287537", new DateTime(2025, 6, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5910), "NPV-021-0003", 21 },
                    { new Guid("dce43f87-a5d2-4b11-83d1-6e203452dc48"), "Mohan", 1, true, true, "Sharma", "Singh", "+9779745698839", new DateTime(2024, 7, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7150), "NPV-028-0002", 28 },
                    { new Guid("dd5641c0-0622-47ce-8dc1-23421e489c1a"), "Shova", 2, true, true, "Yadav", "Laxmi", "+9779858472729", new DateTime(2024, 10, 12, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(900), "NPV-048-0008", 48 },
                    { new Guid("de5c43c2-1c87-48ad-a8cb-293f36d332c8"), "Arjun", 1, true, true, "Maharjan", "Raj", "+9779824035975", new DateTime(2024, 10, 29, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3970), "NPV-011-0005", 11 },
                    { new Guid("df47404d-a793-4ecd-b2ed-a1491e3ee72d"), "Parbati", 2, true, true, "B.K.", "Laxmi", "+9779845721804", new DateTime(2025, 10, 24, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(490), "NPV-046-0003", 46 },
                    { new Guid("dfb448cb-d75a-4922-b3b2-ad68a6e71652"), "Anita", 2, true, false, "Sharma", "Laxmi", "+9779886131729", new DateTime(2024, 3, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9080), "NPV-038-0009", 38 },
                    { new Guid("dfeacdce-f4e0-4840-b004-3caf96bb43b8"), "Hari", 1, true, true, "Rai", "Raj", "+9779619290476", new DateTime(2025, 9, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7510), "NPV-029-0009", 29 },
                    { new Guid("e051d51b-dc22-4653-9fd8-0c304d892262"), "Rekha", 2, true, true, "Gurung", "Kumari", "+9779755494267", new DateTime(2025, 7, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(1900), "NPV-001-0003", 1 },
                    { new Guid("e06cf847-5989-4bad-b374-ad49fe1ac892"), "Bikash", 1, true, true, "Khadka", "Prasad", "+9779756093236", new DateTime(2025, 8, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8530), "NPV-035-0009", 35 },
                    { new Guid("e0f5ea61-2b74-4bde-ab66-610d0e85821c"), "Krishna", 1, true, true, "Nepali", "Prasad", "+9779887211000", new DateTime(2025, 5, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8140), "NPV-033-0002", 33 },
                    { new Guid("e0f84841-de07-4ac1-8059-75179dc6605e"), "Ram", 1, true, true, "Lama", "Prasad", "+9779858613737", new DateTime(2024, 2, 27, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7780), "NPV-031-0006", 31 },
                    { new Guid("e1547d9d-0dac-4b2b-81e1-efbe9100a493"), "Sita", 2, true, true, "Karki", "Devi", "+9779802225954", new DateTime(2025, 10, 31, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8600), "NPV-036-0004", 36 },
                    { new Guid("e1920f4a-3ba8-47f2-a49b-ae9e48dc28b2"), "Parbati", 2, true, true, "Rai", "Devi", "+9779764438932", new DateTime(2024, 3, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8620), "NPV-036-0005", 36 },
                    { new Guid("e1ad2f64-f30b-480f-81ab-bd05aad57cc8"), "Bishnu", 1, true, true, "Sharma", "Raj", "+9779627039620", new DateTime(2025, 6, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7140), "NPV-028-0001", 28 },
                    { new Guid("e1e408a8-3ed9-4075-af48-f7845845b05c"), "Rajesh", 1, true, true, "Rai", "Raj", "+9779635925989", new DateTime(2025, 9, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5290), "NPV-018-0003", 18 },
                    { new Guid("e1f4fb78-c6e7-4124-abb1-b4856beb3248"), "Radha", 2, true, true, "Yadav", "Laxmi", "+9779825742939", new DateTime(2025, 6, 9, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(640), "NPV-047-0002", 47 },
                    { new Guid("e29830c5-c125-4a4f-99a3-6286d191cd7d"), "Sabitri", 2, true, true, "Yadav", "Laxmi", "+9779753826128", new DateTime(2025, 2, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4680), "NPV-015-0003", 15 },
                    { new Guid("e2e7ae25-4414-4f69-8fd2-f35bc6152178"), "Gita", 2, true, false, "Maharjan", "Kumari", "+9779816963148", new DateTime(2024, 11, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3160), "NPV-006-0010", 6 },
                    { new Guid("e320aca7-25a1-45a0-934d-e5f8813154c8"), "Prakash", 1, true, true, "Magar", "Bahadur", "+9779622046234", new DateTime(2025, 11, 19, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(530), "NPV-046-0005", 46 },
                    { new Guid("e35f4ec9-5c35-417c-b02f-b5951c381580"), "Hari", 1, true, true, "Nepali", "Singh", "+9779859557523", new DateTime(2025, 11, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8430), "NPV-035-0002", 35 },
                    { new Guid("e413c597-0cce-4cf7-be1b-e0130312ad24"), "Rupa", 2, true, false, "Gurung", "Devi", "+9779756582260", new DateTime(2024, 4, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2270), "NPV-001-0010", 1 },
                    { new Guid("e45c48af-67c9-4a69-871f-9ef9d0d67013"), "Rajesh", 1, true, true, "Tamang", "Raj", "+9779618292796", new DateTime(2025, 4, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6720), "NPV-026-0003", 26 },
                    { new Guid("e4e69439-50dc-43ec-af69-f92148d0a121"), "Mohan", 1, true, true, "Magar", "Kumar", "+9779802042810", new DateTime(2025, 10, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3090), "NPV-006-0005", 6 },
                    { new Guid("e5bd2eca-142a-426c-91c4-9c69c12e4027"), "Bikash", 1, true, true, "Gurung", "Kumar", "+9779814680952", new DateTime(2025, 6, 20, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7420), "NPV-029-0003", 29 },
                    { new Guid("e5d0b912-b86b-45a8-85fa-71ffd1b9d5e8"), "Sabitri", 2, true, true, "Thapa", "Kumari", "+9779861938468", new DateTime(2025, 3, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4690), "NPV-015-0004", 15 },
                    { new Guid("e7155c41-014d-4855-a34c-2adba879699a"), "Sabitri", 2, true, true, "Thapa", "Kumari", "+9779766233380", new DateTime(2025, 1, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(1990), "NPV-001-0007", 1 },
                    { new Guid("e8eff2a1-278a-4a3c-ad8a-c11a793846df"), "Anita", 2, true, true, "Thapa", "Maya", "+9779612053983", new DateTime(2025, 1, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3870), "NPV-010-0008", 10 },
                    { new Guid("e934f7b8-4822-42fe-b04a-92f564afa5b0"), "Anita", 2, true, false, "Tamang", "Devi", "+9779617918782", new DateTime(2025, 8, 17, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(590), "NPV-046-0009", 46 },
                    { new Guid("e9725e9b-bc38-4e81-b760-6f774ea0d12f"), "Laxmi", 2, true, true, "Yadav", "Kumari", "+9779816168685", new DateTime(2025, 5, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8940), "NPV-037-0009", 37 },
                    { new Guid("e97cfc2a-4461-4dd3-a9cc-30b1bafb0c28"), "Sarita", 2, true, true, "B.K.", "Maya", "+9779815127250", new DateTime(2025, 11, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2960), "NPV-005-0007", 5 },
                    { new Guid("e988f416-f869-48b3-9e75-e375d2716c8c"), "Shyam", 1, true, true, "Gurung", "Bahadur", "+9779624932346", new DateTime(2025, 7, 23, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5890), "NPV-021-0002", 21 },
                    { new Guid("ea426a82-dd92-41e2-aba2-5b41268bba3f"), "Suresh", 1, true, true, "Lama", "Singh", "+9779881057781", new DateTime(2025, 9, 12, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7700), "NPV-031-0001", 31 },
                    { new Guid("eaa49bd4-7fe8-4371-bbe6-811463b3e530"), "Hari", 1, true, true, "Thapa", "Raj", "+9779635892521", new DateTime(2024, 1, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8900), "NPV-037-0007", 37 },
                    { new Guid("eb2ead19-c582-4995-b28e-7e73b2ca548e"), "Nisha", 2, true, true, "Lama", "Maya", "+9779619690786", new DateTime(2025, 8, 17, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9170), "NPV-039-0005", 39 },
                    { new Guid("ec35fbf6-91fa-49b8-8f63-20143549931d"), "Sarita", 2, true, true, "Nepali", "Devi", "+9779613311276", new DateTime(2025, 10, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3560), "NPV-008-0008", 8 },
                    { new Guid("ec855d85-1e35-4f98-b459-485d141265b1"), "Ram", 1, true, false, "Maharjan", "Prasad", "+9779636563857", new DateTime(2025, 7, 21, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6750), "NPV-026-0005", 26 },
                    { new Guid("ee8c51b9-9562-4f37-adbc-f704ae48ad6b"), "Sarita", 2, true, false, "Gurung", "Maya", "+9779618313434", new DateTime(2024, 4, 18, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2600), "NPV-004-0002", 4 },
                    { new Guid("ee963a49-6c65-41a5-9d47-f3b7aa780d4f"), "Shyam", 1, true, false, "B.K.", "Singh", "+9779762196275", new DateTime(2025, 5, 30, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9740), "NPV-042-0005", 42 },
                    { new Guid("efb21555-2ad2-4205-b51b-b09958a47cd0"), "Parbati", 2, true, true, "Nepali", "Kumari", "+9779628408947", new DateTime(2024, 11, 3, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2610), "NPV-004-0003", 4 },
                    { new Guid("eff9fe7a-a922-4518-9078-9c5ed1461f14"), "Suresh", 1, true, true, "Rai", "Raj", "+9779613910376", new DateTime(2025, 4, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6080), "NPV-022-0005", 22 },
                    { new Guid("f0455ccc-11ea-41b3-82ab-56cfa8937877"), "Rupa", 2, true, true, "Magar", "Kumari", "+9779863069804", new DateTime(2024, 1, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2330), "NPV-002-0004", 2 },
                    { new Guid("f0d645b4-6ef5-4ee3-83ee-5a91d8f7e5f5"), "Bikash", 1, true, true, "Tamang", "Bahadur", "+9779632099938", new DateTime(2024, 1, 14, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7450), "NPV-029-0005", 29 },
                    { new Guid("f111f0be-4817-491e-9a7b-2297393148c1"), "Santosh", 1, true, true, "Khadka", "Raj", "+9779755185263", new DateTime(2024, 5, 30, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(540), "NPV-046-0006", 46 },
                    { new Guid("f12b4620-7914-4201-a111-daea502a0865"), "Rekha", 2, true, true, "Sharma", "Kumari", "+9779767865446", new DateTime(2025, 10, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3630), "NPV-009-0002", 9 },
                    { new Guid("f1546dc1-0a1c-45a5-9184-c21ff03db830"), "Sita", 2, true, true, "Sharma", "Kumari", "+9779763682688", new DateTime(2024, 10, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5700), "NPV-019-0010", 19 },
                    { new Guid("f1e6cbf4-ddce-4c7d-9d9a-59cf4079ab4a"), "Bishnu", 1, true, true, "Rai", "Raj", "+9779768564522", new DateTime(2025, 12, 4, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8970), "NPV-038-0001", 38 },
                    { new Guid("f20ff137-07b2-4553-be0f-7908b20634da"), "Gita", 2, true, true, "Shrestha", "Laxmi", "+9779827185702", new DateTime(2025, 7, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9100), "NPV-038-0010", 38 },
                    { new Guid("f27f14e3-be13-471a-8ab2-d8dabb60f26e"), "Krishna", 1, true, true, "Sharma", "Raj", "+9779638506455", new DateTime(2025, 7, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4520), "NPV-014-0002", 14 },
                    { new Guid("f297ebf2-fbee-4e14-9c94-d6f3755e0d3e"), "Krishna", 1, true, true, "Tamang", "Singh", "+9779888936275", new DateTime(2024, 4, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(3360), "NPV-008-0002", 8 },
                    { new Guid("f2f12812-5231-4c19-a19e-39e9a5d7f06c"), "Hari", 1, true, true, "Gurung", "Bahadur", "+9779769508785", new DateTime(2025, 9, 10, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8500), "NPV-035-0007", 35 },
                    { new Guid("f3474c7e-18df-4418-b336-d25de293a1eb"), "Nabin", 1, true, true, "Khadka", "Bahadur", "+9779627939489", new DateTime(2024, 3, 8, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4340), "NPV-012-0010", 12 },
                    { new Guid("f4ae698e-1b16-484c-8a1a-27b1f2eea606"), "Mohan", 1, true, true, "Shrestha", "Singh", "+9779632053883", new DateTime(2025, 5, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9350), "NPV-040-0007", 40 },
                    { new Guid("f54cd269-5715-4120-909f-7e9aa96e7439"), "Prakash", 1, true, true, "Sharma", "Bahadur", "+9779841394992", new DateTime(2025, 2, 1, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8230), "NPV-033-0008", 33 },
                    { new Guid("f586ecdd-d943-4064-a672-aa2b79c70b67"), "Shyam", 1, true, true, "Magar", "Bahadur", "+9779754869243", new DateTime(2025, 3, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7860), "NPV-032-0001", 32 },
                    { new Guid("f591f7aa-f0d8-4e88-bf85-48968fda2b91"), "Maya", 2, true, true, "Khadka", "Kumari", "+9779843618032", new DateTime(2024, 2, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(1970), "NPV-001-0006", 1 },
                    { new Guid("f640a37f-55b3-49b7-8d95-c87474b02134"), "Sita", 2, true, false, "Nepali", "Maya", "+9779806598113", new DateTime(2024, 2, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(6570), "NPV-025-0002", 25 },
                    { new Guid("f6440e30-a88a-48d0-a55f-dc901e7dd3dc"), "Nabin", 1, true, true, "B.K.", "Singh", "+9779769307848", new DateTime(2024, 12, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9110), "NPV-039-0001", 39 },
                    { new Guid("f6ab58b6-a05a-4daa-ac3a-15b7049e01e8"), "Rajesh", 1, true, true, "B.K.", "Kumar", "+9779819560373", new DateTime(2024, 11, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8850), "NPV-037-0003", 37 },
                    { new Guid("f6cf082e-6532-44ff-8f61-1bcdc4801c80"), "Sunita", 2, true, true, "B.K.", "Maya", "+9779857472085", new DateTime(2025, 2, 22, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5180), "NPV-017-0006", 17 },
                    { new Guid("f8449860-4aee-47c3-940e-0a669d1aa60b"), "Rajesh", 1, true, true, "Yadav", "Bahadur", "+9779846696850", new DateTime(2024, 10, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(5830), "NPV-020-0008", 20 },
                    { new Guid("f84a7d0e-c258-4086-8c4a-0fc53b1f4d1e"), "Sunita", 2, true, false, "Rai", "Laxmi", "+9779804002550", new DateTime(2025, 7, 16, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8520), "NPV-035-0008", 35 },
                    { new Guid("f88fe9ac-d9ea-4fe8-bdb9-ac7247a1c9f1"), "Shova", 2, true, true, "Magar", "Kumari", "+9779868980669", new DateTime(2024, 6, 7, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(4590), "NPV-014-0007", 14 },
                    { new Guid("f92b12e7-1f4b-4e47-8516-03fc9e57ce73"), "Suresh", 1, true, true, "Nepali", "Prasad", "+9779885984190", new DateTime(2025, 11, 11, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2920), "NPV-005-0004", 5 },
                    { new Guid("fc6bbca8-d1a5-4021-b230-a9c1442ed2ac"), "Nabin", 1, true, true, "Sharma", "Raj", "+9779869362472", new DateTime(2024, 10, 5, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(1050), "NPV-048-0010", 48 },
                    { new Guid("fc99627c-18a9-4a5d-94d3-146b6aa50d48"), "Santosh", 1, true, true, "Nepali", "Raj", "+9779755253400", new DateTime(2024, 3, 30, 21, 49, 16, 495, DateTimeKind.Utc).AddTicks(760), "NPV-047-0009", 47 },
                    { new Guid("fd2d2211-154b-48b5-9ce5-5626519e5fc6"), "Suresh", 1, true, true, "Shrestha", "Singh", "+9779856633455", new DateTime(2025, 9, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(2460), "NPV-003-0003", 3 },
                    { new Guid("fd78cfc0-ea69-4cfa-a5d1-776034184132"), "Sita", 2, true, true, "Gurung", "Laxmi", "+9779851581788", new DateTime(2025, 6, 19, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9880), "NPV-043-0004", 43 },
                    { new Guid("fdb3ebcc-5151-4fb5-8e84-cfd329e82425"), "Hari", 1, true, true, "Sharma", "Prasad", "+9779854664418", new DateTime(2025, 8, 26, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(9380), "NPV-040-0009", 40 },
                    { new Guid("fdb61265-7a5a-45c3-9305-8983cff6d5a5"), "Arjun", 1, true, true, "Karki", "Prasad", "+9779849692719", new DateTime(2025, 1, 13, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(8590), "NPV-036-0003", 36 },
                    { new Guid("fdff7286-1ed8-45de-aa95-5380b937c01d"), "Sita", 2, true, true, "Shrestha", "Kumari", "+9779885143031", new DateTime(2025, 2, 25, 21, 49, 16, 494, DateTimeKind.Utc).AddTicks(7640), "NPV-030-0007", 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectionParties_LogoFileId",
                table: "ElectionParties",
                column: "LogoFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectionParties_MediaFiles_LogoFileId",
                table: "ElectionParties",
                column: "LogoFileId",
                principalTable: "MediaFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectionParties_MediaFiles_LogoFileId",
                table: "ElectionParties");

            migrationBuilder.DropTable(
                name: "MediaFiles");

            migrationBuilder.DropIndex(
                name: "IX_ElectionParties_LogoFileId",
                table: "ElectionParties");

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("020dc498-c5c8-44de-8e38-85585df2e2ae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("032bfc4c-5bcc-4019-8a39-f2c72dca3dfa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("03f63268-91bf-497c-814b-2ea275940e18"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0444f195-7c58-4347-8930-395b73929980"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0480774f-18f0-4d58-901c-b00894621d60"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("05705747-2310-4d73-b132-5374ea73dd9d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("057c1b8f-ebb5-4cc5-9c25-487e768bd893"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("05a994dc-60e7-47e0-befa-7ee312ccd6c5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("05e3e9a3-f697-427d-ad8b-ade5802eb453"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("060b1af1-3cd9-4ad1-b0c8-33d636c43b84"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("06317653-3530-448f-b49b-8d6ce18c7822"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("06cab003-aa73-4545-8680-bc61aa1e31f9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("071e4af7-7b51-4c38-8b18-c237a9b48634"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0763c529-11f3-4bba-a2d7-8cec3ae6924e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("07f7b3d8-af4c-45fc-8e73-f44f0c93d55e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0830a120-8c90-48b0-a194-bfa30ec6727a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("08658bd8-801d-46c9-92c4-957f97aeef69"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("093c03ec-0d7e-463d-8b21-c61827a357ba"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("09b2b6df-df92-43ec-be7a-d8805afb4dc3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0a9fd801-0c4a-4d08-9044-0524ddb3edee"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0b8af4eb-394a-406a-bcad-a8ee34b84f9d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0b9af398-1983-47d4-b114-4ea387ab5876"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0bb9a89e-8914-4307-9d10-9fa9526c1284"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0bf8b906-4f73-4b7e-8819-9796088cea47"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0bff68cd-90f8-4c75-a18b-0680442955bf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0c1c3033-e851-4add-818d-46cc6510af81"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0d35de9b-78b8-4a58-9b6a-856745c3bef8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0d459a34-7791-4020-a262-c66f9e28dc12"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0dcfbd17-6ff9-4132-80a4-12d0b8fb23dd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0e68c4f4-71f6-428e-a00f-0ccf06ebaa9b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1063f379-245d-4f13-bafb-e8b0e81dd442"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1109b501-0215-4d8d-9908-e575bd262b86"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("11172831-6da4-425f-bd7c-2d77a85948b6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("11553ae3-c214-4ceb-a0ea-b7d708d9d394"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("12b91007-4ce7-4a67-84b2-e3a9da2c0c3b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("136c4276-a276-4a3f-81e0-9339a96cb755"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("136e822d-dded-4f84-b636-346cc10ff68e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("14168ec5-bdca-4cd4-ab4b-704715bca831"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1457fd6a-9715-45cc-afc5-877ca2250762"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("156d9f2a-134c-44b7-8be5-74271d7d87c9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("16409c8f-8ba4-4030-8136-09a8ae494fcc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("16e5f6a1-926c-404d-858e-85aea4323c19"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("16f25406-c909-471b-9ff5-e326f1db1fa4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("170531bc-1ff1-4c0c-a529-fdebee90d752"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("195d3428-f0a4-41dd-8291-e9ea137b8fed"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1a23138e-c10d-441d-9a8e-bb089fffcf73"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1a41157d-bd9e-4a2e-a4ce-3274edf1607e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1a4f159c-b002-4467-a17b-863cee22fcdc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1bbff0bd-d253-4d1c-ab65-4695c9e05b60"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1cee99b4-f2d7-44ab-a521-baae969a8e83"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1d229b6f-b16f-485b-a5d9-a0c41896686e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1d2e82cd-c539-413a-b45b-8191f36e0be7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1d6b21d1-82fb-4cb9-9235-e2e0a2e60637"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1d822b7f-9004-4dca-937c-281ce45c8858"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1d9fb088-7040-4346-8902-9cf98f1d7ec0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1dad3b3c-6614-40d1-8871-1b5ed9d79c15"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1e4372cc-cfc9-45f9-a7f9-8657d3bae0ac"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1f5c359a-e212-4e9a-bf69-07c24c1bb17c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("21c4da0d-e4df-4727-a295-285411626d02"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2208683f-9d1c-49fc-a72d-0db22520f48a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("25b56a10-99a1-4a13-b95e-76ba40975245"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("25cf84a4-3219-477c-b5af-1d42a2e193e5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("260172bc-8eae-4811-994b-48ca3eaced49"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("26061a64-a57d-4cd5-9d20-5b13d0d234a4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("265c25df-e539-4f17-81ae-de2edbd7f7d3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("26a5195f-da62-4a8c-adb9-7a33bc7941c7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("292de35c-ba00-4d29-be1a-44d8a4b0f410"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("298eb06a-64dd-469f-878e-1feadd541c49"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("299ff111-e74b-4639-abe7-bfad336afc7a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("29bcc4a0-29cd-40bd-b46b-1caf1d8b4b70"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2a23c562-218b-40c8-a1b7-cb3d871dcdb7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2aaae39d-4d79-47c1-9868-4fb2aec833b6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2b88076c-a7ea-4975-8524-6431b2d8792a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2be1134d-409d-473e-8756-d2d01260bf32"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2c51fc82-e2ba-4f9f-8fe2-ad3d00c8d6d0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2d91cf39-69cd-4fe9-a312-9d110d9f18cc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2eccb4d9-53bf-4688-8983-93be42f2be93"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3061b092-4a7d-4a7d-a790-b34a12c36ac0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("309a991f-7513-4f9a-84bc-9d59a0e07922"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("30c3203b-c033-4f41-969e-b2301fda9139"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("32679f05-dd6d-42fb-8a9a-d87d7acf80ec"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3274a90c-8b70-4e59-ac97-40bac1292579"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("341f371f-b3fc-4390-a12d-97002ebf4810"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("34b000b6-f540-4dc7-ada3-db3d28d274c5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("35778ca2-e446-48b6-af90-b351a4b0dd4b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("36403d99-4cb0-4f57-ba1b-da33578c86a2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("37ad9353-1ccf-4dd2-ad21-2dc4845f9021"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("386faac2-17f7-4bb9-a092-90ff7690985e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("38d1f036-bb84-44f4-8ca5-7539256d7806"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("390030f0-b4f4-4b4e-b6b9-663d2d501b1b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("398f9bb4-6e42-4dfe-930f-829ba3b20c32"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3a14d202-d2cf-4b23-9565-c4181c042191"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3b3847b3-77d4-40b2-b4b7-a89c6ccd5da4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3b427167-38f8-43d9-a397-93c3d084c0ad"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3cae04b5-e3ff-4b9d-8eb3-be0b17b3262e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3cd02f5f-1213-4233-9452-80a6a5a2b2bb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3d045488-d7bf-4970-b07f-5056c28a8690"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3d07bcd5-459b-4149-be92-dc4c85fba8c8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3d70e6b8-7f61-48fe-bfdb-bfdd9448d605"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3dafd6d2-4829-419b-b0c4-6993c1b57cfc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3fc1da2a-2808-4aa3-a047-b4bf8d3c94fd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3ff5bc0b-4b32-41be-95c5-281c5e3376aa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("400cdb43-977f-430e-8457-39a4bec573b9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("40ae0066-43a5-43df-9e27-580055dc4501"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("40b2262d-9560-4001-b164-72d41c8d84dd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4136186f-6d0b-4e83-838e-3d93ecc921bd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("41c0e76c-d389-4680-9b7d-17ec1f88f627"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("41da7afd-571b-4a1d-8f32-9d32778501d0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("41ec21e6-84b9-4d98-b362-ee95d8273a98"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("430f81bf-08d4-4995-b814-eaea9a04646f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("432fbabd-cbf4-481b-a9f7-d05ffe64e687"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("443da11f-203e-4c91-83b0-03d1d0c2b888"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("44483ce7-319c-4621-af3a-bddb437e5949"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("448f8169-eee9-43e5-8e3e-c46eec5b931d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4526a9a6-78db-4373-aabd-27661be86d0e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("45742502-803c-4852-b7a8-cbf6ec93a8d5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("46b7794e-442d-433a-946e-414b7067f9a7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4751cffa-7d02-4933-a4e4-cdbff7fe6c69"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("47df5947-f4bf-4b10-bc33-841c90d30742"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4838723b-711f-48b4-951e-80b2c1a87d40"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("484e2f36-5908-4282-a92f-6b91fb55a8bf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("484e4179-aa2a-4af4-b362-eece210c4cc1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("48df1a17-c9d2-41b2-b922-3ff534efe46d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("494c63f8-b42c-49b3-81e0-402615084731"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("49ddce0e-4bf1-4a23-8856-9e1ab71b6fff"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("49e1f0f4-e73e-4b57-895c-eb27400385ea"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4b26411e-f5fb-4c5e-a35d-9a23e3c72dd0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4c22410d-d92e-4567-bb35-c0319b89c880"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4ce8f350-257e-4897-85b1-940df3bc0c9d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4cf2ae5a-ae3f-4b20-b7d2-dcd03f4284c9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4cf93cda-0a7c-4313-b9a8-5c9734734981"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4e11f172-f663-4ab9-baa9-535cfa451faa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4e337c78-1545-48a3-8795-30c8c6895dc0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4e962327-897a-44c5-803e-571e66dd21c8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4eaac5ab-a746-46cc-9703-929babd566ed"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4eb57dab-8296-41aa-8647-dd5a6a64e750"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4ef14049-1114-4d0d-89cf-c60b4cac7adb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4f27c055-8949-450b-b287-0f56fbf57b99"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4f4c953b-b575-4c11-9dea-9fa9c73c4741"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4f52b74e-b649-4d2d-b821-1ef5e6525aae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("50db2be3-89ec-4b7f-9cf1-637ff403f9ed"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("516ad07d-2808-41a4-baf7-39a94c892264"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("51acc85a-c6d9-4e37-aebc-0404478bca17"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("51e843f1-274d-49c7-9ca9-5ab6b507d876"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("52023c37-8012-4c1e-b867-ad14d1da8402"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5255b623-9319-4b69-a7fd-ecdc64913d81"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("532598b0-e2f5-4b6d-962b-df4c93c558ad"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("537347d8-c12d-4e65-aa19-ceb01fb5542a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("54772b2a-56c0-435e-a6f6-3194d43723ca"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("547bb22c-6f09-4c8f-9fd3-cae5ecf8d6df"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("54b0390f-773c-4a87-8f4e-bf1afcf24235"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("55c2c332-324d-4ffd-8169-a7725ec87b70"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("563d396f-346c-485d-bcd1-1296f0b8ee8c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("57496853-1463-42b3-b32b-10d082ea04ed"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5776fe6b-a4a4-4466-8f36-2d01b334d1b3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("57fd32db-c847-4de0-83cb-df601caff002"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("584f6a10-6877-4811-8c15-f501b2e2fb79"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5860fe38-d6fc-4290-9b2e-64bdf9653f8f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("58b6ce7b-aa40-4cb5-a06c-cfe0407c6a5f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("599c3f38-8739-4273-b489-97b1a2469ed7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5a325a3a-8742-4f4d-adb8-48ee45239f0c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5aee250d-2ee6-4a87-8c62-c3cb9c187712"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5b0ae4f1-9e9d-48cd-8f29-7e6c46d5e9bb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c4b5e0c-a604-4ba9-9f8a-59b2512c7095"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5cfbf8b8-5775-46fb-9296-28ae45f13e39"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5d382ca0-3d60-459d-824a-925d494ae8bc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5d8544f7-3398-4aa9-bc8d-65f9c4d03eb8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5dd5dcf9-e6d3-45cc-b104-b727e041edda"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5de53c4d-78fe-4570-a303-a891fc00b4c4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5e6a62fd-c64b-410f-ad8e-b915cb1e3282"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5e8af7d6-7f28-4813-9a4a-a43ce38a29c7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5ff9b414-6878-421a-9b51-79daa9cffa95"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("60f7e3a5-913f-47c4-9172-f93a9a671d03"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("61580600-7d09-4f38-94a4-dfc90339f045"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6240c9de-d113-4914-ae2f-e399ab52d46a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("62ef75c7-a133-41d3-ba38-441be07eb050"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("630a2d2e-2f2c-4f9d-b724-5a9f5dac4a97"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6366245b-74de-446f-95f3-3606616aa194"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("63ae58f3-53e7-4157-b442-c75fb8f82808"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("643a2ceb-0a64-438d-8f26-4fed6f83f305"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6494b1de-899d-4696-825e-c2a3047cbc8b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("660b01d2-2579-40ab-8522-2f92ca86cb2e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("66a663a6-477d-4e44-9041-87a3a4c9a916"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("66b0a2b3-d361-410d-85a9-b00dcdeeb519"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("66d422d5-8221-4229-9f27-6576803d2e94"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("674aa07c-c053-4bf6-b5b8-ffb663394c4a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("67ef173e-abd5-45f4-8307-5d65340dee17"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("681bef7a-ad6d-4a4c-8811-650606bb90e2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("68a55042-0d33-4ec6-af09-3356030fb54c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("68fa1b9f-b0bc-4f1e-af97-8839b0df5452"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("69e847ec-46d3-436a-bb37-98512a170771"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6aa2236c-fd59-4302-b54c-db401cd6aefa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6b135ef8-e23e-4a05-a2bb-c0fc05aa905c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6b8d3d40-c08a-4b7b-b2c2-83455c8d16a5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6d49bd66-f96c-4e92-b12e-7a98f082802e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6d8162c9-c6b0-474d-ae86-15a75650667c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6d8506fd-3dce-4d24-89ef-a8ff2528fe45"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6e13a23f-ecec-4acb-9f24-6d374407999e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6ea2fe75-ab76-4acd-bd62-602db6d85015"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6ebd7e67-c071-4722-8969-c720261a0efc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6fc77978-1772-4359-9183-210a020684ff"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("71245c72-ed43-4b6a-bd42-4cf19a1fc16e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7266507e-fefd-44a4-869d-8ce3c9cb4375"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("72d9dfad-90cc-495a-97a4-11f2e10ce00f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("73bab120-f80d-4b57-966b-a3f88245a159"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("746453dd-38ba-46ee-bece-8bd1c4bcd576"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("748444bb-0ea2-426d-a3b1-f92daf360580"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("74a7ade9-9ef2-4df0-a327-6b007b044c17"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("74bfcb9f-7ce4-4aa0-bd71-6ebb2f8c96cf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("75ec4ab2-d7f6-4387-9a91-e68549178693"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("776cd855-5242-4000-97b6-8d0463da3fbb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("77949866-cd59-4f9f-ba43-fc2b6b811d29"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("77da6022-eb6c-4a66-b052-5a10a6cc45b1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("78701a68-22e2-4291-9267-a30e36a5805f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("78c15be9-7858-4cc7-958f-25a893a17e6b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("78f864d1-f573-481a-be82-303068d24db6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("79f5d786-41c1-477d-81b3-fe8de9ad2cb1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7a3c4673-a1f4-40c6-8ab4-70a4f18267ed"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7a6df614-785a-4d8c-b111-38cac085f5b5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7b91a94b-056e-4478-89a5-b031efc31b89"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7bec5706-b94e-4712-b053-8b77bfd6b898"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7d74722d-8937-4122-b8e3-43452c3b9061"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7eb41a7e-373d-4636-9ed2-8abd15de6775"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7f2a2232-6677-4255-a786-04c1c43c0464"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7f64a9ac-8661-4482-9a64-1ada18ff073a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("809d26b9-9f4a-4780-9e4a-acf14a5949cb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("819ece2b-21ad-4671-af2d-601e3907de29"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("81b57fc8-9dab-4aa9-a500-3cc41e0f4e9b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("81e6c9e6-640c-41ad-888f-93af8321b57a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("81f70903-4c50-43aa-889f-ddf68e571c73"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("821734d3-72ab-4d17-9ad0-ae71eab810b3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8251f1e0-bd7b-4411-8e0a-3dc586b1861b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("827af319-b26b-45b9-9e91-e38bad3fd945"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("828c3560-910b-406e-b825-9170fd85c2f3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8312aebd-f824-428a-a6d8-ec7375d1abcd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8464b2df-8734-4989-9c04-a4918157d97d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("85bb944e-783f-4823-807f-d80f5157ca1e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("85dc8a25-0a37-4e2b-95de-01b95c5c82c6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8750d217-c66c-426f-8b0d-87dbe08e922a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8781284c-258a-4f21-9f36-901f9ca36f42"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("87bfb692-4e44-48be-a7e6-c8c2dc1ee4f5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("87e4676f-30b1-48b4-b4a2-4f21e1791c1a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("88584078-8550-43ac-9c0f-4a6836305011"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("88c6dc6e-f1ef-434b-b39c-9abd1e9d75f1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("891854bc-0ac4-4326-a20e-bba0ca6f17f9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("89a77c6e-9090-4b80-a3cc-c18186878b98"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("89e229bd-ae99-4901-8dc8-4d8039ff496e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8a7a0cd2-d236-49d5-9a5a-dda6878f52c4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8b4bbba1-eec1-4069-a7e0-e1248ce7ec6f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8bbd66a2-6754-4229-b3cb-fe91fbd60eaf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8df962d2-8f41-484f-87b0-6a0ae8bfd855"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8e8671fd-8f9c-43a6-9413-3c771808ccd0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8e9449de-d7eb-4e11-b8cc-91b6a6acbbe2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8f5a3097-54ef-48d3-bf0b-952596ca9387"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8f74a43e-1239-407c-8f1e-075b7dcca670"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("900d3f42-3f66-422a-84e9-e909ba2c4ba9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9031e582-0b06-47b3-9fad-8ea91063fca7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9090a653-e0c4-4322-8313-5b7da66ca00f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("90c1cef0-ac3d-42fc-9b67-1f7606c0a561"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9102460e-0b30-4e11-9cf7-ade100ab9a78"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("920a8dd1-6b01-4a25-ba79-c17e46480e85"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9233989c-5b47-4809-aafb-2fa24843ca24"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9244e701-cae8-4b7e-bbec-659e28538111"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("929644f9-f16a-41d7-9d74-9bbf1cac37ed"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("92e50e79-d2e0-4995-90fe-8b611ecedf68"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("92fec424-6c22-4df1-8e00-be38690548fb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("93422a18-07dc-404c-a73c-c496619a26b6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("953260bc-7703-4b46-94ce-2c7d3bdead0d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("95344c42-d9d3-4951-9a9a-ab7b6f18f5aa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("95c5bdef-c420-4042-8a6c-086765c75131"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9635ae06-3816-4084-b57c-db9706f48649"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("96528e9f-748b-40d4-9314-c030f77e2dff"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("96b53b2f-29e3-422a-b541-57222a08c0be"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("96ca76e9-4642-47a3-b400-aad97218abed"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("973ec65b-7cfb-46e0-8600-583302bb3849"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("97de5bb2-9f1f-474c-939f-4c8565d8c032"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("988edde6-672e-4ea6-bc60-1822bc3ed63d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("98c4b7bc-d1ed-4385-a398-18f55df55b76"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("99812c29-6622-4474-bda1-e708ee151643"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("99c8c2a8-d135-446a-b6f2-8f329d2c502b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9a8d0413-eb77-4297-9a21-53b61dd7f6c4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9b03247a-412a-4d9d-bed2-c3f66e0df473"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9b19cbbd-8263-4555-a125-cbe9df5fbb9b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9bd43250-8bef-44b6-af27-d5910a8eaa2d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9ced8047-c745-474f-9e1e-e811f0acef30"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9d0e1181-8fba-4430-a89e-7ad463fe40fd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9d2c2bd2-7a6d-4935-93d0-eab78bb02659"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9e082f33-2205-4d2f-bc45-85666622d81b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9e21cf42-1f6a-4113-943b-5439f458e941"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9e3fb2f5-f90d-4dd4-8a61-e9da80658fa2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9e655511-3c8d-42e8-94d3-8b550f944f81"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9f423ea2-4bf4-4d0c-931c-419a3f31338f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9f4fed6a-9076-41cc-b1cf-d7edb333fa86"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9f8de9bb-5c4a-4f24-b3ed-a77ca6cf4601"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a06606c4-f73a-4143-a6bd-b5e8f1d22754"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a0e6f4c1-c1cf-44cb-9764-63bd153a5c26"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a123553f-dbc8-4027-bab5-d62adddb1e4f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a1d4bbe6-5388-4406-b30a-e8a62c6da125"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a2fecec3-9fe0-43b0-b9cd-8d9bcaa2800c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a36e7476-3666-4152-9384-3d2c513f642f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a3a399dd-e0d0-44e2-8ec6-04c77817fbf0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a74fe4a8-4f1b-482a-8849-caa8a87391b2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a76d9dc8-09cf-40bb-be9f-d7eee06ba997"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a79f096f-0d9b-4940-bac7-533edfa4edcf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a878d6ba-d370-4037-befa-363867eb2d07"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a887b3d7-5810-41d8-8808-5fa649329704"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a91307fc-d1bd-4f4a-adee-13847c2c092a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a91dea0b-21e1-46b5-a721-239d8354e273"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a9f22df9-af17-4cfc-a074-789797053f4b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aaef549c-c9df-44c0-ae75-4e24173d3acf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ac9c5d33-230a-4c5f-a9b0-bd05d319ed4f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ad4afd63-97f6-4ca7-a180-7301bd55f6ab"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ad5cd739-c8f8-4ded-9c79-71ce074a1d2d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aded748d-0850-4127-9319-1debe20cdd57"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ae5b4171-21e1-4995-a799-5894ca4ae8c6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ae9c4a43-aff8-406c-bf7f-2eceb3639374"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aeeebed0-1691-428b-9c5a-3a06aa9215b4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("af8fb256-e952-48eb-a7e2-3bad623c435c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("afd6e6ad-942e-438f-ab58-54e7034cc098"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aff51b88-5ee9-454d-bc40-5e99397c44bd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b02be99a-1c86-4174-8e49-3d8c813585a0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b0dbf643-fe6c-461e-9c1b-c5713b8949e4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b135389e-a03c-448b-a97e-739add904ced"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b1a0e87d-56ab-4842-b440-62309f095c2c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b1b2d37a-81f7-47b6-b77d-cb255e62c2b3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b1eab6a2-87a5-4652-890e-da5c6cad461d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b2369157-0e66-4cb2-ae51-9ae43abab8ae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b2f80017-3fbe-429c-9575-96f78a07985e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b3e93305-bed4-4e6b-93e4-662803b6f522"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b4a53b92-fc1f-4a3e-92dc-dc68dd0c093d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b4cad353-82d7-4d48-b151-18a1e07e49ba"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b55ced4f-ccc7-41be-ae76-8f60a9efa704"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b6cbb38d-7cda-4109-93fa-54ab6ec325a3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b7f4c885-58b6-4262-b41c-a6976badfbb0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b804886b-1ea0-47a1-8cee-26472b8684a2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b8c73cf1-b84e-48c3-baf4-7e66d6f3ac18"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b988014c-7959-4619-b5a6-1a32f4813eb5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b9e5a91f-ca33-4bfc-afca-f23b9bffa5f7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b9ed1481-9cf5-4f83-86fc-e66d34b26787"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ba594f72-4873-4a9b-a0e0-986b4192d4cf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ba9a3553-518f-4ad6-957a-b742b61fa1e7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bac25d89-58de-4430-962c-cdde8e0482db"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bb46ffa9-dbfd-486c-abf4-e6c0e74b2a6f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bb6dbbf6-9ead-462e-9167-9ed911441d9d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bb8e978c-fdce-4c4d-9a16-3dbb9b2e121c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bd1df4df-2174-4920-a6ad-55b8a19d4e61"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bdf5fc64-0b1c-4259-988b-053c3ed128e6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("be3478ca-9160-49f9-9b91-a9ab353d02ae"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bea23f09-a79a-41d7-b4c0-af91219e46fb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("beba460c-70ee-469e-ac78-a60066fc321d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bed55e4d-5b26-4022-8e2f-b929282d9e53"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c0227594-eaa3-470d-818c-d368f04f3e54"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c0b3cb90-acb7-4b7e-839f-8c9b53057a74"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c0cab6c9-d31d-4a4f-b0a1-9c87148ea646"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c240281e-f559-4df7-84d5-9fe6b1b74cb3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c2d69f76-55f5-43dd-bf59-c70e4e3613c7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c3535130-3862-4dc2-945a-cead271f0052"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c385e061-b1fc-4912-8769-2e2eac9e7466"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c52919bf-0d23-4a66-860e-e87e762c0588"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c53d8db4-f1dd-46f3-9949-492d5585ea45"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c53e0cbb-b6de-472e-ad3f-5da98512b880"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c59a1cad-dd28-47d9-8b1a-c383e7a20c91"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c6b1fdb9-f352-460c-871d-52c24c529b4f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c6b83853-f8ee-4aad-9fbb-132be23af1c0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c7463fdc-0a0e-43ee-8a85-20fd17377ecf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c7e15f2d-5390-4fd4-99e3-8f957b31323f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c88a75a1-7669-4593-b5a9-84ce72df8566"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c89019a6-4fd3-45de-aee5-dfdecd02552a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c8ddafbc-3e14-4bc6-9b9f-0e56b035c298"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c9eef962-5fd8-47a4-9c56-5fd2d8f79bc7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ca0e3ce3-0d4d-4a51-8c55-4cc02376403e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ca381e83-a283-492e-91c8-3c2bec36201a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ca7fcaa1-9a39-40f6-b533-e70913d12895"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cab3c910-b082-4666-ab41-f757a918b959"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cc009212-c5a2-4258-a6d5-673934e3a17d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cc395650-97bb-473e-a9e0-26ae00678cf5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cce12b78-dfda-4fb8-b6aa-02b149de655a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cdf525ed-b137-42cd-abf3-bd7c33ce0b65"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ce0f04d2-98f7-430a-a129-46b39feedd6f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ce8c40a6-4d74-458a-a0e2-5851c194cf64"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ce94612e-dc98-40c9-982c-f2d212ce9673"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cec53a4d-8d7b-4d37-b21a-3fdf80a67a80"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cef659bf-3870-45f7-83e9-668e93641be9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cffe1ccc-55a3-4dcd-b1de-77c925352a2f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d013cf2a-1281-4357-844b-7f2e236beed5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d0470b36-af62-40df-b564-1970a35b5c14"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d0fabaf7-077b-481a-9a32-d13e8c4faaad"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d19fd602-8672-40d3-aa26-05029f6eac19"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d1f364cf-2449-49cd-bfd4-1e4d389692f9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d2139f05-6bcb-40d5-8ea6-c87021bcc8b4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d2bf0204-afec-459f-bea6-edafd57fc519"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d3ea82d2-24bb-4bd8-854f-4b18df550f6e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d45c321a-ba20-475d-8962-400a0d15949e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d483e4ae-7b51-43de-816e-484ffdc55be1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d4bbf147-5d2d-4eeb-9efd-f09720c0b51c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d4e58cd6-6365-49c0-9a8a-8d0e166de191"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d60d6cc7-e29a-4c94-894a-5a9656ebb74f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d73eb2b5-f47f-46ab-a489-46f24c1fde7f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d7f76a26-e038-444e-8e23-71545c64c6b3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d931efb1-a7a8-4442-ad3e-bb5ad830d2fb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d9ae3e90-9a9f-4df9-8ad6-6cf8eedd9243"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("da599875-ee6a-4aac-af5e-9534179044ed"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("db0e3872-147c-4b53-8561-23346f8e4985"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("db3ae708-c65b-4707-8f2b-0a7d4be4c0de"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("db4fbff7-737c-4c60-a8d1-c3864641d8a0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("db963cdc-fe15-491d-b70a-aff16303270a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dbe085ee-9d94-46d8-972f-15063c943658"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dc176e22-72b1-4cf8-b342-72f922147d0b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dc23188b-b851-4693-99bc-afe1eb5c5a5a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dc84797f-cd58-46e5-97f4-d8d22669110f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dcd71bca-d897-440a-bd2e-014c6fb21b78"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dce43f87-a5d2-4b11-83d1-6e203452dc48"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dd5641c0-0622-47ce-8dc1-23421e489c1a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("de5c43c2-1c87-48ad-a8cb-293f36d332c8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("df47404d-a793-4ecd-b2ed-a1491e3ee72d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dfb448cb-d75a-4922-b3b2-ad68a6e71652"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dfeacdce-f4e0-4840-b004-3caf96bb43b8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e051d51b-dc22-4653-9fd8-0c304d892262"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e06cf847-5989-4bad-b374-ad49fe1ac892"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e0f5ea61-2b74-4bde-ab66-610d0e85821c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e0f84841-de07-4ac1-8059-75179dc6605e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e1547d9d-0dac-4b2b-81e1-efbe9100a493"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e1920f4a-3ba8-47f2-a49b-ae9e48dc28b2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e1ad2f64-f30b-480f-81ab-bd05aad57cc8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e1e408a8-3ed9-4075-af48-f7845845b05c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e1f4fb78-c6e7-4124-abb1-b4856beb3248"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e29830c5-c125-4a4f-99a3-6286d191cd7d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e2e7ae25-4414-4f69-8fd2-f35bc6152178"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e320aca7-25a1-45a0-934d-e5f8813154c8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e35f4ec9-5c35-417c-b02f-b5951c381580"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e413c597-0cce-4cf7-be1b-e0130312ad24"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e45c48af-67c9-4a69-871f-9ef9d0d67013"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e4e69439-50dc-43ec-af69-f92148d0a121"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e5bd2eca-142a-426c-91c4-9c69c12e4027"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e5d0b912-b86b-45a8-85fa-71ffd1b9d5e8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e7155c41-014d-4855-a34c-2adba879699a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e8eff2a1-278a-4a3c-ad8a-c11a793846df"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e934f7b8-4822-42fe-b04a-92f564afa5b0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e9725e9b-bc38-4e81-b760-6f774ea0d12f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e97cfc2a-4461-4dd3-a9cc-30b1bafb0c28"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e988f416-f869-48b3-9e75-e375d2716c8c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ea426a82-dd92-41e2-aba2-5b41268bba3f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eaa49bd4-7fe8-4371-bbe6-811463b3e530"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eb2ead19-c582-4995-b28e-7e73b2ca548e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ec35fbf6-91fa-49b8-8f63-20143549931d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ec855d85-1e35-4f98-b459-485d141265b1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ee8c51b9-9562-4f37-adbc-f704ae48ad6b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ee963a49-6c65-41a5-9d47-f3b7aa780d4f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("efb21555-2ad2-4205-b51b-b09958a47cd0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eff9fe7a-a922-4518-9078-9c5ed1461f14"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f0455ccc-11ea-41b3-82ab-56cfa8937877"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f0d645b4-6ef5-4ee3-83ee-5a91d8f7e5f5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f111f0be-4817-491e-9a7b-2297393148c1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f12b4620-7914-4201-a111-daea502a0865"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f1546dc1-0a1c-45a5-9184-c21ff03db830"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f1e6cbf4-ddce-4c7d-9d9a-59cf4079ab4a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f20ff137-07b2-4553-be0f-7908b20634da"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f27f14e3-be13-471a-8ab2-d8dabb60f26e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f297ebf2-fbee-4e14-9c94-d6f3755e0d3e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f2f12812-5231-4c19-a19e-39e9a5d7f06c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f3474c7e-18df-4418-b336-d25de293a1eb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f4ae698e-1b16-484c-8a1a-27b1f2eea606"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f54cd269-5715-4120-909f-7e9aa96e7439"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f586ecdd-d943-4064-a672-aa2b79c70b67"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f591f7aa-f0d8-4e88-bf85-48968fda2b91"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f640a37f-55b3-49b7-8d95-c87474b02134"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f6440e30-a88a-48d0-a55f-dc901e7dd3dc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f6ab58b6-a05a-4daa-ac3a-15b7049e01e8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f6cf082e-6532-44ff-8f61-1bcdc4801c80"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f8449860-4aee-47c3-940e-0a669d1aa60b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f84a7d0e-c258-4086-8c4a-0fc53b1f4d1e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f88fe9ac-d9ea-4fe8-bdb9-ac7247a1c9f1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f92b12e7-1f4b-4e47-8516-03fc9e57ce73"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fc6bbca8-d1a5-4021-b230-a9c1442ed2ac"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fc99627c-18a9-4a5d-94d3-146b6aa50d48"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fd2d2211-154b-48b5-9ce5-5626519e5fc6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fd78cfc0-ea69-4cfa-a5d1-776034184132"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fdb3ebcc-5151-4fb5-8e84-cfd329e82425"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fdb61265-7a5a-45c3-9305-8983cff6d5a5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fdff7286-1ed8-45de-aa95-5380b937c01d"));

            migrationBuilder.DropColumn(
                name: "LogoFileId",
                table: "ElectionParties");

            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "ElectionParties",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoContentType",
                table: "ElectionParties",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoFileName",
                table: "ElectionParties",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "ElectionParties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Logo", "LogoContentType", "LogoFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.InsertData(
                table: "Voters",
                columns: new[] { "VoterId", "FirstName", "Gender", "IsActive", "IsVerified", "LastName", "MiddleName", "MobileNumber", "RegisteredAt", "VoterCardNumber", "VotingPlaceId" },
                values: new object[,]
                {
                    { new Guid("000fbdd2-5586-4dfc-b0f1-eae294e1e748"), "Nisha", 2, true, true, "Nepali", "Maya", "+9779856947743", new DateTime(2025, 10, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6960), "NPV-018-0010", 18 },
                    { new Guid("00208455-01d7-4e4c-82bd-00686f7d3aae"), "Gopal", 1, true, true, "B.K.", "Raj", "+9779624297274", new DateTime(2024, 4, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6600), "NPV-016-0004", 16 },
                    { new Guid("00233d24-4101-4e55-a623-a566e404290b"), "Sita", 2, true, false, "Karki", "Kumari", "+9779856320677", new DateTime(2024, 3, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7140), "NPV-020-0008", 20 },
                    { new Guid("0024b770-632f-4170-bfbf-7010cc646b9a"), "Parbati", 2, true, true, "Maharjan", "Devi", "+9779822037025", new DateTime(2025, 3, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9050), "NPV-036-0008", 36 },
                    { new Guid("002b188c-9837-41fd-addd-a15e2bc70d9d"), "Nabin", 1, true, true, "Sharma", "Singh", "+9779825341330", new DateTime(2025, 9, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5700), "NPV-008-0003", 8 },
                    { new Guid("00d2a84a-e244-49f4-b377-85072259f0d7"), "Rajesh", 1, true, true, "B.K.", "Bahadur", "+9779745038032", new DateTime(2024, 6, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6520), "NPV-015-0006", 15 },
                    { new Guid("010fd42b-9c90-4915-9eb0-1b2af35f4bf1"), "Ram", 1, true, true, "Shrestha", "Raj", "+9779806539214", new DateTime(2024, 6, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6930), "NPV-018-0007", 18 },
                    { new Guid("01478f13-543e-43d6-8d40-8afaf980d0b2"), "Nisha", 2, true, true, "B.K.", "Maya", "+9779635139180", new DateTime(2025, 1, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8720), "NPV-034-0001", 34 },
                    { new Guid("0176d23c-53fd-4f0b-bb57-a05547a8bf03"), "Suresh", 1, true, true, "Karki", "Bahadur", "+9779857077033", new DateTime(2025, 10, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7300), "NPV-022-0004", 22 },
                    { new Guid("019522be-ebef-49f4-a70c-d9877be87146"), "Krishna", 1, true, true, "Maharjan", "Kumar", "+9779846845039", new DateTime(2025, 7, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8730), "NPV-034-0002", 34 },
                    { new Guid("02cd5533-ca99-4493-a640-f8cbd93e049d"), "Ram", 1, true, true, "Lama", "Kumar", "+9779801089250", new DateTime(2024, 9, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9070), "NPV-036-0010", 36 },
                    { new Guid("04116eb4-4f28-4006-ae8b-e27e691329b8"), "Gita", 2, true, false, "Shrestha", "Devi", "+9779809967774", new DateTime(2025, 7, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9600), "NPV-041-0008", 41 },
                    { new Guid("0441049f-288d-4355-8bb4-f12382c16696"), "Hari", 1, true, false, "Gurung", "Singh", "+9779616344938", new DateTime(2024, 3, 15, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(170), "NPV-046-0001", 46 },
                    { new Guid("047f3c0d-c030-4b10-8316-1e8cb830d43e"), "Shyam", 1, true, false, "Lama", "Raj", "+9779768827211", new DateTime(2025, 8, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5960), "NPV-010-0010", 10 },
                    { new Guid("0587cec7-4c90-43cf-86c6-8f9432824422"), "Hari", 1, true, true, "B.K.", "Raj", "+9779744494849", new DateTime(2024, 2, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7170), "NPV-021-0001", 21 },
                    { new Guid("05c03f20-f254-4998-a7ac-d619e33a900b"), "Sarita", 2, true, true, "Sharma", "Maya", "+9779613845942", new DateTime(2025, 9, 18, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(460), "NPV-048-0002", 48 },
                    { new Guid("0630a847-cc4b-4c39-ba1d-20293ac7f06f"), "Radha", 2, true, false, "Maharjan", "Kumari", "+9779802901217", new DateTime(2024, 4, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8060), "NPV-028-0005", 28 },
                    { new Guid("076207ff-ca19-42ef-91bd-ca87d39e557d"), "Sabitri", 2, true, true, "Tamang", "Kumari", "+9779635021902", new DateTime(2024, 3, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9660), "NPV-042-0004", 42 },
                    { new Guid("079ecc06-55c9-427b-9d93-cff58b478478"), "Anita", 2, true, true, "Nepali", "Kumari", "+9779618685476", new DateTime(2025, 1, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7670), "NPV-025-0004", 25 },
                    { new Guid("08534da4-6a8e-4ef3-bfe5-0c54767c6111"), "Bikash", 1, true, true, "Sharma", "Singh", "+9779744995421", new DateTime(2024, 6, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7870), "NPV-026-0009", 26 },
                    { new Guid("0865a445-328e-45b3-a1f6-904dce8fb021"), "Sarita", 2, true, true, "Chaudhary", "Devi", "+9779633612697", new DateTime(2025, 4, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6380), "NPV-014-0005", 14 },
                    { new Guid("099e7547-870b-4060-986a-fcc793a9c2f7"), "Radha", 2, true, true, "Chaudhary", "Laxmi", "+9779627422726", new DateTime(2024, 1, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7580), "NPV-024-0005", 24 },
                    { new Guid("0a0d3773-1de8-4be1-9537-c753d4904af4"), "Rupa", 2, true, false, "Yadav", "Kumari", "+9779848508985", new DateTime(2024, 7, 31, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5970), "NPV-011-0001", 11 },
                    { new Guid("0a8d8f05-950d-4f8e-839b-81a933712e51"), "Mohan", 1, true, true, "Yadav", "Raj", "+9779818019106", new DateTime(2025, 10, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8330), "NPV-030-0007", 30 },
                    { new Guid("0b9f82cd-0fe0-41e6-974e-e9ec73bf33dc"), "Gita", 2, true, true, "Tamang", "Maya", "+9779618363218", new DateTime(2024, 12, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7420), "NPV-022-0009", 22 },
                    { new Guid("0bf3ee67-e61c-4c6d-bb59-d62e8be765d1"), "Hari", 1, true, false, "Thapa", "Bahadur", "+9779626025535", new DateTime(2025, 6, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9480), "NPV-040-0005", 40 },
                    { new Guid("0c945825-6c3a-441a-a026-353d3555d6dd"), "Nisha", 2, true, false, "Tamang", "Kumari", "+9779882460705", new DateTime(2024, 3, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9590), "NPV-041-0007", 41 },
                    { new Guid("0cc57c70-9578-48e1-a0e5-ba2bcd425a52"), "Sarita", 2, true, true, "Thapa", "Devi", "+9779867508996", new DateTime(2024, 8, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8920), "NPV-036-0001", 36 },
                    { new Guid("0d8ad21b-c66d-402e-946e-8b397488b8ae"), "Nisha", 2, true, true, "Tamang", "Kumari", "+9779809549065", new DateTime(2024, 5, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6190), "NPV-012-0007", 12 },
                    { new Guid("0e06bc8a-5d5c-4419-9c2a-93da347c8888"), "Arjun", 1, true, false, "Sharma", "Raj", "+9779754289202", new DateTime(2024, 11, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5370), "NPV-005-0007", 5 },
                    { new Guid("0ec5a5a3-8064-4c02-892c-8dd52848e528"), "Ram", 1, true, true, "Karki", "Raj", "+9779825447529", new DateTime(2024, 3, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5760), "NPV-008-0010", 8 },
                    { new Guid("0ee3594c-6b99-46f8-96d8-080576a5c6b6"), "Arjun", 1, true, true, "Nepali", "Prasad", "+9779829188625", new DateTime(2024, 12, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9790), "NPV-043-0007", 43 },
                    { new Guid("0f48e397-2fff-4119-bac7-9bba864010d7"), "Bishnu", 1, true, false, "B.K.", "Kumar", "+9779888870266", new DateTime(2024, 5, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7610), "NPV-024-0008", 24 },
                    { new Guid("0f941bc7-7b6e-41ad-9e5f-f00f4c86a58b"), "Rekha", 2, true, true, "Lama", "Devi", "+9779631216663", new DateTime(2025, 8, 17, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(260), "NPV-046-0010", 46 },
                    { new Guid("0ffd8bb9-9a62-4aa1-b318-75cf60a4f3e2"), "Santosh", 1, true, true, "Rai", "Singh", "+9779623069956", new DateTime(2025, 4, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9540), "NPV-041-0002", 41 },
                    { new Guid("114afccc-9151-40a3-b2f4-ba9d07fe68f9"), "Bikash", 1, true, false, "B.K.", "Raj", "+9779868615395", new DateTime(2025, 8, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5840), "NPV-009-0008", 9 },
                    { new Guid("11bbccd0-fd0c-409d-86a3-a36336a22527"), "Santosh", 1, true, true, "Khadka", "Raj", "+9779616525468", new DateTime(2025, 1, 31, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6460), "NPV-014-0010", 14 },
                    { new Guid("13f24807-100e-4df7-be41-38a88a466a38"), "Ram", 1, true, true, "Sharma", "Prasad", "+9779817868686", new DateTime(2024, 6, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7630), "NPV-024-0010", 24 },
                    { new Guid("14b4f7a3-bc37-4e9d-8379-ca2f700874f3"), "Rajesh", 1, true, true, "Magar", "Bahadur", "+9779631969901", new DateTime(2024, 7, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9840), "NPV-044-0002", 44 },
                    { new Guid("1592d560-bcd7-48e4-a5f2-ffb148b5b12f"), "Gita", 2, true, true, "Nepali", "Kumari", "+9779855667397", new DateTime(2024, 5, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7770), "NPV-026-0004", 26 },
                    { new Guid("164d6ac2-f5d4-4dc2-a884-722b258a406e"), "Prakash", 1, true, false, "Tamang", "Prasad", "+9779887440517", new DateTime(2024, 1, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5050), "NPV-003-0001", 3 },
                    { new Guid("16a90bea-76d0-4e27-915d-6eff3a798517"), "Sita", 2, true, true, "Nepali", "Kumari", "+9779825017217", new DateTime(2024, 2, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9620), "NPV-041-0010", 41 },
                    { new Guid("17a8fb01-3323-4327-9d0e-ec93db2b1863"), "Bishnu", 1, true, true, "Lama", "Bahadur", "+9779845242514", new DateTime(2024, 7, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5470), "NPV-006-0007", 6 },
                    { new Guid("17f3ee80-8744-4bca-9a02-9847689eaa26"), "Prakash", 1, true, true, "B.K.", "Singh", "+9779883275758", new DateTime(2025, 9, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9460), "NPV-040-0004", 40 },
                    { new Guid("196c84d7-bf8c-4ab1-964e-4135288e1df4"), "Radha", 2, true, true, "B.K.", "Maya", "+9779757789450", new DateTime(2024, 10, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4950), "NPV-002-0002", 2 },
                    { new Guid("19711f96-f9a5-44da-aa5f-396f67f0e79c"), "Hari", 1, true, false, "Sharma", "Bahadur", "+9779753243676", new DateTime(2025, 2, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8150), "NPV-028-0008", 28 },
                    { new Guid("197b3ed8-9e95-45f2-af0b-32fd1959020d"), "Santosh", 1, true, true, "Thapa", "Bahadur", "+9779826764133", new DateTime(2025, 11, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9550), "NPV-041-0003", 41 },
                    { new Guid("1a092b96-5764-4e79-86f3-85f742564c5f"), "Nabin", 1, true, true, "Nepali", "Prasad", "+9779748071606", new DateTime(2025, 7, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8020), "NPV-028-0001", 28 },
                    { new Guid("1a19f32e-6cd6-4070-82dd-f43791dcb012"), "Sabitri", 2, true, true, "Magar", "Kumari", "+9779768701914", new DateTime(2025, 11, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5290), "NPV-004-0008", 4 },
                    { new Guid("1a26e50c-c494-414c-ba5f-3ade7eed7d84"), "Rupa", 2, true, true, "Rai", "Devi", "+9779623626706", new DateTime(2024, 2, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8060), "NPV-028-0004", 28 },
                    { new Guid("1a53a9c3-2c26-41e9-95e0-cbdca31a3a80"), "Sarita", 2, true, true, "B.K.", "Kumari", "+9779851406136", new DateTime(2024, 6, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8290), "NPV-030-0002", 30 },
                    { new Guid("1a5ed1ea-4cca-4dc0-bc77-48cf43741929"), "Bishnu", 1, true, true, "Rai", "Prasad", "+9779768682873", new DateTime(2024, 12, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9720), "NPV-042-0010", 42 },
                    { new Guid("1befe9c8-9545-40c2-9c72-7d4b14bc498b"), "Sunita", 2, true, true, "Shrestha", "Maya", "+9779868486884", new DateTime(2025, 10, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4860), "NPV-001-0004", 1 },
                    { new Guid("1c4fabfe-6bef-40e6-ae63-33f24bf89a56"), "Parbati", 2, true, true, "Yadav", "Maya", "+9779848016334", new DateTime(2025, 2, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9610), "NPV-041-0009", 41 },
                    { new Guid("1d021a83-4161-4d05-9c36-c836235d2fac"), "Arjun", 1, true, true, "Sharma", "Raj", "+9779621569292", new DateTime(2025, 11, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6550), "NPV-015-0009", 15 },
                    { new Guid("1ebbe052-5f41-478f-974e-9e22aa0b544c"), "Rajesh", 1, true, true, "Nepali", "Kumar", "+9779636078593", new DateTime(2024, 8, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7080), "NPV-020-0002", 20 },
                    { new Guid("1ee5a71c-ee09-4d41-bb25-73090e0317bf"), "Suresh", 1, true, false, "Lama", "Raj", "+9779626502360", new DateTime(2025, 12, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9330), "NPV-039-0006", 39 },
                    { new Guid("1f9c8791-a197-4434-b58d-629b79c8af13"), "Rekha", 2, true, false, "Gurung", "Devi", "+9779619336003", new DateTime(2025, 1, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9510), "NPV-040-0009", 40 },
                    { new Guid("1fb5933e-14b8-48f4-9bbc-cbbc37700ea8"), "Mohan", 1, true, false, "Gurung", "Singh", "+9779881971545", new DateTime(2024, 4, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5910), "NPV-010-0005", 10 },
                    { new Guid("20d03353-add1-4468-8bec-c3711863aad7"), "Shova", 2, true, true, "Gurung", "Devi", "+9779819282513", new DateTime(2024, 12, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9160), "NPV-037-0009", 37 },
                    { new Guid("2217054a-8162-4d56-b382-57307938b103"), "Anita", 2, true, true, "Yadav", "Laxmi", "+9779846431545", new DateTime(2024, 6, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6580), "NPV-016-0002", 16 },
                    { new Guid("2262a11e-22f8-4c21-8cfb-dc6e5630424b"), "Parbati", 2, true, true, "Karki", "Maya", "+9779751836949", new DateTime(2024, 11, 15, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(100), "NPV-045-0004", 45 },
                    { new Guid("2286566e-89e0-44e6-894f-8e375fef2c32"), "Bishnu", 1, true, true, "Karki", "Bahadur", "+9779755129840", new DateTime(2025, 10, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7530), "NPV-023-0010", 23 },
                    { new Guid("23f9e834-6724-4086-9a30-91c825894ad5"), "Mohan", 1, true, true, "Nepali", "Singh", "+9779851268544", new DateTime(2025, 10, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7000), "NPV-019-0004", 19 },
                    { new Guid("2478c127-01b2-4c98-b924-1a13079614c3"), "Suresh", 1, true, true, "Maharjan", "Bahadur", "+9779819998100", new DateTime(2024, 3, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8160), "NPV-028-0009", 28 },
                    { new Guid("25ca2474-a523-4d97-ba1c-f1f785772842"), "Laxmi", 2, true, true, "Sharma", "Kumari", "+9779886806689", new DateTime(2025, 12, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8500), "NPV-032-0004", 32 },
                    { new Guid("26a7bb4e-a52e-4d61-82fd-b89ee150795b"), "Anita", 2, true, true, "Chaudhary", "Laxmi", "+9779857582395", new DateTime(2025, 6, 10, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(190), "NPV-046-0003", 46 },
                    { new Guid("2835159d-3f56-4747-b870-2ded00e4785c"), "Maya", 2, true, true, "Gurung", "Kumari", "+9779885032329", new DateTime(2024, 8, 29, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(180), "NPV-046-0002", 46 },
                    { new Guid("28541e8e-f9b7-4450-949d-12e9f494b633"), "Laxmi", 2, true, true, "Sharma", "Kumari", "+9779848155270", new DateTime(2025, 9, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7110), "NPV-020-0005", 20 },
                    { new Guid("29ff74e2-1932-4215-818a-16461d1b6eac"), "Shyam", 1, true, true, "B.K.", "Kumar", "+9779854725875", new DateTime(2024, 3, 4, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(370), "NPV-048-0001", 48 },
                    { new Guid("2ae592b8-f243-449f-beb0-e5ec17fc7252"), "Bishnu", 1, true, true, "Thapa", "Singh", "+9779811955150", new DateTime(2024, 3, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7430), "NPV-022-0010", 22 },
                    { new Guid("2b4ffbf0-0fc3-46a1-a7dc-072eb4e95a32"), "Sarita", 2, true, true, "Nepali", "Laxmi", "+9779611730436", new DateTime(2024, 1, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5280), "NPV-004-0007", 4 },
                    { new Guid("2b7e32db-19a6-486c-a2c7-be02d5236e86"), "Prakash", 1, true, true, "Rai", "Raj", "+9779631542436", new DateTime(2025, 8, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7710), "NPV-025-0008", 25 },
                    { new Guid("2ba91ae4-14bb-4909-9cb6-4b191f696bb2"), "Arjun", 1, true, true, "Gurung", "Prasad", "+9779761251128", new DateTime(2024, 12, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9650), "NPV-042-0003", 42 },
                    { new Guid("2c6091da-83e1-46cf-952a-82a423fe674d"), "Nisha", 2, true, false, "Tamang", "Laxmi", "+9779842999299", new DateTime(2024, 1, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7120), "NPV-020-0006", 20 },
                    { new Guid("2c77a5d8-8479-4e0b-b83c-63f46b9fe738"), "Sunita", 2, true, true, "Nepali", "Kumari", "+9779751914177", new DateTime(2025, 7, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9250), "NPV-038-0008", 38 },
                    { new Guid("2d05881c-3cf7-4ac9-91c3-49458aa99ad2"), "Sabitri", 2, true, true, "Shrestha", "Kumari", "+9779764084394", new DateTime(2025, 3, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9730), "NPV-043-0001", 43 },
                    { new Guid("2d1044ae-41f1-4b87-9757-214f52631e25"), "Maya", 2, true, true, "Tamang", "Kumari", "+9779803398616", new DateTime(2024, 4, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5850), "NPV-009-0009", 9 },
                    { new Guid("2d57c7e2-f62f-4e57-a4da-d361d678f130"), "Hari", 1, true, true, "Yadav", "Raj", "+9779889410720", new DateTime(2024, 4, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7200), "NPV-021-0004", 21 },
                    { new Guid("2d8ecd7d-ce84-43c6-9c06-00245d98d53d"), "Sunita", 2, true, true, "Tamang", "Kumari", "+9779742636797", new DateTime(2025, 6, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6710), "NPV-017-0005", 17 },
                    { new Guid("2f351979-614c-4606-9c67-7d4ced2fee4c"), "Gita", 2, true, true, "Chaudhary", "Devi", "+9779819400024", new DateTime(2025, 2, 19, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(160), "NPV-045-0010", 45 },
                    { new Guid("3081602b-b5e6-43ec-970e-cde71dffbff5"), "Rekha", 2, true, false, "Sharma", "Devi", "+9779758413078", new DateTime(2025, 5, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9110), "NPV-037-0004", 37 },
                    { new Guid("31d925ed-be15-41d1-b729-2f6268649069"), "Suresh", 1, true, true, "Karki", "Bahadur", "+9779869122561", new DateTime(2025, 11, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8210), "NPV-029-0004", 29 },
                    { new Guid("33b941a6-d960-41dd-8a54-f5b0d785ccae"), "Maya", 2, true, true, "B.K.", "Laxmi", "+9779754578468", new DateTime(2024, 10, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9410), "NPV-040-0003", 40 },
                    { new Guid("343ef34c-042b-431c-8497-a947a049bb92"), "Arjun", 1, true, true, "Shrestha", "Singh", "+9779888032022", new DateTime(2025, 7, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6720), "NPV-017-0006", 17 },
                    { new Guid("35c6c85c-95a5-473e-9775-c61b47fc1802"), "Sarita", 2, true, false, "Magar", "Kumari", "+9779819117134", new DateTime(2025, 10, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5170), "NPV-004-0003", 4 },
                    { new Guid("3662eb1c-af76-4bd0-8bf1-5ff263dec5f9"), "Rupa", 2, true, false, "Lama", "Kumari", "+9779769823361", new DateTime(2024, 4, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5950), "NPV-010-0009", 10 },
                    { new Guid("36692b2f-122c-4bde-bd23-8c62194141fa"), "Shova", 2, true, true, "Magar", "Laxmi", "+9779805210625", new DateTime(2024, 2, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8240), "NPV-029-0007", 29 },
                    { new Guid("36b159b5-a308-411d-ab8b-7a8d9d905511"), "Sunita", 2, true, true, "Yadav", "Laxmi", "+9779847579407", new DateTime(2024, 11, 27, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(60), "NPV-044-0010", 44 },
                    { new Guid("36d00bb2-afea-4b5c-ba2e-c16f6ea83c2f"), "Shyam", 1, true, true, "B.K.", "Singh", "+9779865909528", new DateTime(2024, 10, 18, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(300), "NPV-047-0004", 47 },
                    { new Guid("3767ebfe-bec3-423f-aed6-508fc9c161db"), "Santosh", 1, true, true, "Khadka", "Prasad", "+9779816742514", new DateTime(2025, 4, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4820), "NPV-001-0002", 1 },
                    { new Guid("37844a02-55a7-4788-8209-740a6ea9ecdb"), "Sabitri", 2, true, true, "Nepali", "Maya", "+9779802457234", new DateTime(2024, 1, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6650), "NPV-016-0009", 16 },
                    { new Guid("37f84403-237d-45c4-8cf8-4fea51a98815"), "Sabitri", 2, true, true, "Karki", "Laxmi", "+9779615752987", new DateTime(2025, 7, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5900), "NPV-010-0004", 10 },
                    { new Guid("3803c50e-3cf3-4b87-8187-558f77548ba4"), "Sita", 2, true, true, "Shrestha", "Kumari", "+9779625998887", new DateTime(2024, 9, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8600), "NPV-032-0008", 32 },
                    { new Guid("380fe920-0071-48cc-8732-e0be8037dfe3"), "Shyam", 1, true, true, "Yadav", "Kumar", "+9779638196015", new DateTime(2024, 9, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9370), "NPV-039-0010", 39 },
                    { new Guid("38a1f344-8ac1-4810-8584-c9369c7758e2"), "Sabitri", 2, true, false, "Lama", "Kumari", "+9779625754397", new DateTime(2025, 3, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7040), "NPV-019-0008", 19 },
                    { new Guid("38beaa41-99f3-4c83-9896-bd3b65403262"), "Bikash", 1, true, true, "Karki", "Bahadur", "+9779822951633", new DateTime(2025, 4, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7860), "NPV-026-0008", 26 },
                    { new Guid("38c79515-12ec-46f0-824b-f66ef357c674"), "Rajesh", 1, true, true, "Khadka", "Kumar", "+9779854150360", new DateTime(2025, 5, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6330), "NPV-013-0010", 13 },
                    { new Guid("392eaf5e-5111-45df-b4cd-5d8faf8d13e7"), "Sita", 2, true, true, "Thapa", "Devi", "+9779807316850", new DateTime(2025, 12, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5480), "NPV-006-0008", 6 },
                    { new Guid("393d9246-1e04-49df-828d-3141d4f62db8"), "Bishnu", 1, true, true, "Rai", "Raj", "+9779888063379", new DateTime(2024, 10, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8580), "NPV-032-0006", 32 },
                    { new Guid("3a6cec46-82ab-4f4e-a52f-0ffef659684f"), "Nisha", 2, true, true, "B.K.", "Maya", "+9779762853440", new DateTime(2024, 4, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8830), "NPV-035-0002", 35 },
                    { new Guid("3a8ec36d-7d58-44db-a28e-19fc7ab60153"), "Nabin", 1, true, true, "B.K.", "Kumar", "+9779632326106", new DateTime(2025, 1, 9, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(490), "NPV-048-0005", 48 },
                    { new Guid("3c09400c-1cae-492d-a1b9-90c996c50f19"), "Ram", 1, true, true, "Lama", "Kumar", "+9779636500842", new DateTime(2024, 6, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8490), "NPV-032-0003", 32 },
                    { new Guid("3c2b1602-4e15-407a-96da-56af6a7ab930"), "Krishna", 1, true, true, "Khadka", "Prasad", "+9779752505843", new DateTime(2025, 6, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7250), "NPV-021-0009", 21 },
                    { new Guid("3cfcaba7-6d74-42af-b453-39c18189e79a"), "Sunita", 2, true, true, "Karki", "Devi", "+9779825698269", new DateTime(2024, 12, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7730), "NPV-025-0010", 25 },
                    { new Guid("3db138ad-3032-46cf-9461-ff57923a8fe9"), "Maya", 2, true, false, "Karki", "Maya", "+9779617483137", new DateTime(2024, 10, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5830), "NPV-009-0007", 9 },
                    { new Guid("3e0f2512-483c-467a-9e2a-05e3eb3accd7"), "Bikash", 1, true, true, "Maharjan", "Singh", "+9779636168299", new DateTime(2025, 2, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6120), "NPV-011-0010", 11 },
                    { new Guid("3e5e3a0f-b1ca-4a9d-ad80-333ef76042ee"), "Suresh", 1, true, true, "Sharma", "Kumar", "+9779885175546", new DateTime(2024, 7, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8420), "NPV-031-0006", 31 },
                    { new Guid("3f6326e0-ce2b-4326-9a2f-94bd84c9c831"), "Sunita", 2, true, true, "Magar", "Devi", "+9779633166030", new DateTime(2025, 4, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5330), "NPV-005-0002", 5 },
                    { new Guid("3ffd8301-0a00-43cf-b7da-a0bf35b3c779"), "Sarita", 2, true, true, "Rai", "Kumari", "+9779767098131", new DateTime(2024, 12, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8850), "NPV-035-0004", 35 },
                    { new Guid("4054babb-226b-466d-b2f9-8ee07f0d06a4"), "Shova", 2, true, true, "Nepali", "Maya", "+9779741634532", new DateTime(2025, 8, 21, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(310), "NPV-047-0005", 47 },
                    { new Guid("4083e273-035b-41e8-8847-14bdf73f2a6e"), "Rajesh", 1, true, true, "B.K.", "Bahadur", "+9779622838479", new DateTime(2025, 4, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7850), "NPV-026-0007", 26 },
                    { new Guid("4083f04c-d5a5-4ee5-ab7e-912e57ab3c02"), "Shyam", 1, true, true, "Nepali", "Kumar", "+9779821592991", new DateTime(2025, 12, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7900), "NPV-027-0002", 27 },
                    { new Guid("41b065a5-979d-406d-9dbd-b5c207da49d5"), "Sarita", 2, true, true, "Thapa", "Devi", "+9779819150061", new DateTime(2024, 5, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9810), "NPV-043-0009", 43 },
                    { new Guid("42066e00-859e-4d86-8c98-6737a2d61cf1"), "Rupa", 2, true, true, "Chaudhary", "Kumari", "+9779883017107", new DateTime(2025, 11, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9020), "NPV-036-0005", 36 },
                    { new Guid("42e8ad3f-0e2b-4247-9eee-808f3164886d"), "Sita", 2, true, true, "Nepali", "Kumari", "+9779881195754", new DateTime(2024, 5, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8230), "NPV-029-0006", 29 },
                    { new Guid("435857bd-6bc7-41c4-bafe-ba64cedf6a13"), "Bikash", 1, true, true, "Tamang", "Bahadur", "+9779866029592", new DateTime(2024, 5, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8410), "NPV-031-0005", 31 },
                    { new Guid("436a79ca-fb50-4a89-bcc7-923e1df3ee06"), "Maya", 2, true, true, "Lama", "Kumari", "+9779758042607", new DateTime(2024, 3, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7260), "NPV-021-0010", 21 },
                    { new Guid("43795be1-1c59-4ca6-9e5c-a9ad59313108"), "Prakash", 1, true, true, "Lama", "Prasad", "+9779742418913", new DateTime(2025, 8, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8640), "NPV-033-0003", 33 },
                    { new Guid("43823cde-4142-4755-9ce7-13e8bfc13265"), "Suresh", 1, true, true, "Gurung", "Singh", "+9779821238128", new DateTime(2025, 12, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9680), "NPV-042-0006", 42 },
                    { new Guid("43c58681-e5d2-46cf-8cab-053c509a581a"), "Gita", 2, true, true, "Karki", "Kumari", "+9779753693497", new DateTime(2024, 6, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8400), "NPV-031-0004", 31 },
                    { new Guid("43e46d1a-1c73-463b-9f3a-ed732ff15f80"), "Sabitri", 2, true, true, "Karki", "Maya", "+9779638571493", new DateTime(2024, 8, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8650), "NPV-033-0004", 33 },
                    { new Guid("43f5c418-1b91-424a-80fc-ff7e2246797f"), "Rajesh", 1, true, true, "Shrestha", "Singh", "+9779887645667", new DateTime(2024, 10, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6170), "NPV-012-0005", 12 },
                    { new Guid("44161be6-fd0e-49d4-a4b2-e5966f8f3cf3"), "Prakash", 1, true, false, "Maharjan", "Raj", "+9779768394980", new DateTime(2025, 10, 8, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(250), "NPV-046-0009", 46 },
                    { new Guid("44305360-d183-474c-8169-95e9599a3fc2"), "Shova", 2, true, true, "Thapa", "Laxmi", "+9779747512706", new DateTime(2024, 8, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9570), "NPV-041-0005", 41 },
                    { new Guid("4442fd6e-cd41-42d1-bd17-803219df6297"), "Anita", 2, true, true, "Karki", "Maya", "+9779759501499", new DateTime(2024, 2, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4930), "NPV-001-0010", 1 },
                    { new Guid("44d0eb84-3d97-4ba2-a7b4-9afcad650957"), "Sunita", 2, true, true, "Tamang", "Kumari", "+9779829260199", new DateTime(2025, 1, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8790), "NPV-034-0008", 34 },
                    { new Guid("44f5f490-ff2e-46f7-a180-67c35e5a65ab"), "Laxmi", 2, true, true, "Yadav", "Maya", "+9779816587160", new DateTime(2025, 8, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8360), "NPV-030-0010", 30 },
                    { new Guid("450370ef-7dbe-48b8-8181-4a1c4ac366a2"), "Arjun", 1, true, true, "Shrestha", "Kumar", "+9779857025044", new DateTime(2024, 8, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6300), "NPV-013-0008", 13 },
                    { new Guid("45067207-1b9e-4fdf-a36a-94113e269d8d"), "Prakash", 1, true, true, "Tamang", "Bahadur", "+9779801352265", new DateTime(2024, 9, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8270), "NPV-029-0010", 29 },
                    { new Guid("4567e79f-7375-49e4-8499-c3eeb647248c"), "Krishna", 1, true, false, "Gurung", "Singh", "+9779815504928", new DateTime(2025, 12, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8350), "NPV-030-0008", 30 },
                    { new Guid("45d257f2-aa1c-4766-b71d-15ab0f5c91fc"), "Suresh", 1, true, true, "Tamang", "Raj", "+9779887843751", new DateTime(2025, 7, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5520), "NPV-007-0002", 7 },
                    { new Guid("49449066-adb0-496e-926b-a53cf74e2321"), "Hari", 1, true, true, "Karki", "Singh", "+9779821221808", new DateTime(2024, 11, 3, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(150), "NPV-045-0009", 45 },
                    { new Guid("49d8a8ad-7d6c-4ed5-938a-101f11ab3a2f"), "Hari", 1, true, true, "Chaudhary", "Raj", "+9779809667185", new DateTime(2025, 12, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9530), "NPV-041-0001", 41 },
                    { new Guid("4a0166e8-451d-4512-a0f5-773ea9102c20"), "Rupa", 2, true, true, "B.K.", "Kumari", "+9779612361498", new DateTime(2024, 12, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5420), "NPV-006-0002", 6 },
                    { new Guid("4a2aa2eb-1e3f-40e1-8f8e-483b2b580a76"), "Rajesh", 1, true, false, "Magar", "Singh", "+9779866375317", new DateTime(2025, 2, 28, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(330), "NPV-047-0007", 47 },
                    { new Guid("4b1fe7a0-de5e-46c8-8b3f-16acbc13e279"), "Sarita", 2, true, false, "Lama", "Devi", "+9779808751021", new DateTime(2024, 3, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8660), "NPV-033-0005", 33 },
                    { new Guid("4b4ffc62-3a8d-4c3a-97c1-8c9e6497a1a3"), "Suresh", 1, true, true, "Nepali", "Bahadur", "+9779857690563", new DateTime(2025, 7, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5140), "NPV-003-0010", 3 },
                    { new Guid("4c10a770-2fb0-4496-a1f3-ee2a0e023ea9"), "Sita", 2, true, true, "Magar", "Kumari", "+9779888780233", new DateTime(2024, 11, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6050), "NPV-011-0009", 11 },
                    { new Guid("4c7ef636-7031-439c-9d26-2b48fbe98d8e"), "Santosh", 1, true, true, "Nepali", "Singh", "+9779863000001", new DateTime(2024, 5, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8590), "NPV-032-0007", 32 },
                    { new Guid("4ca0b6d6-a67c-4ebc-a325-5ae644c3ccb3"), "Nisha", 2, true, true, "Rai", "Maya", "+9779754244530", new DateTime(2025, 5, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7490), "NPV-023-0006", 23 },
                    { new Guid("4ce8207c-f2f6-44e8-89b7-e2abb769b723"), "Anita", 2, true, true, "Gurung", "Kumari", "+9779613211153", new DateTime(2024, 9, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6350), "NPV-014-0002", 14 },
                    { new Guid("4d308d09-ccd1-4e05-b85a-bee4ce75bfe1"), "Gopal", 1, true, false, "Thapa", "Bahadur", "+9779765328313", new DateTime(2024, 8, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6950), "NPV-018-0009", 18 },
                    { new Guid("4d88a77f-f26a-4313-b976-c3089925f18a"), "Maya", 2, true, true, "Lama", "Kumari", "+9779766752645", new DateTime(2024, 10, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5320), "NPV-005-0001", 5 },
                    { new Guid("4de18a6a-9ddd-4d69-8b73-118f157d7a9e"), "Sarita", 2, true, true, "Thapa", "Kumari", "+9779828636666", new DateTime(2024, 1, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5890), "NPV-010-0003", 10 },
                    { new Guid("4e18b60a-19f1-4611-af6e-d9a76f50f54a"), "Gopal", 1, true, false, "Karki", "Kumar", "+9779812760407", new DateTime(2025, 9, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7070), "NPV-020-0001", 20 },
                    { new Guid("4f1dc3bd-f27c-4ab5-bdd6-d214fb2c226d"), "Gopal", 1, true, true, "Karki", "Bahadur", "+9779804351303", new DateTime(2025, 9, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9080), "NPV-037-0001", 37 },
                    { new Guid("50261993-9558-46fb-97b5-f8c4f365ce9d"), "Sabitri", 2, true, true, "Magar", "Kumari", "+9779614322142", new DateTime(2025, 1, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9280), "NPV-039-0001", 39 },
                    { new Guid("507c0edf-cda1-47ec-a8ad-d1927733484f"), "Rekha", 2, true, true, "Rai", "Devi", "+9779883256676", new DateTime(2024, 3, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6290), "NPV-013-0007", 13 },
                    { new Guid("511fd45d-36e3-4957-b9b3-a8749e3ea780"), "Krishna", 1, true, true, "Karki", "Bahadur", "+9779856436509", new DateTime(2025, 1, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6560), "NPV-015-0010", 15 },
                    { new Guid("51a5c8c5-158a-4d7d-8db7-f1ec2bb9eb04"), "Prakash", 1, true, true, "Chaudhary", "Prasad", "+9779863645527", new DateTime(2024, 1, 27, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(360), "NPV-047-0010", 47 },
                    { new Guid("51bb5b52-dd2d-4620-afbd-46af862861e2"), "Shyam", 1, true, false, "Thapa", "Prasad", "+9779613178640", new DateTime(2024, 10, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8840), "NPV-035-0003", 35 },
                    { new Guid("525354ae-b6f1-40f4-8a69-70d3d78d7c84"), "Bikash", 1, true, true, "Karki", "Singh", "+9779617543830", new DateTime(2024, 11, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7660), "NPV-025-0003", 25 },
                    { new Guid("526983d5-c902-4f8c-83f0-e9a3087e272f"), "Bishnu", 1, true, true, "Shrestha", "Singh", "+9779867790578", new DateTime(2024, 7, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9850), "NPV-044-0003", 44 },
                    { new Guid("52ba2c12-90d8-40a7-a15b-90fa52fe87b9"), "Santosh", 1, true, true, "Maharjan", "Raj", "+9779746385543", new DateTime(2025, 4, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7980), "NPV-027-0010", 27 },
                    { new Guid("53a5d720-d5a8-4764-a3a5-d66e787849d9"), "Sarita", 2, true, true, "Yadav", "Devi", "+9779759478106", new DateTime(2024, 11, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7950), "NPV-027-0007", 27 },
                    { new Guid("5426e125-011d-477e-ad48-74bb8e555818"), "Rekha", 2, true, true, "Yadav", "Devi", "+9779866045991", new DateTime(2025, 8, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5550), "NPV-007-0005", 7 },
                    { new Guid("5523b28f-8034-4fa0-a0fd-17c16968bcd3"), "Anita", 2, true, true, "Nepali", "Devi", "+9779622882892", new DateTime(2024, 10, 31, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6360), "NPV-014-0003", 14 },
                    { new Guid("5572447f-2987-4547-9e4d-04de3514609a"), "Anita", 2, true, false, "Maharjan", "Kumari", "+9779624650405", new DateTime(2025, 1, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4870), "NPV-001-0005", 1 },
                    { new Guid("55b92406-8b75-40d6-a124-251deec98fba"), "Suresh", 1, true, true, "Magar", "Prasad", "+9779865599717", new DateTime(2024, 11, 22, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(230), "NPV-046-0007", 46 },
                    { new Guid("56648429-9b7d-4afb-88e2-2556661a4f5e"), "Sarita", 2, true, true, "Chaudhary", "Maya", "+9779752257910", new DateTime(2025, 6, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6410), "NPV-014-0008", 14 },
                    { new Guid("56a95200-e2e9-47f4-94a7-b9d7d07905a9"), "Prakash", 1, true, false, "Yadav", "Bahadur", "+9779742180269", new DateTime(2024, 4, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6040), "NPV-011-0008", 11 },
                    { new Guid("57099844-dad8-406f-9190-ca9c32e4e33b"), "Nisha", 2, true, true, "Maharjan", "Devi", "+9779868199241", new DateTime(2025, 3, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9700), "NPV-042-0008", 42 },
                    { new Guid("57b6f238-1f78-43a9-99e8-4d972605200a"), "Sabitri", 2, true, false, "Shrestha", "Kumari", "+9779866022946", new DateTime(2024, 12, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7480), "NPV-023-0005", 23 },
                    { new Guid("57ce4e7c-9402-4ef4-bc0c-cc6ff9d11534"), "Rupa", 2, true, false, "Karki", "Kumari", "+9779637190229", new DateTime(2025, 2, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9400), "NPV-040-0002", 40 },
                    { new Guid("58063dfd-a1de-4676-badc-2346f02714e0"), "Gita", 2, true, false, "Gurung", "Laxmi", "+9779819645679", new DateTime(2025, 6, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5300), "NPV-004-0009", 4 },
                    { new Guid("581fe582-f89d-427a-a2af-64b62084dd0c"), "Parbati", 2, true, true, "Sharma", "Laxmi", "+9779818946466", new DateTime(2024, 4, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5350), "NPV-005-0004", 5 },
                    { new Guid("585133af-d17f-4391-b3bb-edc671ae783d"), "Rekha", 2, true, false, "Magar", "Maya", "+9779631140857", new DateTime(2025, 6, 24, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(140), "NPV-045-0008", 45 },
                    { new Guid("58a2f10a-d37a-4a35-b421-2fb9ea31026f"), "Shyam", 1, true, false, "Magar", "Bahadur", "+9779629510564", new DateTime(2024, 7, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7020), "NPV-019-0006", 19 },
                    { new Guid("594660fb-e7c3-4198-bed5-28c66bfaca7f"), "Bikash", 1, true, true, "Chaudhary", "Singh", "+9779843820801", new DateTime(2024, 3, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9270), "NPV-038-0010", 38 },
                    { new Guid("5a4c2288-6367-4c13-95a1-a1fc6ef2a97b"), "Santosh", 1, true, true, "Magar", "Kumar", "+9779828479365", new DateTime(2025, 11, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7400), "NPV-022-0007", 22 },
                    { new Guid("5a52bb9a-ffd3-4523-9b2d-acb97274b153"), "Arjun", 1, true, false, "Shrestha", "Singh", "+9779824747279", new DateTime(2025, 11, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8190), "NPV-029-0002", 29 },
                    { new Guid("5a669c1f-ad05-4f30-ae8d-a446a38584fa"), "Anita", 2, true, false, "Tamang", "Maya", "+9779881444170", new DateTime(2024, 10, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7060), "NPV-019-0010", 19 },
                    { new Guid("5ad9080d-8396-4b08-9df9-a1b01e3d25c7"), "Mohan", 1, true, true, "Tamang", "Prasad", "+9779841351740", new DateTime(2024, 5, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9520), "NPV-040-0010", 40 },
                    { new Guid("5ba89840-e670-4008-aa73-f1bb8267aaac"), "Ram", 1, true, true, "Lama", "Raj", "+9779823507755", new DateTime(2025, 12, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7760), "NPV-026-0003", 26 },
                    { new Guid("5bfc9579-ea72-4e6c-8549-cc8c8be7ee1d"), "Bishnu", 1, true, true, "Nepali", "Raj", "+9779851384030", new DateTime(2024, 12, 14, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(110), "NPV-045-0005", 45 },
                    { new Guid("5c23cc92-daca-4978-8ae2-021da298f36e"), "Bishnu", 1, true, true, "Nepali", "Singh", "+9779621284630", new DateTime(2025, 9, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5820), "NPV-009-0006", 9 },
                    { new Guid("5c26eb94-3b48-4bd5-a765-dcc77c88dcb3"), "Radha", 2, true, true, "Khadka", "Devi", "+9779765288872", new DateTime(2024, 9, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5490), "NPV-006-0009", 6 },
                    { new Guid("5c33382a-0122-49c3-b9e6-50400a35cbdf"), "Bikash", 1, true, true, "Magar", "Raj", "+9779634999452", new DateTime(2024, 5, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6740), "NPV-017-0008", 17 },
                    { new Guid("5c3416da-da71-4479-993d-022ca49b5e32"), "Sarita", 2, true, true, "Lama", "Maya", "+9779743321668", new DateTime(2024, 9, 21, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(120), "NPV-045-0006", 45 },
                    { new Guid("5cb38115-b464-4d9f-acd2-3f1f79d63236"), "Rupa", 2, true, true, "Lama", "Devi", "+9779636017141", new DateTime(2025, 12, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8450), "NPV-031-0009", 31 },
                    { new Guid("5cbd48ad-51f8-4631-bc6c-a04b2d32a16a"), "Anita", 2, true, true, "Rai", "Devi", "+9779886719415", new DateTime(2024, 11, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7600), "NPV-024-0007", 24 },
                    { new Guid("5cd8d431-0f22-4b8c-9f47-907f28127493"), "Arjun", 1, true, true, "Lama", "Prasad", "+9779742159446", new DateTime(2024, 6, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8140), "NPV-028-0007", 28 },
                    { new Guid("5d5afecb-ab6c-4c2f-8760-1d5f33517c0d"), "Sabitri", 2, true, true, "Tamang", "Maya", "+9779759766614", new DateTime(2024, 6, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6250), "NPV-013-0003", 13 },
                    { new Guid("5dc06fe9-5f50-44b6-9120-485967161a99"), "Anita", 2, true, true, "Lama", "Laxmi", "+9779813951257", new DateTime(2024, 10, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8370), "NPV-031-0001", 31 },
                    { new Guid("5dc8b4c3-0db6-4c32-8066-96f003ca17a6"), "Santosh", 1, true, true, "Sharma", "Singh", "+9779632141062", new DateTime(2025, 11, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5690), "NPV-008-0002", 8 },
                    { new Guid("5e0acae4-8f13-4146-aae1-ecca96ae16bb"), "Rekha", 2, true, true, "Tamang", "Kumari", "+9779883922145", new DateTime(2024, 3, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8320), "NPV-030-0005", 30 },
                    { new Guid("5ec0f08d-7cfd-48d0-8373-8387bb98fa8a"), "Anita", 2, true, true, "Nepali", "Devi", "+9779841162903", new DateTime(2024, 1, 25, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(530), "NPV-048-0009", 48 },
                    { new Guid("5f6445af-3252-4606-a6db-855418de4dd6"), "Mohan", 1, true, true, "Nepali", "Singh", "+9779863817431", new DateTime(2024, 1, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9260), "NPV-038-0009", 38 },
                    { new Guid("5ffff54e-c3fe-4cf6-abcb-806a36dde624"), "Gita", 2, true, true, "Rai", "Laxmi", "+9779856007840", new DateTime(2024, 8, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6280), "NPV-013-0006", 13 },
                    { new Guid("60468723-1e39-4835-be5a-603e7c6eab7f"), "Shova", 2, true, true, "Thapa", "Devi", "+9779749622538", new DateTime(2025, 11, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9820), "NPV-043-0010", 43 },
                    { new Guid("608ad8e7-7a77-4386-bc51-6e6d02ef8143"), "Hari", 1, true, false, "Magar", "Bahadur", "+9779805982124", new DateTime(2024, 7, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5680), "NPV-008-0001", 8 },
                    { new Guid("616cf646-cbb5-4518-b4b2-f578089cc19a"), "Rekha", 2, true, true, "B.K.", "Laxmi", "+9779745468168", new DateTime(2025, 2, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7320), "NPV-022-0006", 22 },
                    { new Guid("62000069-7229-4406-a8ea-114f15cbd44d"), "Rupa", 2, true, true, "Chaudhary", "Kumari", "+9779625947078", new DateTime(2025, 2, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4990), "NPV-002-0006", 2 },
                    { new Guid("63345bf2-2070-471d-bb22-6a42572335dc"), "Mohan", 1, true, false, "Sharma", "Bahadur", "+9779611382043", new DateTime(2025, 11, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9990), "NPV-044-0004", 44 },
                    { new Guid("6350e25a-ff54-4595-b422-5aa52a27aa65"), "Mohan", 1, true, true, "Karki", "Bahadur", "+9779768282704", new DateTime(2025, 7, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8900), "NPV-035-0009", 35 },
                    { new Guid("6398cc98-6411-431e-88e6-622d16a5e832"), "Rupa", 2, true, false, "Karki", "Laxmi", "+9779864829089", new DateTime(2025, 1, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9030), "NPV-036-0006", 36 },
                    { new Guid("640719cc-7687-4d1a-bbba-2df2a44e53ef"), "Prakash", 1, true, false, "Tamang", "Kumar", "+9779611387911", new DateTime(2024, 11, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9130), "NPV-037-0006", 37 },
                    { new Guid("6477def8-0d8b-4015-bc8c-0ff9b5bbf84d"), "Rajesh", 1, true, true, "Nepali", "Singh", "+9779626100427", new DateTime(2025, 7, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9220), "NPV-038-0005", 38 },
                    { new Guid("64d7609c-c767-4d0c-bbb9-354c0c098e47"), "Sarita", 2, true, true, "Rai", "Kumari", "+9779844943874", new DateTime(2024, 10, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5500), "NPV-006-0010", 6 },
                    { new Guid("656b0bd6-704a-45cb-9036-b0b6e88e499b"), "Santosh", 1, true, true, "Chaudhary", "Bahadur", "+9779762290425", new DateTime(2024, 9, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7620), "NPV-024-0009", 24 },
                    { new Guid("664a958d-f804-49a7-9915-6676a7f5fe9c"), "Gopal", 1, true, true, "Tamang", "Prasad", "+9779815172707", new DateTime(2025, 11, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8600), "NPV-032-0009", 32 },
                    { new Guid("6665a251-d818-4a84-a0b7-512cc6c58c06"), "Parbati", 2, true, true, "Lama", "Maya", "+9779628973473", new DateTime(2025, 10, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5410), "NPV-006-0001", 6 },
                    { new Guid("669a933b-f65b-491f-a5f8-777f627f9892"), "Ram", 1, true, true, "Khadka", "Singh", "+9779864435730", new DateTime(2024, 5, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7470), "NPV-023-0004", 23 },
                    { new Guid("66ea3aeb-a745-4633-8709-0cc13732e25a"), "Bishnu", 1, true, true, "Magar", "Raj", "+9779626116408", new DateTime(2025, 10, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6590), "NPV-016-0003", 16 },
                    { new Guid("675d0480-3511-46c1-ac93-19cc8c50c7de"), "Arjun", 1, true, true, "Karki", "Kumar", "+9779855637269", new DateTime(2025, 10, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4890), "NPV-001-0006", 1 },
                    { new Guid("6808f496-8e9a-44b9-b239-7b3a1dfab8a5"), "Dipak", 1, true, true, "Karki", "Bahadur", "+9779638747459", new DateTime(2025, 5, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9710), "NPV-042-0009", 42 },
                    { new Guid("6827ce8a-7411-4924-9c43-8eb5ff1d09f2"), "Hari", 1, true, true, "Chaudhary", "Singh", "+9779828374123", new DateTime(2025, 5, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8180), "NPV-029-0001", 29 },
                    { new Guid("682838bc-5d71-44ef-b27a-8621ee37f756"), "Gopal", 1, true, true, "Maharjan", "Singh", "+9779857081550", new DateTime(2024, 10, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8810), "NPV-034-0010", 34 },
                    { new Guid("68d091b1-07f0-439a-bea4-bf05facc13de"), "Nisha", 2, true, true, "Gurung", "Maya", "+9779612147025", new DateTime(2024, 7, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6680), "NPV-017-0002", 17 },
                    { new Guid("68fb8bef-d74d-480f-ac1f-61ca32f7084c"), "Gita", 2, true, true, "Yadav", "Kumari", "+9779759812602", new DateTime(2025, 7, 19, 5, 23, 36, 945, DateTimeKind.Utc), "NPV-044-0005", 44 },
                    { new Guid("69312e8a-bd2e-4e91-8329-1c0fd2cac210"), "Prakash", 1, true, true, "B.K.", "Bahadur", "+9779883057822", new DateTime(2025, 8, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5880), "NPV-010-0002", 10 },
                    { new Guid("69ae6ab6-b350-4326-83aa-59b460187e92"), "Dipak", 1, true, true, "Sharma", "Raj", "+9779841695465", new DateTime(2024, 5, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4910), "NPV-001-0008", 1 },
                    { new Guid("6c37ee2f-cf1c-4150-a97c-1f3e99d6a158"), "Krishna", 1, true, false, "Thapa", "Singh", "+9779616928012", new DateTime(2024, 12, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7230), "NPV-021-0007", 21 },
                    { new Guid("6dcf8786-fc58-49ce-8e87-72f383d58bb7"), "Nabin", 1, true, true, "B.K.", "Prasad", "+9779869636766", new DateTime(2024, 9, 26, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(130), "NPV-045-0007", 45 },
                    { new Guid("6e905f5d-bcac-4a98-9ba7-3e63b6d304d9"), "Shyam", 1, true, true, "Magar", "Prasad", "+9779758310043", new DateTime(2024, 9, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4960), "NPV-002-0003", 2 },
                    { new Guid("6eb2daf4-f910-44ad-bddf-940d0318531f"), "Sunita", 2, true, true, "Maharjan", "Devi", "+9779886350902", new DateTime(2025, 7, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5780), "NPV-009-0002", 9 },
                    { new Guid("6f20f3b9-bbd6-450b-9a9f-6c260865602f"), "Rekha", 2, true, false, "Rai", "Kumari", "+9779847800370", new DateTime(2025, 3, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5660), "NPV-007-0010", 7 },
                    { new Guid("6f3d585e-aef4-4ee7-88a9-de3055897f32"), "Sita", 2, true, true, "Gurung", "Kumari", "+9779862003295", new DateTime(2024, 1, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5390), "NPV-005-0009", 5 },
                    { new Guid("6f4fdb08-d48d-4c3b-b2d5-2f3d754faed1"), "Rajesh", 1, true, false, "Rai", "Prasad", "+9779618475565", new DateTime(2024, 6, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9300), "NPV-039-0003", 39 },
                    { new Guid("6f5775e7-ef78-46f8-91e2-175bbe766d73"), "Bishnu", 1, true, true, "Shrestha", "Bahadur", "+9779747288135", new DateTime(2024, 5, 20, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(270), "NPV-047-0001", 47 },
                    { new Guid("6f797c90-4006-41f1-8ea8-4923f063941d"), "Sunita", 2, true, true, "B.K.", "Maya", "+9779762904562", new DateTime(2025, 6, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8480), "NPV-032-0002", 32 },
                    { new Guid("6fd4307b-3244-46aa-85ef-b44d37db735a"), "Arjun", 1, true, true, "Gurung", "Bahadur", "+9779612196348", new DateTime(2025, 7, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5720), "NPV-008-0005", 8 },
                    { new Guid("70ba5d1b-d988-47e9-90f1-15791ecc789e"), "Sarita", 2, true, true, "Rai", "Devi", "+9779814808907", new DateTime(2025, 3, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5190), "NPV-004-0005", 4 },
                    { new Guid("7142a478-4cde-4f7e-b697-e990c657bd1f"), "Sunita", 2, true, false, "Karki", "Maya", "+9779865809366", new DateTime(2024, 3, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8610), "NPV-032-0010", 32 },
                    { new Guid("7147f8ba-e610-4b1a-8c72-2c0f6a4cd3f6"), "Radha", 2, true, true, "Khadka", "Laxmi", "+9779753683300", new DateTime(2025, 9, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6730), "NPV-017-0007", 17 },
                    { new Guid("7160376f-e60f-4cee-866a-685d7f06b934"), "Rupa", 2, true, true, "Nepali", "Kumari", "+9779627421124", new DateTime(2025, 2, 2, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(520), "NPV-048-0008", 48 },
                    { new Guid("721ab76c-134b-45ad-869c-c8190f413868"), "Ram", 1, true, true, "Yadav", "Singh", "+9779762905437", new DateTime(2024, 1, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8040), "NPV-028-0002", 28 },
                    { new Guid("722c5c50-5bf4-4dde-a25d-7cd6a81c7146"), "Ram", 1, true, false, "Chaudhary", "Bahadur", "+9779766347709", new DateTime(2025, 3, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6640), "NPV-016-0008", 16 },
                    { new Guid("72615e09-578f-47c7-9a18-89bebbdcd1df"), "Anita", 2, true, true, "Tamang", "Maya", "+9779852803149", new DateTime(2024, 10, 4, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(280), "NPV-047-0002", 47 },
                    { new Guid("728b61fc-b04e-4618-b1b2-bd449c41a53b"), "Sarita", 2, true, true, "Tamang", "Kumari", "+9779814469830", new DateTime(2024, 3, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8470), "NPV-032-0001", 32 },
                    { new Guid("72938716-f473-4a68-9894-2acee0d40ef5"), "Radha", 2, true, true, "Khadka", "Maya", "+9779612347304", new DateTime(2025, 4, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9360), "NPV-039-0009", 39 },
                    { new Guid("735586cd-151b-4a91-945d-1910b3a932a5"), "Nisha", 2, true, true, "Thapa", "Kumari", "+9779862164365", new DateTime(2024, 3, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6780), "NPV-018-0002", 18 },
                    { new Guid("7378430c-0a0c-4e19-8e85-b7e2d13ffccc"), "Sarita", 2, true, true, "Thapa", "Kumari", "+9779766564323", new DateTime(2024, 10, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7570), "NPV-024-0004", 24 },
                    { new Guid("73da4cea-f958-4a20-b6a9-c76fccec937f"), "Krishna", 1, true, true, "Gurung", "Prasad", "+9779616652510", new DateTime(2025, 7, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8940), "NPV-036-0003", 36 },
                    { new Guid("7428c176-08c6-46a1-8e42-1417a1678d5c"), "Krishna", 1, true, false, "Thapa", "Kumar", "+9779618083909", new DateTime(2025, 6, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7910), "NPV-027-0003", 27 },
                    { new Guid("758cf61f-6328-44c5-ac92-b0e75dccfe39"), "Sabitri", 2, true, true, "Yadav", "Laxmi", "+9779816861216", new DateTime(2024, 3, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6570), "NPV-016-0001", 16 },
                    { new Guid("75ca3c14-8506-4be1-a968-718879bb529a"), "Rajesh", 1, true, true, "B.K.", "Kumar", "+9779746697736", new DateTime(2024, 5, 28, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(30), "NPV-044-0007", 44 },
                    { new Guid("763fa937-10c3-4ca7-8033-782adf13fc3b"), "Mohan", 1, true, false, "Tamang", "Singh", "+9779816733711", new DateTime(2025, 10, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6180), "NPV-012-0006", 12 },
                    { new Guid("77ac1ea8-54e3-4529-9052-b8d7b10ad841"), "Suresh", 1, true, true, "B.K.", "Kumar", "+9779613138355", new DateTime(2024, 6, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8360), "NPV-030-0009", 30 },
                    { new Guid("788bbb83-1cf8-4946-9d57-b87dedab3421"), "Mohan", 1, true, true, "Chaudhary", "Raj", "+9779801579949", new DateTime(2025, 11, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7720), "NPV-025-0009", 25 },
                    { new Guid("79e0b88c-9af7-40ab-a0c7-b7c3ad5e58c5"), "Arjun", 1, true, true, "Thapa", "Singh", "+9779846513536", new DateTime(2025, 8, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6160), "NPV-012-0004", 12 },
                    { new Guid("7a8b10f1-10d6-4964-9c4d-dc4971164458"), "Rupa", 2, true, true, "Khadka", "Laxmi", "+9779854848919", new DateTime(2024, 7, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6340), "NPV-014-0001", 14 },
                    { new Guid("7b18601a-2701-46d6-b0a3-45915fe4eda8"), "Sarita", 2, true, false, "Sharma", "Kumari", "+9779869465873", new DateTime(2025, 4, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6270), "NPV-013-0005", 13 },
                    { new Guid("7bf7f849-ebf7-4240-807b-fcbb425dda93"), "Sunita", 2, true, true, "Tamang", "Kumari", "+9779802450384", new DateTime(2025, 3, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6450), "NPV-014-0009", 14 },
                    { new Guid("7c569e67-7a18-461c-bb36-d5e757a55a75"), "Maya", 2, true, true, "Tamang", "Maya", "+9779765732627", new DateTime(2024, 8, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6150), "NPV-012-0003", 12 },
                    { new Guid("7c5e5895-3940-42cb-a978-f2611bf14bf2"), "Bishnu", 1, true, true, "Karki", "Kumar", "+9779613123677", new DateTime(2025, 5, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9170), "NPV-037-0010", 37 },
                    { new Guid("7c982572-2337-46fb-b10e-b3e4b6ed6c96"), "Mohan", 1, true, true, "Shrestha", "Singh", "+9779625640478", new DateTime(2025, 11, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7590), "NPV-024-0006", 24 },
                    { new Guid("7d2ee968-6e5c-4f23-9d9f-9e909a1667ea"), "Laxmi", 2, true, true, "Yadav", "Devi", "+9779848081763", new DateTime(2024, 12, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7970), "NPV-027-0009", 27 },
                    { new Guid("7d3d3285-5567-4f9f-9e16-dcfa91bcf8de"), "Bishnu", 1, true, true, "Karki", "Prasad", "+9779746360573", new DateTime(2024, 12, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8200), "NPV-029-0003", 29 },
                    { new Guid("7e4ee587-0abb-4934-bdd7-0de5e06ef784"), "Laxmi", 2, true, true, "Sharma", "Devi", "+9779845108637", new DateTime(2025, 11, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9040), "NPV-036-0007", 36 },
                    { new Guid("7f97594b-d027-4915-9af6-c1da6ad84302"), "Anita", 2, true, false, "Thapa", "Kumari", "+9779888141726", new DateTime(2024, 7, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9150), "NPV-037-0008", 37 },
                    { new Guid("8379a936-6adc-4ff6-9d46-c2230d7d4779"), "Rajesh", 1, true, true, "Karki", "Bahadur", "+9779851527114", new DateTime(2024, 7, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5590), "NPV-007-0008", 7 },
                    { new Guid("84daa9e4-a21e-495c-8f3e-07b75aacad03"), "Anita", 2, true, true, "Magar", "Laxmi", "+9779758528702", new DateTime(2025, 3, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8670), "NPV-033-0006", 33 },
                    { new Guid("8522981a-c01c-4368-80cd-41b4c85017eb"), "Shova", 2, true, true, "Thapa", "Kumari", "+9779885464518", new DateTime(2024, 8, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7100), "NPV-020-0004", 20 },
                    { new Guid("85efe9c1-795a-403f-bc36-28914b8e1bd9"), "Laxmi", 2, true, true, "Karki", "Laxmi", "+9779748552898", new DateTime(2025, 10, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5580), "NPV-007-0007", 7 },
                    { new Guid("85f16f84-77e0-4671-9028-80b54acc6b16"), "Laxmi", 2, true, true, "B.K.", "Maya", "+9779632045511", new DateTime(2024, 6, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7050), "NPV-019-0009", 19 },
                    { new Guid("85f290b6-994d-4496-80c1-6bb6803c718e"), "Sarita", 2, true, false, "Magar", "Devi", "+9779884888145", new DateTime(2024, 9, 29, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(470), "NPV-048-0003", 48 },
                    { new Guid("87196d34-bf5f-4c65-a7b5-b308ed7fcff0"), "Sunita", 2, true, true, "Nepali", "Devi", "+9779816364753", new DateTime(2025, 10, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7930), "NPV-027-0005", 27 },
                    { new Guid("87679ab9-bbdf-4930-bb77-68355438b4d2"), "Shyam", 1, true, true, "Shrestha", "Bahadur", "+9779755285170", new DateTime(2024, 4, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9060), "NPV-036-0009", 36 },
                    { new Guid("87cecf04-6203-423b-b887-1bb6bd8e9403"), "Shyam", 1, true, false, "Gurung", "Raj", "+9779762996257", new DateTime(2024, 1, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7130), "NPV-020-0007", 20 },
                    { new Guid("88b4cdd9-1abd-46d6-9679-c79c9f36eac3"), "Gopal", 1, true, true, "Rai", "Kumar", "+9779858875569", new DateTime(2025, 12, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5530), "NPV-007-0003", 7 },
                    { new Guid("88d5642c-6608-43d3-9891-8010b4cfb040"), "Ram", 1, true, true, "Gurung", "Bahadur", "+9779869220442", new DateTime(2025, 12, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7410), "NPV-022-0008", 22 },
                    { new Guid("895ed9bb-39c0-4f96-aae1-ff59c29a4f13"), "Arjun", 1, true, false, "Karki", "Raj", "+9779822501839", new DateTime(2024, 3, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9490), "NPV-040-0007", 40 },
                    { new Guid("8a238ac4-d67e-471a-9c66-6d51ff033f40"), "Radha", 2, true, true, "Maharjan", "Devi", "+9779743122049", new DateTime(2025, 9, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5380), "NPV-005-0008", 5 },
                    { new Guid("8a4dfb0a-bde2-4234-a679-fe82e4d7adcc"), "Rupa", 2, true, true, "Gurung", "Kumari", "+9779815604176", new DateTime(2025, 12, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6470), "NPV-015-0001", 15 },
                    { new Guid("8a988f7e-b914-4045-a6f9-549feb264068"), "Rajesh", 1, true, true, "Rai", "Kumar", "+9779842048646", new DateTime(2025, 3, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5340), "NPV-005-0003", 5 },
                    { new Guid("8a9eb6b3-d0e2-4f20-97e5-f228301b9ea4"), "Parbati", 2, true, true, "Rai", "Kumari", "+9779813391456", new DateTime(2025, 11, 18, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(200), "NPV-046-0004", 46 },
                    { new Guid("8af4b20d-2652-47a8-808a-a760c84d4c27"), "Anita", 2, true, true, "Maharjan", "Kumari", "+9779801197712", new DateTime(2024, 2, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9140), "NPV-037-0007", 37 },
                    { new Guid("8b167d3f-7444-4434-935a-aca6d3906c79"), "Nisha", 2, true, true, "Magar", "Kumari", "+9779814255740", new DateTime(2025, 1, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6500), "NPV-015-0004", 15 },
                    { new Guid("8b4ff7c9-04d8-4022-b350-787625ac519f"), "Nabin", 1, true, false, "Rai", "Prasad", "+9779817400654", new DateTime(2025, 6, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5130), "NPV-003-0009", 3 },
                    { new Guid("8b6ea6b9-3e7f-4c32-b7e1-c1c04bc0a972"), "Sarita", 2, true, true, "Karki", "Maya", "+9779857779232", new DateTime(2025, 3, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8780), "NPV-034-0007", 34 },
                    { new Guid("8b72e9cc-4892-46b8-87a6-62d552c70809"), "Rupa", 2, true, true, "Rai", "Kumari", "+9779822861327", new DateTime(2024, 6, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6540), "NPV-015-0008", 15 },
                    { new Guid("8c6e5630-9cf6-4862-8f36-2e683cf4c46e"), "Hari", 1, true, true, "Chaudhary", "Kumar", "+9779848981612", new DateTime(2025, 1, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8890), "NPV-035-0008", 35 },
                    { new Guid("8cb53ffd-34b1-41be-9270-448388b2d0d2"), "Prakash", 1, true, true, "Nepali", "Prasad", "+9779828101549", new DateTime(2025, 6, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9800), "NPV-043-0008", 43 },
                    { new Guid("8cca5312-9e14-46d1-a099-82d701f5fa13"), "Sabitri", 2, true, true, "Rai", "Maya", "+9779815051385", new DateTime(2024, 8, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5730), "NPV-008-0006", 8 },
                    { new Guid("8e11eaa7-65ad-48e3-b714-5a27fbade753"), "Nabin", 1, true, true, "Rai", "Prasad", "+9779636956934", new DateTime(2025, 11, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7540), "NPV-024-0001", 24 },
                    { new Guid("8f07e01f-51f1-42aa-b43b-66bca94490a2"), "Laxmi", 2, true, true, "Karki", "Laxmi", "+9779757599202", new DateTime(2025, 4, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5710), "NPV-008-0004", 8 },
                    { new Guid("8f26f21c-069d-45e2-8e21-b51efe384e86"), "Rajesh", 1, true, true, "Tamang", "Raj", "+9779884294938", new DateTime(2024, 8, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8430), "NPV-031-0007", 31 },
                    { new Guid("8f57ab02-e589-4152-bfb9-082038f4187b"), "Santosh", 1, true, true, "Sharma", "Kumar", "+9779815417579", new DateTime(2024, 4, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4920), "NPV-001-0009", 1 },
                    { new Guid("8f8266fd-8f51-4ec3-ad83-cfc6a5783fe9"), "Sarita", 2, true, true, "Rai", "Maya", "+9779825631547", new DateTime(2024, 4, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9310), "NPV-039-0004", 39 },
                    { new Guid("8fa778b6-8110-47d4-8720-93fe7556271a"), "Nisha", 2, true, true, "B.K.", "Maya", "+9779625791451", new DateTime(2024, 9, 18, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(210), "NPV-046-0005", 46 },
                    { new Guid("90e30218-9b9e-478f-8a0f-fc147facf8b9"), "Sarita", 2, true, true, "Yadav", "Kumari", "+9779803015447", new DateTime(2025, 5, 31, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6260), "NPV-013-0004", 13 },
                    { new Guid("92f47e50-9231-48db-a364-f9b38daba7b5"), "Rupa", 2, true, true, "B.K.", "Laxmi", "+9779634888568", new DateTime(2024, 2, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8690), "NPV-033-0008", 33 },
                    { new Guid("930bd336-ec35-4bfb-8de8-c1d4263cb998"), "Parbati", 2, true, true, "Maharjan", "Devi", "+9779621177522", new DateTime(2023, 12, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9580), "NPV-041-0006", 41 },
                    { new Guid("93ce41c8-0532-41c8-8d72-aadcdfd959d7"), "Rupa", 2, true, false, "Rai", "Laxmi", "+9779765868778", new DateTime(2024, 9, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5370), "NPV-005-0006", 5 },
                    { new Guid("94203c5a-d4b2-41f0-af58-4a2d0d9e95cd"), "Maya", 2, true, true, "Thapa", "Kumari", "+9779766799258", new DateTime(2023, 12, 31, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8330), "NPV-030-0006", 30 },
                    { new Guid("94733f68-3a79-4936-8268-4f9eff4779cd"), "Maya", 2, true, true, "Gurung", "Kumari", "+9779821038919", new DateTime(2025, 10, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8880), "NPV-035-0007", 35 },
                    { new Guid("94d2d79d-9d4a-4bb9-8c21-b77f35d0d834"), "Nabin", 1, true, true, "Karki", "Kumar", "+9779814148166", new DateTime(2024, 4, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8440), "NPV-031-0008", 31 },
                    { new Guid("9543a1c5-20d2-40a0-8ee6-574cd830f698"), "Krishna", 1, true, false, "Karki", "Bahadur", "+9779755416755", new DateTime(2024, 11, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8620), "NPV-033-0001", 33 },
                    { new Guid("9563dab7-20ae-4c84-9ddd-004cac1aa238"), "Nisha", 2, true, true, "Chaudhary", "Laxmi", "+9779631338384", new DateTime(2024, 4, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9750), "NPV-043-0003", 43 },
                    { new Guid("965a30e0-d9ca-47a7-a7d2-efff72d76acd"), "Nabin", 1, true, true, "Tamang", "Kumar", "+9779845871493", new DateTime(2025, 12, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5730), "NPV-008-0007", 8 },
                    { new Guid("972fa20f-76ee-4191-b003-704d3860f847"), "Ram", 1, true, true, "Gurung", "Prasad", "+9779863803431", new DateTime(2024, 3, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7010), "NPV-019-0005", 19 },
                    { new Guid("97b73b50-10da-4611-aa6a-8bb9644cc51c"), "Nisha", 2, true, true, "Lama", "Maya", "+9779804722404", new DateTime(2025, 1, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7180), "NPV-021-0002", 21 },
                    { new Guid("9807c611-fe29-4002-8419-951fed3ae8c1"), "Sarita", 2, true, true, "Sharma", "Maya", "+9779766090497", new DateTime(2024, 6, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6510), "NPV-015-0005", 15 },
                    { new Guid("98406176-afcf-42cb-b277-10957b89845a"), "Sarita", 2, true, true, "Chaudhary", "Maya", "+9779816066106", new DateTime(2025, 6, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9190), "NPV-038-0002", 38 },
                    { new Guid("98c55289-4ff7-4beb-81fe-6ffe5d64d706"), "Santosh", 1, true, true, "Gurung", "Singh", "+9779823377165", new DateTime(2024, 10, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7560), "NPV-024-0003", 24 },
                    { new Guid("992875d2-edc1-45f5-a5ce-978227162ab2"), "Bikash", 1, true, true, "Magar", "Singh", "+9779855183376", new DateTime(2025, 11, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6000), "NPV-011-0004", 11 },
                    { new Guid("9985ec91-4582-4d42-acd6-43e22d1caef9"), "Laxmi", 2, true, false, "Nepali", "Kumari", "+9779867663153", new DateTime(2025, 1, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7460), "NPV-023-0003", 23 },
                    { new Guid("9a6ddfe4-d357-4388-bed0-700f8ff101a8"), "Maya", 2, true, true, "Thapa", "Devi", "+9779843276109", new DateTime(2024, 7, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9740), "NPV-043-0002", 43 },
                    { new Guid("9ad72346-f96d-4a79-b158-ca7441829f92"), "Bishnu", 1, true, false, "Tamang", "Raj", "+9779618789272", new DateTime(2024, 9, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4980), "NPV-002-0005", 2 },
                    { new Guid("9afcf075-8653-48f3-ae87-8887aae14761"), "Parbati", 2, true, true, "Lama", "Maya", "+9779826356425", new DateTime(2025, 6, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8260), "NPV-029-0009", 29 },
                    { new Guid("9b05fa75-a4e8-4f5e-94fc-af1bf935ad07"), "Gita", 2, true, true, "Maharjan", "Maya", "+9779744625227", new DateTime(2024, 11, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6750), "NPV-017-0009", 17 },
                    { new Guid("9becbc07-5be4-4e0b-bb5b-ccc1eff82611"), "Shova", 2, true, true, "Khadka", "Laxmi", "+9779767116450", new DateTime(2024, 7, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9670), "NPV-042-0005", 42 },
                    { new Guid("9cca1e23-f67a-44fd-a542-f9f44187cda8"), "Rajesh", 1, true, true, "Thapa", "Bahadur", "+9779759191251", new DateTime(2024, 10, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5180), "NPV-004-0004", 4 },
                    { new Guid("9ceaae22-f8ea-44cd-a478-979132c99307"), "Ram", 1, true, true, "Sharma", "Singh", "+9779858926650", new DateTime(2025, 3, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6480), "NPV-015-0002", 15 },
                    { new Guid("9d02fc78-514e-4d5d-83b0-d372db50574c"), "Arjun", 1, true, true, "Thapa", "Prasad", "+9779854695653", new DateTime(2025, 11, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5790), "NPV-009-0003", 9 },
                    { new Guid("9d452f27-f6de-4eba-b894-c95591b7e886"), "Gopal", 1, true, false, "Magar", "Kumar", "+9779763866707", new DateTime(2025, 6, 22, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(20), "NPV-044-0006", 44 },
                    { new Guid("9d9a2967-c768-4f71-988e-5720740bab7f"), "Sita", 2, true, false, "B.K.", "Devi", "+9779861012122", new DateTime(2025, 7, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6310), "NPV-013-0009", 13 },
                    { new Guid("9e1f0576-e42a-4104-bd4f-bed72ba44358"), "Krishna", 1, true, true, "Thapa", "Raj", "+9779829776443", new DateTime(2025, 9, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7890), "NPV-027-0001", 27 },
                    { new Guid("9e94a5cc-ec9a-4523-b325-029f8a9978c6"), "Bikash", 1, true, false, "Karki", "Singh", "+9779741128447", new DateTime(2025, 7, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8740), "NPV-034-0003", 34 },
                    { new Guid("9fcfbc4b-20ee-4982-bc80-3576eca2e2d1"), "Rajesh", 1, true, false, "Karki", "Prasad", "+9779881829721", new DateTime(2024, 7, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6990), "NPV-019-0003", 19 },
                    { new Guid("9fe4ac53-ad1a-4244-b06f-04076107c035"), "Sarita", 2, true, true, "Thapa", "Kumari", "+9779816064811", new DateTime(2024, 9, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5110), "NPV-003-0007", 3 },
                    { new Guid("9ff14ba0-facd-4bab-84e6-e656f858ab2f"), "Gopal", 1, true, true, "Nepali", "Kumar", "+9779746991688", new DateTime(2025, 11, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5400), "NPV-005-0010", 5 },
                    { new Guid("a02339cd-040e-4b83-a8d8-6824563b69b0"), "Rajesh", 1, true, true, "Maharjan", "Kumar", "+9779824488963", new DateTime(2025, 2, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8820), "NPV-035-0001", 35 },
                    { new Guid("a0c26130-f747-4342-a540-615ddaafa725"), "Radha", 2, true, false, "Lama", "Kumari", "+9779805110246", new DateTime(2024, 5, 25, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(350), "NPV-047-0009", 47 },
                    { new Guid("a2ef2c35-255a-4be6-871f-5cc67b139b6e"), "Krishna", 1, true, true, "Lama", "Kumar", "+9779613182615", new DateTime(2025, 10, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5740), "NPV-008-0008", 8 },
                    { new Guid("a4030f29-50e0-4ff8-9c39-c01e67c67ea0"), "Santosh", 1, true, true, "Chaudhary", "Bahadur", "+9779801238047", new DateTime(2024, 3, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5030), "NPV-002-0009", 2 },
                    { new Guid("a44c77ee-cf30-42f4-8cad-030b6477c4ca"), "Radha", 2, true, false, "Khadka", "Kumari", "+9779769447928", new DateTime(2024, 3, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9120), "NPV-037-0005", 37 },
                    { new Guid("a512943f-7135-47b1-a748-ca0479509972"), "Sabitri", 2, true, true, "Nepali", "Devi", "+9779627661515", new DateTime(2025, 1, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7440), "NPV-023-0001", 23 },
                    { new Guid("a54a6f4a-81af-466e-b799-7f0f2b7c7b53"), "Bikash", 1, true, true, "Gurung", "Raj", "+9779814310293", new DateTime(2024, 1, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6670), "NPV-017-0001", 17 },
                    { new Guid("a6a157ca-982e-4bb2-ad1e-e7f40696db90"), "Mohan", 1, true, true, "Tamang", "Prasad", "+9779862246830", new DateTime(2025, 9, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5450), "NPV-006-0005", 6 },
                    { new Guid("a6e2933a-243b-473d-8697-c9caa18deb53"), "Sarita", 2, true, true, "Nepali", "Maya", "+9779862006655", new DateTime(2024, 2, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7190), "NPV-021-0003", 21 },
                    { new Guid("a6e4dfd5-75b8-43b9-be5b-35c4fb82ce36"), "Arjun", 1, true, false, "Chaudhary", "Singh", "+9779754345905", new DateTime(2025, 4, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5020), "NPV-002-0008", 2 },
                    { new Guid("a729048a-4f54-4009-8eed-72ea2245b1b8"), "Nisha", 2, true, true, "Magar", "Devi", "+9779824189302", new DateTime(2025, 1, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7700), "NPV-025-0007", 25 },
                    { new Guid("a76df46d-f6ad-44bf-992d-05b64bd983fd"), "Suresh", 1, true, true, "Khadka", "Bahadur", "+9779865840402", new DateTime(2024, 10, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5510), "NPV-007-0001", 7 },
                    { new Guid("a7b269a7-d981-41a1-a2ac-2a7d72934bc3"), "Bikash", 1, true, true, "Thapa", "Bahadur", "+9779634447306", new DateTime(2025, 3, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5810), "NPV-009-0005", 9 },
                    { new Guid("a7d8d40f-21ec-4224-8581-454dcca0bae9"), "Sabitri", 2, true, true, "Shrestha", "Laxmi", "+9779619238902", new DateTime(2025, 4, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5980), "NPV-011-0002", 11 },
                    { new Guid("a8539bfa-3db0-488e-a797-5536a5430fda"), "Shova", 2, true, true, "Maharjan", "Kumari", "+9779849942351", new DateTime(2025, 2, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5800), "NPV-009-0004", 9 },
                    { new Guid("a924f979-782d-48d8-9656-c94e06b13856"), "Dipak", 1, true, true, "Magar", "Singh", "+9779615995009", new DateTime(2024, 4, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9090), "NPV-037-0002", 37 },
                    { new Guid("a9952659-226f-4f38-951f-77cbbf626f13"), "Sarita", 2, true, true, "Khadka", "Kumari", "+9779827306329", new DateTime(2025, 12, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6980), "NPV-019-0002", 19 },
                    { new Guid("a9ae93aa-58cb-40bb-8e71-ba32e89a2550"), "Sabitri", 2, true, true, "B.K.", "Laxmi", "+9779749764863", new DateTime(2025, 3, 20, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(540), "NPV-048-0010", 48 },
                    { new Guid("a9d630ee-1196-49a8-a678-27f20b3e740f"), "Krishna", 1, true, true, "Sharma", "Prasad", "+9779889146536", new DateTime(2024, 8, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5360), "NPV-005-0005", 5 },
                    { new Guid("a9fde7cd-1edf-4115-9728-d03124618e26"), "Arjun", 1, true, true, "Khadka", "Prasad", "+9779868911031", new DateTime(2024, 1, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9500), "NPV-040-0008", 40 },
                    { new Guid("aa2e9cb3-6cf7-49ba-8092-0322e95e8110"), "Santosh", 1, true, true, "Maharjan", "Prasad", "+9779882389748", new DateTime(2024, 1, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5440), "NPV-006-0004", 6 },
                    { new Guid("aa3581a2-5ab5-4264-9cc4-c596c79bf47e"), "Rekha", 2, true, true, "Lama", "Kumari", "+9779804621210", new DateTime(2024, 9, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9380), "NPV-040-0001", 40 },
                    { new Guid("aa91247e-870a-4d0f-8000-bfd5bdce0a32"), "Bikash", 1, true, false, "Tamang", "Singh", "+9779755885164", new DateTime(2025, 11, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5060), "NPV-003-0002", 3 },
                    { new Guid("aade1d7d-95b7-41ae-a891-52b7c86a9144"), "Hari", 1, true, true, "Rai", "Kumar", "+9779817002533", new DateTime(2024, 2, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5000), "NPV-002-0007", 2 },
                    { new Guid("abb3545b-d6c4-4bf3-96fe-0789b3b9c4b4"), "Shyam", 1, true, false, "Shrestha", "Raj", "+9779869814248", new DateTime(2025, 1, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6020), "NPV-011-0006", 11 },
                    { new Guid("ac14aaf7-9088-490c-ae72-eedbfad146db"), "Shyam", 1, true, false, "Magar", "Singh", "+9779813491158", new DateTime(2025, 8, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5150), "NPV-004-0001", 4 },
                    { new Guid("ac7ee192-892b-42b4-a65d-511897233fd1"), "Ram", 1, true, false, "Thapa", "Prasad", "+9779816668564", new DateTime(2025, 2, 7, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(80), "NPV-045-0002", 45 },
                    { new Guid("ad0a0f9a-333a-45d4-b556-78606fe129ee"), "Dipak", 1, true, true, "Yadav", "Singh", "+9779842379246", new DateTime(2024, 4, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8280), "NPV-030-0001", 30 },
                    { new Guid("ad6805ab-a17d-467a-a134-97deb06ba739"), "Sabitri", 2, true, false, "Shrestha", "Maya", "+9779849285108", new DateTime(2024, 11, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8680), "NPV-033-0007", 33 },
                    { new Guid("ae4016d7-0d01-4ea0-b613-54070f7bc1c9"), "Sita", 2, true, true, "Chaudhary", "Kumari", "+9779745245781", new DateTime(2025, 1, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4850), "NPV-001-0003", 1 },
                    { new Guid("ae7eb216-6e3a-4e69-ae61-e41bce68c0a9"), "Sabitri", 2, true, true, "Maharjan", "Kumari", "+9779826500495", new DateTime(2025, 4, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8050), "NPV-028-0003", 28 },
                    { new Guid("af5cbf22-7897-4445-8351-fb717ae315fa"), "Rekha", 2, true, true, "Maharjan", "Kumari", "+9779802827238", new DateTime(2024, 6, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5750), "NPV-008-0009", 8 },
                    { new Guid("b0027644-f952-4f5e-a483-2c67c4d1c8bb"), "Anita", 2, true, false, "Gurung", "Kumari", "+9779619280887", new DateTime(2024, 5, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5560), "NPV-007-0006", 7 },
                    { new Guid("b11cf2f1-9713-42e9-8a4f-85a9359d35ca"), "Radha", 2, true, true, "Chaudhary", "Kumari", "+9779868941189", new DateTime(2025, 12, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7290), "NPV-022-0003", 22 },
                    { new Guid("b12c5397-ff07-4a91-8345-355a89e8768b"), "Arjun", 1, true, true, "Maharjan", "Kumar", "+9779816860231", new DateTime(2024, 6, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8380), "NPV-031-0002", 31 },
                    { new Guid("b13a520e-d722-4b59-861c-4f97a8865025"), "Shyam", 1, true, true, "Gurung", "Prasad", "+9779613260564", new DateTime(2025, 9, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5600), "NPV-007-0009", 7 },
                    { new Guid("b14cee9b-47ba-4a38-a225-e0700db68a2c"), "Sabitri", 2, true, true, "Khadka", "Laxmi", "+9779629462994", new DateTime(2024, 2, 16, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7750), "NPV-026-0002", 26 },
                    { new Guid("b161a2ce-e823-44f8-b611-886c80e83a2a"), "Sita", 2, true, true, "Lama", "Maya", "+9779766929341", new DateTime(2025, 2, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9290), "NPV-039-0002", 39 },
                    { new Guid("b274c86b-ac8a-43c5-ba21-cade3fa3d4dd"), "Arjun", 1, true, true, "Rai", "Prasad", "+9779857907025", new DateTime(2024, 2, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(2830), "NPV-001-0001", 1 },
                    { new Guid("b33387a7-0dbf-4b12-8725-2c91ec5741c4"), "Bikash", 1, true, false, "Karki", "Singh", "+9779803956305", new DateTime(2024, 9, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5080), "NPV-003-0004", 3 },
                    { new Guid("b366bcff-1940-4488-b029-1117b41cd929"), "Dipak", 1, true, true, "Magar", "Raj", "+9779853390927", new DateTime(2025, 4, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7880), "NPV-026-0010", 26 },
                    { new Guid("b3dd55b1-1af2-40e3-9945-51d7d2b10b44"), "Nisha", 2, true, true, "Karki", "Maya", "+9779629756380", new DateTime(2025, 5, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7240), "NPV-021-0008", 21 },
                    { new Guid("b4602cf0-4aaa-4599-9fa7-19a30887e381"), "Rupa", 2, true, true, "Maharjan", "Kumari", "+9779622760732", new DateTime(2024, 2, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7940), "NPV-027-0006", 27 },
                    { new Guid("b519a8a0-d2e3-4eb1-af1f-7d93163d1ed2"), "Sita", 2, true, false, "Maharjan", "Maya", "+9779816720096", new DateTime(2024, 2, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8950), "NPV-036-0004", 36 },
                    { new Guid("b56fe07e-19e2-48b2-abc7-6d19fb51534f"), "Ram", 1, true, false, "Nepali", "Prasad", "+9779617212223", new DateTime(2024, 11, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4970), "NPV-002-0004", 2 },
                    { new Guid("b5dc5a9a-0b2c-4613-a849-1721c0325f72"), "Ram", 1, true, true, "Rai", "Bahadur", "+9779882870067", new DateTime(2025, 2, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6140), "NPV-012-0002", 12 },
                    { new Guid("b65566b3-86de-402f-9464-4894a703af7e"), "Nisha", 2, true, false, "Yadav", "Maya", "+9779614660394", new DateTime(2024, 11, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9630), "NPV-042-0001", 42 },
                    { new Guid("b66fa75a-c147-450b-abbf-8de1e970e4f7"), "Shova", 2, true, true, "Magar", "Devi", "+9779617744355", new DateTime(2024, 12, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6820), "NPV-018-0006", 18 },
                    { new Guid("b8261e6e-6ac6-4683-beab-ca25fd6f9f5e"), "Gopal", 1, true, false, "Chaudhary", "Raj", "+9779816745467", new DateTime(2025, 12, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7960), "NPV-027-0008", 27 },
                    { new Guid("b873b3d3-715c-48a0-af20-dd6393b7a868"), "Sarita", 2, true, true, "Khadka", "Kumari", "+9779824659442", new DateTime(2024, 9, 26, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(340), "NPV-047-0008", 47 },
                    { new Guid("b89d295b-384a-40ae-9187-d65a1d3cea77"), "Radha", 2, true, true, "Sharma", "Devi", "+9779763226397", new DateTime(2025, 9, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7690), "NPV-025-0006", 25 },
                    { new Guid("b8d4b339-87fe-425f-a2fe-631b548c8f9c"), "Anita", 2, true, true, "Sharma", "Laxmi", "+9779629270410", new DateTime(2025, 5, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7680), "NPV-025-0005", 25 },
                    { new Guid("b9d9813a-ce28-47cc-96a5-458e769220e4"), "Rupa", 2, true, true, "Karki", "Kumari", "+9779612891792", new DateTime(2024, 11, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7220), "NPV-021-0006", 21 },
                    { new Guid("ba09494b-1798-491f-b7d5-4d20192f8bd9"), "Anita", 2, true, true, "Lama", "Maya", "+9779843080383", new DateTime(2024, 1, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6240), "NPV-013-0002", 13 },
                    { new Guid("bb8d24b8-ea9e-4770-85a4-e8f396045d2e"), "Sarita", 2, true, false, "Magar", "Kumari", "+9779844372080", new DateTime(2025, 5, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5770), "NPV-009-0001", 9 },
                    { new Guid("bbda2981-cc88-49e4-acaa-20e224d84ea6"), "Mohan", 1, true, true, "Shrestha", "Raj", "+9779752097991", new DateTime(2024, 2, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5990), "NPV-011-0003", 11 },
                    { new Guid("bc7c0ea9-8047-4d5e-a134-b62535c71b58"), "Bishnu", 1, true, true, "Maharjan", "Singh", "+9779746678895", new DateTime(2025, 2, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6810), "NPV-018-0005", 18 },
                    { new Guid("bd353d99-322c-4af1-b9f2-484c4e063b09"), "Sarita", 2, true, true, "B.K.", "Kumari", "+9779866298461", new DateTime(2024, 5, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6770), "NPV-018-0001", 18 },
                    { new Guid("bd53824c-8669-4650-807d-2ab52026e312"), "Gita", 2, true, true, "Maharjan", "Kumari", "+9779889005040", new DateTime(2025, 7, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9690), "NPV-042-0007", 42 },
                    { new Guid("bd99a37b-80b2-415a-ab49-265330ff9d81"), "Dipak", 1, true, true, "Magar", "Raj", "+9779811992243", new DateTime(2024, 8, 31, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9480), "NPV-040-0006", 40 },
                    { new Guid("bdb94a95-4c55-45bf-907c-7e107a0fd1ae"), "Suresh", 1, true, true, "Yadav", "Kumar", "+9779865503606", new DateTime(2024, 11, 7, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7840), "NPV-026-0006", 26 },
                    { new Guid("bdbd156f-2ff6-4ce1-8c64-f9938ccf568e"), "Sita", 2, true, true, "Nepali", "Kumari", "+9779801864612", new DateTime(2024, 8, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9640), "NPV-042-0002", 42 },
                    { new Guid("be56df04-103a-455e-a3cd-4dcc3a1ab70a"), "Sunita", 2, true, true, "Khadka", "Maya", "+9779616445767", new DateTime(2024, 7, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8630), "NPV-033-0002", 33 },
                    { new Guid("be5e975a-92c0-4f51-bad1-91980001ea63"), "Suresh", 1, true, true, "Gurung", "Raj", "+9779888560255", new DateTime(2025, 4, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7280), "NPV-022-0002", 22 },
                    { new Guid("beb0806a-2d0b-4460-9660-5989b8d9e089"), "Bikash", 1, true, true, "Chaudhary", "Raj", "+9779613954444", new DateTime(2024, 10, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8710), "NPV-033-0010", 33 },
                    { new Guid("bf09a2c0-e903-4442-849a-de611848a74a"), "Bikash", 1, true, false, "Thapa", "Kumar", "+9779639052520", new DateTime(2024, 2, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5260), "NPV-004-0006", 4 },
                    { new Guid("bf807f75-948b-4938-8ac9-6e68aa5c9f96"), "Rajesh", 1, true, true, "Tamang", "Raj", "+9779621059120", new DateTime(2025, 9, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8300), "NPV-030-0003", 30 },
                    { new Guid("c10fbb65-7895-40da-be60-0ce9515da996"), "Suresh", 1, true, true, "Karki", "Prasad", "+9779741446537", new DateTime(2025, 6, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8700), "NPV-033-0009", 33 },
                    { new Guid("c11fe15e-c395-4c45-9df9-4be2f9130fd4"), "Sabitri", 2, true, true, "Lama", "Maya", "+9779818591388", new DateTime(2025, 4, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6970), "NPV-019-0001", 19 },
                    { new Guid("c3692dcb-6657-43bc-b990-c7760ba8a187"), "Ram", 1, true, true, "Maharjan", "Raj", "+9779801164436", new DateTime(2025, 11, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6610), "NPV-016-0005", 16 },
                    { new Guid("c4262e55-6c46-4496-a39c-6e7c7e057638"), "Rajesh", 1, true, false, "Karki", "Singh", "+9779614149497", new DateTime(2025, 1, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8870), "NPV-035-0006", 35 },
                    { new Guid("c44beb8e-21a8-471e-b313-73d8d6748fae"), "Parbati", 2, true, true, "Magar", "Kumari", "+9779761056843", new DateTime(2024, 12, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5120), "NPV-003-0008", 3 },
                    { new Guid("c5dc1d87-4a01-4ecc-b38c-1987283971e7"), "Nabin", 1, true, false, "Karki", "Singh", "+9779885499453", new DateTime(2024, 4, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9340), "NPV-039-0007", 39 },
                    { new Guid("c6faf413-bd2c-4fff-bbfc-be260f0e43ab"), "Nisha", 2, true, true, "Thapa", "Laxmi", "+9779806856132", new DateTime(2024, 3, 20, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6220), "NPV-012-0010", 12 },
                    { new Guid("c7d64769-e619-4bba-9cf5-4b98bf04c088"), "Rajesh", 1, true, true, "Nepali", "Bahadur", "+9779809514789", new DateTime(2024, 6, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6700), "NPV-017-0004", 17 },
                    { new Guid("c89721e4-dbde-4ce4-aec6-a782d7a40599"), "Ram", 1, true, true, "Yadav", "Kumar", "+9779639734724", new DateTime(2025, 11, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9180), "NPV-038-0001", 38 },
                    { new Guid("c89812e1-728f-4398-a5b2-cf8652394939"), "Prakash", 1, true, false, "Tamang", "Kumar", "+9779622881773", new DateTime(2025, 9, 18, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(90), "NPV-045-0003", 45 },
                    { new Guid("c8a3e30f-8025-4d0a-b9e3-4233776039e1"), "Laxmi", 2, true, false, "Karki", "Devi", "+9779759498916", new DateTime(2025, 11, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7090), "NPV-020-0003", 20 },
                    { new Guid("c912fc86-a14b-4619-9b5d-3a0791656087"), "Sita", 2, true, true, "Shrestha", "Kumari", "+9779824083816", new DateTime(2025, 11, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5860), "NPV-009-0010", 9 },
                    { new Guid("c91aa773-ec8b-451c-bc60-729ee2795fae"), "Shova", 2, true, true, "Rai", "Devi", "+9779619853543", new DateTime(2024, 2, 26, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(220), "NPV-046-0006", 46 },
                    { new Guid("cb836e34-4b86-4dd5-a713-0bb18d4fbfbe"), "Sarita", 2, true, true, "Nepali", "Maya", "+9779824643153", new DateTime(2025, 12, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6690), "NPV-017-0003", 17 },
                    { new Guid("cb9161ba-f792-4d27-a4a8-53989884c80d"), "Rajesh", 1, true, true, "Thapa", "Prasad", "+9779626376755", new DateTime(2025, 2, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9100), "NPV-037-0003", 37 },
                    { new Guid("cc40f930-2d8a-4c43-b0f7-01daf822fa8e"), "Gita", 2, true, true, "Karki", "Kumari", "+9779883548798", new DateTime(2025, 2, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7500), "NPV-023-0007", 23 },
                    { new Guid("cd4caa97-8d0f-4b46-87f9-040e6f84b317"), "Maya", 2, true, true, "Chaudhary", "Laxmi", "+9779808261346", new DateTime(2024, 6, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4900), "NPV-001-0007", 1 },
                    { new Guid("ce45dd22-c18d-415b-b301-661e315e8fcb"), "Sita", 2, true, true, "Nepali", "Kumari", "+9779852624991", new DateTime(2023, 12, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6400), "NPV-014-0007", 14 },
                    { new Guid("cec64d21-0dbc-4845-a9a5-20de0071f2d2"), "Nabin", 1, true, true, "Yadav", "Kumar", "+9779625245555", new DateTime(2025, 3, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7450), "NPV-023-0002", 23 },
                    { new Guid("cef32485-dde8-457d-bf04-7f5c9d5b591a"), "Maya", 2, true, true, "Karki", "Kumari", "+9779857445104", new DateTime(2025, 8, 10, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7030), "NPV-019-0007", 19 },
                    { new Guid("cf2f997d-34cb-4c96-8dd4-1ae654913a5c"), "Dipak", 1, true, true, "Yadav", "Kumar", "+9779757258703", new DateTime(2024, 9, 17, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(240), "NPV-046-0008", 46 },
                    { new Guid("d0a8d518-4570-48f9-85f8-7306651d5124"), "Laxmi", 2, true, true, "Lama", "Maya", "+9779802071715", new DateTime(2025, 7, 3, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(320), "NPV-047-0006", 47 },
                    { new Guid("d155459c-1b6f-4580-8dd7-eba327b45ab3"), "Nabin", 1, true, true, "Magar", "Prasad", "+9779844810001", new DateTime(2024, 7, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9830), "NPV-044-0001", 44 },
                    { new Guid("d16250e4-f4a2-4724-8a09-b9d2ef5e03d9"), "Sarita", 2, true, true, "Shrestha", "Maya", "+9779635042791", new DateTime(2025, 10, 31, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9200), "NPV-038-0003", 38 },
                    { new Guid("d2da34f8-729e-42f2-9b74-78af1c7d600c"), "Hari", 1, true, true, "Rai", "Bahadur", "+9779827068270", new DateTime(2024, 1, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9230), "NPV-038-0006", 38 },
                    { new Guid("d2f12985-2b0a-4b18-9027-d3d56e063db1"), "Maya", 2, true, true, "Rai", "Laxmi", "+9779842240884", new DateTime(2024, 9, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6370), "NPV-014-0004", 14 },
                    { new Guid("d4b342ec-29a2-4b19-a693-3ecb6d0d9ba8"), "Arjun", 1, true, true, "B.K.", "Raj", "+9779825873444", new DateTime(2025, 9, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6130), "NPV-012-0001", 12 },
                    { new Guid("d56ad508-68a9-4544-9767-eee4efc41920"), "Rekha", 2, true, false, "Yadav", "Kumari", "+9779806784796", new DateTime(2024, 11, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5040), "NPV-002-0010", 2 },
                    { new Guid("d635069c-eea2-4480-9211-a8b4dea872f6"), "Mohan", 1, true, true, "Thapa", "Singh", "+9779888597957", new DateTime(2025, 1, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8750), "NPV-034-0004", 34 },
                    { new Guid("d6fbf3b0-30a9-44ec-aa9d-0a1919aa6a85"), "Radha", 2, true, true, "Chaudhary", "Laxmi", "+9779849026575", new DateTime(2025, 11, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6010), "NPV-011-0005", 11 },
                    { new Guid("d73ab184-6cd2-4505-a641-de1e028b901d"), "Maya", 2, true, true, "Magar", "Laxmi", "+9779622475687", new DateTime(2025, 10, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5940), "NPV-010-0008", 10 },
                    { new Guid("d7c2f5f1-cace-4157-bf36-32b8e5597a33"), "Prakash", 1, true, true, "Karki", "Bahadur", "+9779765441695", new DateTime(2025, 8, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9320), "NPV-039-0005", 39 },
                    { new Guid("d8c791bc-07c9-4496-91e5-cc48b00f5fcb"), "Sarita", 2, true, false, "Thapa", "Devi", "+9779631379770", new DateTime(2025, 11, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7270), "NPV-022-0001", 22 },
                    { new Guid("d8f252be-97a8-47b4-a07a-5035861259db"), "Rupa", 2, true, true, "Chaudhary", "Laxmi", "+9779802096422", new DateTime(2024, 7, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7150), "NPV-020-0009", 20 },
                    { new Guid("d902979d-5ffb-4d2f-b5e9-e392317d769f"), "Gopal", 1, true, true, "Gurung", "Prasad", "+9779846085034", new DateTime(2024, 12, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7160), "NPV-020-0010", 20 },
                    { new Guid("d9285da6-f8c4-4b8a-9315-1202d87acc35"), "Arjun", 1, true, true, "Magar", "Kumar", "+9779888139822", new DateTime(2024, 2, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9350), "NPV-039-0008", 39 },
                    { new Guid("da1f7c1b-b411-4f45-b9bf-d9b0889c2a8e"), "Mohan", 1, true, true, "Gurung", "Singh", "+9779742750955", new DateTime(2024, 5, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6530), "NPV-015-0007", 15 },
                    { new Guid("da31829e-c145-4cf0-b46c-22fcf372eda6"), "Shova", 2, true, true, "Chaudhary", "Devi", "+9779848927955", new DateTime(2024, 2, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8760), "NPV-034-0005", 34 },
                    { new Guid("da922def-31cf-42f1-afaf-ed940793bf8d"), "Parbati", 2, true, false, "Khadka", "Kumari", "+9779807861216", new DateTime(2024, 7, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5920), "NPV-010-0006", 10 },
                    { new Guid("db373d77-b678-43f6-a5d9-a4315e42d9e4"), "Krishna", 1, true, true, "Yadav", "Prasad", "+9779762968494", new DateTime(2025, 1, 6, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(70), "NPV-045-0001", 45 },
                    { new Guid("dbcad8a0-fa7d-49d7-8624-d060eabb1ed3"), "Laxmi", 2, true, true, "Chaudhary", "Laxmi", "+9779813739577", new DateTime(2024, 11, 3, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5930), "NPV-010-0007", 10 },
                    { new Guid("dbd695c8-9988-4911-88dc-0a90458982d4"), "Sarita", 2, true, false, "Tamang", "Devi", "+9779631824120", new DateTime(2024, 2, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8220), "NPV-029-0005", 29 },
                    { new Guid("dc5e553f-43e9-400d-acb2-69de7f98ea8c"), "Gita", 2, true, true, "Gurung", "Maya", "+9779805944366", new DateTime(2025, 11, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8930), "NPV-036-0002", 36 },
                    { new Guid("dc9e1905-107c-451e-915c-63c5bb9a28f1"), "Rekha", 2, true, true, "Sharma", "Devi", "+9779749978553", new DateTime(2024, 3, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7740), "NPV-026-0001", 26 },
                    { new Guid("dca1a39e-15e9-415f-a4ae-62126559c981"), "Nisha", 2, true, true, "Lama", "Maya", "+9779744578125", new DateTime(2025, 4, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7210), "NPV-021-0005", 21 },
                    { new Guid("dceee0e9-139f-4d68-b2bf-86d5db4ee4ff"), "Sarita", 2, true, true, "Nepali", "Kumari", "+9779881317507", new DateTime(2024, 1, 27, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(480), "NPV-048-0004", 48 },
                    { new Guid("de1c15de-20fc-40a8-a09b-df62011dae9b"), "Radha", 2, true, true, "Shrestha", "Maya", "+9779769549999", new DateTime(2024, 9, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9780), "NPV-043-0006", 43 },
                    { new Guid("de3d87cc-0141-41af-b781-926785c624d6"), "Sarita", 2, true, false, "Lama", "Laxmi", "+9779813345908", new DateTime(2024, 2, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6200), "NPV-012-0008", 12 },
                    { new Guid("df405ecf-6f45-46cb-a3d1-a2d36a3e8c20"), "Bikash", 1, true, true, "Lama", "Singh", "+9779847784190", new DateTime(2024, 2, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6230), "NPV-013-0001", 13 },
                    { new Guid("e0396370-2361-4f6b-88d6-4e12da1b6fdb"), "Parbati", 2, true, true, "Karki", "Maya", "+9779846112744", new DateTime(2024, 11, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7640), "NPV-025-0001", 25 },
                    { new Guid("e04719b4-b5f9-4ca5-9f95-48de2100b258"), "Prakash", 1, true, true, "Karki", "Singh", "+9779808553871", new DateTime(2024, 12, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7780), "NPV-026-0005", 26 },
                    { new Guid("e1272df2-0ef7-4b15-ab50-0eb9f669491b"), "Shyam", 1, true, true, "Thapa", "Bahadur", "+9779746791152", new DateTime(2024, 10, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5310), "NPV-004-0010", 4 },
                    { new Guid("e20bffe1-570b-4253-bce5-04c7245a8af4"), "Sita", 2, true, true, "Rai", "Laxmi", "+9779828437971", new DateTime(2025, 1, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8860), "NPV-035-0005", 35 },
                    { new Guid("e2f55dd7-6900-4990-84c6-9fbc9367fb0b"), "Ram", 1, true, true, "Lama", "Singh", "+9779614243153", new DateTime(2024, 5, 15, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6210), "NPV-012-0009", 12 },
                    { new Guid("e312b9b5-f03d-469d-8eda-96d2432ca5f7"), "Bikash", 1, true, false, "Yadav", "Singh", "+9779763793942", new DateTime(2024, 5, 13, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5070), "NPV-003-0003", 3 },
                    { new Guid("e369350c-231a-45c3-90fe-04016b8e9e24"), "Prakash", 1, true, true, "B.K.", "Bahadur", "+9779801119890", new DateTime(2025, 4, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6760), "NPV-017-0010", 17 },
                    { new Guid("e37a19bd-8fc6-4edb-b593-ef5466aaebb0"), "Nisha", 2, true, false, "Magar", "Kumari", "+9779765928674", new DateTime(2025, 2, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9560), "NPV-041-0004", 41 },
                    { new Guid("e3984cc9-452a-4457-a6bd-5f55e290633a"), "Anita", 2, true, true, "Tamang", "Devi", "+9779859359644", new DateTime(2024, 9, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8310), "NPV-030-0004", 30 },
                    { new Guid("e422731f-6678-453e-936e-840531597881"), "Maya", 2, true, true, "Nepali", "Devi", "+9779752984195", new DateTime(2025, 4, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6630), "NPV-016-0007", 16 },
                    { new Guid("e434ee53-5a79-4b3d-b210-cbb5b175eac1"), "Hari", 1, true, true, "Gurung", "Singh", "+9779617689314", new DateTime(2025, 10, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8170), "NPV-028-0010", 28 },
                    { new Guid("e4a8c818-86fe-417c-aa87-69e493204d0c"), "Laxmi", 2, true, false, "Tamang", "Devi", "+9779612810948", new DateTime(2024, 4, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7650), "NPV-025-0002", 25 },
                    { new Guid("e4e1dc3e-539b-4947-a62f-05d524eafafe"), "Sunita", 2, true, true, "Lama", "Laxmi", "+9779623422049", new DateTime(2025, 5, 31, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7550), "NPV-024-0002", 24 },
                    { new Guid("e4e639dd-4f46-4977-affc-3a95762c04f1"), "Hari", 1, true, true, "Lama", "Singh", "+9779613921491", new DateTime(2024, 9, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6390), "NPV-014-0006", 14 },
                    { new Guid("e5361b8a-41f0-43c6-9752-c8f5dc45dfb3"), "Nisha", 2, true, true, "B.K.", "Laxmi", "+9779625972517", new DateTime(2023, 12, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8130), "NPV-028-0006", 28 },
                    { new Guid("e550e4a6-0184-4470-a98e-42cb204b95fa"), "Santosh", 1, true, true, "Lama", "Singh", "+9779824202833", new DateTime(2025, 7, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5160), "NPV-004-0002", 4 },
                    { new Guid("e68bee12-45d7-4e3f-a1e4-a6f29e1d1210"), "Dipak", 1, true, true, "Shrestha", "Singh", "+9779859142779", new DateTime(2024, 9, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7520), "NPV-023-0009", 23 },
                    { new Guid("e754f5fd-456d-4543-ae23-d24f69209896"), "Rekha", 2, true, true, "Tamang", "Kumari", "+9779869459355", new DateTime(2024, 7, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7920), "NPV-027-0004", 27 },
                    { new Guid("e76df00d-32fe-462d-b520-4fa67b51e7d9"), "Sunita", 2, true, true, "B.K.", "Laxmi", "+9779866241433", new DateTime(2024, 3, 20, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(50), "NPV-044-0009", 44 },
                    { new Guid("e83d56c3-b28d-4a9c-ab00-fb6c10250167"), "Sunita", 2, true, false, "Sharma", "Maya", "+9779636903389", new DateTime(2025, 9, 4, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9770), "NPV-043-0005", 43 },
                    { new Guid("ea9f1120-d751-43ac-a1a2-abe2f2c75875"), "Suresh", 1, true, true, "Karki", "Bahadur", "+9779841279030", new DateTime(2024, 11, 23, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6660), "NPV-016-0010", 16 },
                    { new Guid("ead98b01-f228-4731-8ee2-620ebf317b2e"), "Sabitri", 2, true, true, "Yadav", "Devi", "+9779889765692", new DateTime(2024, 5, 9, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5540), "NPV-007-0004", 7 },
                    { new Guid("eb787543-ddcf-4930-9bb6-7536f433eb59"), "Suresh", 1, true, false, "Khadka", "Raj", "+9779829773828", new DateTime(2025, 10, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8800), "NPV-034-0009", 34 },
                    { new Guid("ebe93bb3-96a2-4fa8-9771-9a083cc05f89"), "Sunita", 2, true, true, "Yadav", "Maya", "+9779752453971", new DateTime(2024, 4, 2, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9210), "NPV-038-0004", 38 },
                    { new Guid("ec1a4438-44e6-4289-acda-bb25e24e62ca"), "Nisha", 2, true, true, "Maharjan", "Laxmi", "+9779886725314", new DateTime(2025, 5, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6490), "NPV-015-0003", 15 },
                    { new Guid("ed04a357-df21-40d8-b44b-897577c13fa4"), "Hari", 1, true, true, "Sharma", "Kumar", "+9779634509896", new DateTime(2025, 4, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5100), "NPV-003-0006", 3 },
                    { new Guid("eda85106-9055-40c1-9587-4d4c6ddeec51"), "Arjun", 1, true, true, "Nepali", "Kumar", "+9779808581789", new DateTime(2025, 9, 22, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8390), "NPV-031-0003", 31 },
                    { new Guid("edaa0578-e07a-4195-b78d-3759ccfa1a99"), "Radha", 2, true, true, "Thapa", "Laxmi", "+9779754301602", new DateTime(2024, 8, 24, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(290), "NPV-047-0003", 47 },
                    { new Guid("edc51ff4-39ec-4861-93e2-ce1e2bb97e54"), "Nisha", 2, true, true, "Rai", "Laxmi", "+9779884047767", new DateTime(2024, 5, 21, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6620), "NPV-016-0006", 16 },
                    { new Guid("eee5f981-d2fc-4adb-85ba-f908db6705aa"), "Anita", 2, true, true, "Tamang", "Devi", "+9779636656447", new DateTime(2025, 12, 18, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(500), "NPV-048-0006", 48 },
                    { new Guid("f09d5943-c3d6-4915-a455-06242f8ec60e"), "Radha", 2, true, true, "Lama", "Laxmi", "+9779817406901", new DateTime(2025, 3, 29, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(40), "NPV-044-0008", 44 },
                    { new Guid("f0c2f46a-21b4-49ae-b113-a80a10721309"), "Dipak", 1, true, true, "Nepali", "Raj", "+9779803665540", new DateTime(2024, 11, 19, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8770), "NPV-034-0006", 34 },
                    { new Guid("f1188189-2081-4ae4-a9fa-34b84484e7e9"), "Shyam", 1, true, true, "Khadka", "Raj", "+9779861412899", new DateTime(2024, 1, 29, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8910), "NPV-035-0010", 35 },
                    { new Guid("f127d0ec-5f06-48cd-9e8d-ac4618754e83"), "Ram", 1, true, false, "Thapa", "Kumar", "+9779759586552", new DateTime(2024, 8, 11, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5430), "NPV-006-0003", 6 },
                    { new Guid("f1d3de2a-b522-4b9b-a606-a89c68f14347"), "Bishnu", 1, true, false, "B.K.", "Raj", "+9779885408046", new DateTime(2025, 2, 6, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7510), "NPV-023-0008", 23 },
                    { new Guid("f1f35836-fcba-4c07-a81c-a1afc403adc2"), "Mohan", 1, true, false, "Sharma", "Bahadur", "+9779881779687", new DateTime(2024, 11, 26, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5870), "NPV-010-0001", 10 },
                    { new Guid("f3e1dfb7-10aa-4430-ae65-c7beed7396bc"), "Sabitri", 2, true, true, "Rai", "Laxmi", "+9779861619016", new DateTime(2025, 10, 5, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8460), "NPV-031-0010", 31 },
                    { new Guid("f5194610-45c0-43ae-9592-adec7eb72a4c"), "Nisha", 2, true, true, "Khadka", "Kumari", "+9779821899771", new DateTime(2024, 11, 8, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6800), "NPV-018-0004", 18 },
                    { new Guid("f687b9bc-e36d-434d-9e2c-e203f41e88fa"), "Suresh", 1, true, true, "Yadav", "Prasad", "+9779765376748", new DateTime(2025, 6, 14, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6790), "NPV-018-0003", 18 },
                    { new Guid("f71b0901-ce9e-4ebe-894a-1013f42e2dbf"), "Gita", 2, true, true, "Rai", "Maya", "+9779626002870", new DateTime(2024, 11, 24, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9760), "NPV-043-0004", 43 },
                    { new Guid("f7570f03-b803-4d4b-a065-008aa02f2244"), "Ram", 1, true, true, "Yadav", "Bahadur", "+9779886326554", new DateTime(2025, 8, 27, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5090), "NPV-003-0005", 3 },
                    { new Guid("f7d227c9-3ffd-4541-99ee-8f50c9985506"), "Mohan", 1, true, true, "Tamang", "Prasad", "+9779859853053", new DateTime(2024, 6, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8560), "NPV-032-0005", 32 },
                    { new Guid("f8eb0f7a-e20c-4422-84c5-b4bcdde1265c"), "Nabin", 1, true, true, "Lama", "Raj", "+9779841001225", new DateTime(2024, 1, 18, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(7310), "NPV-022-0005", 22 },
                    { new Guid("fa768f85-fd1a-4dbb-8bae-816c881e1705"), "Anita", 2, true, false, "Maharjan", "Laxmi", "+9779768745017", new DateTime(2025, 8, 30, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(9240), "NPV-038-0007", 38 },
                    { new Guid("fabda38b-efc9-406b-b5c7-f7e3d5a8cfcd"), "Ram", 1, true, false, "Thapa", "Singh", "+9779615345309", new DateTime(2024, 8, 28, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6030), "NPV-011-0007", 11 },
                    { new Guid("fb4daf5d-e463-45b5-be85-5648330ddc05"), "Anita", 2, true, true, "Chaudhary", "Devi", "+9779846065592", new DateTime(2025, 1, 7, 5, 23, 36, 945, DateTimeKind.Utc).AddTicks(510), "NPV-048-0007", 48 },
                    { new Guid("fc488e15-2ece-442c-9dab-9306d9d35f5c"), "Rupa", 2, true, true, "Chaudhary", "Maya", "+9779843209537", new DateTime(2025, 12, 1, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(6940), "NPV-018-0008", 18 },
                    { new Guid("fcc57b1c-f73a-452b-a837-408c9b59d69e"), "Shyam", 1, true, true, "Sharma", "Bahadur", "+9779819144300", new DateTime(2024, 6, 17, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(5460), "NPV-006-0006", 6 },
                    { new Guid("feb3dac9-1996-44e4-984f-131f0dcdfbd3"), "Maya", 2, true, true, "Rai", "Maya", "+9779761087465", new DateTime(2024, 4, 25, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(8250), "NPV-029-0008", 29 },
                    { new Guid("feecd9fd-2025-4a44-91e9-d77328981879"), "Gita", 2, true, true, "Sharma", "Kumari", "+9779632454605", new DateTime(2024, 10, 12, 5, 23, 36, 944, DateTimeKind.Utc).AddTicks(4940), "NPV-002-0001", 2 }
                });
        }
    }
}
