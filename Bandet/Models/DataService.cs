namespace Bandet.Models
{
    public class DataService
    {
        private static List<Band> bands = new List<Band>()
        {
            new Band { Id = 1, Name = "Kreator", Description= "Thrash Metal from Germany"},
            new Band { Id = 2, Name = "Green Day", Description= "Grunge from USA"},
            new Band { Id = 3, Name = "Ludovic Einaudi", Description= "Classical Music from Italy"}
        };

        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }

        public Band GetBandById(int id)
        {
            var bandsArray= bands.ToArray();
            return bandsArray[id-1];
        }
    }
}
