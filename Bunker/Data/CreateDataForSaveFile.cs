using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunker.Models;

namespace Bunker.Data
{
    class CreateDataForSaveFile
    {
        Specifications specifications;
        SavingToFile saveToFile;
        public CreateDataForSaveFile(int playersCount, Specifications _specifications, string pathToFile)
        {
            specifications = _specifications;
            string disaster = FormingDisaster();
            string[][] allPlayers = new string[playersCount][];
            allPlayers = FormingRandomProperties(playersCount, disaster);
            saveToFile = new SavingToFile(allPlayers, pathToFile);
        }

        private string FormingDisaster()
        {
            Random rnd = new Random();
            string disaster = specifications.Disaster[rnd.Next(0, specifications.Disaster.Count)];
            return disaster;
        }

        private string[][] FormingRandomProperties(int playersCount, string disaster)
        {
            Random rnd = new Random();
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

                allPlayers[i] = FormingFinalProperties(propertyPlayer, disaster, rnd);
            }
            return allPlayers;
        }

        private string[] FormingFinalProperties(string[] playerProp, string disaster, Random rnd)
        {
            int age = rnd.Next(0, 2);
            int child = rnd.Next(0, 2);
            string[] propertyPlayer = new string[14];
            propertyPlayer[0] = "Катастрофа: " + disaster;
            propertyPlayer[1] = "Профессия: " + playerProp[0];
            propertyPlayer[2] = "Возраст: " + rnd.Next(16, 96);
            if (child == 1) propertyPlayer[3] = "Деторождение: Childfree";
            else propertyPlayer[3] = "Деторождение: не Childfree";
            if (age == 1) propertyPlayer[4] = "Пол: Мужчина";
            else propertyPlayer[4] = "Пол: Женщина";
            propertyPlayer[5] = "Рост: " + rnd.Next(120, 200) + " см. Вес: " + rnd.Next(38, 140) + " кг";
            propertyPlayer[6] = "Здоровье: " + playerProp[1];
            propertyPlayer[7] = "Черта характера: " + playerProp[2];
            propertyPlayer[8] = "Фоббия: " + playerProp[4];
            propertyPlayer[9] = "Хобби: " + playerProp[3];
            propertyPlayer[10] = "Доп. информация: " + playerProp[5];
            propertyPlayer[11] = "Багаж: " + playerProp[6];
            propertyPlayer[12] = "Карта 1: " + playerProp[7];
            propertyPlayer[13] = "Карта 2: " + playerProp[8];
            return propertyPlayer;
        }
    }
}
