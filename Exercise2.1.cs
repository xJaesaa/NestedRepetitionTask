using System;

namespace nestedreptask_2_1
{
    class Program
    {
        static void Main_2_1(string[] args)
        {
            for(int i = 5; i > 0; i--){
                string repeat = new string('x', i);
                Console.WriteLine(repeat);
            }
        }
    }
}
