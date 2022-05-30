using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoCinema.Migrations
{
    public partial class horarioFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HorarioFinal",
                table: "Sessao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorarioFinal",
                table: "Sessao");
        }
    }
}
