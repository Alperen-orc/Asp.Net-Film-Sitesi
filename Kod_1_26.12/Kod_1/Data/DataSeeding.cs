using Kod_1.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();

            context.Database.Migrate();//dotnet ef database update
            var genres = new List<Genre>()
                 {
                    new Genre{Name="Macera",Movies=
                        new List<Movie>(){
                             new Movie {
                                Title="yeni macera filmi 1",
                                Description="Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of alien invaders. But when a celebrated war hero goes down in defeat, the fate of the planet and mankind hangs in the balance.",
                                ImageUrl="7.jpg",
                                
                            },
                    new Movie {
                        Title="yeni macera filmi 2",
                        Description="A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit m...",
                        ImageUrl="8.jpg",
                        
                    },

                        }
                    },
                    new Genre{Name="Komedi"},
                    new Genre{Name="Romantik"},
                    new Genre{Name="Savaş"},
                    new Genre{Name="Bilim Kurgu"}
                 };
            var movies = new List<Movie>()
{
        new Movie {
        Title="Jiu Jitsu",
        Description="Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of alien invaders. But when a celebrated war hero goes down in defeat, the fate of the planet and mankind hangs in the balance.",
        ImageUrl="7.jpg",
        Genres=new List<Genre>(){genres[0],new Genre() {Name="Yeni Tür" },genres[1] }
    },
    new Movie {
        Title="Fatman",
        Description="A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit m...",
        ImageUrl="8.jpg",
        Genres=new List<Genre>(){genres[0],genres[2] }
    },
    new Movie {
        Title="The Dalton Gang",
        Description="When their brother Frank is killed by an outlaw, brothers Bob Dalton, Emmett Dalton and Gray Dalton join their local sheriff's department. When the...",
        ImageUrl="9.jpg",
        Genres=new List<Genre>(){genres[1],genres[3] }
    },
        new Movie {
        Title="Tenet",
        Description="Armed with only one word - Tenet - and fighting for the survival of the entire world, the Protagonist journeys through a twilight world of internat...",
        ImageUrl="4.jpg",
        Genres=new List<Genre>(){genres[0],genres[1] }
    },
    new Movie {
        Title="The Craft: Legacy",
        Description="An eclectic foursome of aspiring teenage witches get more than they bargained for as they lean into their newfound powers.",
        ImageUrl="5.jpg",
        Genres=new List<Genre>(){genres[2],genres[4] }
    },
    new Movie {
        Title="Hard Kill",
        Description="The work of billionaire tech CEO Donovan Chalmers is so valuable that he hires mercenaries to protect it, and a terrorist group kidnaps his daughte...",
        ImageUrl="6.jpg",
        Genres=new List<Genre>(){genres[1],genres[2] }
    }
};
            var users = new List<User>()
            {
                new User
                {
                    UserId=1,
                    UserName="alperen6",
                    Name="alperen",
                    Email="alperenoruc6@gmail.com",
                    Password="123",
                    RePassword="123",
                    Url=null                    
                },
                new User
                {
                    UserId=2,
                    UserName="alperen7",
                    Name="alperen",
                    Email="alperenoruc6@gmail.com",
                    Password="123",
                    RePassword="123",
                    Url=null
                },
                new User
                {
                    UserId=3,
                    UserName="alperen8",
                    Name="alperen",
                    Email="alperenoruc6@gmail.com",
                    Password="123",
                    RePassword="123",
                    Url=null
                }
            };
            var comments = new List<Comment>
            {
                new Comment
                {
                    Name="Alperen",
                    comment="çok iyiydi",
                    
                }
            };
            


            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }

                if (context.Movies.Count()==0)
                {
                    context.Movies.AddRange(movies);
                }
                if (context.Comments.Count() == 0)
                {
                    context.Comments.AddRange(comments);
                }


                context.SaveChanges();
            }
        }
    }
}
