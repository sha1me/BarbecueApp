using Barbecue.Services;
using Barbecue.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace Barbecue
{
    public class ViewModelLocator
    {
        private static IDialogService _dialogservice = new DialogService();
        private static IShashlikDataService _shashlikDataService = new ShashlikDataService(new ShashlikRepository());

        private static ShashlikOverviewViewModel _shashlikOverviewViewModel = new ShashlikOverviewViewModel(_shashlikDataService, _dialogservice);
        private static ShashlikDetailViewModel _shashlikDetailViewModel = new ShashlikDetailViewModel(_shashlikDataService, _dialogservice);


        private static ShashlikDetailViewModel ShashlikDetailViewModel
        {
            get => _shashlikDetailViewModel;
        }

        public static ShashlikOverviewViewModel ShashlikOverviewViewModel
        {
            get => _shashlikOverviewViewModel;
        }
    }
}
