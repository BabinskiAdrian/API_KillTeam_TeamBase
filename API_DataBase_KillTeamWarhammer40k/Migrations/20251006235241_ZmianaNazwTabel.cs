using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DataBase_KillTeamWarhammer40k.Migrations
{
    /// <inheritdoc />
    public partial class ZmianaNazwTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactionEquipment_KillTeam_KillTeamId",
                table: "FactionEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_FactionRule_KillTeam_KillTeamId",
                table: "FactionRule");

            migrationBuilder.DropForeignKey(
                name: "FK_FirefightPloy_KillTeam_KillTeamId",
                table: "FirefightPloy");

            migrationBuilder.DropForeignKey(
                name: "FK_Operative_KillTeam_KillTeamId",
                table: "Operative");

            migrationBuilder.DropForeignKey(
                name: "FK_OperativeAbility_Operative_OperativeId",
                table: "OperativeAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_OperativeWeapon_Operative_OperativesId",
                table: "OperativeWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_OperativeWeapon_Weapon_WeaponsId",
                table: "OperativeWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_StrategyPloy_KillTeam_KillTeamId",
                table: "StrategyPloy");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponWeaponAbility_WeaponAbility_WeaponAbilitiesId",
                table: "WeaponWeaponAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponWeaponAbility_Weapon_WeaponsId",
                table: "WeaponWeaponAbility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponAbility",
                table: "WeaponAbility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UniversalEquipment",
                table: "UniversalEquipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StrategyPloy",
                table: "StrategyPloy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OperativeAbility",
                table: "OperativeAbility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operative",
                table: "Operative");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KillTeam",
                table: "KillTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FirefightPloy",
                table: "FirefightPloy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactionRule",
                table: "FactionRule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactionEquipment",
                table: "FactionEquipment");

            migrationBuilder.RenameTable(
                name: "WeaponAbility",
                newName: "WeaponAbilityDbSet");

            migrationBuilder.RenameTable(
                name: "Weapon",
                newName: "WeaponDbSet");

            migrationBuilder.RenameTable(
                name: "UniversalEquipment",
                newName: "UniversalEquipmentDbSet");

            migrationBuilder.RenameTable(
                name: "StrategyPloy",
                newName: "StrategyPloyDbSet");

            migrationBuilder.RenameTable(
                name: "OperativeAbility",
                newName: "OperativeAbilityDbSet");

            migrationBuilder.RenameTable(
                name: "Operative",
                newName: "OperativeDbSet");

            migrationBuilder.RenameTable(
                name: "KillTeam",
                newName: "KillTeamDbSet");

            migrationBuilder.RenameTable(
                name: "FirefightPloy",
                newName: "FirefightPloyDbSet");

            migrationBuilder.RenameTable(
                name: "FactionRule",
                newName: "FactionRuleDbSet");

            migrationBuilder.RenameTable(
                name: "FactionEquipment",
                newName: "FactionEquipmentDbSet");

            migrationBuilder.RenameIndex(
                name: "IX_StrategyPloy_KillTeamId",
                table: "StrategyPloyDbSet",
                newName: "IX_StrategyPloyDbSet_KillTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_OperativeAbility_OperativeId",
                table: "OperativeAbilityDbSet",
                newName: "IX_OperativeAbilityDbSet_OperativeId");

            migrationBuilder.RenameIndex(
                name: "IX_Operative_KillTeamId",
                table: "OperativeDbSet",
                newName: "IX_OperativeDbSet_KillTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_FirefightPloy_KillTeamId",
                table: "FirefightPloyDbSet",
                newName: "IX_FirefightPloyDbSet_KillTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_FactionRule_KillTeamId",
                table: "FactionRuleDbSet",
                newName: "IX_FactionRuleDbSet_KillTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_FactionEquipment_KillTeamId",
                table: "FactionEquipmentDbSet",
                newName: "IX_FactionEquipmentDbSet_KillTeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponAbilityDbSet",
                table: "WeaponAbilityDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponDbSet",
                table: "WeaponDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UniversalEquipmentDbSet",
                table: "UniversalEquipmentDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StrategyPloyDbSet",
                table: "StrategyPloyDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OperativeAbilityDbSet",
                table: "OperativeAbilityDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OperativeDbSet",
                table: "OperativeDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KillTeamDbSet",
                table: "KillTeamDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirefightPloyDbSet",
                table: "FirefightPloyDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactionRuleDbSet",
                table: "FactionRuleDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactionEquipmentDbSet",
                table: "FactionEquipmentDbSet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FactionEquipmentDbSet_KillTeamDbSet_KillTeamId",
                table: "FactionEquipmentDbSet",
                column: "KillTeamId",
                principalTable: "KillTeamDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactionRuleDbSet_KillTeamDbSet_KillTeamId",
                table: "FactionRuleDbSet",
                column: "KillTeamId",
                principalTable: "KillTeamDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FirefightPloyDbSet_KillTeamDbSet_KillTeamId",
                table: "FirefightPloyDbSet",
                column: "KillTeamId",
                principalTable: "KillTeamDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperativeAbilityDbSet_OperativeDbSet_OperativeId",
                table: "OperativeAbilityDbSet",
                column: "OperativeId",
                principalTable: "OperativeDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperativeDbSet_KillTeamDbSet_KillTeamId",
                table: "OperativeDbSet",
                column: "KillTeamId",
                principalTable: "KillTeamDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperativeWeapon_OperativeDbSet_OperativesId",
                table: "OperativeWeapon",
                column: "OperativesId",
                principalTable: "OperativeDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperativeWeapon_WeaponDbSet_WeaponsId",
                table: "OperativeWeapon",
                column: "WeaponsId",
                principalTable: "WeaponDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StrategyPloyDbSet_KillTeamDbSet_KillTeamId",
                table: "StrategyPloyDbSet",
                column: "KillTeamId",
                principalTable: "KillTeamDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponWeaponAbility_WeaponAbilityDbSet_WeaponAbilitiesId",
                table: "WeaponWeaponAbility",
                column: "WeaponAbilitiesId",
                principalTable: "WeaponAbilityDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponWeaponAbility_WeaponDbSet_WeaponsId",
                table: "WeaponWeaponAbility",
                column: "WeaponsId",
                principalTable: "WeaponDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactionEquipmentDbSet_KillTeamDbSet_KillTeamId",
                table: "FactionEquipmentDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_FactionRuleDbSet_KillTeamDbSet_KillTeamId",
                table: "FactionRuleDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_FirefightPloyDbSet_KillTeamDbSet_KillTeamId",
                table: "FirefightPloyDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_OperativeAbilityDbSet_OperativeDbSet_OperativeId",
                table: "OperativeAbilityDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_OperativeDbSet_KillTeamDbSet_KillTeamId",
                table: "OperativeDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_OperativeWeapon_OperativeDbSet_OperativesId",
                table: "OperativeWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_OperativeWeapon_WeaponDbSet_WeaponsId",
                table: "OperativeWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_StrategyPloyDbSet_KillTeamDbSet_KillTeamId",
                table: "StrategyPloyDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponWeaponAbility_WeaponAbilityDbSet_WeaponAbilitiesId",
                table: "WeaponWeaponAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponWeaponAbility_WeaponDbSet_WeaponsId",
                table: "WeaponWeaponAbility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponDbSet",
                table: "WeaponDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponAbilityDbSet",
                table: "WeaponAbilityDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UniversalEquipmentDbSet",
                table: "UniversalEquipmentDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StrategyPloyDbSet",
                table: "StrategyPloyDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OperativeDbSet",
                table: "OperativeDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OperativeAbilityDbSet",
                table: "OperativeAbilityDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KillTeamDbSet",
                table: "KillTeamDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FirefightPloyDbSet",
                table: "FirefightPloyDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactionRuleDbSet",
                table: "FactionRuleDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactionEquipmentDbSet",
                table: "FactionEquipmentDbSet");

            migrationBuilder.RenameTable(
                name: "WeaponDbSet",
                newName: "Weapon");

            migrationBuilder.RenameTable(
                name: "WeaponAbilityDbSet",
                newName: "WeaponAbility");

            migrationBuilder.RenameTable(
                name: "UniversalEquipmentDbSet",
                newName: "UniversalEquipment");

            migrationBuilder.RenameTable(
                name: "StrategyPloyDbSet",
                newName: "StrategyPloy");

            migrationBuilder.RenameTable(
                name: "OperativeDbSet",
                newName: "Operative");

            migrationBuilder.RenameTable(
                name: "OperativeAbilityDbSet",
                newName: "OperativeAbility");

            migrationBuilder.RenameTable(
                name: "KillTeamDbSet",
                newName: "KillTeam");

            migrationBuilder.RenameTable(
                name: "FirefightPloyDbSet",
                newName: "FirefightPloy");

            migrationBuilder.RenameTable(
                name: "FactionRuleDbSet",
                newName: "FactionRule");

            migrationBuilder.RenameTable(
                name: "FactionEquipmentDbSet",
                newName: "FactionEquipment");

            migrationBuilder.RenameIndex(
                name: "IX_StrategyPloyDbSet_KillTeamId",
                table: "StrategyPloy",
                newName: "IX_StrategyPloy_KillTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_OperativeDbSet_KillTeamId",
                table: "Operative",
                newName: "IX_Operative_KillTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_OperativeAbilityDbSet_OperativeId",
                table: "OperativeAbility",
                newName: "IX_OperativeAbility_OperativeId");

            migrationBuilder.RenameIndex(
                name: "IX_FirefightPloyDbSet_KillTeamId",
                table: "FirefightPloy",
                newName: "IX_FirefightPloy_KillTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_FactionRuleDbSet_KillTeamId",
                table: "FactionRule",
                newName: "IX_FactionRule_KillTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_FactionEquipmentDbSet_KillTeamId",
                table: "FactionEquipment",
                newName: "IX_FactionEquipment_KillTeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponAbility",
                table: "WeaponAbility",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UniversalEquipment",
                table: "UniversalEquipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StrategyPloy",
                table: "StrategyPloy",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operative",
                table: "Operative",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OperativeAbility",
                table: "OperativeAbility",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KillTeam",
                table: "KillTeam",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirefightPloy",
                table: "FirefightPloy",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactionRule",
                table: "FactionRule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactionEquipment",
                table: "FactionEquipment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FactionEquipment_KillTeam_KillTeamId",
                table: "FactionEquipment",
                column: "KillTeamId",
                principalTable: "KillTeam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactionRule_KillTeam_KillTeamId",
                table: "FactionRule",
                column: "KillTeamId",
                principalTable: "KillTeam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FirefightPloy_KillTeam_KillTeamId",
                table: "FirefightPloy",
                column: "KillTeamId",
                principalTable: "KillTeam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operative_KillTeam_KillTeamId",
                table: "Operative",
                column: "KillTeamId",
                principalTable: "KillTeam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperativeAbility_Operative_OperativeId",
                table: "OperativeAbility",
                column: "OperativeId",
                principalTable: "Operative",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperativeWeapon_Operative_OperativesId",
                table: "OperativeWeapon",
                column: "OperativesId",
                principalTable: "Operative",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperativeWeapon_Weapon_WeaponsId",
                table: "OperativeWeapon",
                column: "WeaponsId",
                principalTable: "Weapon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StrategyPloy_KillTeam_KillTeamId",
                table: "StrategyPloy",
                column: "KillTeamId",
                principalTable: "KillTeam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponWeaponAbility_WeaponAbility_WeaponAbilitiesId",
                table: "WeaponWeaponAbility",
                column: "WeaponAbilitiesId",
                principalTable: "WeaponAbility",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponWeaponAbility_Weapon_WeaponsId",
                table: "WeaponWeaponAbility",
                column: "WeaponsId",
                principalTable: "Weapon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
