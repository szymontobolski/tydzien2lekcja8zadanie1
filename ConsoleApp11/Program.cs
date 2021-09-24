using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 0;
            while (true && a <=100)
            {
                bool czyPierwsza = true;
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        czyPierwsza = false;
                    }

                }    
                    
                if (czyPierwsza)
                   
                    
                {

                    Console.WriteLine(a);
                    
                    
                }
             
                
                
                a++;
            }


        }
    }
}
