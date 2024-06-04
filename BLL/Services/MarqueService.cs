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
    public class MarqueService : IMarqueService
    { 
        private IMarqueRepository _marqueRepository;
        

        public MarqueService()
        {
            this._marqueRepository = new MarqueRepository();
        }

        public List<Marque> GetListMarque()
        {
            List<Marque> marques = new List<Marque>();
            marques = _marqueRepository.GetMarques();
            return marques;
        }
    }
}
