using BarbecueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ShashlikRepository : IShashlikRepository
    {
        private static List<Shashlik> Shashliks;

        public ShashlikRepository()
        {
        }

        public Shashlik GetAShashlik()
        {
            if (Shashliks == null)
                LoadShashliks();

            return Shashliks.FirstOrDefault();
        }

        public List<Shashlik> GetShashliks()
        {
            if (Shashliks == null)
                LoadShashliks();

            return Shashliks;
        }
        public Shashlik GetShashlikByID(int id)
        {
            if (Shashliks == null)
                LoadShashliks();

            return Shashliks.Where(c => c.ShashlikID == id).FirstOrDefault();
        }

        public void DeleteShashlik(Shashlik shashlik)
        {
            Shashliks.Remove(shashlik);
        }

        public void UpdateShashlik(Shashlik shashlik)
        {
            Shashlik shashlikToUpdate = Shashliks.Where(c => c.ShashlikID ==  shashlik.ShashlikID).FirstOrDefault();
            shashlikToUpdate = shashlik;
        }

        private void LoadShashliks()
        {
            Shashliks = new List<Shashlik>()
            {
                new Shashlik()
                {
                    ShashlikID = 1,
                    ShashlikName = "Чуань",
                    Description = "Чуань — это китайские шашлыки, которые готовили уйгуры (представители тюркоязычной народности) в провинции Синьцзян на западе страны.",
                    ImageID = 1,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.Китай,
                    Price = 390
                },
                new Shashlik()
                {
                    ShashlikID = 2,
                    ShashlikName = "Браай",
                    Description = "Браай — это южноафриканское слово, означающее барбекю, и является его аналогом.",
                    ImageID = 2,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.ЮжнаяАфрика,
                    Price = 550
                },
                new Shashlik()
                {
                    ShashlikID = 3,
                    ShashlikName = "Йерк",
                    Description = "Йерк – это ямайский стиль готовить на огне маринованное или копченое мясо в очень острой смеси специй, называемой Ямайской Смесью Специй Йерк.",
                    ImageID = 3,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.Ямайка,
                    Price = 350
                },
                new Shashlik()
                {
                    ShashlikID = 4,
                    ShashlikName = "Лечон",
                    Description = "Лечон — это целая свинья, зажаренная на вертеле.",
                    ImageID = 4,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.Филлипины,
                    Price = 1300
                },
                new Shashlik()
                {
                    ShashlikID = 5,
                    ShashlikName = "Барбекю",
                    Description = "Если в России — шашлыки, то у американцев — барбекю. В принципе, это то же жаренное на открытом огне мясо, но есть ряд отличий.",
                    ImageID = 5,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.США,
                    Price = 500
                },
                new Shashlik()
                {
                    ShashlikID = 6,
                    ShashlikName = "Якинику",
                    Description = "Якинику возникло в Корее, но в Японии приобрело ряд особенностей. Японское якинику гораздо менее острое, чем корейское.",
                    ImageID = 6,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.Корея,
                    Price = 450
                },
                new Shashlik()
                {
                    ShashlikID = 7,
                    ShashlikName = "Сатэ",
                    Description = "В Индонезии широко распространена миниатюрная версия шашлыка — сатэ. Предположительно этот рецепт появился там в начале XIX века под влиянием арабских и индийских кулинарных традиций.",
                    ImageID = 7,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.Индонезия,
                    Price = 300
                },
                new Shashlik()
                {
                    ShashlikID = 8,
                    ShashlikName = "Хоровац",
                    Description = "Готовят его по традиции только мужчины. Рецептов более двадцати, различаются видом мяса и способами маринования — в уксусе, вине или коньяке.",
                    ImageID = 8,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.Армения,
                    Price = 590
                },
                new Shashlik()
                {
                    ShashlikID = 9,
                    ShashlikName = "Мцвади",
                    Description = "Правильный мцвади готовят только из самого свежего мяса — баранины или свинины (лучше брать шейку). И самое главное: мясо не маринуют.",
                    ImageID = 9,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.Грузия,
                    Price = 500
                },
                new Shashlik()
                {
                    ShashlikID = 10,
                    ShashlikName = "Тандури",
                    Description = "В Индии вместо классического шашлыка предпочитают готовить цыплят тандури. Название блюда напрямую связано со способом его приготовления: в глиняной индийской печи тандури.",
                    ImageID = 10,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022, 1, 3),
                    OriginCountry = Country.Индия,
                    Price = 400
                }
            };
        }

        public Shashlik GetShashlikById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
