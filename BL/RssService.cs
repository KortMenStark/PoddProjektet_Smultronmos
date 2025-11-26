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
    //Denna klass hämtar RSS_flöden från internet via URL.
    public class RssService : IRssService
    {
        public async Task<SyndicationFeed> HamtaFlodeAsync(string rssUrl)
        {
            //Här körs hämtningen i en separat tråd för att inte blockera UI-tråden.
            return await Task.Run(() =>
            {
                try
                {
                    //Inställningar för XML-läsaren.
                    var settings = new XmlReaderSettings
                    {
                        DtdProcessing = DtdProcessing.Parse,
                        IgnoreProcessingInstructions = true,
                        IgnoreComments = true,
                        IgnoreWhitespace = true
                    };

                    //Här skapas en XML-läsare med den angivna RSS-URL:en.
                    using (XmlReader lasare = XmlReader.Create(rssUrl, settings))
                    {
                        //Här laddas RSS-flödet som SyndicationFeed-objekt.
                        return SyndicationFeed.Load(lasare);
                    }
                }
                catch (Exception ex)
                {
                    //En catch som fångar fel — 404, ogiltig URL, XML-fel, nätfel exempelvis. 
                    throw new ApplicationException(
                        "Kunde inte hämta RSS-flödet. Kontrollera att adressen är korrekt och att det är ett giltigt RSS-flöde.",
                        ex);
                }
            });
        }
    }
}