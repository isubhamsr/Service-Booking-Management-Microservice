using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service_Booking_Management_Microservice.Migrations
{
    /// <inheritdoc />
    public partial class MakeNullableAppservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppServiceReports_AppServices_AppServiceId",
                table: "AppServiceReports");

            migrationBuilder.AlterColumn<int>(
                name: "AppServiceId",
                table: "AppServiceReports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AppServiceReports_AppServices_AppServiceId",
                table: "AppServiceReports",
                column: "AppServiceId",
                principalTable: "AppServices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppServiceReports_AppServices_AppServiceId",
                table: "AppServiceReports");

            migrationBuilder.AlterColumn<int>(
                name: "AppServiceId",
                table: "AppServiceReports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppServiceReports_AppServices_AppServiceId",
                table: "AppServiceReports",
                column: "AppServiceId",
                principalTable: "AppServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
