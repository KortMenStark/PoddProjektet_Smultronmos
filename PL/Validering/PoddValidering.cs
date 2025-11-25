using Models_new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Validering
{
    internal class PoddValidering
    {

        public static void Validera(Podd podd)
        {
            GemensamValidering.KontrolleraEjNull(podd, "Podden får inte vara null.");
            GemensamValidering.KontrolleraVarde(podd.Titel, "Podden måste ha en titel.");
            GemensamValidering.KontrolleraVarde(podd.RssUrl, "RSS-URL får inte vara tom.");
            GemensamValidering.KontrolleraUrl(podd.RssUrl, "RSS-URL är ogiltig.");
        }

        // --- Hjälpmetoder 

        //private static void KontrolleraEjNull(object? varde, string meddelande)
        //{
        //    if (varde is null)
        //        throw new ArgumentNullException(meddelande);
        //}

        //private static void KontrolleraVarde(string? text, string meddelande)
        //{
        //    if (string.IsNullOrWhiteSpace(text))
        //        throw new ArgumentException(meddelande);
        //}

        //private static void KontrolleraUrl(string? url, string meddelande)
        //{
        //    if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
        //        throw new ArgumentException(meddelande);
        //}
    }
}
