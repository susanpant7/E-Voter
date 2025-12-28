using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Voter.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addUniqueCols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WardName",
                table: "Wards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VotingPlaceAddress",
                table: "VotingPlaces",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceName",
                table: "Provinces",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceCode",
                table: "Provinces",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MunicipalityName",
                table: "Municipalities",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MunicipalityCode",
                table: "Municipalities",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DistrictName",
                table: "Districts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DistrictCode",
                table: "Districts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_MunicipalityId_WardName",
                table: "Wards",
                columns: new[] { "MunicipalityId", "WardName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wards_MunicipalityId_WardNumber",
                table: "Wards",
                columns: new[] { "MunicipalityId", "WardNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VotingPlaces_VotingPlaceAddress",
                table: "VotingPlaces",
                column: "VotingPlaceAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_ProvinceCode",
                table: "Provinces",
                column: "ProvinceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_ProvinceName",
                table: "Provinces",
                column: "ProvinceName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_DistrictId_MunicipalityCode",
                table: "Municipalities",
                columns: new[] { "DistrictId", "MunicipalityCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_DistrictId_MunicipalityName",
                table: "Municipalities",
                columns: new[] { "DistrictId", "MunicipalityName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId_DistrictCode",
                table: "Districts",
                columns: new[] { "ProvinceId", "DistrictCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId_DistrictName",
                table: "Districts",
                columns: new[] { "ProvinceId", "DistrictName" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Wards_MunicipalityId_WardName",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Wards_MunicipalityId_WardNumber",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_VotingPlaces_VotingPlaceAddress",
                table: "VotingPlaces");

            migrationBuilder.DropIndex(
                name: "IX_Provinces_ProvinceCode",
                table: "Provinces");

            migrationBuilder.DropIndex(
                name: "IX_Provinces_ProvinceName",
                table: "Provinces");

            migrationBuilder.DropIndex(
                name: "IX_Municipalities_DistrictId_MunicipalityCode",
                table: "Municipalities");

            migrationBuilder.DropIndex(
                name: "IX_Municipalities_DistrictId_MunicipalityName",
                table: "Municipalities");

            migrationBuilder.DropIndex(
                name: "IX_Districts_ProvinceId_DistrictCode",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_ProvinceId_DistrictName",
                table: "Districts");

            migrationBuilder.AlterColumn<string>(
                name: "WardName",
                table: "Wards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "VotingPlaceAddress",
                table: "VotingPlaces",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceName",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceCode",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MunicipalityName",
                table: "Municipalities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "MunicipalityCode",
                table: "Municipalities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DistrictName",
                table: "Districts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "DistrictCode",
                table: "Districts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

        }
    }
}
