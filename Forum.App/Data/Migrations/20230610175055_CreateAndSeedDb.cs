using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forum.App.Data.Migrations
{
    public partial class CreateAndSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("1d45dbbe-a6fb-4b16-9e29-5c21e2f8229d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam scelerisque vulputate nibh, quis euismod diam consequat in. Nullam at nulla. ", "My first post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("f2ecebb6-1b93-4f49-b6fe-a4c998c9b9d3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris commodo elit id erat fringilla luctus. ", "My second post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("f58ae873-7133-4464-92ab-051691bc0e99"), "Consectetur adipiscing elit. Mauris commodo elit id erat fringilla luctus. ", "My third post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
