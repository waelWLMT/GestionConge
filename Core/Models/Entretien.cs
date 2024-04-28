using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Entretien
    {
        public int EntretienId { get; set; }
        public DateTime DateEffet { get; set; }
        public  string Kilometrage { get; set; }
        public bool FiltreAirChange { get; set; }
        public bool FiltreHuileChange { get; set; }
        public bool FiltreEssenceChange { get; set; }
        public string MarqueHuile { get; set; }
        public string Commentaire { get; set; }

        // propriete de navigation
        public int VoitureId { get; set; }
        public Voiture Voiture { get; set; }

    }
}
