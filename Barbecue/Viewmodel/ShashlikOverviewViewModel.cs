using Barbecue.Extensions;
using Barbecue.Messages;
using Barbecue.Services;
using Barbecue.Utility;
using BarbecueModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Barbecue.View
{
    public class ShashlikOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IShashlikDataService _shashlikDataService;
        private IDialogService _dialogService;

        private ObservableCollection<Shashlik> _shashliks;
        public ObservableCollection<Shashlik> Shashliks
        {
            get => _shashliks;
            set
            {
                _shashliks = value;
                RaisePropertyChanged();
            }
        }

        private Shashlik _selectedShashlik;

        public Shashlik SelectedShashlik
        {
            get => _selectedShashlik;
            set
            {
                _selectedShashlik = value;
                RaisePropertyChanged();
            }
        }
        public ICommand EditCommand { get; set; }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ShashlikOverviewViewModel(IShashlikDataService shashlikDataService, IDialogService dialogService)
        {
            _shashlikDataService = shashlikDataService;
            _dialogService = dialogService;

            LoadData();

            LoadCommands();
        }
        private void LoadCommands()
        {
            EditCommand = new CustomCommand(EditShashlik, CanEditShashlik);
        }
        private void OnUpdateListMessageReceived(UpdateListMessage obj)
        {
            LoadData();
            _dialogService.CloseDetailDialog();
        }

        private void EditShashlik(object obj)
        {

            _dialogService.ShowDetailDialog();
        }

        private bool CanEditShashlik(object obj)
        {
            if (SelectedShashlik != null)
                return true;
            return false;
        }

        private void LoadData()
        {
            Shashliks = _shashlikDataService.GetAllShashliks().ToObservableCollection();
        }
    }
}
