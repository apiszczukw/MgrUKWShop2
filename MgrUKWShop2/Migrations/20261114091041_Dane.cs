using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MgrUKWShop2.Migrations
{
    /// <inheritdoc />
    public partial class Dane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Dynamiczne filmy pełne pościgów, efektów specjalnych i adrenaliny.", "Akcja i Sensacja" },
                    { 2, "Lekkie i zabawne produkcje idealne na dobry humor i relaks.", "Komedia" },
                    { 3, "Poruszające opowieści skupiające się na emocjach, relacjach i ludzkich wyborach.", "Dramat" },
                    { 4, "Podróże w przyszłość, kosmos, magia oraz niesamowite światy wyobraźni.", "Sci-Fi i Fantasy" },
                    { 5, "Trzymające w napięciu zagadki, tajemnice i mroczne intrygi.", "Thriller i Kryminał" },
                    { 6, "Wyjątkowe bajki i filmy animowane dla widzów w każdym wieku.", "Animacje" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CategoryId", "DateAdded", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman stawia czoło swojemu największemu wrogowi – Jokerowi.", "Christopher Nolan", 14.99m, "Mroczny Rycerz" },
                    { 2, 1, new DateTime(2015, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pościg przez postapokaliptyczne pustkowie w walce o przetrwanie.", "George Miller", 19.99m, "Mad Max: Na drodze gniewu" },
                    { 3, 1, new DateTime(2014, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Były płatny zabójca mści się za śmierć swojego psa.", "Chad Stahelski", 12.99m, "John Wick" },
                    { 4, 1, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rzymski generał szuka zemsty na skorumpowanym cesarzu.", "Ridley Scott", 16.99m, "Gladiator" },
                    { 5, 1, new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Policjant z Nowego Jorku ratuje zakładników w wieżowcu.", "John McTiernan", 9.99m, "Szklana pułapka" },
                    { 6, 2, new DateTime(2009, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trzej przyjaciele budzą się po wieczorze kawalerskim w Las Vegas bez pan młodego.", "Todd Phillips", 11.99m, "Kac Vegas" },
                    { 7, 2, new DateTime(2011, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sparaliżowany milioner zatrudnia młodego opiekuna z przedmieścia.", "Olivier Nakache, Eric Toledano", 13.99m, "Nietykalni" },
                    { 8, 2, new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kultowa polska komedia sensacyjna o perypetiach młodego skrzypka.", "Olaf Lubaszenko", 9.99m, "Chłopaki nie płaczą" },
                    { 9, 2, new DateTime(1997, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zwykły taksówkarz omyłkowo wzięty za płatnego zabójcę.", "Juliusz Machulski", 9.99m, "Kiler" },
                    { 10, 2, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Błyskotliwa kariera i upadek nowojorskiego maklera giełdowego.", "Martin Scorsese", 17.99m, "Wilk z Wall Street" },
                    { 11, 3, new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historia wieloletniej przyjaźni dwóch więźniów w zakładzie karnym.", "Frank Darabont", 14.99m, "Skazani na Shawshank" },
                    { 12, 3, new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saga rodzinna mafijnego klanu Corleone.", "Francis Ford Coppola", 15.99m, "Ojciec chrzestny" },
                    { 13, 3, new DateTime(1999, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strażnik więzienny odkrywa, że skazaniec posiada niezwykły dar.", "Frank Darabont", 13.99m, "Zielona mila" },
                    { 14, 3, new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niemiecki przemysłowiec ratuje setki Żydów podczas II wojny światowej.", "Steven Spielberg", 16.99m, "Lista Schindlera" },
                    { 15, 3, new DateTime(1997, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Młody geniusz matematyczny próbuje odnaleźć swoją drogę życiową.", "Gus Van Sant", 11.99m, "Buntownik z wyboru" },
                    { 16, 4, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haker odkrywa, że świat jest symulacją stworzoną przez maszyny.", "Lana Wachowski, Lilly Wachowski", 14.99m, "Matrix" },
                    { 17, 4, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa astronautów wyrusza przez tunel czasoprzestrzenny, by uratować ludzkość.", "Christopher Nolan", 18.99m, "Interstellar" },
                    { 18, 4, new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wyprawa hobbitów mająca na celu zniszczenie Jedynych Pierścieni.", "Peter Jackson", 19.99m, "Władca Pierścieni: Drużyna Pierścienia" },
                    { 19, 4, new DateTime(2017, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nowy łowca androidów odkrywa sekret, który może pogrążyć społeczeństwo.", "Denis Villeneuve", 21.99m, "Blade Runner 2049" },
                    { 20, 4, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Młody arystokrata trafia na niebezpieczną planetę pełną cennej substancji.", "Denis Villeneuve", 24.99m, "Diuna" },
                    { 21, 5, new DateTime(1995, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Detektywi tropią seryjnego mordercę inspirowanego siedmioma grzechami głównymi.", "David Fincher", 12.99m, "Siedem" },
                    { 22, 5, new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Młoda agentka FBI współpracuje z uwięzionym psychopatem, by złapać innego mordercę.", "Jonathan Demme", 13.99m, "Milczenie owiec" },
                    { 23, 5, new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwaj szeryfowie badają tajemnicze zaginięcie pacjentki szpitala psychiatrycznego.", "Martin Scorsese", 14.99m, "Wyspa tajemnic" },
                    { 24, 5, new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niezadowolony z życia pracownik biurowy zakłada nielegalny klub walki.", "David Fincher", 13.99m, "Podziemny krąg" },
                    { 25, 5, new DateTime(2007, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Detektywi i dziennikarze próbują rozwiązać zagadkę seryjnego mordercy z San Francisco.", "David Fincher", 11.99m, "Zodiak" },
                    { 26, 6, new DateTime(1994, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Młody lew musi przejąć władzę po swoim ojcu.", "Roger Allers, Rob Minkoff", 14.99m, "Król Lew" },
                    { 27, 6, new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ogr wyrusza na ratunek księżniczce, by odzyskać swoje bagot.", "Andrew Adamson, Vicky Jenson", 12.99m, "Shrek" },
                    { 28, 6, new DateTime(2015, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emocje w głowie dorastającej dziewczynki próbują utrzymać równowagę.", "Pete Docter", 16.99m, "W głowie się nie mieści" },
                    { 29, 6, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Młody Miles Morales odkrywa moce i wieloświat pełen Pająków.", "Bob Persichetti, Peter Ramsey, Rodney Rothman", 19.99m, "Spider-Man: Uniwersum" },
                    { 30, 6, new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chłopiec trafia do Krainy Zmarłych, by poznać historię swojej rodziny.", "Lee Unkrich", 15.99m, "Coco" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
