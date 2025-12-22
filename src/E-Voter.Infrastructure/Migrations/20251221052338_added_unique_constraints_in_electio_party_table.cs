using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Voter.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_unique_constraints_in_electio_party_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("009d8e01-7480-486b-aa6c-3a664388145c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("00c3d568-7aca-4939-a797-af2061f73a5d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("015feef2-1c9b-4002-aced-0f0044044594"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("020540ca-0996-4a96-ad1f-af39dc490e59"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("025fab8f-121e-435f-9ca1-4bdf52916ba2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("02641d84-6a06-4990-b00b-125baabb9edb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0287e825-43bd-442d-8743-9748b81e1829"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("02d85328-8760-436c-be7f-96cccf5a1cb5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("033cd4ca-57b8-462c-82d1-6f4c36ac8722"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("035f0554-7b90-4c01-9bd5-d9065f778e2e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("03ac3f4e-dcfc-4b34-9136-f50d99aee4ec"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("03e89bfc-a666-433a-8a88-256feb662fe9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("043cc76e-bd98-44e1-8005-dca73afe6530"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("05099b6c-a16d-41ef-8b5f-d0c82f066337"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("05354ba0-9912-4621-9b9c-0340bb89accd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("056adbe0-79c5-46ce-b68d-3c6d51affbe0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("067a0c37-2e70-4853-9992-3dd871cab61d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("07dac920-be48-440f-88a5-5cde87b38660"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("081f771c-badc-4c8c-b494-ba3b40bbc389"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("08b77735-d948-4f3e-972e-d0694399a1fb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("08f683c9-c4a8-43fe-9198-6d0b34c57033"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0ac5dd4c-bc08-4e27-aa0d-638b4e07bbc0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0c30f23f-bae9-46e1-ba3e-f2d8a5243118"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0ca4e642-1762-4deb-bebe-ee04f29a310c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0cb09f49-daef-40de-a0a9-a79424d20959"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0cb9ae6b-facc-4113-bb4a-556d0b7cc3cb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0cbde89b-370e-41e7-b33a-fd8d13b862b3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0d07be26-ee75-4333-9e0a-94715dc90cc0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0df91346-26ad-4292-a04a-38e95c78310b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0dfe85d7-8cd7-4f59-b365-2623e52a4a96"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0e6ae559-c504-49a2-b07f-27509ca500ef"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("0fb5488d-640d-4aac-b25c-a64611da3596"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1061378a-cc43-4870-b9fe-3c8cf8eba8d8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("129318fa-058b-4acc-8d03-1e083e898f07"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("14bda5d0-2429-483a-9f73-b1abf56a323d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1539f66b-0bcc-4161-8b20-063719c7aca5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("157a3095-b07b-4fd5-9bef-3827e3a50adc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1635a362-1ee9-448d-857d-c44bdd69838d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("16e0a1ae-1f0e-41ea-8421-46244c780fb4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("17dca75c-1c4a-4f9e-8e7d-1d6cedeaa5cd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("19660658-e2e2-4575-8d95-6e15468f45d6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1996e4eb-521b-4f9f-af65-0cfea78357b2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("19f329b0-a88c-4240-826f-39cbd0b2aa18"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1b363d9d-7027-46e1-9752-e989d736187f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1bc01e6d-0bee-429a-9a73-0d05cb699ea1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1c3d363b-9107-4a9f-b602-a6e0e9302826"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1c61e3b4-ca29-460b-aca0-b1a3fbcee4c9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1cd0b3e3-fb83-4c79-be64-9e1c8df24bb7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1d0e017c-e31f-490f-8d25-c959b1029bb8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1d4bdbd7-823c-44d4-8f98-b89e84f5cfb8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1dc4b86c-b9d2-4213-953b-5cbfa1d2505c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1ec17846-d224-4719-bc52-a4d5861f8f4e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1ef3a079-bcfd-4901-b187-ac7d5f0bf945"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("1f5dabbb-1d5e-4b7c-84b2-39e62721af81"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("206da60c-2910-409d-81f9-c4f33cba6427"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("211f09dd-61df-4fad-8c86-ad24b10c3c43"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("218da2e8-4f08-40a5-b0ee-46920742644e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("21a5c9a2-beea-4852-9b89-16aee0e59d39"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("21ef3237-da99-40f6-918c-b7bb61a96067"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2203b92f-be31-4abc-aab5-a0f3c4d0a983"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("23611a12-fb42-4166-837e-fc20ca3d64e3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("23c5beb9-5240-4b2e-b531-fcd9d9166c65"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("24e43caa-2d91-46df-aa4f-fc277ba4679f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("25ac08ed-6f8c-41c0-bbb9-21b4429c8278"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2682478f-59dd-4a84-8640-7314f60ec3bd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2697ba0e-0c73-44d2-aa24-efc860729283"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("275643fb-a164-498e-82fc-13b818208958"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("276136cf-97e0-4a6c-b586-5be0f8b730bd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("27614eac-686c-4661-9519-be95b8ec5884"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("27953411-ec2d-4bc2-82f6-4144c69aea2b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2996ae63-6ef1-4955-8c67-09eab68c4f6f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("29f9b786-ec6a-4646-ac90-0a110f3a5329"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2a58c78c-f3ae-4565-999e-61a3ed003263"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2a7e2cc2-bfba-4e41-a00a-b25687209703"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2ac2f1b4-712f-4548-a1bb-b2aefc34b3be"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2b4d6d1b-2232-4e88-b1e2-7742c099367c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2b666953-bb58-4e7b-9ca4-e93e46bd8977"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2b7dbf1e-59c7-45df-8c93-c724c062b717"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2bd23c20-6ab7-4ac6-a4fd-b6986f8c814e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2bd56bd1-8e53-408c-b524-77f648ac6cc2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2c85d2c1-4543-4103-a4d8-f3968b429c3c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2cd8542c-e479-4ffc-b861-891126dc8a31"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2d08e82a-9d98-4431-8f52-ec7f7c06f085"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2d505779-4236-4ca1-a367-543caa186f4e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2d8f6695-3a6a-42cd-9b9c-c03e9d85759e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2ef9e75c-aeeb-472d-9f71-c0d28edfe343"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2f018f25-0e6c-4c35-8868-0a4c0bc9f253"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2f0521ac-a394-446e-bcaf-4101770c22f2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("2f091680-b0f9-4bbc-b62f-f1df221bb8ef"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("31268aa8-3c50-4aea-8161-3d1df52cfd41"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("31a6c8e9-f204-4770-9bff-ff524f09d5ce"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("33cd76e3-8bcc-4eec-96d6-b158bb84027e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("35682bc3-41a0-4938-b319-35ea9540caa0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("35db2f3a-dac3-4a44-b653-0699866f9c3b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("36499fa3-d19a-4f3e-a68b-bd26a8565ecc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3701b691-33a4-4073-a9e6-e1782d9e475f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3849cdeb-82e6-4885-a65c-b9ea059ea1e1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3897db2d-2a3e-41cb-b5cf-0e6a7653dfbd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("389f6602-67ce-466c-b58d-1892cc6da748"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("38c5bb91-9332-4953-b83f-680c498144ab"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3902fb2b-e013-450d-a241-63b183ab8ede"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("395d1a2e-619e-4951-a6c0-5e6865a5b65b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3a7c47f3-1f58-41d2-a44b-85d44e092f58"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3b2e0509-b0fc-4b10-82e6-9569c65b6d2c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3bcfaf40-afb5-4067-aa47-06456dbd730a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3bea5a20-ddbe-4b32-8871-4528821bb051"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3c2db403-6099-4d58-b3ea-84af624526a8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3c4018df-3e65-4004-94df-489f8062c5dc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3c793d3e-c269-4c40-bf5d-06201f4008e4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3d2b8e09-d9e5-4653-9fe6-0c442f0d3604"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3dabe9ee-521d-4093-8feb-3e7b3d92435a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3e97030e-85f8-4bb2-8875-de739250afd7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3e9cf725-d38f-4bf1-b004-6ff1c055dbf9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3ea914b6-b17f-4146-b182-a021e8fbbbf1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("3f0c27bd-33e5-41ae-b2c8-733f2c5cbed8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("402dd7fe-da8f-48ba-bdb7-bd9a67427f04"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("406e6efe-0cb6-43d6-bd1d-af7e32552f18"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("406e729e-7063-4482-b5fd-5a14293a8f6b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("40b58bf1-3799-407f-84fc-c7ba31ff2458"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4127ba81-2dda-4cda-bc81-1075d4fd68a6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("412c99b5-c0d4-4680-96f6-47eb2e2b8ab0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("421aefc4-3881-492c-82c2-8589ae1ac78b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("42c9c9a3-d193-4da3-a6f2-a9b91b88c494"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("43782e5d-7bc9-478c-8a9d-05b6c9439368"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("43822f2f-76e3-4184-864a-a01b2fbaaf44"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("438da773-7aee-4d18-af2e-3ee6df7f264d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("44258f33-2902-46c6-9029-f088b37e6340"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("44ae306f-f06c-4b7b-949e-1e43cd9b8eee"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("453123cf-b1c8-4ac1-810d-c706dd3824ac"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("468f1a86-49f7-45f6-8c26-5752c0646f89"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("46ce83d2-ee4c-42a0-bfce-28dbd0a51879"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("473116a2-b9c9-4fa2-9c88-803c4f3be5a6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("47484fd3-6402-4372-8dcc-3c57997eb173"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("47bc285b-2b68-476f-b529-66ec1f91e677"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("47cc8faf-c1dc-4b0c-9f03-4d35872f05a7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("480e93a5-6259-4e58-b1b2-60932a973ae1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("48917392-ee92-405e-80f0-66a3fe3380e0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("48917f78-b321-4ffb-bb29-b3b4198e79cd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("489b2288-5c3c-459d-9df4-61a98df844b0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("48e135b2-0d7c-427a-a39f-dba7312cbeb9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("49b11faa-5d26-41a1-815c-dcbcff5fde69"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("49f29825-c3ed-4d53-97f7-7e9d387b65d6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4a944d6e-2b54-4286-96b3-d891c80e066c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4b3fd694-5798-46c2-9e82-fbbdae3580d4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4c0bd36c-d9bd-425e-a3df-b942e021e3c4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4c683aaa-0333-4448-af97-ca7cfe1e4806"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4cd0e152-7e61-4369-9768-083bc1f3b815"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4d11834b-661c-4feb-baab-2d11051447be"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4d9ca8ef-4484-4e13-9559-37e8328905ce"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4e5005cb-28c3-4525-bf49-cf176181dbe5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4eaacfb9-3f4a-4337-aa25-ddd5e5980757"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4ef78f91-689d-4e5e-9b9d-61feb4825f5e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("4f6e54f9-0fc7-404d-a187-54e377b74b0c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5032c8b6-0ee7-48f0-b2ba-b22ed8359d7b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("50b84b21-1784-4df1-b271-f1902f49eb12"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("50ca2529-0210-485b-b81c-908dfecee87f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("50d37d73-4a15-48ae-8085-60423e1eb40c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("514e4fd7-0db3-4650-a31d-fd7c0c6ef582"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("51a5ae30-dbf8-4c5c-83dc-c218fe3fe801"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5223460b-31b4-4fad-89ac-188adcd41f0c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("52460fe8-18f1-41fd-af63-e07df5d2c0f5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("540b4e51-e5e8-4b21-8a11-30b332442d42"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("555ba255-b750-4653-afb3-c60df2cf1bdd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("55af3210-0952-437a-a7f2-6539618ca128"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("569121b9-faae-42e0-a5d6-ff026a9ce3b2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("58476f4d-66f4-4940-ae4b-777155e978ff"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("589a0783-2297-4137-a668-ee366dc3bafd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("58c47205-a8f0-46ed-a694-b2bcc326e9f1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("593d23f8-ba40-4b59-a25b-30b98f6b562e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("593e9cf7-b85a-4046-8adc-50cc5e686775"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("596ad47c-e647-46a3-9f7e-a97227b9519d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5a8f909f-1e12-415d-a6c9-6bc144b857da"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5ae252ac-ca43-41e6-9294-75e8b245ca89"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5b9b0430-2440-4b27-b064-b15abddc0480"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5ba21a8b-b2cb-4c9c-acb9-097cf420c794"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5bef65b0-c678-4ea7-b788-0623b33fea77"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c2a9399-b471-470e-9a63-dd5e734363db"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c46507c-7bb4-402e-ae07-e4e929fd718d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c4654f9-b5bc-41b3-beab-fe47593a8a45"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5c99cbec-c5a0-466d-b745-02e5ed2b78e1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5cb06d68-80e9-4f86-97e0-d6e183eff826"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5cf98f7a-8fdb-4bc5-a9a7-fc3422d783e7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5d0f7183-0207-4f4f-9104-633d24d52633"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("5e6223be-5b8a-4f85-bf85-a487a69d2d51"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("605f5076-1994-435e-ba47-6194970df393"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6194bc08-d615-47ad-919f-51284978622f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("61d8cb3e-f38b-4adb-81d7-5163543dc958"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6261116d-ddb2-4214-84db-0519e007f515"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("62ae2726-30bb-4bae-8354-9d93cd1b32dc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6327ec1d-fd99-4dcd-836a-624f2ed53214"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("63b377a2-a5f9-43fc-80bb-7135344369ef"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("63b9ecac-fd66-436d-bd3b-832ee050eea3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("640c5467-eb63-42f6-9b3e-21fd310dbe81"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6439bf57-5b5d-4412-819b-bedfce233246"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("65f66d7c-72bc-47db-99b0-1902483d7660"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("68746f2b-ce3e-4b6b-b3fb-f2cea0cb96fb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("688bf43f-d661-4d49-b7cf-4cceff09490f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("68c97161-e5ce-4302-a871-3e746af4cf59"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("698f2e54-2960-4a55-bee5-2f1b125fe444"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6a81f38e-8b02-4caa-883e-da3a2666fca3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6b08f3aa-0efa-4f22-af71-b85c522aad03"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6b3d103b-77ed-4b6f-9154-41aa33b63569"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6b5b5aa6-6cda-4eed-ac43-bc2747e71366"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6b934704-4dcb-484f-bf0c-46034b5ec6c0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6c6aa141-6a9e-4a17-a215-32b5b9eb146b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6d3279eb-0268-4cd5-be00-7bcb8b7cfc98"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6d4bc376-8c9e-4f81-8997-097eb30516c8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6dc1d417-7cd7-49c1-bb35-2e7ae24c4eb5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6e2c70dd-0028-4e19-a1e7-34c9660b6937"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6ea849f3-337c-43a8-aee0-3de335af958e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6f64b17d-de5c-4b33-afe4-753cdf67c071"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6f7f31fd-7fb5-42e7-952f-f413342a2125"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6fa5a210-6b81-4164-b92a-c5a281fac191"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("6fb7956a-aedc-4507-8dbc-a4b7f8ddf18c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("709306de-e9e3-4724-b6c8-22ad364405a1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("70c0e3ee-d781-4a79-bd4e-a619f32f6e13"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("713c6a4e-d1d3-4465-9383-2e10119faa2a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("72696a82-5982-44b9-8e34-3de8ed2e2f91"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("72827d75-0b2f-4b8d-b1f0-8f09cc8e4ae4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("72f64578-9c9d-4325-984a-adc1ad578fdf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("73fb4780-4a7c-4c9f-8294-2053b3ac760f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("748990af-8d29-424c-ae8d-610bed2d4955"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("74991083-2130-490d-be2c-875f0dac6556"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("75a218c8-8599-4fbf-8819-f36a9c3f84bd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("764c622b-65bc-47aa-b6d3-ee02fe14b2d7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("76fbc3fc-8d52-482f-8e51-0fa583825188"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7856ba0b-a24a-4933-99bc-079dddf8b611"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("791d03cb-b8e2-4abd-b94e-01db75fdd98a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("79ac1ef2-3dbe-4a75-b1e4-89339b513430"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("79c0f96e-a999-484d-98ad-4f6d192a440c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("79c49dc0-2cb3-4dc0-87c2-9ebf4281bcaf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("79d7a9fd-7a6c-45df-9da5-3506c01b8cc5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7b1a98c2-8d12-43a3-8747-516816f90229"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7b53fd40-c07a-4b99-93be-2e50abc1d021"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7b6fc02c-a8e8-48c7-9879-2cb3a0ff78dc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7c66adc0-c0ce-41bb-bb8b-b3fd982f7e05"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7d06f89c-5e07-4831-add7-5d11e4abdb44"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7d2fb34d-7e11-43a4-a892-4706e8dac634"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7deb2cd8-4b16-4c09-97b4-eb660082ec3d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7ec30db1-fb21-46ec-a8f5-23b20126f329"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("7f69a6eb-538f-46b6-b667-11c2141902b6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("80a8b828-6444-4ec4-b966-ada62b8a4f54"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8275f3b7-24a0-459c-9b1c-24a0575f42a9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("82b84bb4-dbd8-4dc2-ac81-3b9f28c4e8b7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("82d5c798-3bbc-497a-9ed6-b24d988a6d25"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("83421e0f-6af4-44b5-9e14-bf2e88c7fb2d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("843558bb-d052-4bac-8136-5cee53cadbee"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("846fcfb4-23ab-4514-8aea-7db041661ff2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("84e81939-6dd4-4f8c-b821-b278f250287b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("84f2a2e7-97e4-465d-b6c8-f8f2983b629f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("850e0eb6-581e-4841-876c-ebf1db3994e5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("85753f39-52f8-4f68-9d48-d8c17324ce04"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8575db49-b417-4b29-bf9d-bce32619ff0f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("859404d0-33cb-4a4f-996a-8d1b0a7b562c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("86e2db2e-112a-458f-b91e-c9b4f0d2d2be"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("87465c78-caaf-41da-af6d-e9964d5d831f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("875af2b9-d3aa-4254-bce9-67c15ac2b745"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("876f3597-ff3c-45a0-bd7d-85cef7fccc4c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8829ee39-340e-4e66-83c6-7cc70032325f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("89156140-268c-43c6-adfe-dbe3f1e20366"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8961085e-dd66-4099-84fb-110fef48da95"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("899e87cd-0cdd-4446-be4c-402141bdb5e5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("89b81a63-824d-4490-a93a-80d3483ce2af"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8abe5751-98bf-40e5-94ab-9ee532bb08e5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8c90363c-9155-4b0a-98cd-b589c8358a0f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8dbce918-0bed-4b6d-9e75-0fccc24815d0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8e199b6d-4373-45c5-b65f-313ad0062712"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8ede26f0-78ac-4025-b5fb-023b21d4ad40"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8ef5040d-179f-4c88-acae-54456342c2e6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("8fe2543c-b7f2-4a9f-9434-ea0812059b18"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9014c0e3-553f-44c3-a004-0a91281e6206"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("907c53e8-8d97-4df0-bdde-c32c83328655"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("908999fb-f9fd-4c8a-9d85-f762bd54a514"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("909d2eec-61f8-45d4-80ab-548f291eee5e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("90f78e60-d117-454f-ba95-0e25bfc518cc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9193e477-c3a8-437b-9d90-87c7aa16d4f5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("91d3dca2-079a-40e0-84fe-a8501255b03d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("92484b12-501c-4f46-8bd4-c4d8a1eb0ad8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("93355fca-8088-46de-8eb0-d182dadeda08"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9351acbb-5040-473c-8dc9-f6d07314d055"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("93660bc8-6ccc-4d1c-b3cd-7163a9600a36"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9378dd49-6f80-4c9d-bed0-bcff6e40812f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("93a59654-1a13-4aa8-957c-a5971d2598dc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("93d7de53-3217-4c04-94f6-221099e0c7b4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("944c74b3-528b-47c2-8ae8-88d148150e23"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("945992d5-b884-4761-a0f1-6ec64d400119"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9554fef0-f1a2-4bd8-b683-37d28ad16abe"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("96b3794d-bb93-439e-af13-ade170f16b62"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("978a5d02-2417-4e2a-9de5-86bd1b67c3a4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9905157f-8225-405e-a9dc-ea81ce0562f6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("99bb0f1a-0a4f-474c-9775-00b7ac918297"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("99e37ffd-55eb-40c2-9052-e22d63aaa54a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9a4c7bec-f994-43c0-b4c0-f6177bb777a9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9a887c63-2cfa-4907-a341-7e4dc9c48737"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9bfc233e-4ebf-4501-a072-c8b6d99b702f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9c50e604-9084-4750-bb76-ecb4024c98cd"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9c7d3d3a-79cb-4519-95f6-a845fda33760"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9dc1f4d3-d028-44f9-943c-4697ba3aab03"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9de71d6b-5650-4ffe-81ca-4876b48afb09"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9e052f7a-767b-445d-92b0-5730c0a71b06"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9e8f455f-8ee5-402b-bfb7-3ccf5fdbc4aa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9ea11c36-2e85-4c29-b5be-6c3e9700723e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("9f748b36-09f3-47fe-8196-fd718b2fc458"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a00fdb1a-3516-49b6-98cc-a44e48b089f8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a0db8098-6ec1-47f5-8c03-6ff995219caf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a1364012-5019-420f-a93a-e4a8c909a5d5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a2cd7c91-6b87-4f24-bd75-dc8dfddd21b5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a480caa3-edee-431e-a627-e56bd322fb5f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a5079de6-85af-4be4-a439-9a2aa0935212"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a526b2ba-263c-4a20-9638-9a2c36b6118a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a66f7e6c-1a06-42d3-b105-7d7fb868aac7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a69fb163-a4ff-43a4-8854-bc3b3c6fe53e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a76bcabc-a237-4391-a43a-b7fe087177a1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a7e94034-9d76-4221-8c05-592ed6810a96"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a82a6686-22c7-4522-8050-38973bb8ad83"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a84be7b0-17d7-4696-98ef-95d8870f7019"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a883d580-6959-4f43-85c1-8768f51a0a06"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a8bd592c-7e5e-4ca9-94ef-fe7a7a33f9b5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a8f58097-b673-4490-8d3a-d6f50cdd39fa"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a8fd2e4b-2dc5-4a26-89b3-ba898e558d2c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a94d0eab-837a-45cc-9203-d7d7d8b8527f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("a9c44447-9f85-4baf-a946-0c3d12971185"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aa4389a7-ac35-48a1-a619-1cafa12de76a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("aa8a9130-f685-41c2-aebf-d806bb1bb6c1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("abc863a0-f31b-4d78-bfaa-5f4ce79a4295"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("abe123ef-8702-46dc-acb4-101a8ca8c5a9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ac57c05c-ff01-4f99-92ab-2c22d566d49c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ad07ec51-a03a-4e87-a5a3-9c8c2417c07e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ad134e8d-c073-406e-a9ef-bf1cfe230d6a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ad505ff7-135a-4321-99c9-ec707ff0d326"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ad6c76f4-b3e4-47f9-8b99-c1c1c0507b3e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("adc03b8a-649c-41ab-bac3-9159fd97441f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ade8ccd9-db16-4896-9c55-010c141bb7e5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("adf21491-2422-4ba5-a332-d21a572c7bba"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ae4ad1e7-bcfc-4877-9e8e-6e5d83989141"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("af429bfa-bb2b-4769-8cab-ebc541b208e7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("afb0cee7-6b0d-4f89-bdeb-ff6bef97b3c8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b079d814-9173-41d7-afd7-f3108da6e95c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b0d741ec-d065-4092-a0c4-9dd5e9ff2060"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b38a045e-0e88-4a0f-99a8-b11acba45df0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b4013fa0-0757-415f-a3d0-0674703895c3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b4508008-a245-4077-8444-2736e5f852b6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b4820cd6-edf5-4f03-8182-a331d7562810"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b5db0e45-9589-46a4-bbd4-7fcdc6e06cf9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b66c4cde-e3f4-4d24-9ff4-1e6d6235a1b5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b6c510fd-b6b1-4c89-9e0f-bfa77176f92b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b84aa50a-a14e-443a-93ee-f4f2450c1463"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b8782261-70bf-4fc4-81e3-3958996f35e8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("b8b2b444-6c29-4d50-b1be-4fab46ec15e0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ba44f6f1-6cfb-4c1e-89a7-643cee58fd14"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bb24ff8f-a998-48eb-b290-714548d45e38"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bb29264b-9359-4584-ba10-902057c1c3c9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bb64cdbf-78bf-47cd-ba78-cf6e8b8f0973"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bc5d26dd-56f3-4f2c-9447-301f224d475e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bd5540fd-5154-4c80-b2bb-5262bfbb51b6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("bfe2e758-4815-48c3-a0eb-fa939b8ea522"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c02f5c7a-7b07-4299-a94a-c8df5d6f8770"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c0519ea7-7692-4219-826e-1b42ef98d2ac"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c0a81260-940f-4162-93c9-860d69403ab2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c22c772d-68e0-4a2a-92ad-c136819c8c0a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c3385521-edfa-41c1-a078-0552a623dd1a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c34ccc04-b9c1-4e72-bb04-91f3a7c41f3b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c3cc4454-a09f-4218-a014-d16addb78ba4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c518b8e1-ed27-4307-87f9-8ce3dc0573ad"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c552a9c8-d426-4ef3-a727-8db1e9bab073"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c5b2e3eb-1f8f-4a43-9100-d98114ac151c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c65744a1-e322-4fef-aac0-ac10961901ef"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c6dc6b96-8ad8-4f46-918e-03a08e5216f1"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c702144f-aa28-4424-99cb-fb3c59dfa6a5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c7904d44-639c-427c-845d-7c86120b2821"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c7d5fe7c-eda2-4316-b31f-9610622c68be"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c85fa97b-75e5-4338-b41b-72ba513de4ad"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c87aee7c-d8f6-4c27-905f-2494fbc0ec8a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("c9bee6e3-a7b0-4ba0-9e27-9f30f60d5489"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ca2d2bca-dade-42aa-90f9-3136771b5dbf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ca98d8eb-206b-4bf6-b444-8db05771a62c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cb673a3d-6866-4933-8a06-25ad3d4b9182"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cb69b574-6504-4cd3-b9d3-512aa7e4e671"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cb8e19b3-6645-491a-b514-ceea128a81bf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cc26d285-74df-46da-bcca-8c5ba4f3c875"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cc4cf764-f26f-4b33-8f8d-8d083ed4edc6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cc4d69b1-f426-47dc-91eb-5e8782f00435"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cd941e62-0eb2-4a43-b0bf-23c80b1f43e8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ce2a74e7-108b-4eae-b3f3-3ddd09f002ac"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ce5860e1-adbf-4e1c-86ed-81e4bb11ed45"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("cf8d3e9f-2e75-45e8-98d5-f3994a67b446"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d14d89e1-81e1-4669-8c1b-4880346424d6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d1d9d3e3-d8e8-4322-852f-6ef6c03778b8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d1e1563c-ed43-4876-b65c-1738c46de74e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d21bc933-1f3f-4eef-9d7d-37c03c349a7b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d245af8a-d0ea-4bfe-9201-b5837666bf2f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d2da6826-3d73-477b-946f-92f0a87f948b"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d46fed31-638c-4c01-837d-a88092f25e9d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d55e8e38-0765-48eb-b208-24517c27b4b8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d57c6fc6-da49-4933-8952-5746a08f1bd7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d6476ba8-0d96-4492-8fe6-7d730c5e5ea0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d7fc12a9-6589-4f4f-a7ad-c7265f551b80"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("d930d33f-8564-4dfe-bcbc-3ee4c0964338"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("db76dae9-1b66-4ce3-97ee-82c40e2d9d3d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dbe94b2b-3b88-448d-b07a-31271a9f2818"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dc85eb25-2f41-4dd4-b112-80d3a470cd0a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dc8983d7-8dcb-4c93-a8f8-d1d1ab0e6481"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dcc17380-0ecd-4023-baf7-af308378a88c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dd2d5ad6-77cd-4249-af98-4f01934893c7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dd43ffc4-8e02-42ff-8e33-60dc6aa4dda7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dda9f1f1-c23c-4825-a614-92015bca9e96"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("de19e34b-eb5c-4ce7-ab3b-afeb7780b5cb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("de6d5609-b3cf-4207-ba2d-4d98afb9b89d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("de7f9918-0296-40b9-9e4f-243db3733f7c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("debef35f-2505-4c3d-8be8-760f4f2c1a83"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("df5e7659-7f19-4491-a292-aa38fc2bb6c0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dfc67774-7df7-477a-920d-ecdf986249c8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("dfd1fbfe-16b8-4eda-ae36-7b133f3a16b4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e00f5434-5b3e-4873-9403-bb17b8b8fc84"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e05b0968-c710-47fb-a66a-743386ded7cb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e0f66997-cf5f-412c-9859-6248d29866f9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e0fc1860-5b91-4657-abcc-ac89e3578015"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e106c05f-8b2c-4127-976a-15f43b67803d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e14747aa-fc4f-443c-af94-5677a1362670"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e35de1c0-6e1e-4f83-8202-28f30ae35c82"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e41d428f-154b-4d2a-aa1f-59dacd8c29bf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e48a24d4-6882-422f-86e9-d9b83c573c73"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e498aa56-51e2-4194-b1fa-02d58a0f0ced"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e52cdb62-d8f7-4d2b-b3bb-080d8af50755"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e663e03f-2d52-4a4b-b704-8fc7bcc799ad"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e69e52dd-d29c-4d57-8c2e-45f55db7619f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e719c807-775a-4a74-a55c-d0627991e950"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e7262f17-1194-4a0d-b080-a66bf013fabe"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e7f5cab6-3a48-4a7c-945f-a636edcc27f3"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e90c4258-a01e-4201-96c8-0d02948ddc8f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e95f4f8e-59c2-448f-a338-3c9054f41513"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e964c957-6085-4ac3-80c1-1b7d9f40a2b5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e96ce7dd-9f7f-43b1-b4e7-ce1509e69c59"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e9aa3eb8-e1cf-4241-a531-18551e7f81f0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e9d4bfa5-a8f2-476a-81b3-f341d329d0f4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("e9ed591e-630a-415f-90c3-824085837405"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ea08b6f9-1e0e-44b3-8d6c-7f6d57a1c9cf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eacad8ba-a2cb-4d07-8a5d-44fad9bde3c8"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ebf1fac9-7301-4c0d-9f0e-6e28c72f7ed7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eca8718e-6ef8-4769-8773-dae2dd3064f0"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ecf0e526-c5ed-476d-a1d2-ea8996451dfc"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ed297108-7b50-4f8b-8ae8-4111f82a0ddb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("edafe71c-f2a5-44bf-aee6-5de88d792315"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eddbd1bb-8f97-4e37-8051-5191f2b928d9"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eee3a518-b9cf-4d28-a776-c42f7170237c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("eef1e53e-ede8-4ff8-8565-ba189419ea58"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ef8873ff-4e4e-4b7b-8862-049e20122555"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f06ac7c6-e077-4768-bc64-1d8311cfb0e6"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f0a505a3-9e21-490f-b1ab-0a7f41e3081e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f1c6337f-046d-4ff0-a4d7-53e440df878d"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f2c80fff-2669-4da2-b005-e734d055fb5c"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f2eaa520-955c-4f3b-aa2c-04ecf7e8fe98"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f3af9e2a-83b3-420d-86a4-b248a75ac9c7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f3b677f5-ce59-418c-90f2-1a391d846f1f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f3cd63ad-0e62-4c6c-86ca-248cd74f2f73"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f3dda98a-a968-4908-89d6-04d287d7ab0a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f4212739-e40a-479f-afc9-bb696bf37f5f"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f48aa1c3-a245-43b9-b8ce-2ca254b1efe4"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f4e9fdbe-7713-4c53-956a-a57c7551b9a5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f59c9212-9109-425f-942c-df2a84dda14a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f5dc8b0c-4ced-4a61-82c4-c14f477260ca"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f61c8956-1591-4735-a41b-862a97091221"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f6742e74-9572-4ecf-9a50-7423df07f269"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f6f05f4d-a321-4b89-a3f0-f524ac358af5"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f7bc7901-4275-4d46-95ef-0890299e0212"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f7ef842d-9f33-4806-a76a-cdf84fb47cf7"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("f92bba68-31d9-4e97-9244-6d7070eb14cb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fa414ae1-9d49-45fe-b6ac-6cf47c678a67"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fafa3d5a-abcb-4a45-83db-8856ffb5510e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fb6bda45-3df0-4a88-b953-c1a46d4cea5e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fc6f61c0-093f-4e9d-baa2-78eee55ee60e"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fcc32084-ad6d-4f6f-ba07-c676238e7d2a"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fd00e628-87fc-4fb9-938a-bccef98d93fb"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fd3b3c4e-1d56-4e31-af25-c0ec75af8f22"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fe15359c-ca19-4d2b-b805-e5d393483159"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fe5469ff-80e1-40ec-b7b9-6d6036840197"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("feb41275-8269-459b-ab00-10f23beacfb2"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fee0901d-328e-4f1d-a9b1-164db3648427"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("fefdb00d-51d4-4e63-a77a-a9aae9e7dedf"));

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "VoterId",
                keyValue: new Guid("ff4307d0-7fb5-4585-9a34-4f117131451b"));

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

            migrationBuilder.CreateIndex(
                name: "UIX_ElectionParty_Abbreviation",
                table: "ElectionParties",
                column: "Abbreviation",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UIX_ElectionParty_Name",
                table: "ElectionParties",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UIX_ElectionParty_Abbreviation",
                table: "ElectionParties");

            migrationBuilder.DropIndex(
                name: "UIX_ElectionParty_Name",
                table: "ElectionParties");

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

            migrationBuilder.InsertData(
                table: "Voters",
                columns: new[] { "VoterId", "FirstName", "Gender", "IsActive", "IsVerified", "LastName", "MiddleName", "MobileNumber", "RegisteredAt", "VoterCardNumber", "VotingPlaceId" },
                values: new object[,]
                {
                    { new Guid("009d8e01-7480-486b-aa6c-3a664388145c"), "Nabin", 1, true, true, "Khadka", "Bahadur", "+9779802439187", new DateTime(2024, 11, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9990), "NPV-036-0006", 36 },
                    { new Guid("00c3d568-7aca-4939-a797-af2061f73a5d"), "Nabin", 1, true, true, "Magar", "Singh", "+9779618898280", new DateTime(2025, 10, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9100), "NPV-029-0002", 29 },
                    { new Guid("015feef2-1c9b-4002-aced-0f0044044594"), "Rajesh", 1, true, true, "Yadav", "Bahadur", "+9779616103526", new DateTime(2024, 3, 3, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(10), "NPV-036-0008", 36 },
                    { new Guid("020540ca-0996-4a96-ad1f-af39dc490e59"), "Dipak", 1, true, true, "Lama", "Bahadur", "+9779639971721", new DateTime(2024, 5, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9880), "NPV-035-0005", 35 },
                    { new Guid("025fab8f-121e-435f-9ca1-4bdf52916ba2"), "Krishna", 1, true, false, "Lama", "Raj", "+9779623118545", new DateTime(2024, 10, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7180), "NPV-013-0008", 13 },
                    { new Guid("02641d84-6a06-4990-b00b-125baabb9edb"), "Radha", 2, true, true, "Rai", "Kumari", "+9779843653465", new DateTime(2024, 8, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8090), "NPV-020-0009", 20 },
                    { new Guid("0287e825-43bd-442d-8743-9748b81e1829"), "Gopal", 1, true, true, "Lama", "Raj", "+9779614402673", new DateTime(2024, 6, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6510), "NPV-007-0009", 7 },
                    { new Guid("02d85328-8760-436c-be7f-96cccf5a1cb5"), "Anita", 2, true, true, "Karki", "Laxmi", "+9779886969937", new DateTime(2025, 7, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7690), "NPV-017-0006", 17 },
                    { new Guid("033cd4ca-57b8-462c-82d1-6f4c36ac8722"), "Ram", 1, true, false, "Rai", "Kumar", "+9779625327402", new DateTime(2025, 1, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7400), "NPV-015-0004", 15 },
                    { new Guid("035f0554-7b90-4c01-9bd5-d9065f778e2e"), "Rekha", 2, true, true, "Sharma", "Kumari", "+9779769019106", new DateTime(2024, 4, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9150), "NPV-029-0007", 29 },
                    { new Guid("03ac3f4e-dcfc-4b34-9136-f50d99aee4ec"), "Bishnu", 1, true, true, "Sharma", "Prasad", "+9779852832563", new DateTime(2024, 12, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7390), "NPV-015-0003", 15 },
                    { new Guid("03e89bfc-a666-433a-8a88-256feb662fe9"), "Prakash", 1, true, true, "Gurung", "Kumar", "+9779616879428", new DateTime(2024, 10, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8560), "NPV-024-0010", 24 },
                    { new Guid("043cc76e-bd98-44e1-8005-dca73afe6530"), "Rajesh", 1, true, false, "Lama", "Kumar", "+9779628076336", new DateTime(2024, 12, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8980), "NPV-028-0001", 28 },
                    { new Guid("05099b6c-a16d-41ef-8b5f-d0c82f066337"), "Shova", 2, true, true, "Lama", "Kumari", "+9779844209123", new DateTime(2025, 2, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6180), "NPV-005-0003", 5 },
                    { new Guid("05354ba0-9912-4621-9b9c-0340bb89accd"), "Shyam", 1, true, true, "Maharjan", "Kumar", "+9779811316323", new DateTime(2024, 1, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(950), "NPV-044-0005", 44 },
                    { new Guid("056adbe0-79c5-46ce-b68d-3c6d51affbe0"), "Sita", 2, true, true, "Sharma", "Laxmi", "+9779626975728", new DateTime(2024, 1, 30, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1470), "NPV-048-0010", 48 },
                    { new Guid("067a0c37-2e70-4853-9992-3dd871cab61d"), "Bishnu", 1, true, true, "Maharjan", "Bahadur", "+9779801660315", new DateTime(2024, 10, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9400), "NPV-031-0004", 31 },
                    { new Guid("07dac920-be48-440f-88a5-5cde87b38660"), "Nabin", 1, true, true, "Rai", "Singh", "+9779745250151", new DateTime(2024, 12, 16, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(40), "NPV-037-0001", 37 },
                    { new Guid("081f771c-badc-4c8c-b494-ba3b40bbc389"), "Nabin", 1, true, true, "Gurung", "Singh", "+9779811558666", new DateTime(2024, 2, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8710), "NPV-026-0005", 26 },
                    { new Guid("08b77735-d948-4f3e-972e-d0694399a1fb"), "Nisha", 2, true, true, "Khadka", "Kumari", "+9779814546344", new DateTime(2025, 6, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6140), "NPV-004-0009", 4 },
                    { new Guid("08f683c9-c4a8-43fe-9198-6d0b34c57033"), "Maya", 2, true, true, "B.K.", "Kumari", "+9779757412587", new DateTime(2024, 2, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6460), "NPV-007-0004", 7 },
                    { new Guid("0ac5dd4c-bc08-4e27-aa0d-638b4e07bbc0"), "Mohan", 1, true, false, "Chaudhary", "Kumar", "+9779631081393", new DateTime(2024, 3, 20, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1260), "NPV-046-0010", 46 },
                    { new Guid("0c30f23f-bae9-46e1-ba3e-f2d8a5243118"), "Laxmi", 2, true, false, "Maharjan", "Maya", "+9779811248577", new DateTime(2025, 2, 26, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7730), "NPV-017-0010", 17 },
                    { new Guid("0ca4e642-1762-4deb-bebe-ee04f29a310c"), "Rekha", 2, true, false, "Khadka", "Kumari", "+9779826553027", new DateTime(2025, 3, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9390), "NPV-031-0003", 31 },
                    { new Guid("0cb09f49-daef-40de-a0a9-a79424d20959"), "Shova", 2, true, true, "Maharjan", "Kumari", "+9779808978864", new DateTime(2024, 9, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6910), "NPV-011-0002", 11 },
                    { new Guid("0cb9ae6b-facc-4113-bb4a-556d0b7cc3cb"), "Maya", 2, true, false, "B.K.", "Kumari", "+9779746633379", new DateTime(2025, 8, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7050), "NPV-012-0005", 12 },
                    { new Guid("0cbde89b-370e-41e7-b33a-fd8d13b862b3"), "Anita", 2, true, true, "Shrestha", "Devi", "+9779856757317", new DateTime(2025, 6, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6590), "NPV-008-0007", 8 },
                    { new Guid("0d07be26-ee75-4333-9e0a-94715dc90cc0"), "Maya", 2, true, true, "Maharjan", "Devi", "+9779858419306", new DateTime(2024, 8, 25, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1370), "NPV-047-0010", 47 },
                    { new Guid("0df91346-26ad-4292-a04a-38e95c78310b"), "Hari", 1, true, true, "Tamang", "Raj", "+9779619914437", new DateTime(2024, 5, 7, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1240), "NPV-046-0008", 46 },
                    { new Guid("0dfe85d7-8cd7-4f59-b365-2623e52a4a96"), "Radha", 2, true, true, "Sharma", "Laxmi", "+9779627923005", new DateTime(2024, 9, 10, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9230), "NPV-030-0005", 30 },
                    { new Guid("0e6ae559-c504-49a2-b07f-27509ca500ef"), "Nisha", 2, true, true, "Maharjan", "Maya", "+9779845203954", new DateTime(2024, 3, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5990), "NPV-003-0005", 3 },
                    { new Guid("0fb5488d-640d-4aac-b25c-a64611da3596"), "Mohan", 1, true, true, "Lama", "Prasad", "+9779867350667", new DateTime(2025, 8, 13, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(230), "NPV-038-0004", 38 },
                    { new Guid("1061378a-cc43-4870-b9fe-3c8cf8eba8d8"), "Krishna", 1, true, false, "Gurung", "Raj", "+9779763267630", new DateTime(2025, 10, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9490), "NPV-032-0003", 32 },
                    { new Guid("129318fa-058b-4acc-8d03-1e083e898f07"), "Mohan", 1, true, false, "B.K.", "Prasad", "+9779822182457", new DateTime(2024, 8, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7860), "NPV-019-0002", 19 },
                    { new Guid("14bda5d0-2429-483a-9f73-b1abf56a323d"), "Santosh", 1, true, true, "Gurung", "Bahadur", "+9779821246694", new DateTime(2025, 6, 26, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7130), "NPV-013-0003", 13 },
                    { new Guid("1539f66b-0bcc-4161-8b20-063719c7aca5"), "Sarita", 2, true, true, "Lama", "Laxmi", "+9779633468539", new DateTime(2024, 5, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7890), "NPV-019-0005", 19 },
                    { new Guid("157a3095-b07b-4fd5-9bef-3827e3a50adc"), "Bikash", 1, true, true, "Khadka", "Kumar", "+9779866389417", new DateTime(2024, 9, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7270), "NPV-014-0001", 14 },
                    { new Guid("1635a362-1ee9-448d-857d-c44bdd69838d"), "Parbati", 2, true, true, "Nepali", "Kumari", "+9779824021526", new DateTime(2024, 11, 23, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(750), "NPV-042-0006", 42 },
                    { new Guid("16e0a1ae-1f0e-41ea-8421-46244c780fb4"), "Mohan", 1, true, true, "Tamang", "Prasad", "+9779803338169", new DateTime(2024, 12, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6030), "NPV-003-0009", 3 },
                    { new Guid("17dca75c-1c4a-4f9e-8e7d-1d6cedeaa5cd"), "Rajesh", 1, true, true, "Chaudhary", "Raj", "+9779811400700", new DateTime(2024, 1, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8940), "NPV-027-0007", 27 },
                    { new Guid("19660658-e2e2-4575-8d95-6e15468f45d6"), "Ram", 1, true, true, "Sharma", "Bahadur", "+9779617638693", new DateTime(2025, 8, 23, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(770), "NPV-042-0008", 42 },
                    { new Guid("1996e4eb-521b-4f9f-af65-0cfea78357b2"), "Shyam", 1, true, true, "Maharjan", "Raj", "+9779853221644", new DateTime(2024, 3, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9310), "NPV-030-0006", 30 },
                    { new Guid("19f329b0-a88c-4240-826f-39cbd0b2aa18"), "Hari", 1, true, true, "Khadka", "Prasad", "+9779817881457", new DateTime(2024, 7, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8540), "NPV-024-0008", 24 },
                    { new Guid("1b363d9d-7027-46e1-9752-e989d736187f"), "Sunita", 2, true, true, "Thapa", "Kumari", "+9779637251323", new DateTime(2025, 4, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8620), "NPV-025-0006", 25 },
                    { new Guid("1bc01e6d-0bee-429a-9a73-0d05cb699ea1"), "Mohan", 1, true, true, "B.K.", "Prasad", "+9779768872487", new DateTime(2025, 6, 10, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(490), "NPV-040-0009", 40 },
                    { new Guid("1c3d363b-9107-4a9f-b602-a6e0e9302826"), "Parbati", 2, true, true, "Gurung", "Devi", "+9779769839298", new DateTime(2025, 11, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6790), "NPV-009-0010", 9 },
                    { new Guid("1c61e3b4-ca29-460b-aca0-b1a3fbcee4c9"), "Gita", 2, true, true, "B.K.", "Kumari", "+9779809427822", new DateTime(2025, 8, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7700), "NPV-017-0007", 17 },
                    { new Guid("1cd0b3e3-fb83-4c79-be64-9e1c8df24bb7"), "Suresh", 1, true, false, "Sharma", "Raj", "+9779806357757", new DateTime(2025, 11, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5920), "NPV-002-0009", 2 },
                    { new Guid("1d0e017c-e31f-490f-8d25-c959b1029bb8"), "Gita", 2, true, false, "Khadka", "Kumari", "+9779882503909", new DateTime(2025, 7, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8630), "NPV-025-0007", 25 },
                    { new Guid("1d4bdbd7-823c-44d4-8f98-b89e84f5cfb8"), "Gopal", 1, true, true, "Karki", "Raj", "+9779749283270", new DateTime(2025, 5, 4, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(120), "NPV-037-0008", 37 },
                    { new Guid("1dc4b86c-b9d2-4213-953b-5cbfa1d2505c"), "Krishna", 1, true, true, "B.K.", "Prasad", "+9779889650430", new DateTime(2025, 11, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7810), "NPV-018-0007", 18 },
                    { new Guid("1ec17846-d224-4719-bc52-a4d5861f8f4e"), "Sarita", 2, true, true, "Khadka", "Maya", "+9779805204274", new DateTime(2025, 1, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8430), "NPV-024-0001", 24 },
                    { new Guid("1ef3a079-bcfd-4901-b187-ac7d5f0bf945"), "Sita", 2, true, true, "Thapa", "Devi", "+9779867972491", new DateTime(2025, 8, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7790), "NPV-018-0006", 18 },
                    { new Guid("1f5dabbb-1d5e-4b7c-84b2-39e62721af81"), "Gopal", 1, true, true, "Maharjan", "Singh", "+9779827650676", new DateTime(2025, 4, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5980), "NPV-003-0004", 3 },
                    { new Guid("206da60c-2910-409d-81f9-c4f33cba6427"), "Bikash", 1, true, true, "Lama", "Kumar", "+9779629384490", new DateTime(2024, 5, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9840), "NPV-035-0001", 35 },
                    { new Guid("211f09dd-61df-4fad-8c86-ad24b10c3c43"), "Prakash", 1, true, true, "Rai", "Prasad", "+9779611088164", new DateTime(2025, 9, 13, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(290), "NPV-038-0010", 38 },
                    { new Guid("218da2e8-4f08-40a5-b0ee-46920742644e"), "Rekha", 2, true, true, "Thapa", "Devi", "+9779637070086", new DateTime(2024, 3, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6680), "NPV-009-0005", 9 },
                    { new Guid("21a5c9a2-beea-4852-9b89-16aee0e59d39"), "Ram", 1, true, true, "Yadav", "Bahadur", "+9779756981426", new DateTime(2024, 10, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5730), "NPV-002-0003", 2 },
                    { new Guid("21ef3237-da99-40f6-918c-b7bb61a96067"), "Nisha", 2, true, true, "Thapa", "Laxmi", "+9779844007950", new DateTime(2025, 1, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7840), "NPV-018-0010", 18 },
                    { new Guid("2203b92f-be31-4abc-aab5-a0f3c4d0a983"), "Gopal", 1, true, true, "Maharjan", "Bahadur", "+9779887591584", new DateTime(2024, 1, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8720), "NPV-026-0006", 26 },
                    { new Guid("23611a12-fb42-4166-837e-fc20ca3d64e3"), "Rupa", 2, true, false, "Maharjan", "Maya", "+9779755748270", new DateTime(2025, 12, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9120), "NPV-029-0004", 29 },
                    { new Guid("23c5beb9-5240-4b2e-b531-fcd9d9166c65"), "Suresh", 1, true, true, "Lama", "Prasad", "+9779613348397", new DateTime(2024, 9, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7660), "NPV-017-0003", 17 },
                    { new Guid("24e43caa-2d91-46df-aa4f-fc277ba4679f"), "Krishna", 1, true, true, "Shrestha", "Kumar", "+9779763063602", new DateTime(2025, 8, 15, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(970), "NPV-044-0007", 44 },
                    { new Guid("25ac08ed-6f8c-41c0-bbb9-21b4429c8278"), "Gita", 2, true, true, "B.K.", "Kumari", "+9779807476864", new DateTime(2024, 4, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7830), "NPV-018-0009", 18 },
                    { new Guid("2682478f-59dd-4a84-8640-7314f60ec3bd"), "Radha", 2, true, true, "B.K.", "Maya", "+9779825512880", new DateTime(2025, 10, 26, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(250), "NPV-038-0006", 38 },
                    { new Guid("2697ba0e-0c73-44d2-aa24-efc860729283"), "Gopal", 1, true, true, "Khadka", "Singh", "+9779612460234", new DateTime(2024, 6, 10, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8400), "NPV-023-0008", 23 },
                    { new Guid("275643fb-a164-498e-82fc-13b818208958"), "Sarita", 2, true, true, "Sharma", "Laxmi", "+9779761657999", new DateTime(2025, 9, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9480), "NPV-032-0002", 32 },
                    { new Guid("276136cf-97e0-4a6c-b586-5be0f8b730bd"), "Gopal", 1, true, true, "Magar", "Singh", "+9779827566256", new DateTime(2024, 2, 8, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(500), "NPV-040-0010", 40 },
                    { new Guid("27614eac-686c-4661-9519-be95b8ec5884"), "Suresh", 1, true, true, "Chaudhary", "Bahadur", "+9779811134675", new DateTime(2025, 6, 15, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9210), "NPV-030-0003", 30 },
                    { new Guid("27953411-ec2d-4bc2-82f6-4144c69aea2b"), "Krishna", 1, true, true, "Shrestha", "Singh", "+9779622482332", new DateTime(2025, 2, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7970), "NPV-020-0003", 20 },
                    { new Guid("2996ae63-6ef1-4955-8c67-09eab68c4f6f"), "Rekha", 2, true, false, "Lama", "Laxmi", "+9779636665567", new DateTime(2024, 1, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6840), "NPV-010-0005", 10 },
                    { new Guid("29f9b786-ec6a-4646-ac90-0a110f3a5329"), "Sabitri", 2, true, true, "Shrestha", "Laxmi", "+9779814211027", new DateTime(2024, 11, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6690), "NPV-009-0006", 9 },
                    { new Guid("2a58c78c-f3ae-4565-999e-61a3ed003263"), "Dipak", 1, true, false, "Sharma", "Kumar", "+9779625391574", new DateTime(2025, 8, 15, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9540), "NPV-032-0008", 32 },
                    { new Guid("2a7e2cc2-bfba-4e41-a00a-b25687209703"), "Sarita", 2, true, false, "Shrestha", "Kumari", "+9779624600314", new DateTime(2024, 7, 2, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1220), "NPV-046-0006", 46 },
                    { new Guid("2ac2f1b4-712f-4548-a1bb-b2aefc34b3be"), "Rupa", 2, true, false, "Sharma", "Laxmi", "+9779828172280", new DateTime(2025, 5, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9180), "NPV-029-0010", 29 },
                    { new Guid("2b4d6d1b-2232-4e88-b1e2-7742c099367c"), "Bikash", 1, true, true, "Thapa", "Bahadur", "+9779864627097", new DateTime(2024, 10, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8660), "NPV-025-0010", 25 },
                    { new Guid("2b666953-bb58-4e7b-9ca4-e93e46bd8977"), "Sarita", 2, true, false, "Shrestha", "Maya", "+9779884689342", new DateTime(2024, 12, 1, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1310), "NPV-047-0004", 47 },
                    { new Guid("2b7dbf1e-59c7-45df-8c93-c724c062b717"), "Rupa", 2, true, true, "Magar", "Maya", "+9779613475086", new DateTime(2025, 5, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8080), "NPV-020-0008", 20 },
                    { new Guid("2bd23c20-6ab7-4ac6-a4fd-b6986f8c814e"), "Shova", 2, true, true, "Tamang", "Maya", "+9779766626404", new DateTime(2025, 7, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9130), "NPV-029-0005", 29 },
                    { new Guid("2bd56bd1-8e53-408c-b524-77f648ac6cc2"), "Bikash", 1, true, true, "Lama", "Raj", "+9779817733077", new DateTime(2025, 4, 26, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1250), "NPV-046-0009", 46 },
                    { new Guid("2c85d2c1-4543-4103-a4d8-f3968b429c3c"), "Radha", 2, true, false, "Tamang", "Devi", "+9779815901434", new DateTime(2024, 4, 10, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7500), "NPV-016-0003", 16 },
                    { new Guid("2cd8542c-e479-4ffc-b861-891126dc8a31"), "Sunita", 2, true, true, "B.K.", "Laxmi", "+9779744962453", new DateTime(2025, 2, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7520), "NPV-016-0005", 16 },
                    { new Guid("2d08e82a-9d98-4431-8f52-ec7f7c06f085"), "Hari", 1, true, true, "B.K.", "Raj", "+9779888624945", new DateTime(2024, 3, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9630), "NPV-033-0006", 33 },
                    { new Guid("2d505779-4236-4ca1-a367-543caa186f4e"), "Rupa", 2, true, true, "Chaudhary", "Laxmi", "+9779744624956", new DateTime(2025, 9, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8640), "NPV-025-0008", 25 },
                    { new Guid("2d8f6695-3a6a-42cd-9b9c-c03e9d85759e"), "Krishna", 1, true, true, "Nepali", "Singh", "+9779615126762", new DateTime(2024, 11, 15, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(810), "NPV-043-0002", 43 },
                    { new Guid("2ef9e75c-aeeb-472d-9f71-c0d28edfe343"), "Bikash", 1, true, true, "Gurung", "Singh", "+9779633367906", new DateTime(2025, 11, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8590), "NPV-025-0003", 25 },
                    { new Guid("2f018f25-0e6c-4c35-8868-0a4c0bc9f253"), "Bishnu", 1, true, true, "Thapa", "Prasad", "+9779843963919", new DateTime(2023, 12, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8230), "NPV-022-0002", 22 },
                    { new Guid("2f0521ac-a394-446e-bcaf-4101770c22f2"), "Rupa", 2, true, false, "Khadka", "Maya", "+9779815456508", new DateTime(2024, 1, 11, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(380), "NPV-039-0008", 39 },
                    { new Guid("2f091680-b0f9-4bbc-b62f-f1df221bb8ef"), "Mohan", 1, true, true, "Yadav", "Raj", "+9779886838731", new DateTime(2025, 12, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8150), "NPV-021-0004", 21 },
                    { new Guid("31268aa8-3c50-4aea-8161-3d1df52cfd41"), "Suresh", 1, true, true, "Maharjan", "Prasad", "+9779634846332", new DateTime(2025, 1, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7750), "NPV-018-0002", 18 },
                    { new Guid("31a6c8e9-f204-4770-9bff-ff524f09d5ce"), "Sunita", 2, true, true, "Khadka", "Devi", "+9779806635047", new DateTime(2024, 4, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6300), "NPV-006-0005", 6 },
                    { new Guid("33cd76e3-8bcc-4eec-96d6-b158bb84027e"), "Prakash", 1, true, true, "Sharma", "Prasad", "+9779635654262", new DateTime(2024, 2, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8360), "NPV-023-0004", 23 },
                    { new Guid("35682bc3-41a0-4938-b319-35ea9540caa0"), "Krishna", 1, true, false, "Tamang", "Raj", "+9779841746765", new DateTime(2024, 7, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5620), "NPV-001-0004", 1 },
                    { new Guid("35db2f3a-dac3-4a44-b653-0699866f9c3b"), "Bikash", 1, true, false, "Nepali", "Prasad", "+9779757416400", new DateTime(2024, 9, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9190), "NPV-030-0001", 30 },
                    { new Guid("36499fa3-d19a-4f3e-a68b-bd26a8565ecc"), "Suresh", 1, true, true, "Thapa", "Kumar", "+9779633811650", new DateTime(2024, 10, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6610), "NPV-008-0008", 8 },
                    { new Guid("3701b691-33a4-4073-a9e6-e1782d9e475f"), "Sabitri", 2, true, true, "Sharma", "Maya", "+9779857049410", new DateTime(2025, 4, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7170), "NPV-013-0007", 13 },
                    { new Guid("3849cdeb-82e6-4885-a65c-b9ea059ea1e1"), "Rupa", 2, true, true, "Chaudhary", "Maya", "+9779848918160", new DateTime(2023, 12, 23, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(140), "NPV-037-0010", 37 },
                    { new Guid("3897db2d-2a3e-41cb-b5cf-0e6a7653dfbd"), "Laxmi", 2, true, true, "Shrestha", "Laxmi", "+9779618090885", new DateTime(2024, 11, 22, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(610), "NPV-041-0009", 41 },
                    { new Guid("389f6602-67ce-466c-b58d-1892cc6da748"), "Shova", 2, true, false, "Gurung", "Kumari", "+9779854144956", new DateTime(2024, 7, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7710), "NPV-017-0008", 17 },
                    { new Guid("38c5bb91-9332-4953-b83f-680c498144ab"), "Rajesh", 1, true, true, "Chaudhary", "Bahadur", "+9779886002318", new DateTime(2024, 10, 15, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1000), "NPV-044-0010", 44 },
                    { new Guid("3902fb2b-e013-450d-a241-63b183ab8ede"), "Santosh", 1, true, true, "Maharjan", "Bahadur", "+9779745902120", new DateTime(2025, 2, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7020), "NPV-012-0002", 12 },
                    { new Guid("395d1a2e-619e-4951-a6c0-5e6865a5b65b"), "Sarita", 2, true, true, "Karki", "Devi", "+9779636913818", new DateTime(2025, 2, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6160), "NPV-005-0001", 5 },
                    { new Guid("3a7c47f3-1f58-41d2-a44b-85d44e092f58"), "Nisha", 2, true, true, "Gurung", "Devi", "+9779859900411", new DateTime(2024, 9, 18, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(160), "NPV-038-0002", 38 },
                    { new Guid("3b2e0509-b0fc-4b10-82e6-9569c65b6d2c"), "Nisha", 2, true, true, "Chaudhary", "Maya", "+9779886110259", new DateTime(2024, 11, 1, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9160), "NPV-029-0008", 29 },
                    { new Guid("3bcfaf40-afb5-4067-aa47-06456dbd730a"), "Hari", 1, true, true, "Chaudhary", "Prasad", "+9779824577773", new DateTime(2024, 1, 15, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6650), "NPV-009-0002", 9 },
                    { new Guid("3bea5a20-ddbe-4b32-8871-4528821bb051"), "Santosh", 1, true, true, "Gurung", "Prasad", "+9779611812387", new DateTime(2024, 8, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7030), "NPV-012-0003", 12 },
                    { new Guid("3c2db403-6099-4d58-b3ea-84af624526a8"), "Radha", 2, true, false, "Magar", "Kumari", "+9779624771424", new DateTime(2024, 11, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6120), "NPV-004-0007", 4 },
                    { new Guid("3c4018df-3e65-4004-94df-489f8062c5dc"), "Sabitri", 2, true, true, "Shrestha", "Kumari", "+9779749695374", new DateTime(2025, 8, 28, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1380), "NPV-048-0001", 48 },
                    { new Guid("3c793d3e-c269-4c40-bf5d-06201f4008e4"), "Radha", 2, true, true, "Thapa", "Maya", "+9779761748574", new DateTime(2024, 6, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6670), "NPV-009-0004", 9 },
                    { new Guid("3d2b8e09-d9e5-4653-9fe6-0c442f0d3604"), "Bishnu", 1, true, true, "Khadka", "Bahadur", "+9779803402307", new DateTime(2025, 7, 15, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6950), "NPV-011-0005", 11 },
                    { new Guid("3dabe9ee-521d-4093-8feb-3e7b3d92435a"), "Mohan", 1, true, false, "Thapa", "Prasad", "+9779812270674", new DateTime(2025, 11, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7920), "NPV-019-0008", 19 },
                    { new Guid("3e97030e-85f8-4bb2-8875-de739250afd7"), "Anita", 2, true, false, "Shrestha", "Devi", "+9779827569883", new DateTime(2025, 1, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6100), "NPV-004-0005", 4 },
                    { new Guid("3e9cf725-d38f-4bf1-b004-6ff1c055dbf9"), "Rupa", 2, true, true, "Gurung", "Kumari", "+9779757249499", new DateTime(2024, 2, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8920), "NPV-027-0005", 27 },
                    { new Guid("3ea914b6-b17f-4146-b182-a021e8fbbbf1"), "Nisha", 2, true, true, "Lama", "Maya", "+9779885310190", new DateTime(2025, 12, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6540), "NPV-008-0002", 8 },
                    { new Guid("3f0c27bd-33e5-41ae-b2c8-733f2c5cbed8"), "Krishna", 1, true, true, "Maharjan", "Kumar", "+9779743839154", new DateTime(2025, 3, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6060), "NPV-004-0002", 4 },
                    { new Guid("402dd7fe-da8f-48ba-bdb7-bd9a67427f04"), "Hari", 1, true, true, "Magar", "Bahadur", "+9779841133184", new DateTime(2024, 7, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8570), "NPV-025-0001", 25 },
                    { new Guid("406e6efe-0cb6-43d6-bd1d-af7e32552f18"), "Sabitri", 2, true, true, "Maharjan", "Maya", "+9779629696816", new DateTime(2025, 5, 10, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(940), "NPV-044-0004", 44 },
                    { new Guid("406e729e-7063-4482-b5fd-5a14293a8f6b"), "Dipak", 1, true, true, "B.K.", "Prasad", "+9779634649135", new DateTime(2025, 7, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9890), "NPV-035-0006", 35 },
                    { new Guid("40b58bf1-3799-407f-84fc-c7ba31ff2458"), "Suresh", 1, true, true, "Sharma", "Prasad", "+9779769244326", new DateTime(2024, 10, 11, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9830), "NPV-034-0010", 34 },
                    { new Guid("4127ba81-2dda-4cda-bc81-1075d4fd68a6"), "Shyam", 1, true, false, "Chaudhary", "Kumar", "+9779636999266", new DateTime(2024, 3, 11, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7930), "NPV-019-0009", 19 },
                    { new Guid("412c99b5-c0d4-4680-96f6-47eb2e2b8ab0"), "Nabin", 1, true, false, "Yadav", "Kumar", "+9779744535953", new DateTime(2024, 12, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8200), "NPV-021-0009", 21 },
                    { new Guid("421aefc4-3881-492c-82c2-8589ae1ac78b"), "Suresh", 1, true, true, "Lama", "Kumar", "+9779814307220", new DateTime(2025, 2, 10, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8890), "NPV-027-0002", 27 },
                    { new Guid("42c9c9a3-d193-4da3-a6f2-a9b91b88c494"), "Gita", 2, true, true, "Tamang", "Maya", "+9779766616146", new DateTime(2024, 3, 1, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9690), "NPV-034-0002", 34 },
                    { new Guid("43782e5d-7bc9-478c-8a9d-05b6c9439368"), "Rupa", 2, true, true, "Khadka", "Devi", "+9779825805822", new DateTime(2024, 9, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6220), "NPV-005-0007", 5 },
                    { new Guid("43822f2f-76e3-4184-864a-a01b2fbaaf44"), "Mohan", 1, true, true, "Thapa", "Singh", "+9779841281613", new DateTime(2024, 5, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6280), "NPV-006-0003", 6 },
                    { new Guid("438da773-7aee-4d18-af2e-3ee6df7f264d"), "Hari", 1, true, true, "Nepali", "Singh", "+9779811810091", new DateTime(2025, 2, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(3670), "NPV-001-0001", 1 },
                    { new Guid("44258f33-2902-46c6-9029-f088b37e6340"), "Rekha", 2, true, true, "Chaudhary", "Devi", "+9779636524750", new DateTime(2024, 11, 27, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(20), "NPV-036-0009", 36 },
                    { new Guid("44ae306f-f06c-4b7b-949e-1e43cd9b8eee"), "Suresh", 1, true, true, "Magar", "Bahadur", "+9779818429633", new DateTime(2024, 12, 31, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5760), "NPV-002-0005", 2 },
                    { new Guid("453123cf-b1c8-4ac1-810d-c706dd3824ac"), "Sabitri", 2, true, false, "Karki", "Kumari", "+9779864527175", new DateTime(2024, 4, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9050), "NPV-028-0007", 28 },
                    { new Guid("468f1a86-49f7-45f6-8c26-5752c0646f89"), "Sita", 2, true, true, "Khadka", "Kumari", "+9779819491420", new DateTime(2024, 7, 26, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7280), "NPV-014-0002", 14 },
                    { new Guid("46ce83d2-ee4c-42a0-bfce-28dbd0a51879"), "Bishnu", 1, true, false, "Rai", "Prasad", "+9779768311036", new DateTime(2025, 9, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8480), "NPV-024-0006", 24 },
                    { new Guid("473116a2-b9c9-4fa2-9c88-803c4f3be5a6"), "Laxmi", 2, true, true, "Sharma", "Kumari", "+9779811111681", new DateTime(2024, 7, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1280), "NPV-047-0002", 47 },
                    { new Guid("47484fd3-6402-4372-8dcc-3c57997eb173"), "Radha", 2, true, true, "Lama", "Devi", "+9779844001649", new DateTime(2024, 7, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9610), "NPV-033-0004", 33 },
                    { new Guid("47bc285b-2b68-476f-b529-66ec1f91e677"), "Suresh", 1, true, true, "Shrestha", "Singh", "+9779882540659", new DateTime(2024, 11, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8860), "NPV-026-0009", 26 },
                    { new Guid("47cc8faf-c1dc-4b0c-9f03-4d35872f05a7"), "Maya", 2, true, true, "Khadka", "Kumari", "+9779814000523", new DateTime(2025, 1, 22, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(780), "NPV-042-0009", 42 },
                    { new Guid("480e93a5-6259-4e58-b1b2-60932a973ae1"), "Gopal", 1, true, true, "Tamang", "Singh", "+9779847702034", new DateTime(2025, 7, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6940), "NPV-011-0004", 11 },
                    { new Guid("48917392-ee92-405e-80f0-66a3fe3380e0"), "Rekha", 2, true, false, "Khadka", "Kumari", "+9779884811747", new DateTime(2024, 11, 12, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(900), "NPV-044-0001", 44 },
                    { new Guid("48917f78-b321-4ffb-bb29-b3b4198e79cd"), "Krishna", 1, true, true, "Karki", "Singh", "+9779808275018", new DateTime(2024, 4, 28, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(790), "NPV-042-0010", 42 },
                    { new Guid("489b2288-5c3c-459d-9df4-61a98df844b0"), "Bikash", 1, true, true, "Nepali", "Bahadur", "+9779827043901", new DateTime(2024, 5, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9200), "NPV-030-0002", 30 },
                    { new Guid("48e135b2-0d7c-427a-a39f-dba7312cbeb9"), "Rajesh", 1, true, true, "Rai", "Bahadur", "+9779852583711", new DateTime(2025, 8, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6170), "NPV-005-0002", 5 },
                    { new Guid("49b11faa-5d26-41a1-815c-dcbcff5fde69"), "Sarita", 2, true, true, "Lama", "Kumari", "+9779747671539", new DateTime(2025, 2, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9030), "NPV-028-0005", 28 },
                    { new Guid("49f29825-c3ed-4d53-97f7-7e9d387b65d6"), "Sabitri", 2, true, true, "Sharma", "Devi", "+9779622097551", new DateTime(2024, 11, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5660), "NPV-001-0006", 1 },
                    { new Guid("4a944d6e-2b54-4286-96b3-d891c80e066c"), "Nabin", 1, true, true, "B.K.", "Kumar", "+9779855161987", new DateTime(2025, 8, 8, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(150), "NPV-038-0001", 38 },
                    { new Guid("4b3fd694-5798-46c2-9e82-fbbdae3580d4"), "Bishnu", 1, true, true, "Chaudhary", "Raj", "+9779756175784", new DateTime(2025, 10, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9800), "NPV-034-0008", 34 },
                    { new Guid("4c0bd36c-d9bd-425e-a3df-b942e021e3c4"), "Nisha", 2, true, true, "Yadav", "Devi", "+9779741665037", new DateTime(2025, 11, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8320), "NPV-022-0010", 22 },
                    { new Guid("4c683aaa-0333-4448-af97-ca7cfe1e4806"), "Gopal", 1, true, false, "Nepali", "Singh", "+9779883991669", new DateTime(2025, 3, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6560), "NPV-008-0004", 8 },
                    { new Guid("4cd0e152-7e61-4369-9768-083bc1f3b815"), "Shova", 2, true, true, "Rai", "Devi", "+9779841364232", new DateTime(2025, 6, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8260), "NPV-022-0005", 22 },
                    { new Guid("4d11834b-661c-4feb-baab-2d11051447be"), "Parbati", 2, true, true, "Yadav", "Kumari", "+9779811776079", new DateTime(2025, 10, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7410), "NPV-015-0005", 15 },
                    { new Guid("4d9ca8ef-4484-4e13-9559-37e8328905ce"), "Bikash", 1, true, true, "Thapa", "Singh", "+9779762402176", new DateTime(2024, 10, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5720), "NPV-002-0002", 2 },
                    { new Guid("4e5005cb-28c3-4525-bf49-cf176181dbe5"), "Shyam", 1, true, true, "Maharjan", "Bahadur", "+9779756307625", new DateTime(2024, 2, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7510), "NPV-016-0004", 16 },
                    { new Guid("4eaacfb9-3f4a-4337-aa25-ddd5e5980757"), "Santosh", 1, true, false, "Yadav", "Singh", "+9779861188411", new DateTime(2024, 6, 13, 22, 35, 36, 443, DateTimeKind.Utc), "NPV-036-0007", 36 },
                    { new Guid("4ef78f91-689d-4e5e-9b9d-61feb4825f5e"), "Shova", 2, true, true, "Tamang", "Devi", "+9779885310555", new DateTime(2024, 9, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9600), "NPV-033-0003", 33 },
                    { new Guid("4f6e54f9-0fc7-404d-a187-54e377b74b0c"), "Prakash", 1, true, true, "Tamang", "Kumar", "+9779745271185", new DateTime(2024, 7, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1410), "NPV-048-0004", 48 },
                    { new Guid("5032c8b6-0ee7-48f0-b2ba-b22ed8359d7b"), "Dipak", 1, true, true, "Maharjan", "Raj", "+9779813957383", new DateTime(2024, 6, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9020), "NPV-028-0004", 28 },
                    { new Guid("50b84b21-1784-4df1-b271-f1902f49eb12"), "Rekha", 2, true, true, "Maharjan", "Devi", "+9779634803813", new DateTime(2024, 5, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6720), "NPV-009-0009", 9 },
                    { new Guid("50ca2529-0210-485b-b81c-908dfecee87f"), "Bikash", 1, true, true, "Magar", "Raj", "+9779855120386", new DateTime(2025, 11, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9530), "NPV-032-0007", 32 },
                    { new Guid("50d37d73-4a15-48ae-8085-60423e1eb40c"), "Nisha", 2, true, true, "Yadav", "Maya", "+9779627381680", new DateTime(2024, 5, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9680), "NPV-034-0001", 34 },
                    { new Guid("514e4fd7-0db3-4650-a31d-fd7c0c6ef582"), "Maya", 2, true, true, "Maharjan", "Laxmi", "+9779828833153", new DateTime(2025, 6, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6070), "NPV-004-0003", 4 },
                    { new Guid("51a5ae30-dbf8-4c5c-83dc-c218fe3fe801"), "Bishnu", 1, true, true, "Magar", "Raj", "+9779765803761", new DateTime(2024, 7, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8910), "NPV-027-0004", 27 },
                    { new Guid("5223460b-31b4-4fad-89ac-188adcd41f0c"), "Parbati", 2, true, true, "Sharma", "Laxmi", "+9779889613012", new DateTime(2024, 9, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9330), "NPV-030-0007", 30 },
                    { new Guid("52460fe8-18f1-41fd-af63-e07df5d2c0f5"), "Rajesh", 1, true, true, "Yadav", "Bahadur", "+9779769519361", new DateTime(2025, 3, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8280), "NPV-022-0007", 22 },
                    { new Guid("540b4e51-e5e8-4b21-8a11-30b332442d42"), "Mohan", 1, true, true, "Maharjan", "Raj", "+9779615054650", new DateTime(2025, 2, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7420), "NPV-015-0006", 15 },
                    { new Guid("555ba255-b750-4653-afb3-c60df2cf1bdd"), "Santosh", 1, true, true, "Yadav", "Singh", "+9779853435125", new DateTime(2024, 11, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6450), "NPV-007-0003", 7 },
                    { new Guid("55af3210-0952-437a-a7f2-6539618ca128"), "Arjun", 1, true, true, "Shrestha", "Prasad", "+9779862637481", new DateTime(2025, 7, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9790), "NPV-034-0007", 34 },
                    { new Guid("569121b9-faae-42e0-a5d6-ff026a9ce3b2"), "Santosh", 1, true, false, "Tamang", "Prasad", "+9779859131612", new DateTime(2025, 1, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(430), "NPV-040-0003", 40 },
                    { new Guid("58476f4d-66f4-4940-ae4b-777155e978ff"), "Nisha", 2, true, true, "B.K.", "Devi", "+9779857740977", new DateTime(2024, 11, 2, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(720), "NPV-042-0004", 42 },
                    { new Guid("589a0783-2297-4137-a668-ee366dc3bafd"), "Sabitri", 2, true, false, "Gurung", "Kumari", "+9779844655329", new DateTime(2025, 9, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6870), "NPV-010-0008", 10 },
                    { new Guid("58c47205-a8f0-46ed-a694-b2bcc326e9f1"), "Mohan", 1, true, true, "Karki", "Singh", "+9779748681427", new DateTime(2025, 1, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7720), "NPV-017-0009", 17 },
                    { new Guid("593d23f8-ba40-4b59-a25b-30b98f6b562e"), "Mohan", 1, true, true, "Lama", "Raj", "+9779818019778", new DateTime(2024, 6, 17, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(560), "NPV-041-0005", 41 },
                    { new Guid("593e9cf7-b85a-4046-8adc-50cc5e686775"), "Sabitri", 2, true, true, "Magar", "Maya", "+9779762435834", new DateTime(2025, 10, 5, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(870), "NPV-043-0008", 43 },
                    { new Guid("596ad47c-e647-46a3-9f7e-a97227b9519d"), "Rupa", 2, true, true, "B.K.", "Kumari", "+9779883448207", new DateTime(2025, 5, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8330), "NPV-023-0001", 23 },
                    { new Guid("5a8f909f-1e12-415d-a6c9-6bc144b857da"), "Dipak", 1, true, true, "Chaudhary", "Raj", "+9779766183419", new DateTime(2024, 9, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7880), "NPV-019-0004", 19 },
                    { new Guid("5ae252ac-ca43-41e6-9294-75e8b245ca89"), "Santosh", 1, true, true, "Thapa", "Prasad", "+9779627117418", new DateTime(2025, 2, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7760), "NPV-018-0003", 18 },
                    { new Guid("5b9b0430-2440-4b27-b064-b15abddc0480"), "Mohan", 1, true, true, "Shrestha", "Kumar", "+9779763157328", new DateTime(2024, 8, 3, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(860), "NPV-043-0007", 43 },
                    { new Guid("5ba21a8b-b2cb-4c9c-acb9-097cf420c794"), "Rekha", 2, true, true, "Sharma", "Kumari", "+9779816752584", new DateTime(2025, 1, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5960), "NPV-003-0002", 3 },
                    { new Guid("5bef65b0-c678-4ea7-b788-0623b33fea77"), "Sita", 2, true, true, "Khadka", "Kumari", "+9779852945057", new DateTime(2025, 8, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6570), "NPV-008-0005", 8 },
                    { new Guid("5c2a9399-b471-470e-9a63-dd5e734363db"), "Ram", 1, true, true, "Maharjan", "Raj", "+9779889837836", new DateTime(2025, 3, 6, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(390), "NPV-039-0009", 39 },
                    { new Guid("5c46507c-7bb4-402e-ae07-e4e929fd718d"), "Nisha", 2, true, true, "Maharjan", "Laxmi", "+9779761285928", new DateTime(2024, 4, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7330), "NPV-014-0007", 14 },
                    { new Guid("5c4654f9-b5bc-41b3-beab-fe47593a8a45"), "Sita", 2, true, true, "Chaudhary", "Kumari", "+9779803995333", new DateTime(2024, 4, 5, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1200), "NPV-046-0004", 46 },
                    { new Guid("5c99cbec-c5a0-466d-b745-02e5ed2b78e1"), "Sarita", 2, true, true, "Magar", "Devi", "+9779847206889", new DateTime(2024, 12, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9860), "NPV-035-0003", 35 },
                    { new Guid("5cb06d68-80e9-4f86-97e0-d6e183eff826"), "Sita", 2, true, true, "Yadav", "Laxmi", "+9779808846685", new DateTime(2024, 8, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8120), "NPV-021-0001", 21 },
                    { new Guid("5cf98f7a-8fdb-4bc5-a9a7-fc3422d783e7"), "Sita", 2, true, true, "B.K.", "Laxmi", "+9779841867795", new DateTime(2024, 10, 1, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(640), "NPV-042-0002", 42 },
                    { new Guid("5d0f7183-0207-4f4f-9104-633d24d52633"), "Radha", 2, true, false, "Lama", "Kumari", "+9779624784762", new DateTime(2025, 6, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8420), "NPV-023-0010", 23 },
                    { new Guid("5e6223be-5b8a-4f85-bf85-a487a69d2d51"), "Hari", 1, true, true, "Rai", "Singh", "+9779754472768", new DateTime(2024, 12, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9140), "NPV-029-0006", 29 },
                    { new Guid("605f5076-1994-435e-ba47-6194970df393"), "Dipak", 1, true, true, "Magar", "Raj", "+9779827881745", new DateTime(2025, 6, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6980), "NPV-011-0008", 11 },
                    { new Guid("6194bc08-d615-47ad-919f-51284978622f"), "Rajesh", 1, true, false, "Karki", "Singh", "+9779863848769", new DateTime(2025, 7, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6850), "NPV-010-0006", 10 },
                    { new Guid("61d8cb3e-f38b-4adb-81d7-5163543dc958"), "Radha", 2, true, true, "Thapa", "Devi", "+9779884660523", new DateTime(2024, 3, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(100), "NPV-037-0006", 37 },
                    { new Guid("6261116d-ddb2-4214-84db-0519e007f515"), "Maya", 2, true, true, "Lama", "Kumari", "+9779855113743", new DateTime(2025, 6, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7430), "NPV-015-0007", 15 },
                    { new Guid("62ae2726-30bb-4bae-8354-9d93cd1b32dc"), "Dipak", 1, true, true, "Nepali", "Singh", "+9779634585085", new DateTime(2025, 5, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9430), "NPV-031-0007", 31 },
                    { new Guid("6327ec1d-fd99-4dcd-836a-624f2ed53214"), "Krishna", 1, true, true, "Rai", "Bahadur", "+9779823572616", new DateTime(2025, 7, 26, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6530), "NPV-008-0001", 8 },
                    { new Guid("63b377a2-a5f9-43fc-80bb-7135344369ef"), "Gopal", 1, true, true, "B.K.", "Singh", "+9779749664075", new DateTime(2025, 8, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8000), "NPV-020-0006", 20 },
                    { new Guid("63b9ecac-fd66-436d-bd3b-832ee050eea3"), "Hari", 1, true, true, "Thapa", "Raj", "+9779809294939", new DateTime(2024, 10, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9980), "NPV-036-0005", 36 },
                    { new Guid("640c5467-eb63-42f6-9b3e-21fd310dbe81"), "Nabin", 1, true, false, "Tamang", "Raj", "+9779746705966", new DateTime(2024, 12, 31, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8210), "NPV-021-0010", 21 },
                    { new Guid("6439bf57-5b5d-4412-819b-bedfce233246"), "Sita", 2, true, true, "Karki", "Laxmi", "+9779819403944", new DateTime(2025, 8, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7110), "NPV-013-0001", 13 },
                    { new Guid("65f66d7c-72bc-47db-99b0-1902483d7660"), "Maya", 2, true, true, "Tamang", "Laxmi", "+9779851773810", new DateTime(2024, 2, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9850), "NPV-035-0002", 35 },
                    { new Guid("68746f2b-ce3e-4b6b-b3fb-f2cea0cb96fb"), "Bishnu", 1, true, true, "Karki", "Bahadur", "+9779632343124", new DateTime(2024, 5, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9450), "NPV-031-0009", 31 },
                    { new Guid("688bf43f-d661-4d49-b7cf-4cceff09490f"), "Sarita", 2, true, true, "Thapa", "Kumari", "+9779821796604", new DateTime(2024, 11, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9340), "NPV-030-0008", 30 },
                    { new Guid("68c97161-e5ce-4302-a871-3e746af4cf59"), "Shova", 2, true, true, "Thapa", "Devi", "+9779747591399", new DateTime(2025, 12, 2, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(980), "NPV-044-0008", 44 },
                    { new Guid("698f2e54-2960-4a55-bee5-2f1b125fe444"), "Nisha", 2, true, true, "Magar", "Kumari", "+9779849048354", new DateTime(2025, 6, 26, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7350), "NPV-014-0009", 14 },
                    { new Guid("6a81f38e-8b02-4caa-883e-da3a2666fca3"), "Bikash", 1, true, true, "Rai", "Prasad", "+9779807041158", new DateTime(2024, 7, 19, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(280), "NPV-038-0009", 38 },
                    { new Guid("6b08f3aa-0efa-4f22-af71-b85c522aad03"), "Krishna", 1, true, true, "Tamang", "Prasad", "+9779828326068", new DateTime(2025, 10, 11, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5710), "NPV-002-0001", 2 },
                    { new Guid("6b3d103b-77ed-4b6f-9154-41aa33b63569"), "Mohan", 1, true, true, "B.K.", "Bahadur", "+9779756164165", new DateTime(2025, 5, 11, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6830), "NPV-010-0004", 10 },
                    { new Guid("6b5b5aa6-6cda-4eed-ac43-bc2747e71366"), "Maya", 2, true, true, "Magar", "Devi", "+9779856584326", new DateTime(2024, 8, 29, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1100), "NPV-045-0010", 45 },
                    { new Guid("6b934704-4dcb-484f-bf0c-46034b5ec6c0"), "Rajesh", 1, true, true, "Yadav", "Singh", "+9779745576473", new DateTime(2025, 5, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7820), "NPV-018-0008", 18 },
                    { new Guid("6c6aa141-6a9e-4a17-a215-32b5b9eb146b"), "Bikash", 1, true, false, "B.K.", "Prasad", "+9779742136155", new DateTime(2024, 12, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6380), "NPV-006-0007", 6 },
                    { new Guid("6d3279eb-0268-4cd5-be00-7bcb8b7cfc98"), "Sarita", 2, true, true, "Rai", "Maya", "+9779826646200", new DateTime(2024, 8, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9440), "NPV-031-0008", 31 },
                    { new Guid("6d4bc376-8c9e-4f81-8997-097eb30516c8"), "Prakash", 1, true, true, "Tamang", "Kumar", "+9779639980641", new DateTime(2025, 9, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8380), "NPV-023-0006", 23 },
                    { new Guid("6dc1d417-7cd7-49c1-bb35-2e7ae24c4eb5"), "Ram", 1, true, true, "Magar", "Raj", "+9779846885993", new DateTime(2024, 3, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8580), "NPV-025-0002", 25 },
                    { new Guid("6e2c70dd-0028-4e19-a1e7-34c9660b6937"), "Bishnu", 1, true, true, "Rai", "Bahadur", "+9779847923960", new DateTime(2024, 7, 6, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1120), "NPV-046-0002", 46 },
                    { new Guid("6ea849f3-337c-43a8-aee0-3de335af958e"), "Hari", 1, true, true, "Gurung", "Raj", "+9779856667439", new DateTime(2024, 12, 25, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1420), "NPV-048-0005", 48 },
                    { new Guid("6f64b17d-de5c-4b33-afe4-753cdf67c071"), "Laxmi", 2, true, true, "Karki", "Kumari", "+9779824618716", new DateTime(2024, 11, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5680), "NPV-001-0008", 1 },
                    { new Guid("6f7f31fd-7fb5-42e7-952f-f413342a2125"), "Sita", 2, true, true, "Nepali", "Kumari", "+9779866776522", new DateTime(2025, 5, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9520), "NPV-032-0006", 32 },
                    { new Guid("6fa5a210-6b81-4164-b92a-c5a281fac191"), "Anita", 2, true, true, "Rai", "Kumari", "+9779752906116", new DateTime(2024, 9, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8730), "NPV-026-0007", 26 },
                    { new Guid("6fb7956a-aedc-4507-8dbc-a4b7f8ddf18c"), "Sita", 2, true, false, "Tamang", "Kumari", "+9779624500264", new DateTime(2024, 4, 28, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(960), "NPV-044-0006", 44 },
                    { new Guid("709306de-e9e3-4724-b6c8-22ad364405a1"), "Sunita", 2, true, true, "Yadav", "Kumari", "+9779805555309", new DateTime(2025, 4, 1, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8410), "NPV-023-0009", 23 },
                    { new Guid("70c0e3ee-d781-4a79-bd4e-a619f32f6e13"), "Maya", 2, true, true, "B.K.", "Devi", "+9779858494704", new DateTime(2024, 9, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6190), "NPV-005-0004", 5 },
                    { new Guid("713c6a4e-d1d3-4465-9383-2e10119faa2a"), "Sabitri", 2, true, true, "Khadka", "Maya", "+9779867942319", new DateTime(2025, 3, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5940), "NPV-002-0010", 2 },
                    { new Guid("72696a82-5982-44b9-8e34-3de8ed2e2f91"), "Laxmi", 2, true, true, "Sharma", "Devi", "+9779861826988", new DateTime(2024, 7, 11, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9900), "NPV-035-0007", 35 },
                    { new Guid("72827d75-0b2f-4b8d-b1f0-8f09cc8e4ae4"), "Ram", 1, true, true, "Khadka", "Prasad", "+9779635095424", new DateTime(2024, 11, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7380), "NPV-015-0002", 15 },
                    { new Guid("72f64578-9c9d-4325-984a-adc1ad578fdf"), "Gita", 2, true, true, "Karki", "Devi", "+9779884059790", new DateTime(2025, 7, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7530), "NPV-016-0006", 16 },
                    { new Guid("73fb4780-4a7c-4c9f-8294-2053b3ac760f"), "Maya", 2, true, true, "Gurung", "Devi", "+9779811164819", new DateTime(2024, 8, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6370), "NPV-006-0006", 6 },
                    { new Guid("748990af-8d29-424c-ae8d-610bed2d4955"), "Nisha", 2, true, true, "Nepali", "Maya", "+9779855958633", new DateTime(2025, 4, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8670), "NPV-026-0001", 26 },
                    { new Guid("74991083-2130-490d-be2c-875f0dac6556"), "Maya", 2, true, false, "Karki", "Maya", "+9779741611773", new DateTime(2025, 3, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8350), "NPV-023-0003", 23 },
                    { new Guid("75a218c8-8599-4fbf-8819-f36a9c3f84bd"), "Shova", 2, true, true, "Maharjan", "Devi", "+9779635368052", new DateTime(2025, 3, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6000), "NPV-003-0006", 3 },
                    { new Guid("764c622b-65bc-47aa-b6d3-ee02fe14b2d7"), "Nabin", 1, true, true, "Magar", "Raj", "+9779825196571", new DateTime(2024, 6, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6390), "NPV-006-0008", 6 },
                    { new Guid("76fbc3fc-8d52-482f-8e51-0fa583825188"), "Sunita", 2, true, true, "Rai", "Laxmi", "+9779763943608", new DateTime(2025, 12, 6, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(400), "NPV-039-0010", 39 },
                    { new Guid("7856ba0b-a24a-4933-99bc-079dddf8b611"), "Nabin", 1, true, true, "Sharma", "Raj", "+9779885666638", new DateTime(2024, 1, 3, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(350), "NPV-039-0005", 39 },
                    { new Guid("791d03cb-b8e2-4abd-b94e-01db75fdd98a"), "Anita", 2, true, true, "Thapa", "Maya", "+9779625689038", new DateTime(2025, 11, 21, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(340), "NPV-039-0004", 39 },
                    { new Guid("79ac1ef2-3dbe-4a75-b1e4-89339b513430"), "Bishnu", 1, true, false, "Chaudhary", "Kumar", "+9779886116942", new DateTime(2024, 12, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6820), "NPV-010-0003", 10 },
                    { new Guid("79c0f96e-a999-484d-98ad-4f6d192a440c"), "Arjun", 1, true, false, "Khadka", "Singh", "+9779801455046", new DateTime(2024, 7, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8170), "NPV-021-0006", 21 },
                    { new Guid("79c49dc0-2cb3-4dc0-87c2-9ebf4281bcaf"), "Bishnu", 1, true, true, "Magar", "Raj", "+9779758463619", new DateTime(2025, 8, 26, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6630), "NPV-008-0010", 8 },
                    { new Guid("79d7a9fd-7a6c-45df-9da5-3506c01b8cc5"), "Prakash", 1, true, true, "Rai", "Prasad", "+9779616556945", new DateTime(2024, 10, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5630), "NPV-001-0005", 1 },
                    { new Guid("7b1a98c2-8d12-43a3-8747-516816f90229"), "Parbati", 2, true, true, "Lama", "Devi", "+9779765243566", new DateTime(2025, 8, 10, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6640), "NPV-009-0001", 9 },
                    { new Guid("7b53fd40-c07a-4b99-93be-2e50abc1d021"), "Arjun", 1, true, true, "Shrestha", "Prasad", "+9779801716196", new DateTime(2025, 1, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7990), "NPV-020-0005", 20 },
                    { new Guid("7b6fc02c-a8e8-48c7-9879-2cb3a0ff78dc"), "Suresh", 1, true, false, "Magar", "Bahadur", "+9779754902500", new DateTime(2025, 1, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(620), "NPV-041-0010", 41 },
                    { new Guid("7c66adc0-c0ce-41bb-bb8b-b3fd982f7e05"), "Bishnu", 1, true, true, "Yadav", "Prasad", "+9779866552016", new DateTime(2024, 11, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8610), "NPV-025-0005", 25 },
                    { new Guid("7d06f89c-5e07-4831-add7-5d11e4abdb44"), "Maya", 2, true, true, "Karki", "Devi", "+9779808167221", new DateTime(2025, 5, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9000), "NPV-028-0003", 28 },
                    { new Guid("7d2fb34d-7e11-43a4-a892-4706e8dac634"), "Rupa", 2, true, true, "Khadka", "Maya", "+9779851316253", new DateTime(2025, 9, 1, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(910), "NPV-044-0002", 44 },
                    { new Guid("7deb2cd8-4b16-4c09-97b4-eb660082ec3d"), "Mohan", 1, true, false, "Lama", "Raj", "+9779612260691", new DateTime(2025, 2, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1060), "NPV-045-0006", 45 },
                    { new Guid("7ec30db1-fb21-46ec-a8f5-23b20126f329"), "Gopal", 1, true, true, "Karki", "Bahadur", "+9779758433601", new DateTime(2025, 1, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9650), "NPV-033-0008", 33 },
                    { new Guid("7f69a6eb-538f-46b6-b667-11c2141902b6"), "Santosh", 1, true, true, "Nepali", "Kumar", "+9779824414865", new DateTime(2024, 11, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9820), "NPV-034-0009", 34 },
                    { new Guid("80a8b828-6444-4ec4-b966-ada62b8a4f54"), "Dipak", 1, true, true, "Khadka", "Bahadur", "+9779631672162", new DateTime(2025, 11, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6090), "NPV-004-0004", 4 },
                    { new Guid("8275f3b7-24a0-459c-9b1c-24a0575f42a9"), "Bishnu", 1, true, true, "Maharjan", "Kumar", "+9779869365536", new DateTime(2025, 4, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7940), "NPV-019-0010", 19 },
                    { new Guid("82b84bb4-dbd8-4dc2-ac81-3b9f28c4e8b7"), "Laxmi", 2, true, true, "Chaudhary", "Laxmi", "+9779637708409", new DateTime(2024, 4, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8310), "NPV-022-0009", 22 },
                    { new Guid("82d5c798-3bbc-497a-9ed6-b24d988a6d25"), "Sarita", 2, true, true, "Magar", "Kumari", "+9779824730165", new DateTime(2025, 7, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6580), "NPV-008-0006", 8 },
                    { new Guid("83421e0f-6af4-44b5-9e14-bf2e88c7fb2d"), "Nisha", 2, true, true, "Yadav", "Devi", "+9779825479734", new DateTime(2025, 10, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9710), "NPV-034-0004", 34 },
                    { new Guid("843558bb-d052-4bac-8136-5cee53cadbee"), "Sarita", 2, true, true, "Maharjan", "Devi", "+9779761755790", new DateTime(2024, 6, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9470), "NPV-032-0001", 32 },
                    { new Guid("846fcfb4-23ab-4514-8aea-7db041661ff2"), "Arjun", 1, true, true, "Khadka", "Prasad", "+9779746664529", new DateTime(2024, 11, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7950), "NPV-020-0001", 20 },
                    { new Guid("84e81939-6dd4-4f8c-b821-b278f250287b"), "Ram", 1, true, true, "Khadka", "Bahadur", "+9779634993100", new DateTime(2025, 8, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7010), "NPV-012-0001", 12 },
                    { new Guid("84f2a2e7-97e4-465d-b6c8-f8f2983b629f"), "Nabin", 1, true, true, "Tamang", "Prasad", "+9779753636609", new DateTime(2024, 10, 18, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(600), "NPV-041-0008", 41 },
                    { new Guid("850e0eb6-581e-4841-876c-ebf1db3994e5"), "Maya", 2, true, true, "Magar", "Kumari", "+9779614554067", new DateTime(2024, 4, 11, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9350), "NPV-030-0009", 30 },
                    { new Guid("85753f39-52f8-4f68-9d48-d8c17324ce04"), "Shova", 2, true, true, "Tamang", "Devi", "+9779815722310", new DateTime(2024, 2, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7630), "NPV-016-0010", 16 },
                    { new Guid("8575db49-b417-4b29-bf9d-bce32619ff0f"), "Gita", 2, true, false, "Nepali", "Maya", "+9779612786762", new DateTime(2024, 1, 10, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(470), "NPV-040-0007", 40 },
                    { new Guid("859404d0-33cb-4a4f-996a-8d1b0a7b562c"), "Ram", 1, true, true, "Gurung", "Bahadur", "+9779817858995", new DateTime(2024, 11, 26, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9380), "NPV-031-0002", 31 },
                    { new Guid("86e2db2e-112a-458f-b91e-c9b4f0d2d2be"), "Arjun", 1, true, false, "Rai", "Bahadur", "+9779844719909", new DateTime(2025, 7, 31, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6500), "NPV-007-0008", 7 },
                    { new Guid("87465c78-caaf-41da-af6d-e9964d5d831f"), "Shyam", 1, true, false, "Khadka", "Singh", "+9779761137292", new DateTime(2024, 1, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7260), "NPV-013-0010", 13 },
                    { new Guid("875af2b9-d3aa-4254-bce9-67c15ac2b745"), "Parbati", 2, true, true, "Shrestha", "Devi", "+9779753143350", new DateTime(2025, 9, 1, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1460), "NPV-048-0009", 48 },
                    { new Guid("876f3597-ff3c-45a0-bd7d-85cef7fccc4c"), "Sarita", 2, true, true, "Gurung", "Kumari", "+9779752021799", new DateTime(2025, 5, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5950), "NPV-003-0001", 3 },
                    { new Guid("8829ee39-340e-4e66-83c6-7cc70032325f"), "Mohan", 1, true, true, "Yadav", "Singh", "+9779848607429", new DateTime(2025, 5, 25, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(90), "NPV-037-0005", 37 },
                    { new Guid("89156140-268c-43c6-adfe-dbe3f1e20366"), "Sita", 2, true, false, "Shrestha", "Maya", "+9779805190572", new DateTime(2025, 3, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9110), "NPV-029-0003", 29 },
                    { new Guid("8961085e-dd66-4099-84fb-110fef48da95"), "Santosh", 1, true, true, "B.K.", "Bahadur", "+9779627628135", new DateTime(2025, 3, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9090), "NPV-029-0001", 29 },
                    { new Guid("899e87cd-0cdd-4446-be4c-402141bdb5e5"), "Rekha", 2, true, true, "Lama", "Devi", "+9779625852590", new DateTime(2024, 4, 17, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(740), "NPV-042-0005", 42 },
                    { new Guid("89b81a63-824d-4490-a93a-80d3483ce2af"), "Shyam", 1, true, true, "Sharma", "Bahadur", "+9779747755502", new DateTime(2025, 11, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6010), "NPV-003-0007", 3 },
                    { new Guid("8abe5751-98bf-40e5-94ab-9ee532bb08e5"), "Prakash", 1, true, true, "Thapa", "Bahadur", "+9779746724348", new DateTime(2025, 7, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8700), "NPV-026-0004", 26 },
                    { new Guid("8c90363c-9155-4b0a-98cd-b589c8358a0f"), "Sabitri", 2, true, true, "Shrestha", "Laxmi", "+9779845332483", new DateTime(2024, 2, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9370), "NPV-031-0001", 31 },
                    { new Guid("8dbce918-0bed-4b6d-9e75-0fccc24815d0"), "Arjun", 1, true, false, "Chaudhary", "Singh", "+9779615409726", new DateTime(2024, 1, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6620), "NPV-008-0009", 8 },
                    { new Guid("8e199b6d-4373-45c5-b65f-313ad0062712"), "Rajesh", 1, true, true, "Yadav", "Kumar", "+9779742575356", new DateTime(2025, 3, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8690), "NPV-026-0003", 26 },
                    { new Guid("8ede26f0-78ac-4025-b5fb-023b21d4ad40"), "Gita", 2, true, true, "Gurung", "Maya", "+9779852374643", new DateTime(2024, 1, 1, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8140), "NPV-021-0003", 21 },
                    { new Guid("8ef5040d-179f-4c88-acae-54456342c2e6"), "Bikash", 1, true, true, "Sharma", "Singh", "+9779764283912", new DateTime(2025, 12, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6930), "NPV-011-0003", 11 },
                    { new Guid("8fe2543c-b7f2-4a9f-9434-ea0812059b18"), "Gopal", 1, true, true, "Lama", "Singh", "+9779765612912", new DateTime(2024, 4, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7090), "NPV-012-0009", 12 },
                    { new Guid("9014c0e3-553f-44c3-a004-0a91281e6206"), "Gita", 2, true, true, "Maharjan", "Devi", "+9779761579568", new DateTime(2025, 10, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8880), "NPV-027-0001", 27 },
                    { new Guid("907c53e8-8d97-4df0-bdde-c32c83328655"), "Shyam", 1, true, true, "Rai", "Singh", "+9779847086195", new DateTime(2025, 11, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8450), "NPV-024-0003", 24 },
                    { new Guid("908999fb-f9fd-4c8a-9d85-f762bd54a514"), "Bikash", 1, true, true, "Gurung", "Prasad", "+9779854077359", new DateTime(2025, 11, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9920), "NPV-035-0009", 35 },
                    { new Guid("909d2eec-61f8-45d4-80ab-548f291eee5e"), "Sabitri", 2, true, true, "Gurung", "Devi", "+9779622121429", new DateTime(2025, 10, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6800), "NPV-010-0001", 10 },
                    { new Guid("90f78e60-d117-454f-ba95-0e25bfc518cc"), "Rajesh", 1, true, true, "Tamang", "Raj", "+9779867239540", new DateTime(2024, 4, 5, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(170), "NPV-038-0003", 38 },
                    { new Guid("9193e477-c3a8-437b-9d90-87c7aa16d4f5"), "Ram", 1, true, true, "Maharjan", "Kumar", "+9779747334947", new DateTime(2025, 3, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7640), "NPV-017-0001", 17 },
                    { new Guid("91d3dca2-079a-40e0-84fe-a8501255b03d"), "Rupa", 2, true, true, "Gurung", "Laxmi", "+9779754572390", new DateTime(2024, 3, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9910), "NPV-035-0008", 35 },
                    { new Guid("92484b12-501c-4f46-8bd4-c4d8a1eb0ad8"), "Sita", 2, true, true, "Tamang", "Maya", "+9779634111498", new DateTime(2025, 9, 6, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1050), "NPV-045-0005", 45 },
                    { new Guid("93355fca-8088-46de-8eb0-d182dadeda08"), "Sabitri", 2, true, true, "B.K.", "Maya", "+9779632126713", new DateTime(2024, 6, 8, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(110), "NPV-037-0007", 37 },
                    { new Guid("9351acbb-5040-473c-8dc9-f6d07314d055"), "Hari", 1, true, true, "Karki", "Raj", "+9779619082616", new DateTime(2025, 11, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1360), "NPV-047-0009", 47 },
                    { new Guid("93660bc8-6ccc-4d1c-b3cd-7163a9600a36"), "Sarita", 2, true, true, "Khadka", "Kumari", "+9779622220224", new DateTime(2025, 3, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8900), "NPV-027-0003", 27 },
                    { new Guid("9378dd49-6f80-4c9d-bed0-bcff6e40812f"), "Rekha", 2, true, true, "Yadav", "Devi", "+9779862180172", new DateTime(2024, 2, 22, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(880), "NPV-043-0009", 43 },
                    { new Guid("93a59654-1a13-4aa8-957c-a5971d2598dc"), "Hari", 1, true, true, "Khadka", "Bahadur", "+9779844705034", new DateTime(2024, 8, 11, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8180), "NPV-021-0007", 21 },
                    { new Guid("93d7de53-3217-4c04-94f6-221099e0c7b4"), "Arjun", 1, true, true, "Nepali", "Kumar", "+9779883493945", new DateTime(2024, 11, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5580), "NPV-001-0002", 1 },
                    { new Guid("944c74b3-528b-47c2-8ae8-88d148150e23"), "Nisha", 2, true, true, "Shrestha", "Laxmi", "+9779637668874", new DateTime(2024, 10, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7140), "NPV-013-0004", 13 },
                    { new Guid("945992d5-b884-4761-a0f1-6ec64d400119"), "Radha", 2, true, true, "Rai", "Kumari", "+9779867857303", new DateTime(2024, 10, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7740), "NPV-018-0001", 18 },
                    { new Guid("9554fef0-f1a2-4bd8-b683-37d28ad16abe"), "Shyam", 1, true, true, "Tamang", "Raj", "+9779851763369", new DateTime(2025, 10, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7650), "NPV-017-0002", 17 },
                    { new Guid("96b3794d-bb93-439e-af13-ade170f16b62"), "Rekha", 2, true, true, "Shrestha", "Devi", "+9779883003272", new DateTime(2025, 4, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5790), "NPV-002-0008", 2 },
                    { new Guid("978a5d02-2417-4e2a-9de5-86bd1b67c3a4"), "Prakash", 1, true, true, "Maharjan", "Raj", "+9779611681468", new DateTime(2024, 8, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9040), "NPV-028-0006", 28 },
                    { new Guid("9905157f-8225-405e-a9dc-ea81ce0562f6"), "Sarita", 2, true, false, "Chaudhary", "Maya", "+9779816513151", new DateTime(2024, 10, 6, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(850), "NPV-043-0006", 43 },
                    { new Guid("99bb0f1a-0a4f-474c-9775-00b7ac918297"), "Rupa", 2, true, true, "Yadav", "Kumari", "+9779843517378", new DateTime(2025, 11, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6520), "NPV-007-0010", 7 },
                    { new Guid("99e37ffd-55eb-40c2-9052-e22d63aaa54a"), "Santosh", 1, true, true, "Tamang", "Raj", "+9779755988503", new DateTime(2024, 6, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9950), "NPV-036-0002", 36 },
                    { new Guid("9a4c7bec-f994-43c0-b4c0-f6177bb777a9"), "Rekha", 2, true, true, "Yadav", "Maya", "+9779824850582", new DateTime(2024, 5, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5770), "NPV-002-0006", 2 },
                    { new Guid("9a887c63-2cfa-4907-a341-7e4dc9c48737"), "Anita", 2, true, true, "Sharma", "Maya", "+9779767331766", new DateTime(2025, 10, 15, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9700), "NPV-034-0003", 34 },
                    { new Guid("9bfc233e-4ebf-4501-a072-c8b6d99b702f"), "Nabin", 1, true, true, "B.K.", "Kumar", "+9779636175468", new DateTime(2024, 11, 11, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(30), "NPV-036-0010", 36 },
                    { new Guid("9c50e604-9084-4750-bb76-ecb4024c98cd"), "Mohan", 1, true, false, "Lama", "Kumar", "+9779845327443", new DateTime(2025, 1, 2, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(50), "NPV-037-0002", 37 },
                    { new Guid("9c7d3d3a-79cb-4519-95f6-a845fda33760"), "Anita", 2, true, true, "Maharjan", "Laxmi", "+9779769564533", new DateTime(2025, 7, 25, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(820), "NPV-043-0003", 43 },
                    { new Guid("9dc1f4d3-d028-44f9-943c-4697ba3aab03"), "Gopal", 1, true, true, "Tamang", "Raj", "+9779767494040", new DateTime(2025, 8, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8340), "NPV-023-0002", 23 },
                    { new Guid("9de71d6b-5650-4ffe-81ca-4876b48afb09"), "Laxmi", 2, true, true, "Rai", "Kumari", "+9779611045362", new DateTime(2024, 2, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6200), "NPV-005-0005", 5 },
                    { new Guid("9e052f7a-767b-445d-92b0-5730c0a71b06"), "Mohan", 1, true, true, "Gurung", "Singh", "+9779865115177", new DateTime(2023, 12, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6110), "NPV-004-0006", 4 },
                    { new Guid("9e8f455f-8ee5-402b-bfb7-3ccf5fdbc4aa"), "Laxmi", 2, true, true, "Lama", "Laxmi", "+9779632201610", new DateTime(2024, 3, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7490), "NPV-016-0002", 16 },
                    { new Guid("9ea11c36-2e85-4c29-b5be-6c3e9700723e"), "Rupa", 2, true, true, "Karki", "Maya", "+9779622006803", new DateTime(2024, 12, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8220), "NPV-022-0001", 22 },
                    { new Guid("9f748b36-09f3-47fe-8196-fd718b2fc458"), "Dipak", 1, true, true, "Gurung", "Singh", "+9779742440801", new DateTime(2025, 1, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6050), "NPV-004-0001", 4 },
                    { new Guid("a00fdb1a-3516-49b6-98cc-a44e48b089f8"), "Sabitri", 2, true, true, "Lama", "Kumari", "+9779743593709", new DateTime(2025, 2, 15, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7240), "NPV-013-0009", 13 },
                    { new Guid("a0db8098-6ec1-47f5-8c03-6ff995219caf"), "Radha", 2, true, true, "Lama", "Maya", "+9779744688994", new DateTime(2025, 3, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9960), "NPV-036-0003", 36 },
                    { new Guid("a1364012-5019-420f-a93a-e4a8c909a5d5"), "Bikash", 1, true, true, "Nepali", "Singh", "+9779768501448", new DateTime(2025, 6, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5610), "NPV-001-0003", 1 },
                    { new Guid("a2cd7c91-6b87-4f24-bd75-dc8dfddd21b5"), "Sabitri", 2, true, false, "Rai", "Maya", "+9779757916162", new DateTime(2025, 9, 19, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1320), "NPV-047-0005", 47 },
                    { new Guid("a480caa3-edee-431e-a627-e56bd322fb5f"), "Nisha", 2, true, true, "Rai", "Laxmi", "+9779829180584", new DateTime(2025, 4, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9590), "NPV-033-0002", 33 },
                    { new Guid("a5079de6-85af-4be4-a439-9a2aa0935212"), "Parbati", 2, true, false, "Gurung", "Kumari", "+9779868401063", new DateTime(2024, 4, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9670), "NPV-033-0010", 33 },
                    { new Guid("a526b2ba-263c-4a20-9638-9a2c36b6118a"), "Sarita", 2, true, true, "Yadav", "Devi", "+9779857206311", new DateTime(2025, 9, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7770), "NPV-018-0004", 18 },
                    { new Guid("a66f7e6c-1a06-42d3-b105-7d7fb868aac7"), "Sita", 2, true, true, "Chaudhary", "Kumari", "+9779755143699", new DateTime(2025, 7, 7, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1330), "NPV-047-0006", 47 },
                    { new Guid("a69fb163-a4ff-43a4-8854-bc3b3c6fe53e"), "Rupa", 2, true, true, "Lama", "Kumari", "+9779758860922", new DateTime(2025, 11, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6900), "NPV-011-0001", 11 },
                    { new Guid("a76bcabc-a237-4391-a43a-b7fe087177a1"), "Sita", 2, true, true, "B.K.", "Kumari", "+9779881987164", new DateTime(2025, 3, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9660), "NPV-033-0009", 33 },
                    { new Guid("a7e94034-9d76-4221-8c05-592ed6810a96"), "Arjun", 1, true, true, "Maharjan", "Kumar", "+9779764054788", new DateTime(2025, 10, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9870), "NPV-035-0004", 35 },
                    { new Guid("a82a6686-22c7-4522-8050-38973bb8ad83"), "Sunita", 2, true, false, "Gurung", "Laxmi", "+9779611438886", new DateTime(2025, 2, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5780), "NPV-002-0007", 2 },
                    { new Guid("a84be7b0-17d7-4696-98ef-95d8870f7019"), "Rekha", 2, true, false, "Gurung", "Kumari", "+9779631650060", new DateTime(2024, 5, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5740), "NPV-002-0004", 2 },
                    { new Guid("a883d580-6959-4f43-85c1-8768f51a0a06"), "Nabin", 1, true, false, "Shrestha", "Kumar", "+9779755410426", new DateTime(2025, 10, 26, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(890), "NPV-043-0010", 43 },
                    { new Guid("a8bd592c-7e5e-4ca9-94ef-fe7a7a33f9b5"), "Nabin", 1, true, true, "Lama", "Raj", "+9779828670304", new DateTime(2024, 6, 5, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(920), "NPV-044-0003", 44 },
                    { new Guid("a8f58097-b673-4490-8d3a-d6f50cdd39fa"), "Nisha", 2, true, true, "Rai", "Laxmi", "+9779855792124", new DateTime(2025, 9, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8470), "NPV-024-0005", 24 },
                    { new Guid("a8fd2e4b-2dc5-4a26-89b3-ba898e558d2c"), "Arjun", 1, true, true, "Rai", "Bahadur", "+9779847502035", new DateTime(2024, 1, 28, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1340), "NPV-047-0007", 47 },
                    { new Guid("a94d0eab-837a-45cc-9203-d7d7d8b8527f"), "Sarita", 2, true, false, "Karki", "Laxmi", "+9779619549085", new DateTime(2025, 7, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8460), "NPV-024-0004", 24 },
                    { new Guid("a9c44447-9f85-4baf-a946-0c3d12971185"), "Sunita", 2, true, true, "Thapa", "Maya", "+9779885889033", new DateTime(2025, 1, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7900), "NPV-019-0006", 19 },
                    { new Guid("aa4389a7-ac35-48a1-a619-1cafa12de76a"), "Sarita", 2, true, true, "Maharjan", "Maya", "+9779628750507", new DateTime(2025, 11, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8100), "NPV-020-0010", 20 },
                    { new Guid("aa8a9130-f685-41c2-aebf-d806bb1bb6c1"), "Sunita", 2, true, true, "B.K.", "Kumari", "+9779632299080", new DateTime(2024, 2, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7540), "NPV-016-0007", 16 },
                    { new Guid("abc863a0-f31b-4d78-bfaa-5f4ce79a4295"), "Parbati", 2, true, true, "Tamang", "Kumari", "+9779867790171", new DateTime(2024, 8, 31, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9940), "NPV-036-0001", 36 },
                    { new Guid("abe123ef-8702-46dc-acb4-101a8ca8c5a9"), "Ram", 1, true, true, "Magar", "Bahadur", "+9779747227366", new DateTime(2024, 2, 1, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(480), "NPV-040-0008", 40 },
                    { new Guid("ac57c05c-ff01-4f99-92ab-2c22d566d49c"), "Anita", 2, true, true, "Lama", "Kumari", "+9779627940247", new DateTime(2024, 4, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8970), "NPV-027-0010", 27 },
                    { new Guid("ad07ec51-a03a-4e87-a5a3-9c8c2417c07e"), "Rajesh", 1, true, true, "Lama", "Singh", "+9779754664816", new DateTime(2025, 3, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6400), "NPV-006-0009", 6 },
                    { new Guid("ad134e8d-c073-406e-a9ef-bf1cfe230d6a"), "Shova", 2, true, true, "Lama", "Maya", "+9779635238429", new DateTime(2024, 6, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(800), "NPV-043-0001", 43 },
                    { new Guid("ad505ff7-135a-4321-99c9-ec707ff0d326"), "Nabin", 1, true, true, "B.K.", "Bahadur", "+9779612979045", new DateTime(2024, 2, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6420), "NPV-007-0001", 7 },
                    { new Guid("ad6c76f4-b3e4-47f9-8b99-c1c1c0507b3e"), "Gita", 2, true, true, "Tamang", "Kumari", "+9779623549367", new DateTime(2025, 11, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7680), "NPV-017-0005", 17 },
                    { new Guid("adc03b8a-649c-41ab-bac3-9159fd97441f"), "Bikash", 1, true, true, "Magar", "Singh", "+9779625569900", new DateTime(2025, 1, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7300), "NPV-014-0004", 14 },
                    { new Guid("ade8ccd9-db16-4896-9c55-010c141bb7e5"), "Sita", 2, true, true, "B.K.", "Devi", "+9779852253648", new DateTime(2025, 7, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9060), "NPV-028-0008", 28 },
                    { new Guid("adf21491-2422-4ba5-a332-d21a572c7bba"), "Laxmi", 2, true, true, "Chaudhary", "Laxmi", "+9779847943234", new DateTime(2024, 2, 3, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(450), "NPV-040-0005", 40 },
                    { new Guid("ae4ad1e7-bcfc-4877-9e8e-6e5d83989141"), "Rajesh", 1, true, true, "Rai", "Bahadur", "+9779825791545", new DateTime(2024, 7, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9410), "NPV-031-0005", 31 },
                    { new Guid("af429bfa-bb2b-4769-8cab-ebc541b208e7"), "Anita", 2, true, true, "Khadka", "Laxmi", "+9779858453149", new DateTime(2025, 4, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9080), "NPV-028-0010", 28 },
                    { new Guid("afb0cee7-6b0d-4f89-bdeb-ff6bef97b3c8"), "Arjun", 1, true, true, "Yadav", "Bahadur", "+9779864639802", new DateTime(2024, 3, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8440), "NPV-024-0002", 24 },
                    { new Guid("b079d814-9173-41d7-afd7-f3108da6e95c"), "Sabitri", 2, true, true, "Karki", "Kumari", "+9779637161243", new DateTime(2024, 7, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(590), "NPV-041-0007", 41 },
                    { new Guid("b0d741ec-d065-4092-a0c4-9dd5e9ff2060"), "Sunita", 2, true, true, "Shrestha", "Laxmi", "+9779821322384", new DateTime(2025, 8, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6970), "NPV-011-0007", 11 },
                    { new Guid("b38a045e-0e88-4a0f-99a8-b11acba45df0"), "Rupa", 2, true, true, "Khadka", "Maya", "+9779843100392", new DateTime(2024, 7, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8490), "NPV-024-0007", 24 },
                    { new Guid("b4013fa0-0757-415f-a3d0-0674703895c3"), "Bishnu", 1, true, true, "Magar", "Raj", "+9779627780134", new DateTime(2025, 8, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9070), "NPV-028-0009", 28 },
                    { new Guid("b4508008-a245-4077-8444-2736e5f852b6"), "Mohan", 1, true, true, "B.K.", "Raj", "+9779626432713", new DateTime(2025, 8, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1080), "NPV-045-0008", 45 },
                    { new Guid("b4820cd6-edf5-4f03-8182-a331d7562810"), "Prakash", 1, true, true, "Magar", "Prasad", "+9779755237160", new DateTime(2024, 10, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7370), "NPV-015-0001", 15 },
                    { new Guid("b5db0e45-9589-46a4-bbd4-7fcdc6e06cf9"), "Parbati", 2, true, true, "Magar", "Kumari", "+9779747559113", new DateTime(2025, 2, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8290), "NPV-022-0008", 22 },
                    { new Guid("b66c4cde-e3f4-4d24-9ff4-1e6d6235a1b5"), "Bishnu", 1, true, true, "Magar", "Raj", "+9779823925894", new DateTime(2025, 4, 19, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1030), "NPV-045-0003", 45 },
                    { new Guid("b6c510fd-b6b1-4c89-9e0f-bfa77176f92b"), "Bishnu", 1, true, true, "Magar", "Bahadur", "+9779769581520", new DateTime(2025, 1, 5, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(990), "NPV-044-0009", 44 },
                    { new Guid("b84aa50a-a14e-443a-93ee-f4f2450c1463"), "Ram", 1, true, false, "Chaudhary", "Bahadur", "+9779638089566", new DateTime(2024, 4, 8, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(520), "NPV-041-0002", 41 },
                    { new Guid("b8782261-70bf-4fc4-81e3-3958996f35e8"), "Rupa", 2, true, true, "Sharma", "Kumari", "+9779846835531", new DateTime(2025, 4, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8240), "NPV-022-0003", 22 },
                    { new Guid("b8b2b444-6c29-4d50-b1be-4fab46ec15e0"), "Anita", 2, true, true, "Magar", "Kumari", "+9779861130709", new DateTime(2025, 5, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6470), "NPV-007-0005", 7 },
                    { new Guid("ba44f6f1-6cfb-4c1e-89a7-643cee58fd14"), "Radha", 2, true, true, "Maharjan", "Laxmi", "+9779882376069", new DateTime(2025, 6, 10, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1400), "NPV-048-0003", 48 },
                    { new Guid("bb24ff8f-a998-48eb-b290-714548d45e38"), "Gopal", 1, true, true, "Rai", "Prasad", "+9779868540305", new DateTime(2025, 8, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5700), "NPV-001-0010", 1 },
                    { new Guid("bb29264b-9359-4584-ba10-902057c1c3c9"), "Shova", 2, true, true, "Chaudhary", "Maya", "+9779629120539", new DateTime(2024, 4, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8850), "NPV-026-0008", 26 },
                    { new Guid("bb64cdbf-78bf-47cd-ba78-cf6e8b8f0973"), "Santosh", 1, true, true, "Sharma", "Bahadur", "+9779617644218", new DateTime(2025, 4, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6020), "NPV-003-0008", 3 },
                    { new Guid("bc5d26dd-56f3-4f2c-9447-301f224d475e"), "Nisha", 2, true, true, "Gurung", "Laxmi", "+9779825499033", new DateTime(2025, 11, 8, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7670), "NPV-017-0004", 17 },
                    { new Guid("bd5540fd-5154-4c80-b2bb-5262bfbb51b6"), "Suresh", 1, true, false, "Thapa", "Singh", "+9779845169212", new DateTime(2025, 10, 20, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6960), "NPV-011-0006", 11 },
                    { new Guid("bfe2e758-4815-48c3-a0eb-fa939b8ea522"), "Bishnu", 1, true, true, "Tamang", "Prasad", "+9779747521158", new DateTime(2025, 4, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7550), "NPV-016-0008", 16 },
                    { new Guid("c02f5c7a-7b07-4299-a94a-c8df5d6f8770"), "Krishna", 1, true, true, "Maharjan", "Singh", "+9779888703506", new DateTime(2024, 10, 4, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(460), "NPV-040-0006", 40 },
                    { new Guid("c0519ea7-7692-4219-826e-1b42ef98d2ac"), "Sarita", 2, true, true, "Maharjan", "Maya", "+9779617330939", new DateTime(2025, 4, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9510), "NPV-032-0005", 32 },
                    { new Guid("c0a81260-940f-4162-93c9-860d69403ab2"), "Parbati", 2, true, true, "Maharjan", "Laxmi", "+9779767947293", new DateTime(2025, 3, 6, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(420), "NPV-040-0002", 40 },
                    { new Guid("c22c772d-68e0-4a2a-92ad-c136819c8c0a"), "Gita", 2, true, false, "Yadav", "Devi", "+9779612289055", new DateTime(2025, 3, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8190), "NPV-021-0008", 21 },
                    { new Guid("c3385521-edfa-41c1-a078-0552a623dd1a"), "Radha", 2, true, true, "Tamang", "Kumari", "+9779635013405", new DateTime(2024, 10, 31, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6480), "NPV-007-0006", 7 },
                    { new Guid("c34ccc04-b9c1-4e72-bb04-91f3a7c41f3b"), "Rajesh", 1, true, false, "Thapa", "Raj", "+9779744268130", new DateTime(2024, 4, 4, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8130), "NPV-021-0002", 21 },
                    { new Guid("c3cc4454-a09f-4218-a014-d16addb78ba4"), "Shyam", 1, true, false, "Shrestha", "Bahadur", "+9779856418784", new DateTime(2024, 12, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7340), "NPV-014-0008", 14 },
                    { new Guid("c518b8e1-ed27-4307-87f9-8ce3dc0573ad"), "Ram", 1, true, true, "Tamang", "Raj", "+9779861555278", new DateTime(2024, 1, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6810), "NPV-010-0002", 10 },
                    { new Guid("c552a9c8-d426-4ef3-a727-8db1e9bab073"), "Sarita", 2, true, true, "Shrestha", "Maya", "+9779624470660", new DateTime(2024, 12, 21, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(510), "NPV-041-0001", 41 },
                    { new Guid("c5b2e3eb-1f8f-4a43-9100-d98114ac151c"), "Sarita", 2, true, false, "Khadka", "Maya", "+9779768100776", new DateTime(2024, 4, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6890), "NPV-010-0010", 10 },
                    { new Guid("c65744a1-e322-4fef-aac0-ac10961901ef"), "Maya", 2, true, true, "Tamang", "Kumari", "+9779812516991", new DateTime(2024, 6, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6660), "NPV-009-0003", 9 },
                    { new Guid("c6dc6b96-8ad8-4f46-918e-03a08e5216f1"), "Sabitri", 2, true, true, "Magar", "Maya", "+9779803074246", new DateTime(2024, 10, 31, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9420), "NPV-031-0006", 31 },
                    { new Guid("c702144f-aa28-4424-99cb-fb3c59dfa6a5"), "Prakash", 1, true, true, "Magar", "Singh", "+9779852038602", new DateTime(2024, 10, 15, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8270), "NPV-022-0006", 22 },
                    { new Guid("c7904d44-639c-427c-845d-7c86120b2821"), "Nabin", 1, true, false, "B.K.", "Bahadur", "+9779769942004", new DateTime(2024, 9, 5, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(130), "NPV-037-0009", 37 },
                    { new Guid("c7d5fe7c-eda2-4316-b31f-9610622c68be"), "Rupa", 2, true, true, "Yadav", "Kumari", "+9779854077983", new DateTime(2025, 5, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9620), "NPV-033-0005", 33 },
                    { new Guid("c85fa97b-75e5-4338-b41b-72ba513de4ad"), "Anita", 2, true, true, "Sharma", "Kumari", "+9779744953146", new DateTime(2024, 5, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8390), "NPV-023-0007", 23 },
                    { new Guid("c87aee7c-d8f6-4c27-905f-2494fbc0ec8a"), "Bikash", 1, true, true, "Lama", "Prasad", "+9779746846775", new DateTime(2024, 2, 1, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(370), "NPV-039-0007", 39 },
                    { new Guid("c9bee6e3-a7b0-4ba0-9e27-9f30f60d5489"), "Gopal", 1, true, false, "Chaudhary", "Bahadur", "+9779865984856", new DateTime(2024, 11, 3, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7320), "NPV-014-0006", 14 },
                    { new Guid("ca2d2bca-dade-42aa-90f9-3136771b5dbf"), "Krishna", 1, true, false, "Thapa", "Prasad", "+9779614556262", new DateTime(2024, 8, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6430), "NPV-007-0002", 7 },
                    { new Guid("ca98d8eb-206b-4bf6-b444-8db05771a62c"), "Sarita", 2, true, true, "Yadav", "Maya", "+9779765401490", new DateTime(2024, 5, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7960), "NPV-020-0002", 20 },
                    { new Guid("cb673a3d-6866-4933-8a06-25ad3d4b9182"), "Gopal", 1, true, true, "Lama", "Raj", "+9779629263023", new DateTime(2024, 7, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7070), "NPV-012-0007", 12 },
                    { new Guid("cb69b574-6504-4cd3-b9d3-512aa7e4e671"), "Laxmi", 2, true, true, "Sharma", "Laxmi", "+9779847861186", new DateTime(2024, 5, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8960), "NPV-027-0009", 27 },
                    { new Guid("cb8e19b3-6645-491a-b514-ceea128a81bf"), "Parbati", 2, true, false, "Shrestha", "Laxmi", "+9779767170342", new DateTime(2024, 5, 13, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1450), "NPV-048-0008", 48 },
                    { new Guid("cc26d285-74df-46da-bcca-8c5ba4f3c875"), "Maya", 2, true, true, "Khadka", "Laxmi", "+9779811352853", new DateTime(2025, 9, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7620), "NPV-016-0009", 16 },
                    { new Guid("cc4cf764-f26f-4b33-8f8d-8d083ed4edc6"), "Parbati", 2, true, true, "Nepali", "Kumari", "+9779827843800", new DateTime(2025, 2, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9500), "NPV-032-0004", 32 },
                    { new Guid("cc4d69b1-f426-47dc-91eb-5e8782f00435"), "Bishnu", 1, true, true, "Thapa", "Prasad", "+9779805247013", new DateTime(2024, 2, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6040), "NPV-003-0010", 3 },
                    { new Guid("cd941e62-0eb2-4a43-b0bf-23c80b1f43e8"), "Rajesh", 1, true, true, "Nepali", "Raj", "+9779859681663", new DateTime(2024, 8, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(830), "NPV-043-0004", 43 },
                    { new Guid("ce2a74e7-108b-4eae-b3f3-3ddd09f002ac"), "Rekha", 2, true, false, "Maharjan", "Kumari", "+9779866371987", new DateTime(2024, 11, 15, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1350), "NPV-047-0008", 47 },
                    { new Guid("ce5860e1-adbf-4e1c-86ed-81e4bb11ed45"), "Shyam", 1, true, true, "Shrestha", "Prasad", "+9779847871297", new DateTime(2025, 4, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(550), "NPV-041-0004", 41 },
                    { new Guid("cf8d3e9f-2e75-45e8-98d5-f3994a67b446"), "Bishnu", 1, true, false, "Nepali", "Prasad", "+9779614465109", new DateTime(2024, 12, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9770), "NPV-034-0005", 34 },
                    { new Guid("d14d89e1-81e1-4669-8c1b-4880346424d6"), "Nabin", 1, true, true, "Khadka", "Bahadur", "+9779802982311", new DateTime(2025, 1, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7480), "NPV-016-0001", 16 },
                    { new Guid("d1d9d3e3-d8e8-4322-852f-6ef6c03778b8"), "Suresh", 1, true, true, "Sharma", "Singh", "+9779866339873", new DateTime(2023, 12, 25, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1390), "NPV-048-0002", 48 },
                    { new Guid("d1e1563c-ed43-4876-b65c-1738c46de74e"), "Bikash", 1, true, true, "B.K.", "Singh", "+9779854598948", new DateTime(2025, 5, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1040), "NPV-045-0004", 45 },
                    { new Guid("d21bc933-1f3f-4eef-9d7d-37c03c349a7b"), "Gita", 2, true, true, "Tamang", "Kumari", "+9779819406175", new DateTime(2024, 10, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9460), "NPV-031-0010", 31 },
                    { new Guid("d245af8a-d0ea-4bfe-9201-b5837666bf2f"), "Radha", 2, true, false, "Magar", "Kumari", "+9779889292571", new DateTime(2025, 6, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7870), "NPV-019-0003", 19 },
                    { new Guid("d2da6826-3d73-477b-946f-92f0a87f948b"), "Sita", 2, true, true, "Shrestha", "Laxmi", "+9779751350077", new DateTime(2025, 9, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6250), "NPV-005-0010", 5 },
                    { new Guid("d46fed31-638c-4c01-837d-a88092f25e9d"), "Shova", 2, true, true, "Rai", "Kumari", "+9779754023082", new DateTime(2024, 3, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7060), "NPV-012-0006", 12 },
                    { new Guid("d55e8e38-0765-48eb-b208-24517c27b4b8"), "Sarita", 2, true, false, "Magar", "Kumari", "+9779881192067", new DateTime(2024, 8, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7310), "NPV-014-0005", 14 },
                    { new Guid("d57c6fc6-da49-4933-8952-5746a08f1bd7"), "Nabin", 1, true, true, "Karki", "Prasad", "+9779802443400", new DateTime(2024, 2, 6, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1190), "NPV-046-0003", 46 },
                    { new Guid("d6476ba8-0d96-4492-8fe6-7d730c5e5ea0"), "Bikash", 1, true, true, "Shrestha", "Singh", "+9779863477362", new DateTime(2025, 4, 20, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(630), "NPV-042-0001", 42 },
                    { new Guid("d7fc12a9-6589-4f4f-a7ad-c7265f551b80"), "Nisha", 2, true, true, "B.K.", "Laxmi", "+9779759937258", new DateTime(2024, 7, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7160), "NPV-013-0006", 13 },
                    { new Guid("d930d33f-8564-4dfe-bcbc-3ee4c0964338"), "Maya", 2, true, true, "Khadka", "Laxmi", "+9779759146678", new DateTime(2024, 5, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5690), "NPV-001-0009", 1 },
                    { new Guid("db76dae9-1b66-4ce3-97ee-82c40e2d9d3d"), "Santosh", 1, true, false, "Sharma", "Raj", "+9779639081371", new DateTime(2024, 11, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7150), "NPV-013-0005", 13 },
                    { new Guid("dbe94b2b-3b88-448d-b07a-31271a9f2818"), "Hari", 1, true, true, "Tamang", "Singh", "+9779862341850", new DateTime(2025, 10, 22, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1070), "NPV-045-0007", 45 },
                    { new Guid("dc85eb25-2f41-4dd4-b112-80d3a470cd0a"), "Hari", 1, true, true, "Tamang", "Singh", "+9779802999421", new DateTime(2024, 11, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6210), "NPV-005-0006", 5 },
                    { new Guid("dc8983d7-8dcb-4c93-a8f8-d1d1ab0e6481"), "Suresh", 1, true, true, "Sharma", "Raj", "+9779885298636", new DateTime(2025, 6, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6150), "NPV-004-0010", 4 },
                    { new Guid("dcc17380-0ecd-4023-baf7-af308378a88c"), "Dipak", 1, true, true, "Gurung", "Kumar", "+9779842724001", new DateTime(2025, 10, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8650), "NPV-025-0009", 25 },
                    { new Guid("dd2d5ad6-77cd-4249-af98-4f01934893c7"), "Suresh", 1, true, true, "Magar", "Bahadur", "+9779754462623", new DateTime(2025, 2, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9970), "NPV-036-0004", 36 },
                    { new Guid("dd43ffc4-8e02-42ff-8e33-60dc6aa4dda7"), "Laxmi", 2, true, true, "Shrestha", "Maya", "+9779868519507", new DateTime(2025, 11, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9570), "NPV-032-0010", 32 },
                    { new Guid("dda9f1f1-c23c-4825-a614-92015bca9e96"), "Ram", 1, true, true, "Magar", "Prasad", "+9779764530895", new DateTime(2025, 3, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6240), "NPV-005-0009", 5 },
                    { new Guid("de19e34b-eb5c-4ce7-ab3b-afeb7780b5cb"), "Rekha", 2, true, true, "Maharjan", "Laxmi", "+9779813662080", new DateTime(2024, 11, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8160), "NPV-021-0005", 21 },
                    { new Guid("de6d5609-b3cf-4207-ba2d-4d98afb9b89d"), "Gita", 2, true, true, "Nepali", "Devi", "+9779858859495", new DateTime(2025, 5, 19, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(330), "NPV-039-0003", 39 },
                    { new Guid("de7f9918-0296-40b9-9e4f-243db3733f7c"), "Anita", 2, true, false, "Chaudhary", "Devi", "+9779828576413", new DateTime(2025, 4, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(70), "NPV-037-0003", 37 },
                    { new Guid("debef35f-2505-4c3d-8be8-760f4f2c1a83"), "Arjun", 1, true, true, "Sharma", "Singh", "+9779868327955", new DateTime(2024, 3, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9170), "NPV-029-0009", 29 },
                    { new Guid("df5e7659-7f19-4491-a292-aa38fc2bb6c0"), "Sarita", 2, true, true, "Thapa", "Kumari", "+9779855720607", new DateTime(2025, 4, 28, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1210), "NPV-046-0005", 46 },
                    { new Guid("dfc67774-7df7-477a-920d-ecdf986249c8"), "Bikash", 1, true, true, "Yadav", "Singh", "+9779633741104", new DateTime(2025, 8, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5670), "NPV-001-0007", 1 },
                    { new Guid("dfd1fbfe-16b8-4eda-ae36-7b133f3a16b4"), "Mohan", 1, true, true, "Magar", "Bahadur", "+9779746894435", new DateTime(2025, 6, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6880), "NPV-010-0009", 10 },
                    { new Guid("e00f5434-5b3e-4873-9403-bb17b8b8fc84"), "Radha", 2, true, true, "Yadav", "Devi", "+9779816724003", new DateTime(2024, 8, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9580), "NPV-033-0001", 33 },
                    { new Guid("e05b0968-c710-47fb-a66a-743386ded7cb"), "Rajesh", 1, true, true, "Lama", "Prasad", "+9779744949987", new DateTime(2024, 6, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7360), "NPV-014-0010", 14 },
                    { new Guid("e0f66997-cf5f-412c-9859-6248d29866f9"), "Prakash", 1, true, true, "B.K.", "Raj", "+9779861461916", new DateTime(2025, 2, 14, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7440), "NPV-015-0008", 15 },
                    { new Guid("e0fc1860-5b91-4657-abcc-ac89e3578015"), "Rajesh", 1, true, true, "Lama", "Singh", "+9779741715929", new DateTime(2025, 9, 21, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8250), "NPV-022-0004", 22 },
                    { new Guid("e106c05f-8b2c-4127-976a-15f43b67803d"), "Maya", 2, true, true, "B.K.", "Devi", "+9779634892141", new DateTime(2025, 9, 5, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(660), "NPV-042-0003", 42 },
                    { new Guid("e14747aa-fc4f-443c-af94-5677a1362670"), "Nisha", 2, true, false, "Shrestha", "Kumari", "+9779745051902", new DateTime(2025, 3, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(760), "NPV-042-0007", 42 },
                    { new Guid("e35de1c0-6e1e-4f83-8202-28f30ae35c82"), "Radha", 2, true, true, "Gurung", "Maya", "+9779744819992", new DateTime(2025, 10, 23, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(5970), "NPV-003-0003", 3 },
                    { new Guid("e41d428f-154b-4d2a-aa1f-59dacd8c29bf"), "Parbati", 2, true, true, "Maharjan", "Kumari", "+9779814323454", new DateTime(2025, 6, 20, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(270), "NPV-038-0008", 38 },
                    { new Guid("e48a24d4-6882-422f-86e9-d9b83c573c73"), "Sita", 2, true, true, "Gurung", "Kumari", "+9779865440977", new DateTime(2025, 4, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8990), "NPV-028-0002", 28 },
                    { new Guid("e498aa56-51e2-4194-b1fa-02d58a0f0ced"), "Santosh", 1, true, true, "Magar", "Kumar", "+9779634974569", new DateTime(2025, 2, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7000), "NPV-011-0010", 11 },
                    { new Guid("e52cdb62-d8f7-4d2b-b3bb-080d8af50755"), "Santosh", 1, true, true, "Lama", "Kumar", "+9779809172315", new DateTime(2024, 12, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9360), "NPV-030-0010", 30 },
                    { new Guid("e663e03f-2d52-4a4b-b704-8fc7bcc799ad"), "Rajesh", 1, true, true, "Maharjan", "Singh", "+9779865036484", new DateTime(2025, 9, 14, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1440), "NPV-048-0007", 48 },
                    { new Guid("e69e52dd-d29c-4d57-8c2e-45f55db7619f"), "Laxmi", 2, true, false, "Yadav", "Maya", "+9779823393840", new DateTime(2024, 5, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7850), "NPV-019-0001", 19 },
                    { new Guid("e719c807-775a-4a74-a55c-d0627991e950"), "Radha", 2, true, true, "Rai", "Kumari", "+9779763902495", new DateTime(2025, 3, 27, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1430), "NPV-048-0006", 48 },
                    { new Guid("e7262f17-1194-4a0d-b080-a66bf013fabe"), "Mohan", 1, true, true, "Chaudhary", "Singh", "+9779814271503", new DateTime(2024, 3, 29, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1010), "NPV-045-0001", 45 },
                    { new Guid("e7f5cab6-3a48-4a7c-945f-a636edcc27f3"), "Gita", 2, true, true, "Tamang", "Maya", "+9779815734974", new DateTime(2025, 9, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7980), "NPV-020-0004", 20 },
                    { new Guid("e90c4258-a01e-4201-96c8-0d02948ddc8f"), "Hari", 1, true, false, "Tamang", "Prasad", "+9779747057088", new DateTime(2024, 1, 9, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(310), "NPV-039-0001", 39 },
                    { new Guid("e95f4f8e-59c2-448f-a338-3c9054f41513"), "Parbati", 2, true, true, "Nepali", "Maya", "+9779763095655", new DateTime(2024, 11, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7780), "NPV-018-0005", 18 },
                    { new Guid("e964c957-6085-4ac3-80c1-1b7d9f40a2b5"), "Sarita", 2, true, true, "Thapa", "Devi", "+9779767928704", new DateTime(2024, 9, 6, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8600), "NPV-025-0004", 25 },
                    { new Guid("e96ce7dd-9f7f-43b1-b4e7-ce1509e69c59"), "Gita", 2, true, true, "Gurung", "Kumari", "+9779763923811", new DateTime(2025, 7, 16, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(580), "NPV-041-0006", 41 },
                    { new Guid("e9aa3eb8-e1cf-4241-a531-18551e7f81f0"), "Laxmi", 2, true, true, "Karki", "Kumari", "+9779633329530", new DateTime(2025, 1, 29, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(440), "NPV-040-0004", 40 },
                    { new Guid("e9d4bfa5-a8f2-476a-81b3-f341d329d0f4"), "Bikash", 1, true, true, "B.K.", "Raj", "+9779744819830", new DateTime(2024, 9, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6260), "NPV-006-0001", 6 },
                    { new Guid("e9ed591e-630a-415f-90c3-824085837405"), "Dipak", 1, true, true, "Maharjan", "Raj", "+9779741806228", new DateTime(2024, 4, 7, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(240), "NPV-038-0005", 38 },
                    { new Guid("ea08b6f9-1e0e-44b3-8d6c-7f6d57a1c9cf"), "Sabitri", 2, true, true, "B.K.", "Laxmi", "+9779815298083", new DateTime(2025, 4, 25, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8950), "NPV-027-0008", 27 },
                    { new Guid("eacad8ba-a2cb-4d07-8a5d-44fad9bde3c8"), "Bishnu", 1, true, false, "Shrestha", "Singh", "+9779637276764", new DateTime(2025, 5, 13, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6710), "NPV-009-0008", 9 },
                    { new Guid("ebf1fac9-7301-4c0d-9f0e-6e28c72f7ed7"), "Mohan", 1, true, true, "Maharjan", "Kumar", "+9779889320476", new DateTime(2025, 5, 28, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1020), "NPV-045-0002", 45 },
                    { new Guid("eca8718e-6ef8-4769-8773-dae2dd3064f0"), "Shova", 2, true, true, "B.K.", "Maya", "+9779866683985", new DateTime(2024, 6, 1, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7100), "NPV-012-0010", 12 },
                    { new Guid("ecf0e526-c5ed-476d-a1d2-ea8996451dfc"), "Bikash", 1, true, true, "Chaudhary", "Raj", "+9779761966554", new DateTime(2025, 6, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8010), "NPV-020-0007", 20 },
                    { new Guid("ed297108-7b50-4f8b-8ae8-4111f82a0ddb"), "Parbati", 2, true, false, "Gurung", "Devi", "+9779616687842", new DateTime(2023, 12, 27, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(320), "NPV-039-0002", 39 },
                    { new Guid("edafe71c-f2a5-44bf-aee6-5de88d792315"), "Prakash", 1, true, true, "Gurung", "Kumar", "+9779801206787", new DateTime(2024, 7, 26, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1230), "NPV-046-0007", 46 },
                    { new Guid("eddbd1bb-8f97-4e37-8051-5191f2b928d9"), "Parbati", 2, true, true, "Chaudhary", "Kumari", "+9779824851384", new DateTime(2025, 9, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7470), "NPV-015-0010", 15 },
                    { new Guid("eee3a518-b9cf-4d28-a776-c42f7170237c"), "Suresh", 1, true, true, "Sharma", "Prasad", "+9779867062829", new DateTime(2024, 2, 26, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6490), "NPV-007-0007", 7 },
                    { new Guid("eef1e53e-ede8-4ff8-8565-ba189419ea58"), "Anita", 2, true, true, "Lama", "Kumari", "+9779617063832", new DateTime(2024, 1, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7910), "NPV-019-0007", 19 },
                    { new Guid("ef8873ff-4e4e-4b7b-8862-049e20122555"), "Dipak", 1, true, false, "Maharjan", "Kumar", "+9779863746061", new DateTime(2025, 5, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8930), "NPV-027-0006", 27 },
                    { new Guid("f06ac7c6-e077-4768-bc64-1d8311cfb0e6"), "Mohan", 1, true, true, "Chaudhary", "Bahadur", "+9779615341148", new DateTime(2024, 7, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9550), "NPV-032-0009", 32 },
                    { new Guid("f0a505a3-9e21-490f-b1ab-0a7f41e3081e"), "Bikash", 1, true, true, "Sharma", "Singh", "+9779864925266", new DateTime(2024, 2, 6, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(840), "NPV-043-0005", 43 },
                    { new Guid("f1c6337f-046d-4ff0-a4d7-53e440df878d"), "Bikash", 1, true, true, "Magar", "Bahadur", "+9779627243153", new DateTime(2025, 10, 13, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1090), "NPV-045-0009", 45 },
                    { new Guid("f2c80fff-2669-4da2-b005-e734d055fb5c"), "Parbati", 2, true, false, "B.K.", "Laxmi", "+9779845554210", new DateTime(2024, 1, 1, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6290), "NPV-006-0004", 6 },
                    { new Guid("f2eaa520-955c-4f3b-aa2c-04ecf7e8fe98"), "Sarita", 2, true, true, "Sharma", "Kumari", "+9779801139780", new DateTime(2024, 1, 26, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1300), "NPV-047-0003", 47 },
                    { new Guid("f3af9e2a-83b3-420d-86a4-b248a75ac9c7"), "Prakash", 1, true, false, "Khadka", "Prasad", "+9779812396421", new DateTime(2025, 11, 10, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1270), "NPV-047-0001", 47 },
                    { new Guid("f3b677f5-ce59-418c-90f2-1a391d846f1f"), "Anita", 2, true, true, "B.K.", "Kumari", "+9779757360043", new DateTime(2025, 6, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9220), "NPV-030-0004", 30 },
                    { new Guid("f3cd63ad-0e62-4c6c-86ca-248cd74f2f73"), "Anita", 2, true, true, "Gurung", "Devi", "+9779854613287", new DateTime(2024, 3, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7290), "NPV-014-0003", 14 },
                    { new Guid("f3dda98a-a968-4908-89d6-04d287d7ab0a"), "Rajesh", 1, true, false, "Karki", "Bahadur", "+9779852638082", new DateTime(2025, 5, 29, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8680), "NPV-026-0002", 26 },
                    { new Guid("f4212739-e40a-479f-afc9-bb696bf37f5f"), "Bishnu", 1, true, true, "Khadka", "Singh", "+9779853981433", new DateTime(2025, 2, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7040), "NPV-012-0004", 12 },
                    { new Guid("f48aa1c3-a245-43b9-b8ce-2ca254b1efe4"), "Rajesh", 1, true, false, "Lama", "Prasad", "+9779768727619", new DateTime(2024, 5, 17, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8370), "NPV-023-0005", 23 },
                    { new Guid("f4e9fdbe-7713-4c53-956a-a57c7551b9a5"), "Suresh", 1, true, true, "Gurung", "Bahadur", "+9779612371382", new DateTime(2025, 9, 22, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6550), "NPV-008-0003", 8 },
                    { new Guid("f59c9212-9109-425f-942c-df2a84dda14a"), "Gita", 2, true, true, "Lama", "Laxmi", "+9779632551563", new DateTime(2025, 7, 24, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7450), "NPV-015-0009", 15 },
                    { new Guid("f5dc8b0c-4ced-4a61-82c4-c14f477260ca"), "Parbati", 2, true, true, "Gurung", "Kumari", "+9779753601138", new DateTime(2024, 12, 30, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(260), "NPV-038-0007", 38 },
                    { new Guid("f61c8956-1591-4735-a41b-862a97091221"), "Laxmi", 2, true, false, "Gurung", "Kumari", "+9779852842201", new DateTime(2025, 7, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6700), "NPV-009-0007", 9 },
                    { new Guid("f6742e74-9572-4ecf-9a50-7423df07f269"), "Krishna", 1, true, true, "Lama", "Prasad", "+9779817227799", new DateTime(2024, 1, 8, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(1110), "NPV-046-0001", 46 },
                    { new Guid("f6f05f4d-a321-4b89-a3f0-f524ac358af5"), "Anita", 2, true, true, "Magar", "Kumari", "+9779889584529", new DateTime(2024, 5, 16, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(80), "NPV-037-0004", 37 },
                    { new Guid("f7bc7901-4275-4d46-95ef-0890299e0212"), "Krishna", 1, true, true, "Thapa", "Singh", "+9779764930742", new DateTime(2025, 2, 18, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9930), "NPV-035-0010", 35 },
                    { new Guid("f7ef842d-9f33-4806-a76a-cdf84fb47cf7"), "Rekha", 2, true, true, "Thapa", "Kumari", "+9779857974523", new DateTime(2024, 7, 9, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6270), "NPV-006-0002", 6 },
                    { new Guid("f92bba68-31d9-4e97-9244-6d7070eb14cb"), "Nisha", 2, true, true, "Nepali", "Laxmi", "+9779869387463", new DateTime(2024, 2, 2, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9640), "NPV-033-0007", 33 },
                    { new Guid("fa414ae1-9d49-45fe-b6ac-6cf47c678a67"), "Nabin", 1, true, true, "Sharma", "Bahadur", "+9779829129210", new DateTime(2025, 5, 30, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8550), "NPV-024-0009", 24 },
                    { new Guid("fafa3d5a-abcb-4a45-83db-8856ffb5510e"), "Shova", 2, true, true, "Karki", "Devi", "+9779742019016", new DateTime(2025, 6, 4, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(410), "NPV-040-0001", 40 },
                    { new Guid("fb6bda45-3df0-4a88-b953-c1a46d4cea5e"), "Nabin", 1, true, true, "Chaudhary", "Kumar", "+9779612920478", new DateTime(2024, 3, 19, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7080), "NPV-012-0008", 12 },
                    { new Guid("fc6f61c0-093f-4e9d-baa2-78eee55ee60e"), "Sarita", 2, true, true, "Yadav", "Laxmi", "+9779828844354", new DateTime(2024, 3, 7, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(9780), "NPV-034-0006", 34 },
                    { new Guid("fcc32084-ad6d-4f6f-ba07-c676238e7d2a"), "Prakash", 1, true, true, "Tamang", "Prasad", "+9779848377700", new DateTime(2024, 3, 11, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(7120), "NPV-013-0002", 13 },
                    { new Guid("fd00e628-87fc-4fb9-938a-bccef98d93fb"), "Prakash", 1, true, true, "Rai", "Singh", "+9779805031648", new DateTime(2025, 9, 12, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6130), "NPV-004-0008", 4 },
                    { new Guid("fd3b3c4e-1d56-4e31-af25-c0ec75af8f22"), "Sita", 2, true, true, "Magar", "Devi", "+9779827298004", new DateTime(2024, 4, 1, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6410), "NPV-006-0010", 6 },
                    { new Guid("fe15359c-ca19-4d2b-b805-e5d393483159"), "Mohan", 1, true, true, "Chaudhary", "Prasad", "+9779819638248", new DateTime(2025, 1, 24, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(360), "NPV-039-0006", 39 },
                    { new Guid("fe5469ff-80e1-40ec-b7b9-6d6036840197"), "Rekha", 2, true, false, "Shrestha", "Kumari", "+9779765366602", new DateTime(2024, 7, 16, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6860), "NPV-010-0007", 10 },
                    { new Guid("feb41275-8269-459b-ab00-10f23beacfb2"), "Anita", 2, true, true, "Lama", "Kumari", "+9779805915493", new DateTime(2024, 6, 27, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6230), "NPV-005-0008", 5 },
                    { new Guid("fee0901d-328e-4f1d-a9b1-164db3648427"), "Sita", 2, true, true, "Shrestha", "Devi", "+9779753636262", new DateTime(2024, 2, 5, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(8870), "NPV-026-0010", 26 },
                    { new Guid("fefdb00d-51d4-4e63-a77a-a9aae9e7dedf"), "Ram", 1, true, true, "Yadav", "Singh", "+9779807573203", new DateTime(2025, 1, 28, 22, 35, 36, 442, DateTimeKind.Utc).AddTicks(6990), "NPV-011-0009", 11 },
                    { new Guid("ff4307d0-7fb5-4585-9a34-4f117131451b"), "Radha", 2, true, true, "Karki", "Maya", "+9779849923950", new DateTime(2024, 3, 25, 22, 35, 36, 443, DateTimeKind.Utc).AddTicks(540), "NPV-041-0003", 41 }
                });
        }
    }
}
