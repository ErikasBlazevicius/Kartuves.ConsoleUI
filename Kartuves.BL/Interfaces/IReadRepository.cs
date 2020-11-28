using Kartuves.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartuves.BL.Interfaces
{
   public interface IReadRepository
    {
        List<Subject> GetAllSubjects();
    }
}
