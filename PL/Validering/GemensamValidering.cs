using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Validering
{
    internal class GemensamValidering
    {
        public static void KontrolleraEjNull(object? varde, string meddelande)
        {
            if (varde is null)
                throw new ArgumentNullException(meddelande);
        }

        public static void KontrolleraVarde(string? text, string meddelande)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(meddelande);
        }

        public static void KontrolleraUrl(string? url, string meddelande)
        {
            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                throw new ArgumentException(meddelande);
        }
    }
}
