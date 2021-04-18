using System;

namespace nestedreptask_2_4
{
    class Program
    {
        static void Main_2_4(string[] args)
        {
            Console.WriteLine("How many lines would you like? ");
            string input = Console.ReadLine();
            int x = int.Parse(input);
            int i = 1;
            while(i < x){
                string repeat = new string('x', i);
                Console.WriteLine(repeat);
                i++;
            }
        }
    }
}
