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
        //Metoder för CRUD-operationer på Kategori-objekt.
        Task<List<Kategori>> HamtaAlla();
        Task<Kategori> HamtaEnKategori(string kategoriId);
        Task LagraNyKategori(Kategori nyKategori);
        Task UppdateraKategori(Kategori uppdateradKategori);
        Task TaBortKategori(string kategoriId);
        Task<List<Kategori>> HamtaAllaKategorier();
    }
}