using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service_Booking_Management_Microservice.Migrations
{
    /// <inheritdoc />
    public partial class AddServiceTypeInAppServiceReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "AppServiceReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "AppServiceReports");
        }
    }
}
