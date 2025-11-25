using Models_new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Validering
{
    internal class AvnsittValidering
    {
        public static void Validera(Avsnitt avsnitt)
        {
            GemensamValidering.KontrolleraEjNull(avsnitt, "Avsnittet får inte vara null.");
            GemensamValidering.KontrolleraVarde(avsnitt.Titel, "Avsnittet måste ha en titel.");
        }
    }
}
