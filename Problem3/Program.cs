using System;
class Program3
{
    static void Main()
    {
        Random ran = new Random();
        for (int i = 0; i < 6; i++)
        {
            int number = ran.Next(1, 44);
            Console.WriteLine(number);
        }
    }
}