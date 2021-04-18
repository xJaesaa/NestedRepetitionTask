using System;

namespace nestedreptask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            int times = 10;
            int i = 1;

            while(i < times){
                Console.Write(username);
                i++;
            }
        }
    }
}
