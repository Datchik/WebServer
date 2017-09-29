using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Devise
    {
        public int Id { get; set; }
        public string DeviseName { get; set; }
        public double Taux { get; set; }

        public Devise()
        {

        }

        public Devise(int id, string deviseName, double taux)
        {
            this.Id = id;
            this.DeviseName = deviseName;
            this.Taux = taux;
        }

        public override bool Equals(Object obj)
        {
            // Performs an equality check on two points (integer pairs).
            if (obj == null || GetType() != obj.GetType()) return false;
            Devise d = (Devise)obj;
            return (Taux == d.Taux) && (Id == d.Id) && (DeviseName == d.DeviseName);
        }
    }
}