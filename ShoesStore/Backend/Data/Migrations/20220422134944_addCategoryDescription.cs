using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class addCategoryDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Sneakers are shoes primarily designed for sports or other forms of physical exercise, but which are now also widely used for everyday casual wear.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Description",
                value: "Sandals are an open type of footwear, consisting of a sole held to the wearer's foot by straps going over the instep and around the ankle. Sandals can also have a heel.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Description",
                value: "Sport pertains to any form of competitive physical activity or game that aims to use, maintain or improve physical ability and skills while providing");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Description",
                value: "Hiking (walking) boots are footwear specifically designed for protecting the feet and ankles during outdoor walking activities such as hiking.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "Description",
                value: "A water shoe is a type of footwear that is typically used for activities where the feet are likely to become wet, such as kayaking. ");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEDqdlfhjtsKXmuG6iu24+xb+KShv69j/bdgupu1gniSw/IpU9DHE0DjrSW3gsGffnQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFwK2sAVbQiskKhdksmwzheeo2qVxkY5Id5DXqlIEj54EUY/y8kpO6ATfdRVXpnqvw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEE3R/BNpHrg0e67+KgHHEfJXwHD9zmTL9fvar/sJrWwbyLiUE02WO4zE0mF+ydWlvA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEB1sK5yKqHthl2/uEdryTfha/hTaplSXLBe6gyoshjfPg9ong1HIvYyWZxW27hOn8Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKyWdw25U1Pe43AX2XZjKKnQL7zFIrYHZFWiwD35p+Zthyt072auu8Fz4ySxH00wxQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPCo7YNFFrbQq1ePE1HTkslllJGaJx7YJQqXAdFoaMKJ5rr10sCUZRSLuqTxR256oQ==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKABWC+tWrGThzLZD8hIFZF5Ou1/2c97DWP6ZxUe567a1qgSS2CnzANK+sbT9gABAQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFBN8zcn/LV+jWWL1b13zS4VeMGjBqznXoGrW8tD7SZs8GimlZ5aNDjXEUZiZLFEyg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBvEpWIjHiYroZpE8bMlN1xKCt4qaf8eOOB7f3OzrIdajbZG7MaQGjSoJ0/onMmLNQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEB33nWnII1V40Sqhb8SmN5RroJhs35jq7ay5b+aSxVR4RfRnTpgruZjIhqesbmY9hw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECQC6LUoJbA/oPzQ+fZWc/uPt+8LyKE1FXNl30FKFAb1OBrg3qnowxX3VY+g0cw/kQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELFyWK+9ozBFvh+jJnQ1krBsYBspU/uc9Em6arfJ7IlStqMlVOAxXBvOie4TiX24LQ==");
        }
    }
}
