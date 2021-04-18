using System;

namespace nestedreptask_2_3
{
    class Program
    {
        static void Main_2_3(string[] args)
        {
            for(int i = 1; i <= 5; i++){
                string repeat = new string('x', i);
                Console.WriteLine(repeat);
            }
        }
    }
}
