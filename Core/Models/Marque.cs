using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Marque
    {
        public int MarqueId { get; set; }
        public  string LibelleMarque { get; set; }

        public List<Model> Models { get; set; }


    }
}
