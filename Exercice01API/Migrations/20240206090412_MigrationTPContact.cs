using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice01API.Migrations
{
    public partial class MigrationTPContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avatarURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "contact",
                columns: new[] { "id", "avatarURL", "email", "firstname", "lastname", "password", "phone" },
                values: new object[] { 1, " URL1 ", "Jean.Dakd@gmail.com", "Jean ", " Dakd", " ICOZJQI", "07112562" });

            migrationBuilder.InsertData(
                table: "contact",
                columns: new[] { "id", "avatarURL", "email", "firstname", "lastname", "password", "phone" },
                values: new object[] { 2, " URL 2", "Alfred.aziod@gmail.com", "Alfred ", "aziod", " QZCNQj", "0658421895" });

            migrationBuilder.InsertData(
                table: "contact",
                columns: new[] { "id", "avatarURL", "email", "firstname", "lastname", "password", "phone" },
                values: new object[] { 3, " URL 3", "Nicolas.oczz@gmail.com", "Nicolas ", "oczz", " KOQVN?QKkd", "0715289173" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contact");
        }
    }
}
