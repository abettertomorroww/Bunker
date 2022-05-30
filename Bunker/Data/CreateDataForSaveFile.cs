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
            string[] propertiesPlayer = new string[9];
            string[][] allPlayers = new string[playersCount][];
            int oldNumber = 0;
            int newNumber = 0;

            for (int i = 0; i < playersCount; i++)
            {
                propertiesPlayer[0] = specifications.Profession[rnd.Next(0, specifications.Profession.Count)];
                propertiesPlayer[1] = specifications.Health[rnd.Next(0, specifications.Health.Count)];
                propertiesPlayer[2] = specifications.Personality[rnd.Next(0, specifications.Personality.Count)];
                propertiesPlayer[3] = specifications.Hobby[rnd.Next(0, specifications.Hobby.Count)];
                propertiesPlayer[4] = specifications.Phobia[rnd.Next(0, specifications.Phobia.Count)];
                propertiesPlayer[5] = specifications.Add_Info[rnd.Next(0, specifications.Add_Info.Count)];
                propertiesPlayer[6] = specifications.Luggage[rnd.Next(0, specifications.Luggage.Count)];

                oldNumber = rnd.Next(0, specifications.Card.Count);
                propertiesPlayer[7] = specifications.Card[oldNumber];
                newNumber = rnd.Next(0, specifications.Card.Count);
                if (newNumber == oldNumber)
                {
                    newNumber = rnd.Next(0, specifications.Card.Count);
                    propertiesPlayer[8] = specifications.Card[newNumber];
                }
                else propertiesPlayer[8] = specifications.Card[newNumber];

                allPlayers[i] = FormingFinalProperties(propertiesPlayer, disaster, rnd, animals);
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
            
            string[] propertiesPlayer = new string[15];
            propertiesPlayer[0] = "Катастрофа: " + disaster;
            propertiesPlayer[1] = animals;
            propertiesPlayer[2] = "Профессия: " + playerProp[0];
            propertiesPlayer[3] = "Возраст: " + rnd.Next(16, 96);
            if (child == 1) propertiesPlayer[4] = "Деторождение: Childfree";
            else propertiesPlayer[4] = "Деторождение: не Childfree";
            if (age == 1) propertiesPlayer[5] = "Пол: Мужчина";
            else propertiesPlayer[5] = "Пол: Женщина";

            if (IIB < 18.5) propertiesPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Вес ниже нормы";
            else if (IIB >= 18.5 && IIB < 25) propertiesPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Норма";
            else if (IIB >= 25 && IIB < 30) propertiesPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Избыточный вес";
            else if (IIB >= 30 && IIB < 35) propertiesPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение I степени";
            else if (IIB >= 35 && IIB < 40) propertiesPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение II степени";
            else if (IIB >= 40) propertiesPlayer[6] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение III степени";

            propertiesPlayer[7] = "Здоровье: " + playerProp[1];
            propertiesPlayer[8] = "Черта характера: " + playerProp[2];
            propertiesPlayer[9] = "Фоббия: " + playerProp[4];
            propertiesPlayer[10] = "Хобби: " + playerProp[3];
            propertiesPlayer[11] = "Доп. информация: " + playerProp[5];
            propertiesPlayer[12] = "Багаж: " + playerProp[6];
            propertiesPlayer[13] = "Карта 1: " + playerProp[7];
            propertiesPlayer[14] = "Карта 2: " + playerProp[8];
            return propertiesPlayer;
        }
    }
}
