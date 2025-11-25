using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BL
{
    public class RssService : IRssService
    {
        public async Task<SyndicationFeed> HamtaFlodeAsync(string rssUrl)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var settings = new XmlReaderSettings
                    {
                        DtdProcessing = DtdProcessing.Parse,
                        IgnoreProcessingInstructions = true,
                        IgnoreComments = true,
                        IgnoreWhitespace = true
                    };

                    using (XmlReader lasare = XmlReader.Create(rssUrl, settings))
                    {
                        return SyndicationFeed.Load(lasare);
                    }
                }
                catch (Exception ex)
                {
                    // En catch som fångar fel — 404, ogiltig URL, XML-fel, nätfel exempelvis. 
                    throw new ApplicationException(
                        "Kunde inte hämta RSS-flödet. Kontrollera att adressen är korrekt och att det är ett giltigt RSS-flöde.",
                        ex);
                }
            });
        }
    }
}