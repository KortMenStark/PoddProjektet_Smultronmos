using Models_new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IKategoriRepository
    {
        Task<List<Kategori>> HamtaAlla();
        Task<Kategori> HamtaEnKategori(string kategoriId);
        Task LagraKategori(Kategori nyKategori);
        Task Uppdaterakategori(Kategori uppdateradKategori);
        Task TaBortkategori(string kategoriId);
    }
}