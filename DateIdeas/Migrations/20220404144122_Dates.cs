using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DateIdeas.Migrations
{
    public partial class Dates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateIdeas",
                columns: table => new
                {
                    DateId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<string>(type: "text", nullable: true),
                    RainyDay = table.Column<bool>(type: "boolean", nullable: false),
                    SunnyDay = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateIdeas", x => x.DateId);
                });

            migrationBuilder.InsertData(
                table: "DateIdeas",
                columns: new[] { "DateId", "Date", "RainyDay", "SunnyDay" },
                values: new object[,]
                {
                    { 1, "passear", false, false },
                    { 2, "comer", false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateIdeas");
        }
    }
}
