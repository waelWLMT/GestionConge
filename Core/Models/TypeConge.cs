using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class  TypeConge
    {
        public int IdTypeConge { get; set; }
        public String Libelle { get; set; }
        public String Description { get; set; }

        public TypeConge()
        {

        }

        public TypeConge(int idTypeConge, string libelle, string description)
        {
            IdTypeConge = idTypeConge;
            Libelle = libelle;
            Description = description;
        }


        public override string ToString()
        {
            return "Id Type Conge : " + IdTypeConge +
                   "Libelle : " + Libelle +
                    "Description : " + Description;
        }
    }
}
