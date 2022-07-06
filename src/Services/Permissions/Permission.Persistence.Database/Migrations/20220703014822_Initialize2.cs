using Microsoft.EntityFrameworkCore.Migrations;

namespace Permission.Persistence.Database.Migrations
{
    public partial class Initialize2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_PermissionTypes_PermissionTypesId",
                schema: "Permission",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_PermissionTypesId",
                schema: "Permission",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "PermissionTypesId",
                schema: "Permission",
                table: "Permissions");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_TipoPermiso",
                schema: "Permission",
                table: "Permissions",
                column: "TipoPermiso");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_PermissionTypes_TipoPermiso",
                schema: "Permission",
                table: "Permissions",
                column: "TipoPermiso",
                principalSchema: "Permission",
                principalTable: "PermissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_PermissionTypes_TipoPermiso",
                schema: "Permission",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_TipoPermiso",
                schema: "Permission",
                table: "Permissions");

            migrationBuilder.AddColumn<int>(
                name: "PermissionTypesId",
                schema: "Permission",
                table: "Permissions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionTypesId",
                schema: "Permission",
                table: "Permissions",
                column: "PermissionTypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_PermissionTypes_PermissionTypesId",
                schema: "Permission",
                table: "Permissions",
                column: "PermissionTypesId",
                principalSchema: "Permission",
                principalTable: "PermissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
