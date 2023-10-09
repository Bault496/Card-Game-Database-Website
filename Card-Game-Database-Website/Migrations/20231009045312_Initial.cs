using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Card_Game_Database_Website.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttack1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttackCost1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttackDamage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttackEffect1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttack2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttackCost2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttackDamage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttackEffect2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardHP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardStage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardRetreatCost = table.Column<int>(type: "int", nullable: true),
                    CardRuleBox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttribute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardMonsterType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardAttackValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardDefenseValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardMonsterLevel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
