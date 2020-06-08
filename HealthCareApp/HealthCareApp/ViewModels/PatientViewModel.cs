using HealthCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.ViewModels
{
    public class PatientDetailViewModel
    {
        public Patient PatientDetail { get; set; }
        public List<PatientCheckUp> CheckupHistoryList { get; set; }
    }
}
