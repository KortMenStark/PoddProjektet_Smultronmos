using DAL.Interfaces;
using Models_new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AvsnittService
    {
        private readonly IAvsnittRepository avsnittRepository;

        public AvsnittService(IAvsnittRepository avsnittRepository)
        {
            this.avsnittRepository = avsnittRepository;
        }

        public async Task<List<Avsnitt>> HamtaAllaAvsnitt()
        {
            return await avsnittRepository.HamtaAlla();
        }

        public async Task<Avsnitt> HamtaAvsnittMedId(string avsnittId)
        {
            return await avsnittRepository.HamtaEttAvsnitt(avsnittId);
        }

        public async Task LagraNyttAvsnitt(Avsnitt nyttAvsnitt)
        {
            await avsnittRepository.LagraAvsnitt(nyttAvsnitt);
        }

        public async Task UppdateraAvsnitt(Avsnitt uppdateratAvsnitt)
        {
            await avsnittRepository.UppdateraAvsnitt(uppdateratAvsnitt);
        }

        public async Task TaBortAvsnitt(string avsnittId)
        {
            await avsnittRepository.TaBortAvsnitt(avsnittId);
        }
    }
}