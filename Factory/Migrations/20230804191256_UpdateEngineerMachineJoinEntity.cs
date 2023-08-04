using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class UpdateEngineerMachineJoinEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerMachines_EngineerId",
                table: "EngineerMachines",
                column: "EngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerMachines_MachineId",
                table: "EngineerMachines",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachines_Engineers_EngineerId",
                table: "EngineerMachines",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachines_Machines_MachineId",
                table: "EngineerMachines",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachines_Engineers_EngineerId",
                table: "EngineerMachines");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachines_Machines_MachineId",
                table: "EngineerMachines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers");

            migrationBuilder.DropIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers");

            migrationBuilder.DropIndex(
                name: "IX_EngineerMachines_EngineerId",
                table: "EngineerMachines");

            migrationBuilder.DropIndex(
                name: "IX_EngineerMachines_MachineId",
                table: "EngineerMachines");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Engineers");
        }
    }
}
