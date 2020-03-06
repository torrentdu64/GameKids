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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(inputUserName.Text == "")
            {
                MessageBox.Show("Field is require");
            }else if(inputPassword.Text == "")
            {
                MessageBox.Show("Field is require");
            }
            else
            {
                User user = new User(inputUserName.Text, inputPassword.Text);
                GameKids.User.listUsers.Add(user);
                GameMenu gameMenu = new GameMenu();
                gameMenu.Show();
                this.Hide();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
