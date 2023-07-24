using theSite.Data.Enums;
using theSite.Models;

namespace theSite.Data
{
    public class AppDbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            context.Database.EnsureCreated();

            //Cinema
            if (!context.Cinemas.Any())
            {
                context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Regal Kingstowne",
                            Description = "Theater complex with multiple screens featuring new release films, plush seating & concession stand.\r\nAddress: 5910 Kingstowne Towne Center, Alexandria, VA 22315",
                            ImageURL = "https://lh3.googleusercontent.com/p/AF1QipMs01V3JukQqT9wu7q4LWg9iyZcyRSXLFPFEYZ3=s680-w680-h510"
                        },
                        new Cinema() 
                        {
                            Name = "Disney World Cinema",
                            Description = "The cinema in disney world, near the Orange parking garage",
                            ImageURL = "https://orlandoinformer.com/wp-content/uploads/2018/02/AMC-Disney-Springs-24-4.jpg"
                        }
                    });
                context.SaveChanges();
            }
            //Actors
            if (!context.Actors.Any())
            {
                context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilePictureURL = "https://static.wikia.nocookie.net/jujutsu-kaisen/images/7/79/Yuta_Okkotsu_%28Chapter_137%29.png/revision/latest?cb=20210201190010",
                            FullName = "Yuta Okkotsu",
                            Bio = "Yuta Okkotsu is a teenager who is surrounded and helped by the Cursed Spirit of Rika Orimoto, his childhood friend who died six years before the story and is cursed because both of them promised to get married when they grow up."
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://imgix.ranker.com/list_img_v2/4162/3244162/original/3244162-u1?fit=crop&fm=pjpg&q=60&dpr=2&w=1200&h=720",
                            FullName = "Satoru Gojo",
                            Bio = "He is widely recognized as the strongest in the world and even rivals and surpasses the King of Curses Sukuna himself."
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://lh3.googleusercontent.com/Ryg5ih-fOWbpEGDpbJYJz5RTq3_28Tvo2h3JQRCdiz16lw5ghitDMN6hcWA57g0d6_8VOqQYcCemRBOfZGQA64ZKkFOn71zuF1LDsXwCh4ywF-_z6VqxbBqmbQvK_-PWfZcztxDd1WDTEEUHX6GdP60",
                            FullName = "Monkey D. Luffy",
                            Bio = "I will be the pirate king"
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://www.dexerto.com/cdn-cgi/image/width=3840,quality=75,format=auto/https://editors.dexerto.com/wp-content/uploads/2023/04/20/one-piece-zoro-in-wano-arc.jpeg",
                            FullName = "Roronoa Zoro",
                            Bio = "Pirate hunter in Luffy's crew"
                        }
                    });
                context.SaveChanges();
            }
            //Producers
            if (!context.Producers.Any())
            {
                context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            ProfilePictureURL = "https://staticg.sportskeeda.com/editor/2022/12/19234-16714516610955-1920.jpg",
                            FullName = "Mappa",
                            Bio = "They make a lot of cool new gen anime"
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ef/Toei_Animation_logo.svg/1200px-Toei_Animation_logo.svg.png",
                            FullName = "Toei Animation",
                            Bio = "They made one piece"
                        }
                    });
                context.SaveChanges();
            }
            //Movies
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Jujutsu Kaisen 0",
                            Description = "Yuta Okkotsu, a high schooler who gains control of an extremely powerful Cursed Spirit and gets enrolled in the Tokyo Prefectural Jujutsu High School by Jujutsu Sorcerers to help him control his power and keep an eye on him.",
                            Price = 199.99,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/thumb/7/77/Gekij%C5%8D-ban_Jujutsu_Kaisen_0.png/220px-Gekij%C5%8D-ban_Jujutsu_Kaisen_0.png",
                            StartDate = DateTime.Now.AddDays(4),
                            EndDate = DateTime.Now.AddDays(5),
                            Title = MovieCategory.Action,
                            CinemaId = 1,
                            ProducerId = 1
                        },
                        new Movie()
                        {
                            Name = "One Piece Red",
                            Description = "The Straw Hat Pirates leave for the island of Elegia to attend a concert by Uta, a world-famous singer.",
                            Price = 249.99,
                            ImageURL = "https://otakuusamagazine.com/wp-content/uploads/2022/07/op-film-red-imax1-scaled.jpeg",
                            StartDate = DateTime.Now.AddDays(4),
                            EndDate = DateTime.Now.AddDays(5),
                            Title = MovieCategory.Action,
                            CinemaId = 1,
                            ProducerId = 2
                        }
                    });
                context.SaveChanges();
            }
            //Actors & Movies
            if (!context.Actors_Movies.Any())
            {
                context.Actors_Movies.AddRange(new List<Actor_Movie>()
                {
                    new Actor_Movie()
                    {
                        ActorId = 1,
                        MovieId = 1
                    },
                    new Actor_Movie() 
                    {
                        ActorId = 2,
                        MovieId = 1
                    }
                });
                context.SaveChanges();
            }
        }
    }
}