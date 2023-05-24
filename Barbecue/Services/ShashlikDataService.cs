using BarbecueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace Barbecue.Services
{
    public class ShashlikDataService : IShashlikDataService
    {
        IShashlikRepository _repository;
        public ShashlikDataService(IShashlikRepository repository)
        {
            _repository = repository;
        }

        public Shashlik GetShashlikDetail(int shashlikId)
        {
            return _repository.GetShashlikById(shashlikId);
        }
        public List<Shashlik> GetAllShashliks()
        {
            return _repository.GetShashliks();
        }

        public void DeleteShashlik(Shashlik shashlik)
        {
            _repository.DeleteShashlik(shashlik);
        }

        public void UpdateShashlik(Shashlik shashlik)
        {
            throw new NotImplementedException();
        }
    }
}
