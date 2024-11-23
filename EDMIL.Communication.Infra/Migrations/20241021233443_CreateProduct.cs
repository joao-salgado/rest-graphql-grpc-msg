using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDMIL.Communication.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CreateProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, name: "id"),
                    Name = table.Column<string>(type: "text", nullable: false, name: "name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
