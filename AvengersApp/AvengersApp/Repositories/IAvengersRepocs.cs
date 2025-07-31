using AvengersApp.Models;


namespace AvengersApp.Repositories
{
    public interface IAvengersRepocs
    {
        public IEnumerable<Avengers> GetAllAvengers();
        public Avengers GetAvengersById(int id);
        public void UpdateAvengers(int id);
        public void DeleteAvengers(int id);
   

    }
}
