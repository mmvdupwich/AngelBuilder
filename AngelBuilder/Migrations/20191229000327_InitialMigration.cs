using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelBuilder.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Ability_Id = table.Column<string>(nullable: false),
                    Ability_Name = table.Column<string>(nullable: true),
                    Ability_Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Ability_Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Model_Id = table.Column<string>(nullable: false),
                    Model_Name = table.Column<string>(nullable: true),
                    Model_Points = table.Column<int>(nullable: false),
                    Model_Move = table.Column<string>(nullable: true),
                    Model_WS = table.Column<string>(nullable: true),
                    Model_BS = table.Column<string>(nullable: true),
                    Model_S = table.Column<string>(nullable: true),
                    Model_T = table.Column<string>(nullable: true),
                    Model_W = table.Column<string>(nullable: true),
                    Model_A = table.Column<string>(nullable: true),
                    Model_Ld = table.Column<string>(nullable: true),
                    Model_Sv = table.Column<string>(nullable: true),
                    Model_Min = table.Column<int>(nullable: false),
                    Model_Max = table.Column<int>(nullable: false),
                    Model_Def = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Model_Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Unit_Id = table.Column<string>(nullable: false),
                    Unit_Name = table.Column<string>(nullable: true),
                    Unit_Cat = table.Column<int>(nullable: false),
                    Unit_Min = table.Column<int>(nullable: false),
                    Unit_Max = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Unit_Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Weapon_Id = table.Column<string>(nullable: false),
                    Weapon_Name = table.Column<string>(nullable: true),
                    Weapon_Points = table.Column<int>(nullable: false),
                    Weapon_Range = table.Column<string>(nullable: true),
                    Weapon_Type = table.Column<string>(nullable: true),
                    Weapon_S = table.Column<string>(nullable: true),
                    Weapon_Ap = table.Column<string>(nullable: true),
                    Weapon_Dmg = table.Column<string>(nullable: true),
                    Weapon_Abi = table.Column<string>(nullable: true),
                    Model_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Weapon_Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Models_Model_Id",
                        column: x => x.Model_Id,
                        principalTable: "Models",
                        principalColumn: "Model_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_Model_Id",
                table: "Weapons",
                column: "Model_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Models");
        }
    }
}
