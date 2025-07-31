using AvengersApp.Models;
using AvengersApp.Repositories;
using System.Runtime.CompilerServices;
using AvengersApp.Data;

namespace AvengersApp.Repositories
{
    public class AvengersRepo : IAvengersRepocs
    {
        private readonly AppDBContext _dbContext;

        public AvengersRepo(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteAvengers(int id)
        {
           _dbContext.Remove(id);

        }

        public List<Avengers> GetAllAvengers()
        {
            return _dbContext.avengers.ToList();
        }

      
        public Avengers GetAvengersById(int id)
        {
            var avenger = _dbContext.avengers.Find(id);
            return avenger;
        }

        public void UpdateAvengers(int id)
        {
            _dbContext.Update(id);
        }
    }
}