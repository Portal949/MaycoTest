using System;

namespace MaycoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 150; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("MaycoDuppslo");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Dupplo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Mayco");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
