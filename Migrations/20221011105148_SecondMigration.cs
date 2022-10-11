using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBankMSApi.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonationCamps_Admins_AdminId",
                table: "BloodDonationCamps");

            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonorDonations_BloodDonors_BloodDonorId",
                table: "BloodDonorDonations");

            migrationBuilder.DropForeignKey(
                name: "FK_BloodInventories_Admins_AdminId",
                table: "BloodInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Admins_AdminId",
                table: "Hospitals");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_AdminId",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonorDonations_BloodDonorId",
                table: "BloodDonorDonations");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonationCamps_AdminId",
                table: "BloodDonationCamps");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "BloodDonorBloodDonorId",
                table: "BloodDonorDonations");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "BloodDonationCamps");

            migrationBuilder.RenameColumn(
                name: "AdminBloodBankId",
                table: "Hospitals",
                newName: "BloodBankId");

            migrationBuilder.RenameColumn(
                name: "HospitalId",
                table: "Hospitals",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "BloodInventories",
                newName: "BloodBankId");

            migrationBuilder.RenameColumn(
                name: "BloodInventoryId",
                table: "BloodInventories",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_BloodInventories_AdminId",
                table: "BloodInventories",
                newName: "IX_BloodInventories_BloodBankId");

            migrationBuilder.RenameColumn(
                name: "BloodDonorId",
                table: "BloodDonors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BloodDonorDonationId",
                table: "BloodDonorDonations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AdminBloodBankId",
                table: "BloodDonationCamps",
                newName: "BloodBankId");

            migrationBuilder.RenameColumn(
                name: "BloodDonationCampId",
                table: "BloodDonationCamps",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "BloodDonorId",
                table: "BloodDonorDonations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BloodDonorId1",
                table: "BloodDonorDonations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BloodBanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodBankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodBanks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_BloodBankId",
                table: "Hospitals",
                column: "BloodBankId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonorDonations_BloodDonorId1",
                table: "BloodDonorDonations",
                column: "BloodDonorId1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BloodDonorDonations_BloodDonors_BloodDonorId1",
                table: "BloodDonorDonations",
                column: "BloodDonorId1",
                principalTable: "BloodDonors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodInventories_BloodBanks_BloodBankId",
                table: "BloodInventories",
                column: "BloodBankId",
                principalTable: "BloodBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_BloodBanks_BloodBankId",
                table: "Hospitals",
                column: "BloodBankId",
                principalTable: "BloodBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonationCamps_BloodBanks_BloodBankId",
                table: "BloodDonationCamps");

            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonorDonations_BloodDonors_BloodDonorId1",
                table: "BloodDonorDonations");

            migrationBuilder.DropForeignKey(
                name: "FK_BloodInventories_BloodBanks_BloodBankId",
                table: "BloodInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_BloodBanks_BloodBankId",
                table: "Hospitals");

            migrationBuilder.DropTable(
                name: "BloodBanks");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_BloodBankId",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonorDonations_BloodDonorId1",
                table: "BloodDonorDonations");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonationCamps_BloodBankId",
                table: "BloodDonationCamps");

            migrationBuilder.DropColumn(
                name: "BloodDonorId1",
                table: "BloodDonorDonations");

            migrationBuilder.RenameColumn(
                name: "BloodBankId",
                table: "Hospitals",
                newName: "AdminBloodBankId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hospitals",
                newName: "HospitalId");

            migrationBuilder.RenameColumn(
                name: "BloodBankId",
                table: "BloodInventories",
                newName: "AdminId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BloodInventories",
                newName: "BloodInventoryId");

            migrationBuilder.RenameIndex(
                name: "IX_BloodInventories_BloodBankId",
                table: "BloodInventories",
                newName: "IX_BloodInventories_AdminId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BloodDonors",
                newName: "BloodDonorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BloodDonorDonations",
                newName: "BloodDonorDonationId");

            migrationBuilder.RenameColumn(
                name: "BloodBankId",
                table: "BloodDonationCamps",
                newName: "AdminBloodBankId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BloodDonationCamps",
                newName: "BloodDonationCampId");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Hospitals",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BloodDonorId",
                table: "BloodDonorDonations",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "BloodDonorBloodDonorId",
                table: "BloodDonorDonations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "BloodDonationCamps",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodBankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<long>(type: "bigint", nullable: false),
                    Password = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_AdminId",
                table: "Hospitals",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonorDonations_BloodDonorId",
                table: "BloodDonorDonations",
                column: "BloodDonorId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonationCamps_AdminId",
                table: "BloodDonationCamps",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodDonationCamps_Admins_AdminId",
                table: "BloodDonationCamps",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodDonorDonations_BloodDonors_BloodDonorId",
                table: "BloodDonorDonations",
                column: "BloodDonorId",
                principalTable: "BloodDonors",
                principalColumn: "BloodDonorId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodInventories_Admins_AdminId",
                table: "BloodInventories",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Admins_AdminId",
                table: "Hospitals",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");
        }
    }
}
