using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKids
{
    class Gamification
    {
        private int number1;
        private int number2;
        private int answer;
        private int result;


        public Gamification()
        {

        }

        public int Addition(int number1, int number2)
        {
            answer = number1 + number2;
            return answer;
        }

        public int Substraction(int number1, int number2)
        {
            return answer = number1 - number2;
        }

        public int Multiplication(int number1, int number2)
        {
            return answer = number1 * number2;
        }

        public double Divition(int number1, int number2)
        {
            return answer = number1 % number2;
        }

        public int getAnswer()
        {
            return answer;
        }
    }
}
