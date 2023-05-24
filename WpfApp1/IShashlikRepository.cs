using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarbecueModel;

namespace WpfApp1
{
    public interface IShashlikRepository
    {
        void DeleteShashlik(Shashlik shaslik);
        Shashlik GetAShashlik();
        Shashlik GetShashlikById(int id);
        List<Shashlik> GetShashliks();
        void UpdateShashlik(Shashlik shashlik);
    }
}
