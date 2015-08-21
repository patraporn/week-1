using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
           

            // input
            program b = new program();
            b.input();


            Console.ReadKey();
        }
    }
    class program
    {

        public void input()
        {
            string v;
            Console.WriteLine("Input number: ");
            v = Console.ReadLine();
            int[] input;
            input = v.Split(' ').Select(y => Convert.ToInt32(y)).ToArray();
            process(input);
            output(input);
        }

        public void process(int[] input)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }


        }

        public void output(int[] input )
        {
            Console.WriteLine("Output number: ");
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);

                Console.Write(" ");
            }
        
        }

    }
}
