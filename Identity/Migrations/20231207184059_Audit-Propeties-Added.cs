using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity.Migrations
{
    /// <inheritdoc />
    public partial class AuditPropetiesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "UserSubCategories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "UserSubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "UserProfiles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "UserCategories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "SubCategories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "RefreshTokens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "RefreshTokens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "RefreshTokens",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Devices",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Devices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSubCategories_CreatedById",
                table: "UserSubCategories",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_CreatedById",
                table: "UserProfiles",
                column: "CreatedById",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_CreatedById",
                table: "UserCategories",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_CreatedById",
                table: "RefreshTokens",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UpdatedById",
                table: "RefreshTokens",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_CreatedById",
                table: "Devices",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_UpdatedById",
                table: "Devices",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_AspNetUsers_CreatedById",
                table: "Devices",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_AspNetUsers_UpdatedById",
                table: "Devices",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_CreatedById",
                table: "RefreshTokens",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_UpdatedById",
                table: "RefreshTokens",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_AspNetUsers_CreatedById",
                table: "UserCategories",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_AspNetUsers_CreatedById",
                table: "UserProfiles",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubCategories_AspNetUsers_CreatedById",
                table: "UserSubCategories",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_AspNetUsers_CreatedById",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_AspNetUsers_UpdatedById",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_CreatedById",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_UpdatedById",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_AspNetUsers_CreatedById",
                table: "UserCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_AspNetUsers_CreatedById",
                table: "UserProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubCategories_AspNetUsers_CreatedById",
                table: "UserSubCategories");

            migrationBuilder.DropIndex(
                name: "IX_UserSubCategories_CreatedById",
                table: "UserSubCategories");

            migrationBuilder.DropIndex(
                name: "IX_UserProfiles_CreatedById",
                table: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_UserCategories_CreatedById",
                table: "UserCategories");

            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_CreatedById",
                table: "RefreshTokens");

            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_UpdatedById",
                table: "RefreshTokens");

            migrationBuilder.DropIndex(
                name: "IX_Devices_CreatedById",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_UpdatedById",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "UserSubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "UserSubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "RefreshTokens");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "RefreshTokens");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "RefreshTokens");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Devices");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserProfiles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Devices",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
