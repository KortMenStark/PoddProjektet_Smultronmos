using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using Models_new;

namespace PL.Validering
{
    internal class Validering
    {
     // Kontrollerar att en text inte är tom.
        public static bool KontrolleraTomText(string text, string fältnamn, out string fel)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                fel = $"{fältnamn} får inte vara tom.";
                return false;
            }

            fel = string.Empty;
            return true;
        }

        // Kontrollerar att en RSS-url är ifylld och har giltigt http/https-format.
        public static bool KontrolleraRssUrl(string url, out string fel)
        {
            // Först: får inte vara tom
            if (!KontrolleraTomText(url, "RSS-länken", out fel))
                return false;

            // Sedan: enkel format-koll
            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri) ||
                (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
            {
                fel = "RSS-länken måste vara en giltig http- eller https-adress.";
                return false;
            }

            fel = string.Empty;
            return true;
        }

        // Kontrollerar att vi har ett hämtat RSS-flöde.
        public static bool KontrolleraAttFlodeFinns(SyndicationFeed? feed, out string fel)
        {
            if (feed == null)
            {
                fel = "Inget RSS-flöde att spara. Hämta först.";
                return false;
            }

            fel = string.Empty;
            return true;
        }

        // Kontrollerar att den aktuella URL:en inte har ändrats sedan flödet hämtades.
        public static bool KontrolleraAttRssInteAndrats(string aktuellUrl, string? senastHamtdRssUrl, out string fel)
        {
            if (!string.Equals(aktuellUrl, senastHamtdRssUrl, StringComparison.OrdinalIgnoreCase))
            {
                fel = "RSS-länken har ändrats sedan flödet hämtades. Hämta flödet igen innan du sparar podden.";
                return false;
            }

            fel = string.Empty;
            return true;
        }
        // =========================
        //      KATEGORI-DELEN
        // =========================
        // Validerar ett kategorinamn:
        // - Inte tomt
        // - Minst 2 tecken, max 40
        // - Unikt bland befintliga kategorier
        
        // kategoriSomRedigeras = null vid skapande.
        // Vid redigering skickar du in den kategori som redigeras,
        // så att den inte räknas som "dubblett".
        public static bool KontrolleraKategoriNamn(
            string namn,
            IEnumerable<Kategori> befintligaKategorier,
            out string fel,
            Kategori? kategoriSomRedigeras = null)
        {
            // Tom-koll
            if (!KontrolleraTomText(namn, "Kategorinamn", out fel))
                return false;

            // Längdkoll
            if (namn.Length < 2)
            {
                fel = "Kategorinamn måste vara minst 2 tecken.";
                return false;
            }

            if (namn.Length > 30)
            {
                fel = "Kategorinamn får max vara 30 tecken.";
                return false;
            }

            // Unikhetskontroll (case-insensitive, trimmad)
            var nyttNamn = namn.Trim().ToLower();

            bool finnsRedan = befintligaKategorier.Any(k =>
            {
                if (k.Namn == null)
                    return false;

                var befNamn = k.Namn.Trim().ToLower();

                // Om vi redigerar: hoppa över den kategori vi håller på att ändra
                if (kategoriSomRedigeras != null && k.Id == kategoriSomRedigeras.Id)
                    return false;

                return befNamn == nyttNamn;
            });

            if (finnsRedan)
            {
                fel = "Det finns redan en kategori med samma namn.";
                return false;
            }

            fel = string.Empty;
            return true;
        }
    }
}
