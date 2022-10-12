using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBankMSApi.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonationCamps_BloodBanks_BloodBankId",
                table: "BloodDonationCamps");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonationCamps_BloodBankId",
                table: "BloodDonationCamps");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BloodBanks",
                newName: "BloodBankId");

            migrationBuilder.AddColumn<int>(
                name: "BloodBankId",
                table: "BloodDonorDonations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "BloodDonorDonations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodBankId",
                table: "BloodDonorDonations");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "BloodDonorDonations");

            migrationBuilder.RenameColumn(
                name: "BloodBankId",
                table: "BloodBanks",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonationCamps_BloodBankId",
                table: "BloodDonationCamps",
                column: "BloodBankId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodDonationCamps_BloodBanks_BloodBankId",
                table: "BloodDonationCamps",
                column: "BloodBankId",
                principalTable: "BloodBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
