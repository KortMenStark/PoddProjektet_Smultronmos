using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace BL
{
    public interface IRssService
    {
        Task<SyndicationFeed> HamtaFlodeAsync(string rssUrl);
    }
}