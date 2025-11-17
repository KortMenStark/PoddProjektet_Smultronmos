using DAL_Dataatkomstlager.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class KategoriService
    {
        private readonly IKategoriRepository kategoriRepository;

        public KategoriService(IKategoriRepository kategoriRepository)
        {
            this.kategoriRepository = kategoriRepository;
        }

        public async Task<List<Kategori>> HamtaAllaKategorier()
        {
            return await kategoriRepository.HamtaAlla();
        }

        public async Task<Kategori> HamtaKategoriMedId(string kategoriId)
        {
            return await kategoriRepository.HamtaEnKategori(kategoriId);
        }

        public async Task LagraNyKategori(Kategori nyKategori)
        {
            await kategoriRepository.LagraKategori(nyKategori);
        }

        public async Task UppdateraKategori(Kategori uppdateradKategori)
        {
            await kategoriRepository.Uppdaterakategori(uppdateradKategori);
        }

        public async Task TaBortKategori(string kategoriId)
        {
            await kategoriRepository.TaBortkategori(kategoriId);
        }
    }
}