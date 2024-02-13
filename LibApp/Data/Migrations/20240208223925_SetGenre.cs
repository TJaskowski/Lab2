using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibApp.Data.Migrations
{
    public partial class SetGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Genre ( Name) VALUES ( 'Thriller')");
            migrationBuilder.Sql("INSERT INTO Genre ( Name) VALUES ( 'Fiction')");
            migrationBuilder.Sql("INSERT INTO Genre ( Name) VALUES  ('Comedy')");
            migrationBuilder.Sql("INSERT INTO Genre ( Name) VALUES ( 'Drama')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
