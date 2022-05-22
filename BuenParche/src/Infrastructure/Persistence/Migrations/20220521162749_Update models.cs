using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuenParche.Infrastructure.Persistence.Migrations
{
    public partial class Updatemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeCountry = table.Column<int>(type: "int", nullable: false),
                    CityCountry = table.Column<int>(type: "int", nullable: false),
                    BornDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActivatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPremium = table.Column<bool>(type: "bit", nullable: false),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusicMoviesBooks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SportsHobbies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoogleUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAzureDirectory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLogout = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    IsLogged = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
