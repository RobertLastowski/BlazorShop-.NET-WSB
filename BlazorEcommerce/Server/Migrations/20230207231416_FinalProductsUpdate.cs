using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class FinalProductsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "World Without End takes place in the same fictional town as Pillars of the Earth — Kingsbridge — and features the descendants of some Pillars characters 157 years later.[2] The plot incorporates two major historical events, the start of the Hundred Years' War and the Black Death.[3] The author was inspired by real historical events relating to the Cathedral of Santa María in Vitoria-Gasteiz.", "https://upload.wikimedia.org/wikipedia/en/5/58/World_Without_End-Ken_Follet_Cover_World_Wide_Edition_2007.jpg?20171211011938", "World Without End" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "The Game is a 1997 American thriller film directed by David Fincher, starring Michael Douglas, Sean Penn, Deborah Kara Unger and James Rebhorn and produced by Propaganda Films and PolyGram Filmed Entertainment. It tells the story of a wealthy investment banker who is given a mysterious birthday gift by his brother—participation in a game that integrates in strange ways with his everyday life. As the lines between the banker's real life and the game become more uncertain, hints of a larger conspiracy begin to unfold.", "https://upload.wikimedia.org/wikipedia/en/2/22/The_Game_film_poster.jpg", "The Game" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Cyberpunk 2077 is a 2020 action role-playing video game developed by CD Projekt Red and published by CD Projekt. Set in Night City, an open world set in the Cyberpunk universe, players assume the role of a customisable mercenary known as V, who can acquire skills in hacking and machinery with options for melee and ranged combat. The main story follows V's struggle as he deals with a mysterious cybernetic implant that threatens to overwrite his body with the personality and memories of a deceased celebrity only perceived by V; the two must work together to be separated and save V's life.", "https://upload.wikimedia.org/wikipedia/en/9/9f/Cyberpunk_2077_box_art.jpg", "Cyberpunk 2077" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" });
        }
    }
}
