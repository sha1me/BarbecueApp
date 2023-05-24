using Barbecue.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace BarbecueTest.Mocks
{
    [TestClass]
    public class ShashlikDataServiceTest
    {
        private IShashlikRepository _repository;


        [TestInitialize]
        public void Init()
        {
            _repository = new MockRepository();
        }

        [TestMethod]
        public void GetShashlikDetailTest()
        {
            var service = new ShashlikDataService(_repository);

            var shashlik = service.GetShashlikDetail(1);

            Assert.IsNotNull(shashlik);
        }
    }
}
