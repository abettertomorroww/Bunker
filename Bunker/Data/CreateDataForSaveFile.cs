using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunker.Models;

namespace Bunker.Data
{
    public class CreateDataForSaveFile
    {
        Specifications specifications;
        SavingToFile saveToFile;
        public string[][] allPlayers;
        public CreateDataForSaveFile(int playersCount, Specifications _specifications, string pathToFile)
        {
            specifications = _specifications;
            Random rnd = new Random();
            string disaster = FormingDisaster(rnd);
            string formingBunker = FormingEquipmentAndDevices(rnd);
            string animals = FormingAnimal(rnd);
            allPlayers = new string[playersCount][];
            allPlayers = FormingRandomProperties(playersCount, disaster, rnd, animals, formingBunker);
            saveToFile = new SavingToFile(allPlayers, pathToFile);
        }

        private string FormingDisaster(Random rnd)
        {
            string disaster = specifications.Disaster[rnd.Next(0, specifications.Disaster.Count)] +
                $"\r\nОтсавшееся население: {rnd.Next(1, 56)}%.\r\nРазрушенность мира: {rnd.Next(25, 100)}%." +
                $"\r\nНахождение в бункере: {rnd.Next(1, 15)} лет, {rnd.Next(1, 13)} месяцев \r\n";
            return disaster;
        }

        private string FormingEquipmentAndDevices(Random rnd)
        {
            string formingBunker;
            string eq1;
            string eq2;
            string dev1;
            string dev2;
            string state;

            eq1 = specifications.Equipment[rnd.Next(0, specifications.Equipment.Count)];
            eq2 = specifications.Equipment[rnd.Next(0, specifications.Equipment.Count)];
            if (eq1 == eq2) eq2 = specifications.Equipment[rnd.Next(0, specifications.Equipment.Count)];
            dev1 = specifications.Devices[rnd.Next(0, specifications.Devices.Count)];
            dev2 = specifications.Devices[rnd.Next(0, specifications.Devices.Count)];
            if (dev1 == dev2) dev2 = specifications.Devices[rnd.Next(0, specifications.Devices.Count)];

            switch (rnd.Next(0, 4))
            {
                case 0: state = "Убежище находится в прекрасном состоянии, надежно\r\nспрятано и хорошо защищено внутри от недоброжелателей защитно-герметическими дверями.\r\nВсе системы жизнеобеспечения в норме и работают в автономном режиме.\r\nВ таком убежище можно жить и не бояться за себя."; break;
                case 1: state = "Убежище в хорошем состоянии.\r\nСуществам и другим выжившим, которые настроены враждебно, попасть вряд ли получится, потому что убежище достаточно спрятано и защищено.\r\nВсе системы жизнеобеспечения в норме, работают в автономном режиме и вряд ли могут дать сбой"; break;
                case 2: state = "Убежище в плохом состоянии, недостаточно защищен и при огромном желании враждебные существа и другие выжившие могут попасть внутрь.\r\nСистемы жизнеобеспечения в исправности и работают в автономном режиме, но в любой момент могут отказать.\r\nВсе схемы и документация о починке механизмов присутствуют"; break;
                case 3: state = "Убежище в ужасном состоянии, не защищен и при желании враждебные существа и другие выжившие могут попасть внутрь.\r\nСистемы жизнеобеспечения в сбоят и работают в автономном режиме, но в любой момент могут отказать.\r\nCхемы и документация о починке механизмов отсутствуют"; break;
                default: state = "Состояние убежищя не известно"; break;
            }

            formingBunker = $"{state}\r\n"
                + $"\r\nЖилых комнат: {rnd.Next(1,10)}." 
                + $"\r\nВ убежище оборудовано: {eq1}.\r\nВ убежище оборудовано: {eq2}."
                + $"\r\nВ убежище есть: {dev1}.\r\nВ убежище есть: {dev2}.";

            return formingBunker;
        }

        private string FormingAnimal(Random rnd)
        {
            string animals;
            switch (rnd.Next(1, 7))
            {
                case 1: animals = "\r\nВ бункере живут: Змеи\r\n"; break;
                case 2: animals = "\r\nВ бункере живут: Крысы\r\n"; break;
                case 3: animals = "\r\nВ бункере живут: Летучии мыши\r\n"; break;
                case 4: animals = "\r\nВ бункере живут: Насекомые\r\n"; break;
                case 5: animals = "\r\nВ бункере живут: Птицы\r\n"; break;
                case 6: animals = "\r\nВ бункере живут: Никто\r\n"; break;
                default: animals = "\r\nВ бункере живут: Никто\r\n"; break;
            }
            return animals;
        }

