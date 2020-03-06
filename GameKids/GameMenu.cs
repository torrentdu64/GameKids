using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKids
{
    public partial class GameMenu : Form
    {
        string choise;
        User user;
        

        public GameMenu()
        {
            InitializeComponent();
            
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

           
            choise = addition.Text;
            Game game = new Game(choise);
            game.Show();
            this.Hide();
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            choise = subtraction.Text;
            Game game = new Game(choise);
            game.Show();
            this.Hide();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            choise = multiplication.Text;
            Game game = new Game(choise);
            game.Show();
            this.Hide();
        }

        private void divition_Click(object sender, EventArgs e)
        {
            choise = divition.Text;
            Game game = new Game(choise);
            game.Show();
            this.Hide();
        }
    }
}
