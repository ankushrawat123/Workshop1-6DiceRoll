using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1_6DiceRoll
{
    internal class DiceRoll
    {
        public int num;
        public void Dice()
        {
            Random obj = new Random();
            num = obj.Next(1, 7);

            //using if else method

            //if (num == 1)
            //{
            //    Console.WriteLine("DiceValue obtained is: "+num);
            //}
            //else if (num == 2)
            //{
            //    Console.WriteLine("DiceValue obtained is: " + num);
            //}
            //else if (num == 3)
            //{
            //    Console.WriteLine("DiceValue obtained is: " + num);
            //}
            //else if (num == 4)
            //{
            //    Console.WriteLine("DiceValue obtained is: " + num);
            //}
            //else if (num == 5)
            //{
            //    Console.WriteLine("DiceValue obtained is: " + num);
            //}
            //else
            //{
            //    Console.WriteLine("DiceValue obtained is: " + num);
            //}



            //Using switch case method 

            switch(num)
            {
                case 1:
                    Console.WriteLine("DiceValue obtained is: " + num);
                break;

                case 2:
                    Console.WriteLine("DiceValue obtained is: " + num);
                    break;

                case 3:
                    Console.WriteLine("DiceValue obtained is: " + num);
                    break;

                case 4:
                    Console.WriteLine("DiceValue obtained is: " + num);
                    break;

                case 5:
                    Console.WriteLine("DiceValue obtained is: " + num);
                    break;

                case 6:
                    Console.WriteLine("DiceValue obtained is: " + num);
                    break;
            }


        }
    }
}
