using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace young_game
{
    internal class Game_Engine
    {
        private int I_RandNum1;
        private int I_RandNum2;
        private int I_Operator; // Convert.Tostring
        private string S_Operator; // +, -, *, /
        private int answer; // pc 정답
        string S_RandOperatorNum; 

        Random random = new Random();

        public string S_Rand_Num()
        {
            I_RandNum1 = random.Next(1,100); // 1번
            I_RandNum2 = random.Next(1,100); // 2번
            I_Operator = random.Next(1,5);   //랜덤 연산자
            if (I_RandNum1 <= I_RandNum2)
            {
                int temp;
                temp = I_RandNum1;
                I_RandNum1 = I_RandNum2;
                I_RandNum2 = temp;
            } // 1번 2번 temp
            

            switch(I_Operator)
            {
                case 1:
                    answer = I_RandNum1 + I_RandNum2;
                    S_Operator = "+";
                    break; 
                case 2:
                    answer = I_RandNum1 - I_RandNum2;
                    S_Operator = "-";
                    break; 
                case 3:
                    answer = I_RandNum1 * I_RandNum2;
                    S_Operator = "*";
                    break;
                case 4:
                    answer = I_RandNum1 / I_RandNum2;
                    S_Operator = "/";
                    break;
                default:
                    break;

            } // 계산 및 랜덤 연산자 선택

            return S_RandOperatorNum = string.Format("{0} {1} {2} = %{3}",
                              I_RandNum1, S_Operator, I_RandNum2, answer);// % <- Split
        }
    }
}
