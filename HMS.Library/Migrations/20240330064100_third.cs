using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS.Library.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billings_Discharges_DischargeID",
                table: "Billings");

            migrationBuilder.DropForeignKey(
                name: "FK_Billings_Reports_ReportID",
                table: "Billings");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Departments_DepartmentID",
                table: "Wards");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Patients_PatientID",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Wards_DepartmentID",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Billings_DischargeID",
                table: "Billings");

            migrationBuilder.DropIndex(
                name: "IX_Billings_ReportID",
                table: "Billings");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "DischargeID",
                table: "Billings");

            migrationBuilder.DropColumn(
                name: "ReportID",
                table: "Billings");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "Wards",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "WardName",
                table: "Wards",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Wards_PatientID",
                table: "Wards",
                newName: "IX_Wards_PatientId");

            migrationBuilder.RenameColumn(
                name: "RefType",
                table: "Transactions",
                newName: "RefTypeName");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Patients_PatientId",
                table: "Wards",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Patients_PatientId",
                table: "Wards");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Wards",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Wards",
                newName: "WardName");

            migrationBuilder.RenameIndex(
                name: "IX_Wards_PatientId",
                table: "Wards",
                newName: "IX_Wards_PatientID");

            migrationBuilder.RenameColumn(
                name: "RefTypeName",
                table: "Transactions",
                newName: "RefType");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Wards",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DischargeID",
                table: "Billings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReportID",
                table: "Billings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wards_DepartmentID",
                table: "Wards",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Billings_DischargeID",
                table: "Billings",
                column: "DischargeID");

            migrationBuilder.CreateIndex(
                name: "IX_Billings_ReportID",
                table: "Billings",
                column: "ReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_Billings_Discharges_DischargeID",
                table: "Billings",
                column: "DischargeID",
                principalTable: "Discharges",
                principalColumn: "DischargeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billings_Reports_ReportID",
                table: "Billings",
                column: "ReportID",
                principalTable: "Reports",
                principalColumn: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Departments_DepartmentID",
                table: "Wards",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Patients_PatientID",
                table: "Wards",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientId");
        }
    }
}
