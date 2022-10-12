using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBankMSApi.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BloodDonationCampId",
                table: "BloodDonorDonations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonorDonations_BloodDonationCampId",
                table: "BloodDonorDonations",
                column: "BloodDonationCampId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodDonorDonations_BloodDonationCamps_BloodDonationCampId",
                table: "BloodDonorDonations",
                column: "BloodDonationCampId",
                principalTable: "BloodDonationCamps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonorDonations_BloodDonationCamps_BloodDonationCampId",
                table: "BloodDonorDonations");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonorDonations_BloodDonationCampId",
                table: "BloodDonorDonations");

            migrationBuilder.DropColumn(
                name: "BloodDonationCampId",
                table: "BloodDonorDonations");
        }
    }
}
