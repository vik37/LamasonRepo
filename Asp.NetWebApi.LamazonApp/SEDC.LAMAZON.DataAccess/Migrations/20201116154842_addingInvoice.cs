using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.LAMAZON.DataAccess.Migrations
{
    public partial class addingInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "30a32c35-3725-4c23-a59f-5544cc1b9620", "6a1885be-1202-48d2-8d8b-5b934883aab7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "581c079a-03b8-4c38-b99b-8d6a134c4e3b", "44112c93-6d05-47c3-9819-ca9653b7d82f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "44112c93-6d05-47c3-9819-ca9653b7d82f", "5d0a46a0-beb9-464a-9aa2-99d246b587eb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "581c079a-03b8-4c38-b99b-8d6a134c4e3b", "b28a8894-3eb1-4c54-8642-4d01d777c0d0" });

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    CardNumber = table.Column<int>(nullable: false),
                    SumOfPrice = table.Column<int>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a76381e-0166-447f-a9dd-c5d8a4b44d86", "507b9b56-758d-4b69-8830-2303d883ec4f", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e80da792-01d8-47b2-a7c2-912b28d47eba", "737f50db-97a7-45ec-8749-8deeefd9b63c", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8a7de4ea-5f7b-4800-b916-1553ed407196", 0, "6377c048-97ff-4412-ad76-b3cf36bfacc8", "lamazon@supply.com", true, null, false, null, "lamazon@supply.com", "ADMIN", "AQAAAAEAACcQAAAAEC7sH2RlMxYoSjvRvTEUtMXbkm42Lt1pyj4lv0xwAVgeRL2pyoQq8+NjGKhElAxzHA==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8a7de4ea-5f7b-4800-b916-1553ed407196", "8a76381e-0166-447f-a9dd-c5d8a4b44d86" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_InvoiceId",
                table: "Orders",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Invoice_InvoiceId",
                table: "Orders",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Invoice_InvoiceId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Orders_InvoiceId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e80da792-01d8-47b2-a7c2-912b28d47eba", "737f50db-97a7-45ec-8749-8deeefd9b63c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8a7de4ea-5f7b-4800-b916-1553ed407196", "8a76381e-0166-447f-a9dd-c5d8a4b44d86" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8a76381e-0166-447f-a9dd-c5d8a4b44d86", "507b9b56-758d-4b69-8830-2303d883ec4f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8a7de4ea-5f7b-4800-b916-1553ed407196", "6377c048-97ff-4412-ad76-b3cf36bfacc8" });

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44112c93-6d05-47c3-9819-ca9653b7d82f", "5d0a46a0-beb9-464a-9aa2-99d246b587eb", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30a32c35-3725-4c23-a59f-5544cc1b9620", "6a1885be-1202-48d2-8d8b-5b934883aab7", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "581c079a-03b8-4c38-b99b-8d6a134c4e3b", 0, "b28a8894-3eb1-4c54-8642-4d01d777c0d0", "lamazon@supply.com", true, null, false, null, "lamazon@supply.com", "ADMIN", "AQAAAAEAACcQAAAAEC+zpCW1bKiEpMAFVNmVgNj7PmTIgCK4fQGGUyA2TXqTMqSE2khWi85GsJwmUwn/AA==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "581c079a-03b8-4c38-b99b-8d6a134c4e3b", "44112c93-6d05-47c3-9819-ca9653b7d82f" });
        }
    }
}
