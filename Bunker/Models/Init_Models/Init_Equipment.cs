using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Models.Init_Models
{
    class Init_Equipment
    {
        Specifications specifications;
        public Init_Equipment(Specifications _specifications)
        {
            specifications = _specifications;

            Fill_Equipment();
        }

        private void Fill_Equipment()
        {
            specifications.Equipment.Add("Мастерская");
            specifications.Equipment.Add("Архив с секретными данными");
            specifications.Equipment.Add("Класс-кабинет");
            specifications.Equipment.Add("Столовая");
            specifications.Equipment.Add("Барьер для животных");
            specifications.Equipment.Add("Склад с защитной экипировкой");
            specifications.Equipment.Add("Лаборантская");
            specifications.Equipment.Add("Спортзал");
            specifications.Equipment.Add("Архив с секретными данными");
            specifications.Equipment.Add("Кухня");
            specifications.Equipment.Add("Погреб с вином");
            specifications.Equipment.Add("Небольшая теплица");
            specifications.Equipment.Add("Кинотеатр");
            specifications.Equipment.Add("Пустая комната");
            specifications.Equipment.Add("Склад");
            specifications.Equipment.Add("Медкабинет");
            specifications.Equipment.Add("Библиотека");
            specifications.Equipment.Add("Оранжерея");
            specifications.Equipment.Add("Оружейная");
            specifications.Equipment.Add("Станция очистки воды");
            specifications.Equipment.Add("Теплица");
            specifications.Equipment.Add("Комната с радио");
            specifications.Equipment.Add("Стрельбище");
            specifications.Equipment.Add("Переговорная");
            specifications.Equipment.Add("Комната видеонаблюдения");
            specifications.Equipment.Add("Операционная");
            specifications.Equipment.Add("Склад оружия");
            specifications.Equipment.Add("Склад медикаментов");
            specifications.Equipment.Add("Кислородный генератор");
            specifications.Equipment.Add("Химическая лаборатория");
            specifications.Equipment.Add("Пивоварня");
            specifications.Equipment.Add("Медблок");
            specifications.Equipment.Add("Уголок исскуства");
            specifications.Equipment.Add("Гидропонная ферма");
            specifications.Equipment.Add("Тренажёрный зал");
            specifications.Equipment.Add("Аккамуляторная");
            specifications.Equipment.Add("Комната переработки вторичных отходов");
            specifications.Equipment.Add("Комната с иконами");
            specifications.Equipment.Add("Комната с промышленными станками");
            specifications.Equipment.Add("Склад с запчастями от оружия");
            specifications.Equipment.Add("Грядки");
            specifications.Equipment.Add("Серверная");
            specifications.Equipment.Add("Склад стройматериалов");
            specifications.Equipment.Add("Искуственный загон");
            specifications.Equipment.Add("Комната пыток");
            specifications.Equipment.Add("Генераторная");
            specifications.Equipment.Add("Комната переработки загрязнёного воздуха");
            specifications.Equipment.Add("Станция обработки воды");
            specifications.Equipment.Add("Геологическая лаборатория");
            specifications.Equipment.Add("Центр управления дронами");
            specifications.Equipment.Add("Кабинет психолога/сексолога");
            specifications.Equipment.Add("Подпольный клуб");
            specifications.Equipment.Add("Комната переработки биоотходов");
            specifications.Equipment.Add("Комната с 3D принтером");
            specifications.Equipment.Add("Гараж");
            specifications.Equipment.Add("Карцер");
            specifications.Equipment.Add("Склад электроники");
            specifications.Equipment.Add("Библиотека");
            specifications.Equipment.Add("Комната санитарной обработки");
            specifications.Equipment.Add("Студия стримера");
            specifications.Equipment.Add("Инкубаторная");
            specifications.Equipment.Add("Лаборатория для исследования вирусов");
            specifications.Equipment.Add("Комната с швейной машинкой");
            specifications.Equipment.Add("Генетическая лаборатория");
            specifications.Equipment.Add("Нет");
            specifications.Equipment.Add("Нет");
            specifications.Equipment.Add("Нет");
            specifications.Equipment.Add("Баня");
            specifications.Equipment.Add("Бассейн");
            specifications.Equipment.Add("Кинотеатр");
        }
    }
}
