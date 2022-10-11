using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBankMSApi.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonorDonations_BloodDonors_BloodDonorId1",
                table: "BloodDonorDonations");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonorDonations_BloodDonorId1",
                table: "BloodDonorDonations");

            migrationBuilder.DropColumn(
                name: "BloodDonorId1",
                table: "BloodDonorDonations");

            migrationBuilder.AlterColumn<int>(
                name: "BloodDonorId",
                table: "BloodDonorDonations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonorDonations_BloodDonorId",
                table: "BloodDonorDonations",
                column: "BloodDonorId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodDonorDonations_BloodDonors_BloodDonorId",
                table: "BloodDonorDonations",
                column: "BloodDonorId",
                principalTable: "BloodDonors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonorDonations_BloodDonors_BloodDonorId",
                table: "BloodDonorDonations");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonorDonations_BloodDonorId",
                table: "BloodDonorDonations");

            migrationBuilder.AlterColumn<string>(
                name: "BloodDonorId",
                table: "BloodDonorDonations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BloodDonorId1",
                table: "BloodDonorDonations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonorDonations_BloodDonorId1",
                table: "BloodDonorDonations",
                column: "BloodDonorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodDonorDonations_BloodDonors_BloodDonorId1",
                table: "BloodDonorDonations",
                column: "BloodDonorId1",
                principalTable: "BloodDonors",
                principalColumn: "Id");
        }
    }
}
