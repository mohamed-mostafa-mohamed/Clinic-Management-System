using infrastructure.DTOs.DignosisDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.DignosisService
{
    public interface IDignosisService
    {
        void Add(DignosisDtoAdd dignosisDtoAdd);
        void Delete(DignosisDtoGet dignosisDtoGet);
        IEnumerable<DignosisDtoGet> GetAll();
        DignosisDtoGet GetById(int id);
    }
}