        private string[][] FormingRandomProperties(int playersCount, string disaster, Random rnd, string animals, string formingBunker)
        {
            string[] propertyPlayer = new string[9];
            string[][] allPlayers = new string[playersCount][];
            int oldNumber = 0;
            int newNumber = 0;

            for (int i = 0; i < playersCount; i++)
            {
                propertyPlayer[0] = specifications.Profession[rnd.Next(0, specifications.Profession.Count)];
                propertyPlayer[1] = specifications.Health[rnd.Next(0, specifications.Health.Count)];
                propertyPlayer[2] = specifications.Personality[rnd.Next(0, specifications.Personality.Count)];
                propertyPlayer[3] = specifications.Hobby[rnd.Next(0, specifications.Hobby.Count)];
                propertyPlayer[4] = specifications.Phobia[rnd.Next(0, specifications.Phobia.Count)];
                propertyPlayer[5] = specifications.Add_Info[rnd.Next(0, specifications.Add_Info.Count)];
                propertyPlayer[6] = specifications.Luggage[rnd.Next(0, specifications.Luggage.Count)];

                oldNumber = rnd.Next(0, specifications.Card.Count);
                propertyPlayer[7] = specifications.Card[oldNumber];
                newNumber = rnd.Next(0, specifications.Card.Count);
                if (newNumber == oldNumber)
                {
                    newNumber = rnd.Next(0, specifications.Card.Count);
                    propertyPlayer[8] = specifications.Card[newNumber];
                }
                else propertyPlayer[8] = specifications.Card[newNumber];

                allPlayers[i] = FormingFinalProperties(propertyPlayer, disaster, rnd, animals, formingBunker);
            }
            return allPlayers;
        }

        private string[] FormingFinalProperties(string[] playerProp, string disaster, Random rnd, string animals, string formingBunker)
        {
            int sex = rnd.Next(0, 2);
            int age = rnd.Next(16, 90);
            int child = rnd.Next(0, 3);
            int height = rnd.Next(120, 200);
            int weight = rnd.Next(38, 120);
            double IIB = weight / Math.Pow(height * 0.01, 2);
            int experience = rnd.Next(0, 50);
            int experienceHobby = rnd.Next(0,20);

            if (age - experience < 18 && age > 18) experience = rnd.Next(0, age - 18);
            if (age - experienceHobby < 17 && age > 17) experienceHobby = rnd.Next(0, age - 17);

            string[] propertyPlayer = new string[16];
            propertyPlayer[0] = "Катастрофа: " + disaster;
            propertyPlayer[1] = formingBunker;
            propertyPlayer[2] = animals;
            if (age > 18) propertyPlayer[3] = $"Профессия: {playerProp[0]}. Стаж работы: {experience} лет, {rnd.Next(1, 13)} месяцев";
            else propertyPlayer[3] = $"Профессия: учится на {playerProp[0]}";
            propertyPlayer[4] = "Возраст: " + age; 
            if (child == 1) propertyPlayer[5] = "Деторождение: Childfree";
            else propertyPlayer[5] = "Деторождение: не Childfree";
            if (sex == 1) propertyPlayer[6] = "Пол: Мужчина";
            else propertyPlayer[6] = "Пол: Женщина";

            if (IIB < 18.5) propertyPlayer[7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Вес ниже нормы";
            else if (IIB >= 18.5 && IIB < 25) propertyPlayer[7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Норма";
            else if (IIB >= 25 && IIB < 30) propertyPlayer[7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Избыточный вес";
            else if (IIB >= 30 && IIB < 35) propertyPlayer[7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение I степени";
            else if (IIB >= 35 && IIB < 40) propertyPlayer[7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение II степени";
            else if (IIB >= 40) propertyPlayer[7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение III степени";

            propertyPlayer[8] = "Здоровье: " + playerProp[1];
            propertyPlayer[9] = "Черта характера: " + playerProp[2];
            propertyPlayer[10] = "Фоббия: " + playerProp[4];
            if(age > 17) propertyPlayer[11] = $"Хобби: {playerProp[3]}. Стаж хобби: {experienceHobby} лет, {rnd.Next(1,13)} месяцев";
            else propertyPlayer[11] =  $"Хобби: {playerProp[3]}. Стаж хобби: {0} лет, {rnd.Next(1, 13)} месяцев";
            propertyPlayer[12] = "Доп. информация: " + playerProp[5];
            propertyPlayer[13] = "Багаж: " + playerProp[6];
            propertyPlayer[14] = "Карта 1: " + playerProp[7];
            propertyPlayer[15] = "Карта 2: " + playerProp[8];
            return propertyPlayer;
        }
    }
}
