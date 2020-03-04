using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKids
{
    class Numeraze
    {
        private int num1;
        private int num2;
        private int num3;
        private int num4;
        private int answer;

        public Numeraze(String mum1, String num2, String num3, String answer)
        {
            this.num1 = int.Parse(num1.ToString());
            this.num2 = int.Parse(num2.ToString());
            this.num3 = int.Parse(num3.ToString());
            this.answer = int.Parse(answer.ToString());

        }




    }
}
