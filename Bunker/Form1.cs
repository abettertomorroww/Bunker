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

namespace Bunker
{
    public partial class Form1 : Form
    {
        private Specifications specifications;
        private Init_Profession profession;
        private Init_Phobia phobia;
        private Init_Personality personality;
        private Init_Hobby hobby;
        private Init_Health health;
        private Init_Info info;
        private Init_Luggage luggage;
        private Init_Card card;
        
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;

            specifications = new Specifications();
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

        }
    }
}
