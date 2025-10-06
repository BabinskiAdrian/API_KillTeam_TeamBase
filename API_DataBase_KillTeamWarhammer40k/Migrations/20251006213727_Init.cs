using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DataBase_KillTeamWarhammer40k.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KillTeam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KillTeam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniversalEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversalEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRange = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Atk = table.Column<int>(type: "int", nullable: false),
                    Hit = table.Column<int>(type: "int", nullable: false),
                    DmgNormal = table.Column<int>(type: "int", nullable: false),
                    DmgCrit = table.Column<int>(type: "int", nullable: false),
                    Wr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponAbility", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FactionEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KillTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactionEquipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactionEquipment_KillTeam_KillTeamId",
                        column: x => x.KillTeamId,
                        principalTable: "KillTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactionRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KillTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactionRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactionRule_KillTeam_KillTeamId",
                        column: x => x.KillTeamId,
                        principalTable: "KillTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirefightPloy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KillTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirefightPloy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirefightPloy_KillTeam_KillTeamId",
                        column: x => x.KillTeamId,
                        principalTable: "KillTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operative",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apl = table.Column<int>(type: "int", nullable: false),
                    Move = table.Column<int>(type: "int", nullable: false),
                    Save = table.Column<int>(type: "int", nullable: false),
                    Wounds = table.Column<int>(type: "int", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KillTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operative", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operative_KillTeam_KillTeamId",
                        column: x => x.KillTeamId,
                        principalTable: "KillTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StrategyPloy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KillTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategyPloy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StrategyPloy_KillTeam_KillTeamId",
                        column: x => x.KillTeamId,
                        principalTable: "KillTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponWeaponAbility",
                columns: table => new
                {
                    WeaponAbilitiesId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponWeaponAbility", x => new { x.WeaponAbilitiesId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_WeaponWeaponAbility_WeaponAbility_WeaponAbilitiesId",
                        column: x => x.WeaponAbilitiesId,
                        principalTable: "WeaponAbility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponWeaponAbility_Weapon_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperativeAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperativeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperativeAbility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperativeAbility_Operative_OperativeId",
                        column: x => x.OperativeId,
                        principalTable: "Operative",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperativeWeapon",
                columns: table => new
                {
                    OperativesId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperativeWeapon", x => new { x.OperativesId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_OperativeWeapon_Operative_OperativesId",
                        column: x => x.OperativesId,
                        principalTable: "Operative",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperativeWeapon_Weapon_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FactionEquipment_KillTeamId",
                table: "FactionEquipment",
                column: "KillTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_FactionRule_KillTeamId",
                table: "FactionRule",
                column: "KillTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_FirefightPloy_KillTeamId",
                table: "FirefightPloy",
                column: "KillTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Operative_KillTeamId",
                table: "Operative",
                column: "KillTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_OperativeAbility_OperativeId",
                table: "OperativeAbility",
                column: "OperativeId");

            migrationBuilder.CreateIndex(
                name: "IX_OperativeWeapon_WeaponsId",
                table: "OperativeWeapon",
                column: "WeaponsId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategyPloy_KillTeamId",
                table: "StrategyPloy",
                column: "KillTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponWeaponAbility_WeaponsId",
                table: "WeaponWeaponAbility",
                column: "WeaponsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FactionEquipment");

            migrationBuilder.DropTable(
                name: "FactionRule");

            migrationBuilder.DropTable(
                name: "FirefightPloy");

            migrationBuilder.DropTable(
                name: "OperativeAbility");

            migrationBuilder.DropTable(
                name: "OperativeWeapon");

            migrationBuilder.DropTable(
                name: "StrategyPloy");

            migrationBuilder.DropTable(
                name: "UniversalEquipment");

            migrationBuilder.DropTable(
                name: "WeaponWeaponAbility");

            migrationBuilder.DropTable(
                name: "Operative");

            migrationBuilder.DropTable(
                name: "WeaponAbility");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "KillTeam");
        }
    }
}
