using Models_new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_new
{
    public class Poddflode
    {
        public string Titel { get; set; }
        public string? Beskrivning { get; set; }
        public string? BildUrl { get; set; }
        public List<Avsnitt> AvsnittLista { get; set; }

        public Poddflode()
        {
            AvsnittLista = new List<Avsnitt>();
        }
    }
}