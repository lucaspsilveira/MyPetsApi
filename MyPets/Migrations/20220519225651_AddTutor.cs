using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPets.Migrations
{
    public partial class AddTutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TutorId",
                table: "Pets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tutors",
                columns: table => new
                {
                    TutorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutors", x => x.TutorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_TutorId",
                table: "Pets",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Tutors_TutorId",
                table: "Pets",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "TutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Tutors_TutorId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "Tutors");

            migrationBuilder.DropIndex(
                name: "IX_Pets_TutorId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Pets");
        }
    }
}
