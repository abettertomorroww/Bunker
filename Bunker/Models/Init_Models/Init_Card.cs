using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Models.Init_Models
{
    class Init_Card
    {
        private Specifications specifications;
        public Init_Card(Specifications _specifications)
        {
            specifications = _specifications;

            Fill_Card();
        }

        private void Fill_Card()
        {
            specifications.Card.Add("Добавляет одно место в бункере");
            specifications.Card.Add("Игрок перед тобой (твой номер -1) обязательно должен попасть в бункер");
            specifications.Card.Add("Вернуть игрока в бункер");
            specifications.Card.Add("Данная карта даёт вам возможность поменять параметр чайлдфри любого игрока на противоположный (не чайлдфри -> чайлдфри и наоборот)");
            specifications.Card.Add("Ты можешь поменяться здоровьем с другим человеком");
            specifications.Card.Add("Ты можешь украсть хобби у другого игрока");
            specifications.Card.Add("Ваш голос считается за два");
            specifications.Card.Add("Вы можете активировать карту №1 игрока по выбору");
            specifications.Card.Add("Изменить свой багаж на новый");
            specifications.Card.Add("Вы можете активировать карту №2 игрока по выбору");
            specifications.Card.Add("Смена профессий у всех игроков");
            specifications.Card.Add("Данная карта дает возможно вылечить любого игрока от недуга(кроме вас)");
            specifications.Card.Add("Обмен профессиями по убыванию (профессия 2 переходит к 1 и тд)");
            specifications.Card.Add("Игрок +1 уходит из бункера вместе с тобой");
            specifications.Card.Add("Ваш бункер находится около пресного озера");
            specifications.Card.Add("Данная карта разрешает перекинуть один голос с вас на другого");
            specifications.Card.Add("В 50 м от вас есть бункер с женщинами(Не чайлдфри)");
            specifications.Card.Add("Лечит любого игрока или вас (сидромы и отсутствие конечности - нет)");
            specifications.Card.Add("Лечит любого игрока или вас (сидромы, отсутствие конечности и тяжелое течения болезни - нет)");
            specifications.Card.Add("Лечит любого игрока или вас (только среднее и легкое течение болезни)");
            specifications.Card.Add("Лечит любого игрока или вас (только отсутствие конечности/ей)");
            specifications.Card.Add("Ты можешь поменять свою карту фобии на новую из колоды");
            specifications.Card.Add("Рядом с вами второй бункер и он настроен недоброжелательно");
            specifications.Card.Add("В 50 м от вас есть бункер с мужчинами(Не чайлдфри)");
            specifications.Card.Add("Ты можешь обменять свою фобию на фобию другого игрока");
            specifications.Card.Add("Ты можешь поменять свою карту профессии на новую из колоды");
            specifications.Card.Add("Ваш бункер находится на необитаемом острове");
            specifications.Card.Add("Ваш бункер находится в густом зимнем(тропическом) лесу");
            specifications.Card.Add("Ваш бункер находится в пустыне");
            specifications.Card.Add("Ваш бункер находится в горах");
            specifications.Card.Add("Изменить свой багаж на новый");
            specifications.Card.Add("Возле вас находится бункер с двумя женщинами-химиками(ничего не известно)");
            specifications.Card.Add("Возле вас находится бункер с двумя мужчинами-химиками(ничего не известно)");
            specifications.Card.Add("Возле вас находится бункер с двумя женщиной-врачом(ничего не известно)");
            specifications.Card.Add("Возле вас находится бункер с мужчиной-химиком(ничего не известно)");
            specifications.Card.Add("Обмен профессиями по возрастанию (профессия 2 переходит к 3 и тд)");
            specifications.Card.Add("Обмен фобиями по убыванию (фобия 2 переходит к 1 и тд)");
            specifications.Card.Add("Обмен фобиями по возрастанию (фобия 2 переходит к 3 и тд)");
            specifications.Card.Add("Рядом с бункером находится склад оружия(состояние неизвестно)");
            specifications.Card.Add("Рядом с бункером находится магазин(состояние пуст на 90%)");
            specifications.Card.Add("Рядом с бункером находится магазин(состояние пуст на 75%)");
            specifications.Card.Add("Рядом с бункером находится магазин(состояние пуст на 50%)");
            specifications.Card.Add("Рядом с бункером находится кинотеатр");
            specifications.Card.Add("Рядом с бункером находится аптека(состояние пуста на 90%)");
            specifications.Card.Add("Рядом с бункером находится аптека(состояние неизвестно)");
            specifications.Card.Add("Ваш бункер находится у моря");
            specifications.Card.Add("Данная карта меняет профессии всех игроков на случайные");
            specifications.Card.Add("Данная карта меняет фобии всех игроков на случайные");
            specifications.Card.Add("Данная карта меняет хобби всех игроков на случайные");
            specifications.Card.Add("Данная карта позволяет открыть здоровье игрока по номеру меньшему вашего на 1");
            specifications.Card.Add("Данная карта позволяет открыть здоровье игрока по номеру большему вашего на 1");
            specifications.Card.Add("Данная карта меняет ваш рост и вес на случайные");
            specifications.Card.Add("Данная карта меняет вашу профессию на случайную");
            specifications.Card.Add("Нахождение в бункере увеличивается на 1 год(все условия остаются не изменными)");
            specifications.Card.Add("Нахождение в бункере увеличивается на 5 месяцев(все условия остаются не изменными)");
            specifications.Card.Add("Нахождение в бункере уменьшается на 5 месяцев(все условия остаются не изменными)");
            specifications.Card.Add("Нахождение в бункере уменьшается на 2 месяца(все условия остаются не изменными)");
            specifications.Card.Add("Все игроки увеличивают свой возраст на 5 лет");
            specifications.Card.Add("Все игроки уменьшают свой возраст на 5 лет");
            specifications.Card.Add("Данная карта меняет стадию болезни другого игрока на более тяжелую");
            specifications.Card.Add("Данная карта меняет стадию болезни другого игрока на более лугкую");
            specifications.Card.Add("Данная карта позволят поменяться здоровьем с ближайщеми к вам игроками (+/-1)");
        }
    }
}
