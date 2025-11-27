using Models_new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ValideringMapp
{
    internal class KategoriValidering
    {
        public static void Validera(Kategori kategori)
        {
            GemensamValidering.KontrolleraEjNull(kategori, "Kategorin får inte vara null.");
            GemensamValidering.KontrolleraVarde(kategori.Namn, "Kategorin måste ha ett namn.");

            if (kategori.Namn is not null && kategori.Namn.Length > 20)
                throw new ArgumentException("Kategorinamnet får max vara 20 tecken.");
        }
    }
}
