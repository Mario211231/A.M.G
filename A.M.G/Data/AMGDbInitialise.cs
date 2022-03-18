using A.M.G.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.M.G.Data
{
    public class AMGDbInitialise
    {
       
            public static void Seed(IApplicationBuilder applicationBuilder)
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<AMGDbContext>();
                    context.Database.EnsureCreated();
                    //Киноif 
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<AMGCinema>()
                    {   
                        new AMGCinema()
                        {
                            Name = "TheSpaceCinem",
                            Logo = "https://vtlogo.com/wp-content/uploads/2020/06/the-space-cinema-vector-logo-small.png",
                            Description = "As one of the first cinemas that have opened, we can assure you that you will have memorable experience with our audio and picture, you can help us by giving us feedbacks on what we can chance to make your experiance even better"

                        },
                        new AMGCinema()
                        {
                            Name = "SecretCinema",
                            Logo = "https://ucarecdn.com/571b50c4-34fd-4afb-ae37-47c5ef940a6d/-/format/auto/",
                            Description = "A place where you can enjoy high quality audio and 4k image, we could use your help by sending us feedback on what we can improve to make your experience even better."

                        },
                        new AMGCinema()
                        {
                            Name = "Clyde Cinema",
                            Logo = "https://images.squarespace-cdn.com/content/v1/5949cc59e58c6273f03015b4/1634091318651-GSE4CJ5MJCBYVT7C3D0G/Clyde+Cinema.jpg?format=1500w",
                            Description = "We wish you pleasant experince"

                        },
                        new AMGCinema()
                        {
                            Name = "Cinema Production",
                            Logo = "https://image.shutterstock.com/image-vector/cinema-logo-design-template-260nw-1329059810.jpg",
                            Description = "We could use your help by rating us on our website"

                        },
                        new AMGCinema()
                        {
                            Name = "SpotLight Cinema Supply",
                            Logo = "https://dcassetcdn.com/design_img/3928731/556546/26121197/yfbkkgfazsykp1psz8h4p37gqh_thumbnail.png",
                            Description = "As years pass, our little place keeps improving in any way, we could use your help by sending us feedback or rating us in our website"

                        },

                    });
                        context.SaveChanges();
                    }
                    //Актьори
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<AMGActor>()
                    {
                        new AMGActor()
                        {
                            FullName = "Leonardo DiCaprio",
                            Bio = "TBD",
                            ProfilePictureURL = "https://images.desimartini.com/media/versions/main/gallery/2016-1/f2c2b40f-4dcd-4a46-9b0c-7c6cffdc9bba_gallery_image_250_250.jpg"

                        },
                        new AMGActor()
                        {
                            FullName = "Keanu Reeves",
                            Bio = "TBD",
                            ProfilePictureURL = "https://wikinbio.com/wp-content/uploads/2021/05/Keanu-Reeves-age-height-body-spouse-affairs-salary-family-photos-wiki-biography-Caste-Religion..jpg"

                        },
                        new AMGActor()
                        {
                            FullName = "Will Smith",
                            Bio = "TBD",
                            ProfilePictureURL = "https://static.joonsite.com/seelatest/topic/will-smith.jpg"

                        },
                        new AMGActor()
                        {
                            FullName = "Scarlett Johansson",
                            Bio = "TBD",
                            ProfilePictureURL = "https://cdn.mos.cms.futurecdn.net/vErPd9EFTZJjVQQubxdNpA-320-80.jpgscarlett"

                        },
                        new AMGActor()
                        {
                            FullName = "Natalie Portman",
                            Bio = "TBD",
                            ProfilePictureURL = "https://qt.azureedge.net/resources/authors-images-large/natalie-portman.jpg"

                        },
                    });

                        //Продуценти
                        if (!context.Producers.Any())
                        {
                            context.Producers.AddRange(new List<AMGProducer>()
                    {
                        new AMGProducer()
                        {
                            FullName = "Christopher Nolan",
                            Bio = "TBD",
                            ProfilePictureURL = "https://www.femalefirst.co.uk/image-library/partners/bang/square/250/c/christopher-nolan-aced7cb1e2e1b7d5a8c98b7915806bc8cb792496"

                        },
                        new AMGProducer()
                        {
                            FullName = "Kevin Feige",
                            Bio = "TBD",
                            ProfilePictureURL = "https://static.wikia.nocookie.net/marveldatabase/images/f/ff/Kevin_Feige_001.jpg/revision/latest/smart/width/250/height/250?cb=20170601023537"

                        },
                        new AMGProducer()
                        {
                            FullName = "Steven Spielberg",
                            Bio = "TBD",
                            ProfilePictureURL = "http://qt.azureedge.net/resources/authors-images-large/steven-spielberg.jpg"

                        },
                        new AMGProducer()
                        {
                            FullName = "Quentin Tarantino",
                            Bio = "TBD",
                            ProfilePictureURL = "https://celebritypets.net/wp-content/uploads/2021/10/Quentin-Tarantino-pets-250x250.jpg?x68066"

                        },
                         new AMGProducer()
                        {
                            FullName = "Spike Lee",
                            Bio = "TBD",
                            ProfilePictureURL = "http://www.nymag.com/daily/intel/17_spikelee_lgl.jpg"

                        },

                    });
                            context.SaveChanges();
                            //Филми
                            if (!context.Movies.Any())
                            {
                                context.Movies.AddRange(new List<AMGMovie>()
                            {
                                new AMGMovie()
                                {
                                    Name = "The Revenant",
                                    Description = "To be expected",
                                    Price = 15.50,
                                    ImageURL = "https://flxt.tmsimg.com/assets/p11598208_p_v8_ac.jpg",
                                    StartDate = DateTime.Now.AddDays(-10),
                                    EndDate = DateTime.Now.AddDays(10),
                                    CinemaId = 2,
                                    ProducerId = 1,
                                    MovieClassification = MovieClassification.Fiction

                                },


                                new AMGMovie()
                                {
                                    Name = "John Wick",
                                    Description = "To be expected",
                                    Price = 20.99,
                                    ImageURL = "https://lionsgate.brightspotcdn.com/59/e8/576c91ae47e4aa7fd6240dc48674/john-wick-chapter-1-movies-poster-01.jpg",
                                    StartDate = DateTime.Now.AddDays(-10),
                                    EndDate = DateTime.Now.AddDays(10),
                                    CinemaId = 5,
                                    ProducerId = 4,
                                    MovieClassification = MovieClassification.Fiction

                                },

                                new AMGMovie()
                                {
                                    Name = "Bad Boys",
                                    Description = "To be expected",
                                    Price = 11.99,
                                    ImageURL = "https://mediocremovies.com/wp-content/uploads/2018/11/Bad-Boys-II.jpg",
                                    StartDate = DateTime.Now.AddDays(-10),
                                    EndDate = DateTime.Now.AddDays(10),
                                    CinemaId = 4,
                                    ProducerId = 3,
                                    MovieClassification = MovieClassification.Fiction

                                },

                                new AMGMovie()
                                {
                                    Name = "Black Widow",
                                    Description = "To be expected",
                                    Price = 14.99,
                                    ImageURL = "https://static.posters.cz/image/1300/%D0%9A%D0%B0%D0%BB%D0%B5%D0%BD%D0%B4%D0%B0%D1%80%D0%B8/marvel-black-widow-i98216.jpg",
                                    StartDate = DateTime.Now.AddDays(-10),
                                    EndDate = DateTime.Now.AddDays(10),
                                    CinemaId = 3,
                                    ProducerId = 5,
                                    MovieClassification = MovieClassification.Fiction

                                },

                                new AMGMovie()
                                {
                                    Name = "Black Swan",
                                    Description = "To be expected",
                                    Price = 16.99,
                                    ImageURL = "https://flxt.tmsimg.com/assets/p8236892_p_v8_ar.jpg",
                                    StartDate = DateTime.Now.AddDays(-10),
                                    EndDate = DateTime.Now.AddDays(10),
                                    CinemaId = 1,
                                    ProducerId = 2,
                                    MovieClassification = MovieClassification.Fiction

                                },
                                new AMGMovie()
                                {
                                    Name = "Men in Black",
                                    Description = "To be expected",
                                    Price = 10.99,
                                    ImageURL = "https://m.media-amazon.com/images/M/MV5BMDZkODI2ZGItYTY5Yi00MTA4LWExY2ItM2ZmNjczYjM0NDg1XkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_.jpg",
                                    StartDate = DateTime.Now.AddDays(-10),
                                    EndDate = DateTime.Now.AddDays(10),
                                    CinemaId = 4,
                                    ProducerId = 3,
                                    MovieClassification = MovieClassification.Action

                                }


                            });
                                context.SaveChanges();


                            }

                            //Актьори и Филми
                            if (!context.Actors_Movies.Any())   

                                context.Actors_Movies.AddRange(new List<AMGActor_Movie>()
                                {
                                     new AMGActor_Movie()
                               {
                                   ActorId = 1,
                                   MovieId = 4
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 2,
                                   MovieId = 3
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 4,
                                   MovieId = 5
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 5,
                                   MovieId = 2
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 3,
                                   MovieId = 1
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 4,
                                   MovieId = 1
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 4,
                                   MovieId = 3
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 5,
                                   MovieId = 4
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 2,
                                   MovieId = 5
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 1,
                                   MovieId = 3
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 5,
                                   MovieId = 1
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 4,
                                   MovieId = 2
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 2,
                                   MovieId = 5
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 3,
                                   MovieId = 3
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 5,
                                   MovieId = 5
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 1,
                                   MovieId = 2
                               },

                               new AMGActor_Movie()
                               {
                                   ActorId = 5,
                                   MovieId = 6
                               },

                            });
                            context.SaveChanges();


                        }
                    }
                }
            }
        
    }
   
}

