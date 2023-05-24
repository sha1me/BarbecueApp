using BarbecueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbecue.Services
{
    public interface IShashlikDataService
    {
        void DeleteShashlik(Shashlik shashlik);
        List<Shashlik> GetAllShashliks();
        Shashlik GetShashlikDetail(int shashlikId);
        void UpdateShashlik(Shashlik shashlik);
    }
}
