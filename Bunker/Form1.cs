using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunker.Models.Init_Models;
using Bunker.Models;
using Bunker.Data;
using System.IO;

namespace Bunker
{
    public partial class Form1 : Form
    {
        private Specifications specifications;
        private Init_Disaster disaster;
        private Init_Profession profession;
        private Init_Phobia phobia;
        private Init_Personality personality;
        private Init_Hobby hobby;
        private Init_Health health;
        private Init_Info info;
        private Init_Luggage luggage;
        private Init_Card card;
        private CreateDataForSaveFile createData;
        private string pathToFile;
        private SettingsForm settingsForm;
        private bool settingsReady = false;

        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;

            specifications = new Specifications();
            disaster = new Init_Disaster(specifications);
            profession = new Init_Profession(specifications);
            phobia = new Init_Phobia(specifications);
            personality = new Init_Personality(specifications);
            hobby = new Init_Hobby(specifications);
            health = new Init_Health(specifications);
            info = new Init_Info(specifications);
            luggage = new Init_Luggage(specifications);
            card = new Init_Card(specifications);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int playersCount = Convert.ToInt32(comboBox1.Text);

            if (pathToFile == null)
            {
                MessageBox.Show("Не указан путь сохранения файлов");
            }
            else
            {
                createData = new CreateDataForSaveFile(playersCount, specifications, pathToFile);
                MessageBox.Show("Файлы сохранены");
                settingsReady = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var path_dialog = new FolderBrowserDialog())
                if (path_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pathToFile = path_dialog.SelectedPath;
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (settingsReady == true) 
            {
                int playersCount = Convert.ToInt32(comboBox1.Text);
                settingsForm = new SettingsForm(playersCount, specifications, createData, pathToFile);
                settingsForm.Show();
            }
            else MessageBox.Show("Сначала сгенерируйте роли");
        }
    }
}
