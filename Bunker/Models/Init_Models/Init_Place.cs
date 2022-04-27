using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Models.Init_Models
{
    class Init_Place
    {
        Specifications specifications;
        public Init_Place(Specifications _specifications)
        {
            specifications = _specifications;
            Fill_Place();
        }
        private void Fill_Place()
        {
            specifications.Place.Add("Карьер");
            specifications.Place.Add("Пустыня");
            specifications.Place.Add("Архипелаг");
            specifications.Place.Add("Тропический лес");
            specifications.Place.Add("Остров");
            specifications.Place.Add("Плоскогорье");
            specifications.Place.Add("Хвойный лес");
            specifications.Place.Add("Горы");
            specifications.Place.Add("Тайга");
            specifications.Place.Add("Кратер");
            specifications.Place.Add("Лиственный лес");
            specifications.Place.Add("Болото");
            specifications.Place.Add("Побережье");
            specifications.Place.Add("Тундра");
            specifications.Place.Add("Степь");
            specifications.Place.Add("Арктика");
            specifications.Place.Add("Космическая станция");
            specifications.Place.Add("Подводный купол");
        }
    }
}
