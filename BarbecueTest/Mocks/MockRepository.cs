using BarbecueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace BarbecueTest.Mocks
{
    public class MockRepository : IShashlikRepository
    {
        private List<Shashlik> _shashliks;

        public MockRepository()
        {
            _shashliks = LoadMockShashliks();
        }

        private List<Shashlik> LoadMockShashliks()
        {
            return new List<Shashlik>();
        }


        public void DeleteShashlik(Shashlik shashlik)
        {
            throw new NotImplementedException();
        }


        public void UpdateShashlik(Shashlik shashlik)
        {
            throw new NotImplementedException();
        }

        
        public Shashlik GetAShashlik()
        {
            throw new NotImplementedException();
        }

        public Shashlik GetShashlikById(int shashlikId)
        {
            return _shashliks.Where(c => c.ShashlikID == shashlikId).FirstOrDefault();
        }

        public List<Shashlik> GetShashliks()
        {
            return _shashliks;
        }
    }
}
