using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tastings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Producer = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Varietal = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Vintage = table.Column<int>(type: "INTEGER", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TastingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    EyeIntensity = table.Column<int>(type: "INTEGER", nullable: false),
                    EyeColor = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    EyeOther = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    NoseIntensity = table.Column<int>(type: "INTEGER", nullable: false),
                    AromasPrimary = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    AromasSecondary = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    AromasTertiary = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Sweetness = table.Column<int>(type: "INTEGER", nullable: false),
                    Acidity = table.Column<int>(type: "INTEGER", nullable: false),
                    Tannins = table.Column<int>(type: "INTEGER", nullable: true),
                    Alcohol = table.Column<int>(type: "INTEGER", nullable: false),
                    Body = table.Column<int>(type: "INTEGER", nullable: false),
                    FlavorIntensity = table.Column<int>(type: "INTEGER", nullable: false),
                    Finish = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    QPrRatio = table.Column<int>(type: "INTEGER", nullable: false),
                    Repurchase = table.Column<int>(type: "INTEGER", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tastings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tastings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tastings_UserId",
                table: "Tastings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tastings");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
