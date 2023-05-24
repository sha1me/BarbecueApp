using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Barbecue.Services;

namespace Barbecue.Services
{
    public class DialogService : IDialogService
    {
        Window shashlikDetailView = null;

        public DialogService()
        {
        }

        public void ShowDetailDialog()
        {
            shashlikDetailView = new ShashlikDetailView();
            shashlikDetailView.ShowDialog();
        }

        public void CloseDetailDialog()
        {
            if (shashlikDetailView != null)
                shashlikDetailView.Close();
        }
    }
}
