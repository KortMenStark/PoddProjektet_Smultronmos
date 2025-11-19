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
            });
        }
    }
}