using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BarbecueModel
{
    public class Shashlik : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Private Fields
        private int _shashlikID;
        private string _shashlikName;
        private int _price;
        #endregion

        #region Public Property
        public int ShashlikID
        {
            get => _shashlikID;
            set
            {
                _shashlikID = value;
                RaisePropertyChanged();
            }
        }
        public string ShashlikName
        {
            get => _shashlikName;
            set
            {
                _shashlikName = value;
                RaisePropertyChanged();
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged();
            }
        }
        public string Description { get; set ; }
        public Country OriginCountry { get; set ; }
        public bool InStock { get; set ; }
        public int AmountInStock { get; set ; }
        public DateTime FirstAddedToStockDate { get; set ; }
        public int ImageID { get; set; }
        #endregion
    }
}
