﻿using HealthCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Core.IRepository
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> AllDoctors { get; }
        //public List<Doctor> GetAllDoctors();

        public List<MedicineCategory> GetAllActive { get; set; }
    }
}
