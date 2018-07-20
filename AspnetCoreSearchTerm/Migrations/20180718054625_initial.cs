using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetCoreSearchTerm.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchTerm",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SearchKeyword = table.Column<string>(nullable: true),
                    SearchBarFieldType = table.Column<int>(nullable: false),
                    PageSearchEnter = table.Column<int>(nullable: false),
                    SearchSequence = table.Column<int>(nullable: true),
                    SearchDateTime = table.Column<DateTime>(nullable: false),
                    SearchByUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTerm", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchTerm");
        }
    }
}
