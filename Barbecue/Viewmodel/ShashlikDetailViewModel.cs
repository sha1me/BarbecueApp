using Barbecue.Messages;
using Barbecue.Services;
using Barbecue.Utility;
using BarbecueModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Barbecue.View
{
    public class ShashlikDetailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IShashlikDataService _shashlikDataService;
        private IDialogService _dialogService;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private Shashlik selectedShashlik;
        public Shashlik SelectedShashlik
        {
            get => selectedShashlik;
            set
            {
                selectedShashlik = value;
                RaisePropertyChanged();
            }
        }
        public ShashlikDetailViewModel(IShashlikDataService shashlikDataService, IDialogService dialogService)
        {
            _shashlikDataService = shashlikDataService;
            _dialogService = dialogService;

            SaveCommand = new CustomCommand(SaveShashlik, CanSaveShashlik);
            DeleteCommand = new CustomCommand(DeleteShashlik, CanDeleteShashlik);
        }

        private bool CanSaveShashlik(object obj)
        {
            throw new NotImplementedException();
        }

        private void SaveShashlik(object obj)
        {
            throw new NotImplementedException();
        }

        public void OnShashlikReceived(Shashlik shashlik)
        {
            SelectedShashlik = shashlik;
        }

        private bool CanDeleteShashlik(object obj)
        {
            return true;
        }

        private void DeleteShashlik(object shashlik)
        {
            _shashlikDataService.DeleteShashlik(selectedShashlik);
        }
    }
}
