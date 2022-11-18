using Microsoft.EntityFrameworkCore.Migrations;

namespace OUW_DAL.Migrations
{
    public partial class migupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bankAccountDetails_Customers_ID",
                table: "bankAccountDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bankAccountDetails",
                table: "bankAccountDetails");

            migrationBuilder.RenameTable(
                name: "bankAccountDetails",
                newName: "BankAccountDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankAccountDetails",
                table: "BankAccountDetails",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccountDetails_Customers_ID",
                table: "BankAccountDetails",
                column: "ID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccountDetails_Customers_ID",
                table: "BankAccountDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankAccountDetails",
                table: "BankAccountDetails");

            migrationBuilder.RenameTable(
                name: "BankAccountDetails",
                newName: "bankAccountDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bankAccountDetails",
                table: "bankAccountDetails",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_bankAccountDetails_Customers_ID",
                table: "bankAccountDetails",
                column: "ID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
