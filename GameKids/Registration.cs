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
    public partial class Registration : Form
    {

        User user;

        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputFirstName.Equals("")){
                MessageBox.Show("Field is required");
            }
            else
            {
                user = new User(inputFirstName.Text, inputLastName.Text, inputUserName.Text, inputPassword.Text, inputSchoolYear.Text, inputTeacherName.Text);
                GameKids.User.listUsers.Add(user);
            }
            

            GameMenu gameMenu = new GameMenu();
            gameMenu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
