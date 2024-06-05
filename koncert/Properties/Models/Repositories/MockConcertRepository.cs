using koncert.Properties.Models.Entities;

namespace koncert.Properties.Models.Repositories
{
    public class MockConcertRepository : IConcertRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Concert> AllConcerts => new List<Concert>
        {
            new Concert
            {
                ConcertId=1,
                Name = "Tool | Tauron Arena | Kraków",
                Artist = "Tool",
                Price = 200,
                ImageUrl = "",
                ImageThumbnailUrl = "",
                IsConcertOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 1,
                    Name ="Tool | Tauron Arena | Kraków",
                    NoteOneDescription = new List<NoteOneDescription>
                    {
                        new NoteOneDescription
                        {
                            NoteOneDescriptionId = 1,
                            Content = "Tool ponownie w Polsce! 11 czerwca wystąpi w Tauron Arena"
                        },
                    },
                    NoteTwoSell = new List<NoteTwoSell>
                    {
                        new NoteTwoSell
                        {
                            NoteTwoSellId = 1,
                            Content = "Kup bilety"
                        }
                    },
                    NoteThreeOther = new List<NoteThreeOther>
                    {
                        new NoteThreeOther
                        {
                            NoteThreeOtherId = 1,
                            Content = "Zapraszamy"

                        },
                    },
                    Content ="To będzie świetna zabawa"
                },
                ConcertContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 1,
                        chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 1,  
                                Name = "Tool | Tool | Tool",
                                Places = new List<Place>
                                {
                                    new Place
                                    {
                                        PlaceId = 1,
                                        Name = "Tauron Arena, Kraków",
                                        Duration = "2 godziny",
                                    },
                                },
                                
                               
                            },
        
                        },

                    
                    },
                
                
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 1,
                        Question = "Jak dojadę?",
                        Answer = "Tauron Arena znajduje się przy ul. Tauron 007."
                    },
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 1,
                        Content = "Zapowiedź wideo: https://youtu.be/MM62wjLrgmA?si=VcY21qbS5vMi5gEH"
                    },
                },
                Category= _categoryRepository.AllCategories.ToList()[1]
            }
        };
        public IEnumerable<Concert> ConcertOfTheMonth => AllConcerts.Where(c => c.IsConcertOfTheMonth); //filtrowanie poprawnych wartości ustawionych na true
        public IEnumerable<Concert> Recommended=> AllConcerts.Where(c => c.IsRecommended); //filtrowanie poprawnych wartości ustawionych na true
        public Concert? GetConcertById(int concertId)=>AllConcerts.FirstOrDefault(c=>c.ConcertId == concertId);


    }
}
