using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Models.Init_Models
{
    class Init_Hobby
    {
        private Specifications specifications;
        public Init_Hobby(Specifications _specifications)
        {
            specifications = _specifications;
            Fill_Hobby();
        }

        private void Fill_Hobby()
        {
            specifications.Hobby.Add("Автомобили");
            specifications.Hobby.Add("Ароматерапия");
            specifications.Hobby.Add("Астрономия");
            specifications.Hobby.Add("Аэробика");
            specifications.Hobby.Add("Аэрография");
            specifications.Hobby.Add("Бадминтон");
            specifications.Hobby.Add("Батик");
            specifications.Hobby.Add("Батут");
            specifications.Hobby.Add("Бег");
            specifications.Hobby.Add("Бильярд");
            specifications.Hobby.Add("Блоггерство");
            specifications.Hobby.Add("Бодиарт");
            specifications.Hobby.Add("Боевые искусства(борьба, бокс, рукопашный бой, тайский бокс,…)");
            specifications.Hobby.Add("Бонсай");
            specifications.Hobby.Add("Боулинг");
            specifications.Hobby.Add("Велосипед");
            specifications.Hobby.Add("Видеомонтаж");
            specifications.Hobby.Add("Выращивание кристаллов");
            specifications.Hobby.Add("Выращивание растений и цветов");
            specifications.Hobby.Add("Вязание");
            specifications.Hobby.Add("Гербарий");
            specifications.Hobby.Add("Головоломки");
            specifications.Hobby.Add("Гольф");
            specifications.Hobby.Add("Горные лыжи");
            specifications.Hobby.Add("Граффити");
            specifications.Hobby.Add("Дайвинг");
            specifications.Hobby.Add("Дартс");
            specifications.Hobby.Add("Декупаж");
            specifications.Hobby.Add("Дерево(выжигание и резьба)");
            specifications.Hobby.Add("Диггерство");
            specifications.Hobby.Add("Дизайн интерьера");
            specifications.Hobby.Add("Дизайн одежды");
            specifications.Hobby.Add("Животные(разведение и уход)");
            specifications.Hobby.Add("Жонглирование");
            specifications.Hobby.Add("Зентангл");
            specifications.Hobby.Add("Игра на музыкальных инструментах(пианино, гитара, труба,…)");
            specifications.Hobby.Add("Игрушки и куклы");
            specifications.Hobby.Add("Игры на компьютерах и приставках");
            specifications.Hobby.Add("Изделия из металла и кузнечное дело");
            specifications.Hobby.Add("Изучение новых компьютерных программ");
            specifications.Hobby.Add("Икебана");
            specifications.Hobby.Add("Иностранные языки");
            specifications.Hobby.Add("Йога");
            specifications.Hobby.Add("Исторические реконструкции");
            specifications.Hobby.Add("Кайтинг");
            specifications.Hobby.Add("Каллиграфия");
            specifications.Hobby.Add("Карвинг");
            specifications.Hobby.Add("Картинг и квадроциклы");
            specifications.Hobby.Add("Квест - комнаты");
            specifications.Hobby.Add("Кладоискательство и археология");
            specifications.Hobby.Add("Клубный отдых");
            specifications.Hobby.Add("Коллекционирование");
            specifications.Hobby.Add("Компьютерная графика(дизайн, 3D, flash, спецэффекты и т.д.)");
            specifications.Hobby.Add("Концерты(посещение)");
            specifications.Hobby.Add("Коньки и ролики");
            specifications.Hobby.Add("Косплей");
            specifications.Hobby.Add("Кроссворды(составление и разгадывание)");
            specifications.Hobby.Add("Кулинария");
            specifications.Hobby.Add("Лазертаг");
            specifications.Hobby.Add("Лепка");
            specifications.Hobby.Add("Лошади(верховая езда, уход)");
            specifications.Hobby.Add("Лыжи");
            specifications.Hobby.Add("Массаж");
            specifications.Hobby.Add("Моделирование(самолёты, корабли, воздушные змеи, из спичек, из дерева,…)");
            specifications.Hobby.Add("Музеи и выставки");
            specifications.Hobby.Add("Музыка(написание, ремиксы)");
            specifications.Hobby.Add("Мыловарение");
            specifications.Hobby.Add("Настольные игры");
            specifications.Hobby.Add("Оригами");
            specifications.Hobby.Add("Открытки(изготовление своими руками, обмен(посткроссинг))");
            specifications.Hobby.Add("Охота");
            specifications.Hobby.Add("Паззлы");
            specifications.Hobby.Add("Парашютный спорт");
            specifications.Hobby.Add("Паркур");
            specifications.Hobby.Add("Пейнтбол");
            specifications.Hobby.Add("Пение и караоке");
            specifications.Hobby.Add("Переписка по обычной почте");
            specifications.Hobby.Add("Петанк");
            specifications.Hobby.Add("Пикап");
            specifications.Hobby.Add("Пилатес");
            specifications.Hobby.Add("Писательская деятельность и журналистика");
            specifications.Hobby.Add("Плавание");
            specifications.Hobby.Add("Плетение(бисер, корзины, коробочки, кружева, макраме…)");
            specifications.Hobby.Add("Получение научных званий и степеней");
            specifications.Hobby.Add("Предпринимательство");
            specifications.Hobby.Add("Программирование");
            specifications.Hobby.Add("Психология и тренинги");
            specifications.Hobby.Add("Путешествия(другие страны, альпинизм, походы)");
            specifications.Hobby.Add("Пчеловодство");
            specifications.Hobby.Add("Радиовещание(подкасты, интернет - радиостанции, радиопередатчики)");
            specifications.Hobby.Add("Разработка сайтов");
            specifications.Hobby.Add("Рисование(акварель, холст, бумага, карандаши, стекло, гуашь и т.п.)");
            specifications.Hobby.Add("Рисование по номерам");
            specifications.Hobby.Add("Робототехника");
            specifications.Hobby.Add("Рукоделия из кожи(одежда, аксессуары)");
            specifications.Hobby.Add("Рыбалка");
            specifications.Hobby.Add("Самодельные(handmade) вещи: одежда, обувь, аксессуары");
            specifications.Hobby.Add("Серфинг");
            specifications.Hobby.Add("Силовые тренировки");
            specifications.Hobby.Add("Скейтборд");
            specifications.Hobby.Add("Скрапбукинг(фотоальбомы своими руками)");
            specifications.Hobby.Add("Сноуборд");
            specifications.Hobby.Add("Собирание грибов и ягод");
            specifications.Hobby.Add("Спорт - фанат");
            specifications.Hobby.Add("Стекло(изготовление украшений и предметов интерьера)");
            specifications.Hobby.Add("Страйкбол");
            specifications.Hobby.Add("Стрельба");
            specifications.Hobby.Add("Танцы и балет");
            specifications.Hobby.Add("Татуировки и пирсинг");
            specifications.Hobby.Add("Театр(театральный кружок)");
            specifications.Hobby.Add("Теннис");
            specifications.Hobby.Add("Файер - шоу");
            specifications.Hobby.Add("Фейерверки");
            specifications.Hobby.Add("Фокусы");
            specifications.Hobby.Add("Фотография и фотокниги");
            specifications.Hobby.Add("Футбол");
            specifications.Hobby.Add("Шитье и вышивание");
        }
    }
}
