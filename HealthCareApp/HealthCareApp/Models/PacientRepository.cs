using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class PacientRepository : IPacientRepository
    {
        private readonly AppDbContext _appDbContext;
        public PacientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Pacient> AllPacients
        {
            get
            {
                return _appDbContext.Pacients;
            }
        }

        public Pacient GetPacientById(int pacientId)
        {
            return _appDbContext.Pacients.FirstOrDefault(p => p.PacientId == pacientId);
        }
    }
}
