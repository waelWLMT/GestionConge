using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
   public class  EtatConge
    {
        public int IdEtat { get; set; }
        public  String Libelle { get; set; }
        public String Description { get; set; }

        public EtatConge()
        {

        }

        public EtatConge (int idEtat, string libelle, string description)
        {
            IdEtat = idEtat;
            Libelle = libelle;
            Description = description;
        }


        public override string ToString()
        {
            return "Id Etat : " +IdEtat+
                   "Libelle : " +Libelle+
                    "Description : "  +Description;
        }
    }
}
