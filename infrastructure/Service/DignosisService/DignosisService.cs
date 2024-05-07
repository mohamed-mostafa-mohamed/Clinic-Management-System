using APP_DAL.Models;
using APP_DAL.Repo.DignosisRepo;
using infrastructure.DTOs.DignosisDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Service.DignosisService
{
    public class DignosisService : IDignosisService
    {
        private readonly IDignosisRepo _dignosisRepo;

        public DignosisService(IDignosisRepo dignosisRepo)
        {
          _dignosisRepo = dignosisRepo;
        }
        public void Add(DignosisDtoAdd dignosisDtoAdd)
        {
            var dig = new Dignosis() 
            {
                Disease=dignosisDtoAdd.Disease,
            }; 
            _dignosisRepo.Add(dig);
        }

        public void Delete(DignosisDtoGet dignosisDtoGet)
        {
            var dig = new Dignosis()
            {
                Disease = dignosisDtoGet.Disease,
            };
            _dignosisRepo.Delete(dig);
        }

        public IEnumerable<DignosisDtoGet> GetAll()
        {
            var dig = _dignosisRepo.GetAll();
            return dig.Select(x => new DignosisDtoGet
            {
                Disease=x.Disease,
                ID=x.ID
            });
        }

        public DignosisDtoGet GetById(int id)
        {
            var dig = _dignosisRepo.GetById(id);
            if (dig == null)return null;
            return new DignosisDtoGet { Disease=dig.Disease,ID=dig.ID};
        }
    }
}
