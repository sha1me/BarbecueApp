using Barbecue.Services;
using BarbecueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbecueTest.Mocks
{
    public class MockShashlikDataService : IShashlikDataService
    {
        private MockRepository _repository = new MockRepository();

        public void DeleteShashlik(Shashlik shashlik)
        {

        }

        public List<Shashlik> GetAllShashliks()
        {
            return _repository.GetShashliks();
        }

        public Shashlik GetShashlikDetail(int shashlikId)
        {
            Shashlik shashlik = _repository.GetShashlikById(shashlikId);
            return shashlik;
        }

        public void UpdateShashlik(Shashlik shashlik)
        {

        }
    }
}
