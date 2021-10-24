using System;

namespace Duplicated
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("This program should find a duplicated number within an array");

            int[] array = { 1,5,6,83,7,9,8,6,45,87,22,33,15,6,95,78};
            // the number that is duplicated is 6;
            int aux = 0;
            bool keepSearch = true;


            for(int i = 0; i < array.Length; i++)
            {
                aux = array[i];
                int count = 0;

                foreach (int find in array)
                {
                    if(find == aux)
                    {
                        count++;
                    }
                    if(count > 1)                       //If find some repeted number
                    {
                        keepSearch = false;
                        break;                          // exit from foreach
                    }
                }
                if(keepSearch == false)
                {
                    break;                              // exit from the for too
                }
            }

            Console.Write("Duplicated number in the array: ");
            Console.Write(aux + "\n");
        }
    }
}
