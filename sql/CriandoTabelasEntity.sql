using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LizBrunner.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    IsReceivingInformation = table.Column<bool>(type: "bit", nullable: false),
                    IsVip = table.Column<bool>(type: "bit", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Street = table.Column<string>(type: "varchar(100)", nullable: false),
                    Number = table.Column<string>(type: "varchar(150)", nullable: false),
                    Complement = table.Column<string>(type: "varchar(70)", nullable: true),
                    Zipcode = table.Column<string>(type: "varchar(150)", nullable: false),
                    Neighborhood = table.Column<string>(type: "varchar(70)", nullable: false),
                    City = table.Column<string>(type: "varchar(150)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
