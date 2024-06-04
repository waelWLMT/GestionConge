using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Voiture
    {
        public int VoitureId { get; set; }
        public string Immatriculation { get; set; }
        public int MarqueId { get; set; }
        public int ModeleId { get; set; }
        public string Annee { get; set; }
        public int ProprietaireId { get; set; }
        /*
        // proprités de navigation
        public User Propritaire { get; set; }
        public Marque MarqueVoiture { get; set; }
        public Model ModelVoiture { get; set; }
        */

        public List<Entretien> Entretiens { get; set; }
    }
}
