using Microsoft.EntityFrameworkCore;
using proiect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect.Model
{
   

    public class Cheltuiala
    {
        public enum Tip
        {
            UTILITATI,
            DIVERTISMENT,
            MANCARE,
            IMBRACAMINTE,
            MEDICAMENTE,
            SERVICII,
            TRANSPORT,
            COMISION
        }

        public string Id { get; set; }
        public float Suma { get; set; }
        public int Timestamp { get; set; }
        public Tip TipCheltuiala { get; set; }
    }
}
