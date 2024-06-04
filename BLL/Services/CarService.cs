using BLL.IServices;
using Core.Models;
using Data.IRepositories;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CarService : ICarService
    {
        private  ICarRepository _carRepository;

        public CarService()
        {
            this._carRepository = new CarRepository();
        }
        public void CreationCar(Voiture car)
        {
            this._carRepository.AddCar(car);
        }

        public List<Voiture> GetListeVoiture()
        {
            List<Voiture> voitures = new List<Voiture>();
            voitures = _carRepository.GetListCars();
            return voitures;
        }

        public List<Marque> GetListMarque()
        {
            List<Marque> marques = new List<Marque>();
            marques = _carRepository.GetMarque();
            return marques;
        }

        public List<Model> GetListModel(string nameMarque)
        {
            List<Model> modeles = new List<Model>();
            modeles = _carRepository.GetModel(nameMarque);
            return modeles;
        }

        public List<User> GetNomPrenomProprietaire()
        {
            List<User> propietaires = new List<User>();
            propietaires = _carRepository.GetProprietaire();
            return propietaires;
        }
    }
}
