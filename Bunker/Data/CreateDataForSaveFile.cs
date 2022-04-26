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
            string animals = FormingAnimal(rnd);
            allPlayers = new string[playersCount][];
            allPlayers = FormingRandomProperties(playersCount, disaster, rnd, animals);
            saveToFile = new SavingToFile(allPlayers, pathToFile);
        }

        private string FormingDisaster(Random rnd)
        {
            string disaster = specifications.Disaster[rnd.Next(0, specifications.Disaster.Count)] + 
                $"\r\nОтсавшееся население: {rnd.Next(1,56)}%. Разрушенность мира: {rnd.Next(25,100)}%." +  
                "Нахождение в бункере: {rnd.Next(1, 15)} лет, {rnd.Next(1,13)} месяцев \r\n";
            return disaster;
        }

        private string FormingAnimal(Random rnd)
        {
            string animals;
            switch (rnd.Next(1, 6))
            {
                case 1: animals = "В бункере живут: Змеи\r\n"; break;
                case 2: animals = "В бункере живут: Крысы\r\n"; break;
                case 3: animals = "В бункере живут: Летучии мыши\r\n"; break;
                case 4: animals = "В бункере живут: Насекомые\r\n"; break;
                case 5: animals = "В бункере живут: Птицы\r\n"; break;
                default: animals = "В бункере живут: Никто\r\n"; break;
            }
            return animals;
        }

        private string[][] FormingRandomProperties(int playersCount, string disaster, Random rnd, string animals)
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

                allPlayers[i] = FormingFinalProperties(propertyPlayer, disaster, rnd, animals);
            }
            return allPlayers;
        }

        private string[] FormingFinalProperties(string[] playerProp, string disaster, Random rnd, string animals)
        {
            int age = rnd.Next(0, 2);
            int child = rnd.Next(0, 2);
            int height = rnd.Next(120, 200);
            int weight = rnd.Next(38, 140);
            double IIB = weight / Math.Pow(height*0.01, 2);
            
            string[] propertyPlayer = new string[15];
            propertyPlayer[0] = "Катастрофа: " + disaster;
            propertyPlayer[1] = animals;
            propertyPlayer[2] = "Профессия: " + playerProp[0];
            propertyPlayer[3] = "Возраст: " + rnd.Next(16, 96);
            if (child == 1) propertyPlayer[4] = "Деторождение: Childfree";
            else propertyPlayer[4] = "Деторождение: не Childfree";
            if (age == 1) propertyPlayer[5] = "Пол: Мужчина";
            else propertyPlayer[5] = "Пол: Женщина";

            if (IIB < 18.5) propertyPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Вес ниже нормы";
            else if (IIB >= 18.5 && IIB < 25) propertyPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Норма";
            else if (IIB >= 25 && IIB < 30) propertyPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Избыточный вес";
            else if (IIB >= 30 && IIB < 35) propertyPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение I степени";
            else if (IIB >= 35 && IIB < 40) propertyPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение II степени";
            else if (IIB >= 40) propertyPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение III степени";

            propertyPlayer[7] = "Здоровье: " + playerProp[1];
            propertyPlayer[8] = "Черта характера: " + playerProp[2];
            propertyPlayer[9] = "Фоббия: " + playerProp[4];
            propertyPlayer[10] = "Хобби: " + playerProp[3];
            propertyPlayer[11] = "Доп. информация: " + playerProp[5];
            propertyPlayer[12] = "Багаж: " + playerProp[6];
            propertyPlayer[13] = "Карта 1: " + playerProp[7];
            propertyPlayer[14] = "Карта 2: " + playerProp[8];
            return propertyPlayer;
        }
    }
}
