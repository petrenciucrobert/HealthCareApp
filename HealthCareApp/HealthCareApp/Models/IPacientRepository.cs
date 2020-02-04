using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{ 
    public interface IPacientRepository
    {
        IEnumerable<Pacient> AllPacients { get; }
        Pacient GetPacientById(int pacientId);
    }
}
