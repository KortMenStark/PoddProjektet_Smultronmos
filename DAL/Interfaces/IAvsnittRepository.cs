using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAvsnittRepository
    {
        Task<List<Avsnitt>> HamtaAlla();
        Task<Avsnitt> HamtaEttAvsnitt(string avsnittId);
        Task LagraAvsnitt(Avsnitt nyttAvsnitt);
        Task UppdateraAvsnitt(Avsnitt uppdateratAvsnitt);
        Task TaBortAvsnitt(string avsnittId);
    }
}