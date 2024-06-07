﻿using koncert.Models.Entities;

namespace koncert.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            koncertDbContext koncertDbContext = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<koncertDbContext>();
            if (!koncertDbContext.Categories.Any())
            {
                koncertDbContext.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!koncertDbContext.Concerts.Any())
            {
                koncertDbContext.Concerts.AddRange
                (
                    new Concert
                    {
                        Name = "11.06| TAURON Arena | Kraków",
                        Artist = "Tool",
                        Price = 200,
                        ImageUrl = "/Images/webp/tool.webp",
                        ImageThumbnailUrl = "/Images/webp/tool.webp",
                        IsConcertOfTheMonth = false,
                        IsRecommended = true,
                        Description = new Description
                        {
                            Name = "Description - Więcej informacji o wydarzeniu",
                            NoteOneDescription = new List<NoteOneDescription>
                            {
                                new NoteOneDescription { Content = "Content - Nota 1 - Description" }
                            },
                            NoteTwoSell = new List<NoteTwoSell>
                            {
                                new NoteTwoSell { Content = "Content Nota 2 - Sell" }
                            },
                            NoteThreeOther = new List<NoteThreeOther>
                            {
                                new NoteThreeOther { Content = "Content Nota 3 - Other" }
                            },
                            Content = "Description - Content"
                        },
                        ConcertContent = new List<Content>
                        {
                            new Content
                            {
                                chapters = new List<Chapter>
                                {
                                    new Chapter
                                    {
                                        Name = "Content-Chapter-Name",
                                        Places = new List<Place>
                                        {
                                            new Place { Name = "Place-Name", Duration = "Place-Duration" }
                                        }
                                    }
                                }
                            }
                        },
                        Faq = new List<Faq>
                        {
                            new Faq { Question = "Pytanie 1", Answer = "Odpowiedz na pierwsze czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 2", Answer = "Odpowiedz na drugie czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 3", Answer = "Odpowiedz na trzecie czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 4", Answer = "Odpowiedz na czwarte czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 5", Answer = "Odpowiedz na piąte czesto zadawane pytanie." }
                        },
                        Announcements = new List<Announcement>
                        {
                            new Announcement { Content = "Annoucement - zapowiedź" }
                        },
                        Category = Categories["METAL"]
                    },
                    new Concert
                    {
                        Name = "11.06| TAURON Arena | Kraków",
                        Artist = "Pool",
                        Price = 200,
                        ImageUrl = "/Images/webp/tool.webp",
                        ImageThumbnailUrl = "/Images/webp/tool.webp",
                        IsConcertOfTheMonth = false,
                        IsRecommended = true,
                        Description = new Description
                        {
                            Name = "Description - Więcej informacji o wydarzeniu",
                            NoteOneDescription = new List<NoteOneDescription>
                            {
                                new NoteOneDescription { Content = "Content - Nota 1 - Description" }
                            },
                            NoteTwoSell = new List<NoteTwoSell>
                            {
                                new NoteTwoSell { Content = "Content Nota 2 - Sell" }
                            },
                            NoteThreeOther = new List<NoteThreeOther>
                            {
                                new NoteThreeOther { Content = "Content Nota 3 - Other" }
                            },
                            Content = "Description - Content"
                        },
                        ConcertContent = new List<Content>
                        {
                            new Content
                            {
                                chapters = new List<Chapter>
                                {
                                    new Chapter
                                    {
                                        Name = "Content-Chapter-Name",
                                        Places = new List<Place>
                                        {
                                            new Place { Name = "Place-Name", Duration = "Place-Duration" }
                                        }
                                    }
                                }
                            }
                        },
                        Faq = new List<Faq>
                        {
                            new Faq { Question = "Pytanie 1", Answer = "Odpowiedz na pierwsze czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 2", Answer = "Odpowiedz na drugie czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 3", Answer = "Odpowiedz na trzecie czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 4", Answer = "Odpowiedz na czwarte czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 5", Answer = "Odpowiedz na piąte czesto zadawane pytanie." }
                        },
                        Announcements = new List<Announcement>
                        {
                            new Announcement { Content = "Annoucement - zapowiedź" }
                        },
                        Category = Categories["METAL"]
                    },
                    new Concert
                    {
                        Name = "11.06| TAURON Arena | Kraków",
                        Artist = "Kool",
                        Price = 200,
                        ImageUrl = "/Images/webp/tool.webp",
                        ImageThumbnailUrl = "/Images/webp/tool.webp",
                        IsConcertOfTheMonth = false,
                        IsRecommended = true,
                        Description = new Description
                        {
                            Name = "Description - Więcej informacji o wydarzeniu",
                            NoteOneDescription = new List<NoteOneDescription>
                            {
                                new NoteOneDescription { Content = "Content - Nota 1 - Description" }
                            },
                            NoteTwoSell = new List<NoteTwoSell>
                            {
                                new NoteTwoSell { Content = "Content Nota 2 - Sell" }
                            },
                            NoteThreeOther = new List<NoteThreeOther>
                            {
                                new NoteThreeOther { Content = "Content Nota 3 - Other" }
                            },
                            Content = "Description - Content"
                        },
                        ConcertContent = new List<Content>
                        {
                            new Content
                            {
                                chapters = new List<Chapter>
                                {
                                    new Chapter
                                    {
                                        Name = "Content-Chapter-Name",
                                        Places = new List<Place>
                                        {
                                            new Place { Name = "Place-Name", Duration = "Place-Duration" }
                                        }
                                    }
                                }
                            }
                        },
                        Faq = new List<Faq>
                        {
                            new Faq { Question = "Pytanie 1", Answer = "Odpowiedz na pierwsze czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 2", Answer = "Odpowiedz na drugie czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 3", Answer = "Odpowiedz na trzecie czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 4", Answer = "Odpowiedz na czwarte czesto zadawane pytanie." },
                            new Faq { Question = "Pytanie 5", Answer = "Odpowiedz na piąte czesto zadawane pytanie." }
                        },
                        Announcements = new List<Announcement>
                        {
                            new Announcement { Content = "Annoucement - zapowiedź" }
                        },
                        Category = Categories["METAL"]
                    }
                );

            }
            koncertDbContext.SaveChanges();
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var categoryList = new Category[]
                    {
                        new Category { Name = "METAL" },
                        new Category { Name = "RAP" },
                        new Category { Name = "POP" },
                        new Category { Name = "JAZZ" },
                        new Category { Name = "BLUES" },
                        new Category { Name = "DANCE" },
                        new Category { Name = "ROCK" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category category in categoryList)
                    {
                        categories.Add(category.Name, category);
                    }
                }

                return categories;
            }
        }
    }
}