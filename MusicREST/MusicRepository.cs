namespace MusicREST
{
    public class MusicRepository
    {
        private int _nextId = 4;
        private List<MusicRecords> _musics = new()
        {
            new MusicRecords { Id = 1, Title = "Renaissance", Artist = "Beyonce", Duration = 16, PublicationYear = 2022 },
            new MusicRecords { Id = 2, Title = "Pink Friday 2", Artist = "Nicki Minaj", Duration = 22, PublicationYear = 2023 },
            new MusicRecords { Id = 3, Title = "Graduation", Artist = "Kanye West", Duration = 14, PublicationYear = 2007 }
        };
    }
}
