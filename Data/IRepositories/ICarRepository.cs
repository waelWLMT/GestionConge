using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
   public interface ICarRepository
    {
        void AddCar(Voiture car);
        List<User> GetProprietaire();
        List<Voiture> GetListCars();
        List<Marque> GetMarque();
        List <Model>GetModel(string nameMarque);

    }
}
