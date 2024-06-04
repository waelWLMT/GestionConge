using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Model
    {
        public int ModelId { get; set; }
        public  string LibelleModel { get; set; }

        public int MarqueId { get; set; }


        public Marque MarqueVoiture { get; set; }




    }
}
