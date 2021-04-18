using System;

namespace nestedreptask_1_2
{
    class Program
    {
        static void Main_1_2(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("How many times?");
            string repeat = Console.ReadLine();

            int times = int.Parse(repeat);
            int i = 0;

            while(i < times){
                Console.Write(username);
                i++;
            }
        }
    }
}
