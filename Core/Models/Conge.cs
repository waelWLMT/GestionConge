using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Conge
    {
        public int IdConge { get; set; }
        public int IdEmployee { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int IdEtat { get; set; }
        public int IdType { get; set; }


        public Conge()
        {

        }

        public Conge(int idConge, int idEmployee, DateTime dateDebut, DateTime dateFin, int idEtat, int idType)
        {
            IdConge = idConge;
            IdEmployee = idEmployee;
            DateDebut = dateDebut;
            DateFin = dateFin;
            IdEtat = idEtat;
            IdType = idType;
        }
        public override string ToString()
        {
            return "Id Conge : " +IdConge+
                   "Id Employee : " +IdEmployee+
                   "Date Debut : " +DateDebut+
                   "Date Fin : " +DateFin+
                   "Id Etat : " +IdEtat;
                   "Id Type : " + IdType +;
        }
    }



}
