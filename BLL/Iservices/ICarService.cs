using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
   public  interface ICarService
    {
        void CreationCar(Voiture car);
        List<User> GetNomPrenomProprietaire();

        List<Voiture> GetListeVoiture();
        List<Marque> GetListMarque();
        List<Model> GetListModel(string nameMarque);
    }
}
