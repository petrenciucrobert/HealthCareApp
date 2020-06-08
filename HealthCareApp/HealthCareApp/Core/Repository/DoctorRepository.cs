using HealthCareApp.Core.IRepository;
using HealthCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Core.Repository
{
    public class DoctorRepository:IDoctorRepository
    {
        private readonly AppDbContext _appDbContext;
        public DoctorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }



        public IEnumerable<Doctor> AllDoctors()
        {
                return _appDbContext.Doctors.ToList();
            
        }
    }
}
