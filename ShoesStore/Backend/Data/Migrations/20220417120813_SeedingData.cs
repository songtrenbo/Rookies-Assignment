using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38241250-25BE-498D-927F-987392EEEAC6",
                column: "ConcurrencyStamp",
                value: "8ec77b94-3a10-4c07-9a1d-e57dc71b3cba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9CACE705-D838-42A1-830D-6DC9366BAFD9",
                column: "ConcurrencyStamp",
                value: "18f80431-ffb8-4628-824f-c0579306208b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19082211-16F2-4191-8D57-0789CF309208",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a380fcda-aa07-4685-8e97-23a8b779951a", "AQAAAAEAACcQAAAAEBfbHh8sZVZSBTG4XWoHsT5hwiq7cZFkSTqXMEEzxcFROFUrk/TSRtmeelxhjzakXA==", "b0b3533b-9dd8-4bca-a17c-5f4fae02d112" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38241250-25BE-498D-927F-987392EEEAC6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e8a508a-b3b3-49b2-b357-a764e762532f", "AQAAAAEAACcQAAAAEF3SpquHCKwMh9xMYQw1Dzds22SfaCz3Z2Aa2L2Ggzspln4HTdHwLJIHijjs6J+l4Q==", "2ea61f33-9e6d-4e92-876a-4542185aa4ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68385F93-CB1F-4394-A923-C5BB6D87B2B8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65c6c7b-e7e0-4f4d-940b-cec9e49a9585", "AQAAAAEAACcQAAAAEJ8L6l4PIj8nE8Qgy0T2x/zQmIttPqKA5hT6AZGzOdz6hme7jSCLhnCVFX7l2C4AFw==", "3dc4eca2-685e-4058-8fd5-f9868d2cff5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74B99129-A554-46FB-9BC3-C28C721DE30F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d7a0274-47ff-41d3-9f60-91d762c73ffd", "AQAAAAEAACcQAAAAENMYE/lCLTHm4GJUF0EnnkWCInBQJlWVe/VnJ+f0q5oe7DUsq1QdsyENWmIb7NJuBg==", "58493094-1491-47e3-8334-9cac4eabbc18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85D28D4C-9A15-4AA1-B592-29CF8EE8CDEE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc0052ce-83d2-410c-a15a-60611bf8be84", "AQAAAAEAACcQAAAAEKVV22NWXRIlKncW4cXJTijuTTxkk0ajGoQ7ELgthGolfDrpxwky4EgD3k/8HA6+kg==", "56c7d754-2606-45c5-9a56-8db9d2f79e40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9CACE705-D838-42A1-830D-6DC9366BAFD9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89ae8b37-633a-4426-8fe3-85b2966acc27", "AQAAAAEAACcQAAAAEDHhVlG5w6ax6NscKhLGH5dtuoMn5GJE4GwkydOzL6TAkbYJeRwGpWCUcVnOvEEuhA==", "e5bbad86-f63e-4819-9bd9-34414f4df2cd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38241250-25BE-498D-927F-987392EEEAC6",
                column: "ConcurrencyStamp",
                value: "01a20c43-bd02-43b4-a99b-1b298262c420");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9CACE705-D838-42A1-830D-6DC9366BAFD9",
                column: "ConcurrencyStamp",
                value: "2ff15b6e-4730-45da-a46c-f451c6ac207d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19082211-16F2-4191-8D57-0789CF309208",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32420df-16c5-42dd-8d87-2545d19fa20f", "AQAAAAEAACcQAAAAEKDrudbNJgH5gmK3Yl40eQjbkRQeNxaWjecXAGZr88hqFrVgp9bq64U2z1UuX9suxw==", "83904d1e-bc0f-4112-8719-f039983fdeb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38241250-25BE-498D-927F-987392EEEAC6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70dde594-f573-4e9b-857e-378346ab2313", "AQAAAAEAACcQAAAAEDAJlZWcQPbSQimE5IP0UYdpXPqFgDSeXo9hM73C49ZGHd07bKW9DOsaP8uDBGLuxg==", "43096533-3e91-4c89-b584-c6da7e176b00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68385F93-CB1F-4394-A923-C5BB6D87B2B8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99df3565-b074-44c6-a522-949d3dacc267", "AQAAAAEAACcQAAAAEEDiPaSzOrdSQ3FQUmcBkirqzZOGvh2DxNHey8JigIgqdNPh62YZ+4swrt2L0nwL0Q==", "db0bd0ff-1f73-46f1-8e53-953caa0ea478" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74B99129-A554-46FB-9BC3-C28C721DE30F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1865ce8d-3571-4e89-8de5-4d811cab26a2", "AQAAAAEAACcQAAAAEHWbrNzj+f8T8qLEQVNHOQaVSTCH2rZzEyAcbhoEdrfrXvGyt3D4C/cagrpriBH17Q==", "d4d6c9ad-3e52-4d40-9ad9-5be9a7862420" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85D28D4C-9A15-4AA1-B592-29CF8EE8CDEE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f80c0ad5-6d4c-4c97-8d00-5b0b35d329f7", "AQAAAAEAACcQAAAAEGkePButWWFsxr38aQ3h+DwMN7q3sJH69jgCsX8C+UDKv7lvk9540hhKJ70buUYw2A==", "e740850f-6983-4fb4-b30d-9fb763d121f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9CACE705-D838-42A1-830D-6DC9366BAFD9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce5b437-9798-4804-bc8f-24040a92adae", "AQAAAAEAACcQAAAAEMeV75MJzi3QgrNEc+6z0BcLk1mnLQtE5EzrQudkMAtqjT15XFPoROrVYuTqHWCCRQ==", "ce23b3e8-ad63-4c48-aeec-0346aa7a6bbd" });
        }
    }
}
