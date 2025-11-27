using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

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
    }
}
