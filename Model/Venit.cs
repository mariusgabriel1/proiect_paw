using Microsoft.EntityFrameworkCore;
using proiect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect.Model
{
    public class Venit
    {
        public enum Tip
        {
            DIVIDENDE,
            MOSTENIRE,
            ASIGURARE,
            PENSIE,
            CADOU,
            CHIRIE,
            SALARIU,
            BURSA,
            VANZARE,
            SUBVENTIE
        }

        public string Id { get; set; }
        public float Suma { get; set; }
        public int Timestamp { get; set; }
        public Tip TipVenit { get; set; }
    }
}
