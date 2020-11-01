using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSportGroup.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    birthDate = table.Column<DateTime>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    Neighborhood = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    zipCode = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(maxLength: 14, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Identifier = table.Column<string>(maxLength: 11, nullable: false),
                    Passworld = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
