

using MgrUKWShop2.Models;
using Microsoft.EntityFrameworkCore;

namespace MgrUKWShop2.DAL
{
    public class FilmsContext : DbContext
    {
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Film> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Akcja i Sensacja",
                    Desc = "Dynamiczne filmy pełne pościgów, efektów specjalnych i adrenaliny."
                },
                new Category()
                {
                    Id = 2,
                    Name = "Komedia",
                    Desc = "Lekkie i zabawne produkcje idealne na dobry humor i relaks."
                },
                new Category()
                {
                    Id = 3,
                    Name = "Dramat",
                    Desc = "Poruszające opowieści skupiające się na emocjach, relacjach i ludzkich wyborach."
                },
                new Category()
                {
                    Id = 4,
                    Name = "Sci-Fi i Fantasy",
                    Desc = "Podróże w przyszłość, kosmos, magia oraz niesamowite światy wyobraźni."
                },
                new Category()
                {
                    Id = 5,
                    Name = "Thriller i Kryminał",
                    Desc = "Trzymające w napięciu zagadki, tajemnice i mroczne intrygi."
                },
                new Category()
                {
                    Id = 6,
                    Name = "Animacje",
                    Desc = "Wyjątkowe bajki i filmy animowane dla widzów w każdym wieku."
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            var films = new List<Film>()
            {
                // --- Kategoria 1: Akcja i Sensacja (CategoryId = 1) ---
                new Film()
                {
                    Id = 1,
                    Title = "Mroczny Rycerz",
                    Director = "Christopher Nolan",
                    Desc = "Batman stawia czoło swojemu największemu wrogowi – Jokerowi.",
                    Price = 14.99m,
                    CategoryId = 1,
                    DateAdded = new DateTime(2008, 7, 18)
                },
                new Film()
                {
                    Id = 2,
                    Title = "Mad Max: Na drodze gniewu",
                    Director = "George Miller",
                    Desc = "Pościg przez postapokaliptyczne pustkowie w walce o przetrwanie.",
                    Price = 19.99m,
                    CategoryId = 1,
                    DateAdded = new DateTime(2015, 5, 15)
                },
                new Film()
                {
                    Id = 3,
                    Title = "John Wick",
                    Director = "Chad Stahelski",
                    Desc = "Były płatny zabójca mści się za śmierć swojego psa.",
                    Price = 12.99m,
                    CategoryId = 1,
                    DateAdded = new DateTime(2014, 10, 24)
                },
                new Film()
                {
                    Id = 4,
                    Title = "Gladiator",
                    Director = "Ridley Scott",
                    Desc = "Rzymski generał szuka zemsty na skorumpowanym cesarzu.",
                    Price = 16.99m,
                    CategoryId = 1,
                    DateAdded = new DateTime(2000, 5, 5)
                },
                new Film()
                {
                    Id = 5,
                    Title = "Szklana pułapka",
                    Director = "John McTiernan",
                    Desc = "Policjant z Nowego Jorku ratuje zakładników w wieżowcu.",
                    Price = 9.99m,
                    CategoryId = 1,
                    DateAdded = new DateTime(1988, 7, 15)
                },

                // --- Kategoria 2: Komedia (CategoryId = 2) ---
                new Film()
                {
                    Id = 6,
                    Title = "Kac Vegas",
                    Director = "Todd Phillips",
                    Desc = "Trzej przyjaciele budzą się po wieczorze kawalerskim w Las Vegas bez pan młodego.",
                    Price = 11.99m,
                    CategoryId = 2,
                    DateAdded = new DateTime(2009, 6, 5)
                },
                new Film()
                {
                    Id = 7,
                    Title = "Nietykalni",
                    Director = "Olivier Nakache, Eric Toledano",
                    Desc = "Sparaliżowany milioner zatrudnia młodego opiekuna z przedmieścia.",
                    Price = 13.99m,
                    CategoryId = 2,
                    DateAdded = new DateTime(2011, 11, 2)
                },
                new Film()
                {
                    Id = 8,
                    Title = "Chłopaki nie płaczą",
                    Director = "Olaf Lubaszenko",
                    Desc = "Kultowa polska komedia sensacyjna o perypetiach młodego skrzypka.",
                    Price = 9.99m,
                    CategoryId = 2,
                    DateAdded = new DateTime(2000, 2, 25)
                },
                new Film()
                {
                    Id = 9,
                    Title = "Kiler",
                    Director = "Juliusz Machulski",
                    Desc = "Zwykły taksówkarz omyłkowo wzięty za płatnego zabójcę.",
                    Price = 9.99m,
                    CategoryId = 2,
                    DateAdded = new DateTime(1997, 11, 17)
                },
                new Film()
                {
                    Id = 10,
                    Title = "Wilk z Wall Street",
                    Director = "Martin Scorsese",
                    Desc = "Błyskotliwa kariera i upadek nowojorskiego maklera giełdowego.",
                    Price = 17.99m,
                    CategoryId = 2,
                    DateAdded = new DateTime(2013, 12, 25)
                },

                // --- Kategoria 3: Dramat (CategoryId = 3) ---
                new Film()
                {
                    Id = 11,
                    Title = "Skazani na Shawshank",
                    Director = "Frank Darabont",
                    Desc = "Historia wieloletniej przyjaźni dwóch więźniów w zakładzie karnym.",
                    Price = 14.99m,
                    CategoryId = 3,
                    DateAdded = new DateTime(1994, 9, 23)
                },
                new Film()
                {
                    Id = 12,
                    Title = "Ojciec chrzestny",
                    Director = "Francis Ford Coppola",
                    Desc = "Saga rodzinna mafijnego klanu Corleone.",
                    Price = 15.99m,
                    CategoryId = 3,
                    DateAdded = new DateTime(1972, 3, 24)
                },
                new Film()
                {
                    Id = 13,
                    Title = "Zielona mila",
                    Director = "Frank Darabont",
                    Desc = "Strażnik więzienny odkrywa, że skazaniec posiada niezwykły dar.",
                    Price = 13.99m,
                    CategoryId = 3,
                    DateAdded = new DateTime(1999, 12, 10)
                },
                new Film()
                {
                    Id = 14,
                    Title = "Lista Schindlera",
                    Director = "Steven Spielberg",
                    Desc = "Niemiecki przemysłowiec ratuje setki Żydów podczas II wojny światowej.",
                    Price = 16.99m,
                    CategoryId = 3,
                    DateAdded = new DateTime(1993, 12, 15)
                },
                new Film()
                {
                    Id = 15,
                    Title = "Buntownik z wyboru",
                    Director = "Gus Van Sant",
                    Desc = "Młody geniusz matematyczny próbuje odnaleźć swoją drogę życiową.",
                    Price = 11.99m,
                    CategoryId = 3,
                    DateAdded = new DateTime(1997, 12, 5)
                },

                // --- Kategoria 4: Sci-Fi i Fantasy (CategoryId = 4) ---
                new Film()
                {
                    Id = 16,
                    Title = "Matrix",
                    Director = "Lana Wachowski, Lilly Wachowski",
                    Desc = "Haker odkrywa, że świat jest symulacją stworzoną przez maszyny.",
                    Price = 14.99m,
                    CategoryId = 4,
                    DateAdded = new DateTime(1999, 3, 31)
                },
                new Film()
                {
                    Id = 17,
                    Title = "Interstellar",
                    Director = "Christopher Nolan",
                    Desc = "Grupa astronautów wyrusza przez tunel czasoprzestrzenny, by uratować ludzkość.",
                    Price = 18.99m,
                    CategoryId = 4,
                    DateAdded = new DateTime(2014, 11, 7)
                },
                new Film()
                {
                    Id = 18,
                    Title = "Władca Pierścieni: Drużyna Pierścienia",
                    Director = "Peter Jackson",
                    Desc = "Wyprawa hobbitów mająca na celu zniszczenie Jedynych Pierścieni.",
                    Price = 19.99m,
                    CategoryId = 4,
                    DateAdded = new DateTime(2001, 12, 19)
                },
                new Film()
                {
                    Id = 19,
                    Title = "Blade Runner 2049",
                    Director = "Denis Villeneuve",
                    Desc = "Nowy łowca androidów odkrywa sekret, który może pogrążyć społeczeństwo.",
                    Price = 21.99m,
                    CategoryId = 4,
                    DateAdded = new DateTime(2017, 10, 6)
                },
                new Film()
                {
                    Id = 20,
                    Title = "Diuna",
                    Director = "Denis Villeneuve",
                    Desc = "Młody arystokrata trafia na niebezpieczną planetę pełną cennej substancji.",
                    Price = 24.99m,
                    CategoryId = 4,
                    DateAdded = new DateTime(2021, 10, 22)
                },

                // --- Kategoria 5: Thriller i Kryminał (CategoryId = 5) ---
                new Film()
                {
                    Id = 21,
                    Title = "Siedem",
                    Director = "David Fincher",
                    Desc = "Detektywi tropią seryjnego mordercę inspirowanego siedmioma grzechami głównymi.",
                    Price = 12.99m,
                    CategoryId = 5,
                    DateAdded = new DateTime(1995, 9, 22)
                },
                new Film()
                {
                    Id = 22,
                    Title = "Milczenie owiec",
                    Director = "Jonathan Demme",
                    Desc = "Młoda agentka FBI współpracuje z uwięzionym psychopatem, by złapać innego mordercę.",
                    Price = 13.99m,
                    CategoryId = 5,
                    DateAdded = new DateTime(1991, 2, 14)
                },
                new Film()
                {
                    Id = 23,
                    Title = "Wyspa tajemnic",
                    Director = "Martin Scorsese",
                    Desc = "Dwaj szeryfowie badają tajemnicze zaginięcie pacjentki szpitala psychiatrycznego.",
                    Price = 14.99m,
                    CategoryId = 5,
                    DateAdded = new DateTime(2010, 2, 19)
                },
                new Film()
                {
                    Id = 24,
                    Title = "Podziemny krąg",
                    Director = "David Fincher",
                    Desc = "Niezadowolony z życia pracownik biurowy zakłada nielegalny klub walki.",
                    Price = 13.99m,
                    CategoryId = 5,
                    DateAdded = new DateTime(1999, 10, 15)
                },
                new Film()
                {
                    Id = 25,
                    Title = "Zodiak",
                    Director = "David Fincher",
                    Desc = "Detektywi i dziennikarze próbują rozwiązać zagadkę seryjnego mordercy z San Francisco.",
                    Price = 11.99m,
                    CategoryId = 5,
                    DateAdded = new DateTime(2007, 3, 2)
                },

                // --- Kategoria 6: Animacje (CategoryId = 6) ---
                new Film()
                {
                    Id = 26,
                    Title = "Król Lew",
                    Director = "Roger Allers, Rob Minkoff",
                    Desc = "Młody lew musi przejąć władzę po swoim ojcu.",
                    Price = 14.99m,
                    CategoryId = 6,
                    DateAdded = new DateTime(1994, 6, 15)
                },
                new Film()
                {
                    Id = 27,
                    Title = "Shrek",
                    Director = "Andrew Adamson, Vicky Jenson",
                    Desc = "Ogr wyrusza na ratunek księżniczce, by odzyskać swoje bagot.",
                    Price = 12.99m,
                    CategoryId = 6,
                    DateAdded = new DateTime(2001, 4, 22)
                },
                new Film()
                {
                    Id = 28,
                    Title = "W głowie się nie mieści",
                    Director = "Pete Docter",
                    Desc = "Emocje w głowie dorastającej dziewczynki próbują utrzymać równowagę.",
                    Price = 16.99m,
                    CategoryId = 6,
                    DateAdded = new DateTime(2015, 6, 19)
                },
                new Film()
                {
                    Id = 29,
                    Title = "Spider-Man: Uniwersum",
                    Director = "Bob Persichetti, Peter Ramsey, Rodney Rothman",
                    Desc = "Młody Miles Morales odkrywa moce i wieloświat pełen Pająków.",
                    Price = 19.99m,
                    CategoryId = 6,
                    DateAdded = new DateTime(2018, 12, 14)
                },
                new Film()
                {
                    Id = 30,
                    Title = "Coco",
                    Director = "Lee Unkrich",
                    Desc = "Chłopiec trafia do Krainy Zmarłych, by poznać historię swojej rodziny.",
                    Price = 15.99m,
                    CategoryId = 6,
                    DateAdded = new DateTime(2017, 10, 27)
                }
            };


            modelBuilder.Entity<Film>().HasData(films);
        }
    }
}
