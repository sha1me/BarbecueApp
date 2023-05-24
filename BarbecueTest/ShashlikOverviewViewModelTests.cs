using Barbecue.Services;
using Barbecue.View;
using BarbecueModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BarbecueTest.Mocks
{
    [TestClass]
    public class ShashlikOverviewViewModelTests
    {
        private IShashlikDataService _shashlikDataService;
        private IDialogService _dialogService;


        private ShashlikOverviewViewModel GetViewModel()
        {
            return new ShashlikOverviewViewModel(this._shashlikDataService, this._dialogService);
        }

        [TestInitialize]
        public void Init()
        {
            _shashlikDataService = new MockShashlikDataService();
            _dialogService = new MockDialogService();
        }
            [TestMethod]

            public void LoadAllShashliks()
            {
                ObservableCollection<Shashlik> shashliks = null;
                var expectedShashliks = _shashlikDataService.GetAllShashliks();

                var viewModel = GetViewModel();
                shashliks = viewModel.Shashliks;

                CollectionAssert.AreEqual(expectedShashliks, shashliks);
            }
        }
    }

