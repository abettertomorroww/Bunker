using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunker.Data;
using Bunker.Models;

namespace Bunker
{
    public partial class SettingsForm : Form
    {
        private Specifications specifications;
        private int playersCount;
        private CreateDataForSaveFile createData;
        private SavingToFile savingToFile;
        private Random rnd = new Random();
        private string pathToFile;

        public SettingsForm(int _playersCount, Specifications _specifications, CreateDataForSaveFile _createData, string _pathToFile)
        {
            InitializeComponent();
            specifications = _specifications;
            createData = _createData;
            playersCount = _playersCount;
            pathToFile = _pathToFile;
            for (int i = 0; i < playersCount; i++)
            {
                comboBox1.Items.Add($"Игрок{i + 1}");
                comboBox2.Items.Add($"Игрок{i + 1}");
                comboBox3.Items.Add($"Игрок{i + 1}");
                comboBox4.Items.Add($"Игрок{i + 1}");
                comboBox5.Items.Add($"Игрок{i + 1}");
                comboBox6.Items.Add($"Игрок{i + 1}");
                comboBox7.Items.Add($"Игрок{i + 1}");
                comboBox8.Items.Add($"Игрок{i + 1}");
            }
            comboBox1.Items.Add("Все игроки");
            comboBox2.Items.Add("Все игроки");
            comboBox3.Items.Add("Все игроки");
            comboBox4.Items.Add("Все игроки");
            comboBox5.Items.Add("Все игроки");
            comboBox6.Items.Add("Все игроки");
            comboBox7.Items.Add("Все игроки");
            comboBox8.Items.Add("Все игроки");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "Все игроки")
            {
                createData.allPlayers[comboBox1.SelectedIndex][8] = "Здоровье: " + specifications.Health[rnd.Next(0, specifications.Health.Count)];
            }
            else
            {
                for (int i = 0; i < playersCount; i++)
                {
                    createData.allPlayers[i][8] = "Здоровье: " + specifications.Health[rnd.Next(0, specifications.Health.Count)];
                }
            }
            savingToFile = new SavingToFile(createData.allPlayers, pathToFile);
            MessageBox.Show("Файл(ы) перезаписан(ы)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() != "Все игроки")
            {
                createData.allPlayers[comboBox2.SelectedIndex][10] = "Фобия: " + specifications.Phobia[rnd.Next(0, specifications.Phobia.Count)];
            }
            else
            {
                for (int i = 0; i < playersCount; i++)
                {
                    createData.allPlayers[i][10] = "Фобия: " + specifications.Phobia[rnd.Next(0, specifications.Phobia.Count)];
                }
            }
            savingToFile = new SavingToFile(createData.allPlayers, pathToFile);
            MessageBox.Show("Файл(ы) перезаписан(ы)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() != "Все игроки")
            {
                createData.allPlayers[comboBox3.SelectedIndex][11] = "Хобби: " + specifications.Hobby[rnd.Next(0, specifications.Hobby.Count)];
            }
            else
            {
                for (int i = 0; i < playersCount; i++)
                {
                    createData.allPlayers[i][11] = "Хобби: " + specifications.Hobby[rnd.Next(0, specifications.Hobby.Count)];
                }
            }
            savingToFile = new SavingToFile(createData.allPlayers, pathToFile);
            MessageBox.Show("Файл(ы) перезаписан(ы)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem.ToString() != "Все игроки")
            {
                createData.allPlayers[comboBox4.SelectedIndex][3] = $"Профессия: {specifications.Profession[rnd.Next(0, specifications.Profession.Count)]}." +
                    $" Стаж работы: {rnd.Next(0, 40)} лет, {rnd.Next(1, 13)} месяцев";
            }
            else
            {
                for (int i = 0; i < playersCount; i++)
                {
                    createData.allPlayers[comboBox4.SelectedIndex][3] = $"Профессия: {specifications.Profession[rnd.Next(0, specifications.Profession.Count)]}." +
                    $" Стаж работы: {rnd.Next(0, 40)} лет, {rnd.Next(1, 13)} месяцев";
                }
            }
            savingToFile = new SavingToFile(createData.allPlayers, pathToFile);
            MessageBox.Show("Файл(ы) перезаписан(ы)");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() != "Все игроки")
            {
                createData.allPlayers[comboBox3.SelectedIndex][13] = "Багаж: " + specifications.Luggage[rnd.Next(0, specifications.Luggage.Count)];
            }
            else
            {
                for (int i = 0; i < playersCount; i++)
                {
                    createData.allPlayers[i][13] = "Багаж: " + specifications.Luggage[rnd.Next(0, specifications.Luggage.Count)];
                }
            }
            savingToFile = new SavingToFile(createData.allPlayers, pathToFile);
            MessageBox.Show("Файл(ы) перезаписан(ы)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedItem.ToString() != "Все игроки")
            {
                createData.allPlayers[comboBox6.SelectedIndex][12] = "Доп. информация: " + specifications.Add_Info[rnd.Next(0, specifications.Add_Info.Count)];
            }
            else
            {
                for (int i = 0; i < playersCount; i++)
                {
                    createData.allPlayers[i][12] = "Доп. информация: " + specifications.Add_Info[rnd.Next(0, specifications.Add_Info.Count)];
                }
            }
            savingToFile = new SavingToFile(createData.allPlayers, pathToFile);
            MessageBox.Show("Файл(ы) перезаписан(ы)");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox7.SelectedItem.ToString() != "Все игроки")
            {
                createData.allPlayers[comboBox7.SelectedIndex][9] = "Черта характера: " + specifications.Personality[rnd.Next(0, specifications.Personality.Count)];
            }
            else
            {
                for (int i = 0; i < playersCount; i++)
                {
                    createData.allPlayers[i][9] = "Черта характера: " + specifications.Personality[rnd.Next(0, specifications.Personality.Count)];
                }
            }
            savingToFile = new SavingToFile(createData.allPlayers, pathToFile);
            MessageBox.Show("Файл(ы) перезаписан(ы)");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int height = rnd.Next(120, 200);
            int weight = rnd.Next(38, 120);
            double IIB = weight / Math.Pow(height * 0.01, 2);
            if (comboBox3.SelectedItem.ToString() != "Все игроки")
            {
                if (IIB < 18.5) createData.allPlayers[comboBox3.SelectedIndex][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Вес ниже нормы";
                else if (IIB >= 18.5 && IIB < 25) createData.allPlayers[comboBox3.SelectedIndex][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Норма";
                else if (IIB >= 25 && IIB < 30) createData.allPlayers[comboBox3.SelectedIndex][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Избыточный вес";
                else if (IIB >= 30 && IIB < 35) createData.allPlayers[comboBox3.SelectedIndex][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение I степени";
                else if (IIB >= 35 && IIB < 40) createData.allPlayers[comboBox3.SelectedIndex][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение II степени";
                else if (IIB >= 40) createData.allPlayers[comboBox3.SelectedIndex][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение III степени";
            }
            else
            {
                for (int i = 0; i < playersCount; i++)
                {
                    if (IIB < 18.5) createData.allPlayers[i][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Вес ниже нормы";
                    else if (IIB >= 18.5 && IIB < 25) createData.allPlayers[i][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Норма";
                    else if (IIB >= 25 && IIB < 30) createData.allPlayers[i][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Избыточный вес";
                    else if (IIB >= 30 && IIB < 35) createData.allPlayers[i][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение I степени";
                    else if (IIB >= 35 && IIB < 40) createData.allPlayers[i][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение II степени";
                    else if (IIB >= 40) createData.allPlayers[i][7] = $"Рост: {height} см. Вес: {weight}кг. ИМТ: Ожирение III степени";
                }
            }
            savingToFile = new SavingToFile(createData.allPlayers, pathToFile);
            MessageBox.Show("Файл(ы) перезаписан(ы)");
        }
    }
}
