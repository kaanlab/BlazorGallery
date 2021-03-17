using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorGallery.Migrations
{
    public partial class ChangeIntroModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmbededCode",
                table: "Intros",
                newName: "IntroCode");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundCode",
                table: "Intros",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundCode",
                table: "Intros");

            migrationBuilder.RenameColumn(
                name: "IntroCode",
                table: "Intros",
                newName: "EmbededCode");
        }
    }
}
