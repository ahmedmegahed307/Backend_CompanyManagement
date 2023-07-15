using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class relationBetweenJobTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSubTypes_JobTypes_JobTypeId",
                table: "JobSubTypes");

            migrationBuilder.DropIndex(
                name: "IX_JobSubTypes_JobTypeId",
                table: "JobSubTypes");

            migrationBuilder.DropColumn(
                name: "JobTypeId",
                table: "JobSubTypes");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "JobSubTypes",
                newName: "IsActive");

            migrationBuilder.AddColumn<int>(
                name: "JobSubTypeId",
                table: "JobTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JobTypes_JobSubTypeId",
                table: "JobTypes",
                column: "JobSubTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTypes_JobSubTypes_JobSubTypeId",
                table: "JobTypes",
                column: "JobSubTypeId",
                principalTable: "JobSubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTypes_JobSubTypes_JobSubTypeId",
                table: "JobTypes");

            migrationBuilder.DropIndex(
                name: "IX_JobTypes_JobSubTypeId",
                table: "JobTypes");

            migrationBuilder.DropColumn(
                name: "JobSubTypeId",
                table: "JobTypes");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "JobSubTypes",
                newName: "isActive");

            migrationBuilder.AddColumn<int>(
                name: "JobTypeId",
                table: "JobSubTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobSubTypes_JobTypeId",
                table: "JobSubTypes",
                column: "JobTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSubTypes_JobTypes_JobTypeId",
                table: "JobSubTypes",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id");
        }
    }
}
