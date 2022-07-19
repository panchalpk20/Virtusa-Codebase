using System;

namespace HandsOnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //array declaration
            int[] numbers = new int[5];
            //assign value to array
            numbers[0] = 98;
            numbers[1] = 34;
            numbers[2] = 77;
            numbers[3] = 90;
            numbers[4] = 78;
            //access the array value
            Console.WriteLine("array value at 1st position: {0}", numbers[1]);
            //print all the array values
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //print array values using foreach
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
