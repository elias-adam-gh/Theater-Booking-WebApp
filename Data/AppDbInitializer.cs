using theSite.Models;

namespace theSite.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if(!context.Cinemas.Any())
                {

                }
                //Actors
                if(!context.Actors.Any()) 
                { 

                }
                //Producers
                if(!context.Producers.Any())
                {

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
                            ImageURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt14331144%2F&psig=AOvVaw0Gq6BXElr24yxaLHfxaxod&ust=1690076914726000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCNDmm6GZoYADFQAAAAAdAAAAABAE",
                            StartDate = DateTime.Now.AddDays(4),
                            EndDate = DateTime.Now.AddDays(5),
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if(!context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}
