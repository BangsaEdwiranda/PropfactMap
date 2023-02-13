using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropfactMap.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Y = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropAddrL1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropAddrL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Angle = table.Column<decimal>(type: "decimal(18,8)", nullable: true),
                    PointX = table.Column<decimal>(type: "decimal(18,8)", nullable: true),
                    PointY = table.Column<decimal>(type: "decimal(18,8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressPoints", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressPoints");
        }
    }
}
