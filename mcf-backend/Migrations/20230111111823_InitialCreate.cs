using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mcfbackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BPKBs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    agreementnumber = table.Column<string>(name: "agreement_number", type: "nvarchar(max)", nullable: true),
                    bpkbno = table.Column<string>(name: "bpkb_no", type: "nvarchar(max)", nullable: true),
                    branchid = table.Column<string>(name: "branch_id", type: "nvarchar(max)", nullable: true),
                    bpkbdate = table.Column<DateTime>(name: "bpkb_date", type: "datetime2", nullable: true),
                    fakturno = table.Column<string>(name: "faktur_no", type: "nvarchar(max)", nullable: true),
                    fakturdate = table.Column<DateTime>(name: "faktur_date", type: "datetime2", nullable: true),
                    locationid = table.Column<string>(name: "location_id", type: "nvarchar(max)", nullable: true),
                    policeno = table.Column<string>(name: "police_no", type: "nvarchar(max)", nullable: true),
                    bpkbdatein = table.Column<DateTime>(name: "bpkb_date_in", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPKBs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StorageLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationid = table.Column<string>(name: "location_id", type: "nvarchar(max)", nullable: true),
                    locationname = table.Column<string>(name: "location_name", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageLocations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BPKBs");

            migrationBuilder.DropTable(
                name: "StorageLocations");
        }
    }
}
