using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterCreator.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateListsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarriorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterAge = table.Column<int>(type: "int", nullable: false),
                    CharacterDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EyeColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HairStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HairColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkinColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamNumber = table.Column<int>(type: "int", nullable: false),
                    TeamSlogan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamMission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "BirthLocation", "CharacterAge", "CharacterDescription", "CharacterName", "TeamId", "WarriorType" },
                values: new object[,]
                {
                    { 1, "Elysium", 73, "Very fast man", "Rigo", 1, "Paladin" },
                    { 2, "Xandu", 12, "Very stronk man", "Ali", 1, "Barbarian" },
                    { 3, "Valhallf", 7341, "Very wise man", "Ryan", 2, "Sorcerer" },
                    { 4, "Indianapolis", 35, "Very scary man", "Terry", 2, "Assassin" },
                    { 5, "The Holler", 55, "Very dumb but coo man", "Jimbob", 3, "Druid" },
                    { 6, "A regular place", 30, "Just a regular dude", "Regular Joe", 3, "Regular Dude" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "Ability", "BodyType", "CharacterId", "EyeColor", "HairColor", "HairStyle", "Height", "SkinColor", "Weight" },
                values: new object[,]
                {
                    { 1, "Dexterity", "Slender", 1, "Purple", "Green", "Perm", "7ft 3in", "Fair", "150lb" },
                    { 2, "Strength", "Slim", 2, "Red", "Red", "Spiked", "6ft 1in", "Light", "180lb" },
                    { 3, "Wisdom", "Rotund", 3, "Pink", "Not applicable", "Bald", "5'10", "Fair-Dark", "600lb" },
                    { 4, "Stealth", "Athletic", 4, "Brown", "Brown", "Short", "6feet 3in", "Fair-Light", "200" },
                    { 5, "Healing", "Petite", 5, "Blue", "Blue", "Long Hair", "4feet 12in", "Very Dark", "100lb" },
                    { 6, "Regularness", "Rotund", 6, "Yellow", "Yellow", "Mullet", "5feet 5in", "Very Light", "400lb" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "CharacterId", "TeamDescription", "TeamMission", "TeamName", "TeamNumber", "TeamSlogan" },
                values: new object[,]
                {
                    { 1, 0, "They really aren't very cool", "Chyllin", "Kool Kids", 17, "To Infinity And Beyond!" },
                    { 2, 0, "This team is not very effective", "Not Failing", "The Losers", 0, "FBGM" },
                    { 3, 0, "Everyone aspires to be them", "World Domination", "Chads", 69, "Send It!" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
