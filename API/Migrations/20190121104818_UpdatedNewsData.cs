using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class UpdatedNewsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CratedDate",
                table: "Multiplenews",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Multiplenews",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Multiplenews");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Multiplenews",
                newName: "CratedDate");
        }
    }
}
