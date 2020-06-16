using HealthCareApp.Core.IRepository;
using HealthCareApp.Core.Repository;
using HealthCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.ViewModels
{
    public class PatientCheckUpViewModel
    {

        public PatientCheckUpViewModel()
        {
            this.PatientCheckUp = new PatientCheckUp();
        }
       
        public PatientCheckUp PatientCheckUp { get; set; }
     
        public List<Doctor> Doctors { get; set; }

        
    }
}
