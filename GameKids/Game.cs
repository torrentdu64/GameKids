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
    public partial class Game : Form
    {
        int[] randomQuestion;
        int[] randomAnswwer;
        String operation;
        Boolean Success;
        int answer;


        public Game(string operation)
        {
            InitializeComponent();

            this.operation = operation;

            operatorId.Text = getOperotor();



            initializeGame();
            //number1.Refresh();
        }

        private string getOperotor()
        {
            return this.operation;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }


        //https://stackoverflow.com/questions/2351308/random-number-generator-in-c-sharp-unique-values
        public static int[] Randomize()
        {
            Random rnd = new Random();
            var randomNumbers = Enumerable.Range(1, 9).OrderBy(i => rnd.Next()).ToArray();
            return randomNumbers; 
        }

        private void initializeGame()
        {
            randomQuestion = Randomize().ToArray();
            randomAnswwer = Randomize().ToArray();

         
                if (randomQuestion[1] > randomQuestion[2])
                {
                    number1.Text = randomQuestion[1].ToString();
                    number2.Text = randomQuestion[2].ToString();

                }
                else
                {
                    number1.Text = randomQuestion[2].ToString();
                    number2.Text = randomQuestion[1].ToString();
                }

          
           


            operation = operatorId.Text;

            int number1Parsing = Int32.Parse(number1.Text);
            int number2Parsing = Int32.Parse(number2.Text);

            performOperation(number1Parsing, number2Parsing, operation);

            GameKids.Gamification calculate = new Gamification();

            calculate.Addition(number1Parsing, number2Parsing);



            //foreach (int val in randomAnswwer)
            //{
            //    int counter = 0;
            //    //test.Text += val.ToString();
            //    if (counter == 0 && randomAnswwer[counter + 1] != val)
            //    {
            //        number1.Text = val.ToString();
            //    }
            //    else
            //    {
            //        number1.Text = randomArray[counter + 2].ToString();
            //    }
            //    if (counter == 1 && randomArray[counter + 1] != val)
            //    {
            //        number2.Text = val.ToString();
            //    }
            //    else
            //    {
            //        number1.Text = randomArray[counter + 2].ToString();
            //    }


            //    counter++;
            //}

            Int32[] suggestion = new int[3];
            suggestion = randomAnswwer.ToArray();
            var rng = new Random();
            var shuffe = Enumerable.Range(0, 4).OrderBy(i => rng.Next()).ToArray();


            suggestion[3] = answer;


            List<int> randomNumber = new List<int>();

            
            //randomNumber.Add(new Random().Next(1, 10));
           // randomNumber.Add(new Random().Next(1, 10));
           // randomNumber.Add(new Random().Next(1, 10));
            //randomNumber.Add(answer);

            randomNumber.Sort();



             response1.Text = suggestion[shuffe[0]].ToString();
            response2.Text = suggestion[shuffe[1]].ToString();
            response3.Text = suggestion[shuffe[2]].ToString();
             response4.Text = suggestion[shuffe[3]].ToString();

           // response1.Text = randomNumber[0].ToString();
           // response2.Text = randomNumber[1].ToString();
           // response3.Text = randomNumber[2].ToString();
          //  response4.Text = randomNumber[3].ToString();
        }



        private void performOperation(int number1, int number2, String operation)
        {
            Gamification game = new Gamification();
            switch (operation)
            {

                case "/":
                    //answer = number1 / number2;
                    //answer = int.Parse(tes.ToString());
                    game.Divition(number1, number2);
                    game.getAnswer();
                    break;
                case "*":
                    game.Multiplication(number1, number2);
                    answer = game.getAnswer();
                    break;
                case "-":
                    game.Substraction(number1, number2);
                    answer = game.getAnswer();
                    break;
                case "+":
                    game.Addition(number1 , number2);
                    answer = game.getAnswer();
                    break;
            }

        }

        private void response1_Click(object sender, EventArgs e)
        {

            var valueBtn = int.Parse(response1.Text);

            if (answer.Equals(valueBtn))
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }
            initializeGame();
        }

        private void response2_Click(object sender, EventArgs e)
        {
            var valueBtn = int.Parse(response2.Text);
            if (answer.Equals(valueBtn))
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }
            initializeGame();
        }

        private void response3_Click(object sender, EventArgs e)
        {
            var valueBtn = int.Parse(response3.Text);
            if (answer.Equals(valueBtn))
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }
            initializeGame();
        }

        private void response4_Click(object sender, EventArgs e)
        {
           
            var valueBtn = int.Parse(response4.Text);
            if (answer.Equals(valueBtn))
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }
            initializeGame();
        }
    }
}