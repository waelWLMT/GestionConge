using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Employee : Users
    {

        public int IdEmployee { get; set; }
        public int IdResponsable { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Email { get; set; }
        public String Tel { get; set; }

        public Employee (int idUser)
        {
            IdUser = idUser;
        }
        public Employee(int idUser, int idEmpoyee, int idResponsable, string nom, string prenom, string email, string tel)
        {
            IdUser = idUser;
            IdEmployee = idEmpoyee;
            IdResponsable = idResponsable;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Tel = tel;
        }

        public override string ToString()
        {
            return "IdUser :" + IdUser +
                    "Id Employee : " + IdEmployee +
                    "Id Responsable : " + IdResponsable +
                    "Nom : " + Nom +
                    "Prenom : " + Prenom +
                    "Email : " + Email +
                    "Tel : " + Tel;
                    
        }


    }
}
