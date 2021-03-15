using Microsoft.EntityFrameworkCore;
using proiect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect.Model
{
    public class Cont
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Timestamp { get; set; }
        public List<Cheltuiala> cheltuieli { get; set; }
        public List<Venit> venituri { get; set; }

        public float balanta
        {
            get
            {
                float balanta = 0;
                foreach (Venit venit in venituri)
                {
                    balanta += venit.Suma;
                }
                foreach (Cheltuiala cheltuiala in cheltuieli)
                {
                    balanta -= cheltuiala.Suma;
                }
                return balanta;
            }
        }
    }
}
