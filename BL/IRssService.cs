using System.ServiceModel.Syndication;

namespace BL
{
    //Ett gränssnitt som säger att alla RSS_tjänster måste ha metoden HamtaFlodeAsync.
    public interface IRssService
    {
        Task<SyndicationFeed> HamtaFlodeAsync(string rssUrl);
    }
}