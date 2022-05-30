using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoCinema.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Compra_SessaoId",
                table: "Compra",
                column: "SessaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Sessao_SessaoId",
                table: "Compra",
                column: "SessaoId",
                principalTable: "Sessao",
                principalColumn: "SessaoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Sessao_SessaoId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_SessaoId",
                table: "Compra");
        }
    }
}
