using Models_new;

namespace DAL.Interfaces
{
    public interface IKategoriRepository
    {
        //Metoder för CRUD-operationer på Kategori-objekt.
        Task<Kategori> HamtaEnKategori(string kategoriId);
        Task LagraNyKategori(Kategori nyKategori);
        Task UppdateraKategori(Kategori uppdateradKategori);
        Task TaBortKategori(string kategoriId);
        Task<List<Kategori>> HamtaAllaKategorier();
    }
}