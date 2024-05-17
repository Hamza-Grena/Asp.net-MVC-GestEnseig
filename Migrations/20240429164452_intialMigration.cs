using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionEnseignants.Migrations
{
    /// <inheritdoc />
    public partial class intialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enseignants_Departements_DepartementId",
                table: "Enseignants");

            

            migrationBuilder.RenameColumn(
                name: "DepartementId",
                table: "Enseignants",
                newName: "departementId");

            migrationBuilder.RenameIndex(
                name: "IX_Enseignants_DepartementId",
                table: "Enseignants",
                newName: "IX_Enseignants_departementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enseignants_Departements_departementId",
                table: "Enseignants",
                column: "departementId",
                principalTable: "Departements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enseignants_Departements_departementId",
                table: "Enseignants");

            migrationBuilder.RenameColumn(
                name: "departementId",
                table: "Enseignants",
                newName: "DepartementId");

            migrationBuilder.RenameIndex(
                name: "IX_Enseignants_departementId",
                table: "Enseignants",
                newName: "IX_Enseignants_DepartementId");

            
            migrationBuilder.AddForeignKey(
                name: "FK_Enseignants_Departements_DepartementId",
                table: "Enseignants",
                column: "DepartementId",
                principalTable: "Departements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
