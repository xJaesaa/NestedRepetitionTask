using System;

namespace nestedreptask_2_2
{
    class Program
    {
        static void Main_2_2(string[] args)
        {
            Console.WriteLine("How many X's would you like? ");
            string input = Console.ReadLine();
            int i = int.Parse(input);
            while(i > 0){
                string repeat = new string('x', i);
                Console.WriteLine(repeat);
                i--;
            }
        }
    }
}
