using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models_new;

namespace DAL.Interfaces
{
    public interface IPoddRepository
    {
        //Metoder för CRUD-operationer på Podd-objekt.
        Task<List<Podd>> HamtaAlla();
        Task<Podd> HamtaEnPodd(string poddId);
        Task LagraPodd(Podd nyPodd);
        Task UppdateraPodd(Podd uppdateradPodd);
        Task TaBortPodd(string poddId);
        Task<bool> HittaPoddMedUrlAsync(string rssUrl);

    }
}