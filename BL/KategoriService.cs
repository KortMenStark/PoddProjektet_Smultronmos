using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Repository;
using Models_new;


namespace BL
{
    public class KategoriService
    {
        // 1. Rätt fält
        private readonly IKategoriRepository kategoriRepository;
        private readonly IPoddRepository _poddRepository;
        // 2. Rätt konstruktor
        public KategoriService(
        IKategoriRepository kategoriRepository,
        IPoddRepository poddRepository)
        {
            this.kategoriRepository = kategoriRepository;
            _poddRepository = poddRepository;
        }
        // 3. Hämta kategorier
        public Task<List<Kategori>> HamtaAllaKategorier()
        {
            return kategoriRepository.HamtaAllaKategorier();
        }
        // 4. Lagra kategori
        public Task LagraNyKategori(Kategori kategori)
        {
            return kategoriRepository.LagraNyKategori(kategori);
        }
        // 5. Uppdatera kategori
        public Task UppdateraKategori(Kategori kategori)
        { 
            return kategoriRepository.UppdateraKategori(kategori);
        }
        // 6. Ta bort kategori + nollställ kategori på poddar
        public async Task TaBortKategori(string kategoriId)
        {
            // 6.1 Hämta alla poddar
            var allaPoddar = await _poddRepository.HamtaAlla();
            // 6.2 Filtrera poddar som tillhör kategorin
            var drabbade = allaPoddar
            .Where(p => p.KategoriId == kategoriId)
            .ToList();
            // 6.3 Sätt kategori till null och uppdatera
            foreach (var podd in drabbade)
            {
                podd.KategoriId = null;
                await _poddRepository.UppdateraPodd(podd);
            }
            // 6.4 Ta bort kategorin
            await kategoriRepository.TaBortKategori(kategoriId);
        }
    }
}