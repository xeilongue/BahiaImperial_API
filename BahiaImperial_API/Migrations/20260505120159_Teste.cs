using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BahiaImperial_API.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Loan_Status",
                table: "loans",
                newName: "LoanStatus");

            migrationBuilder.RenameColumn(
                name: "Initial_Loan",
                table: "loans",
                newName: "InitialLoan");

            migrationBuilder.RenameColumn(
                name: "Current_Loan",
                table: "loans",
                newName: "CurrentLoan");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "loans",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "users",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoanStatus",
                table: "loans",
                newName: "Loan_Status");

            migrationBuilder.RenameColumn(
                name: "InitialLoan",
                table: "loans",
                newName: "Initial_Loan");

            migrationBuilder.RenameColumn(
                name: "CurrentLoan",
                table: "loans",
                newName: "Current_Loan");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "loans",
                newName: "Created_At");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "users",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
