using HealthCareApp.Core.IRepository;
using HealthCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Core.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _appDbContext;
        public DoctorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }



        public IEnumerable<Doctor> AllDoctors
        {
            get
            {
                return _appDbContext.Doctors;
            }
        }

        public List<MedicineCategory> GetAllActive
        {
            get
            {
                return _appDbContext.MedicineCategory.ToList();
            }

        }

        List<MedicineCategory> IDoctorRepository.GetAllActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<MedicineCategory> GetAllDoctors()
        {

            throw new NotImplementedException();
        }
    }
}
