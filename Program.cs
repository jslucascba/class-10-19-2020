 using System;

namespace class10_19_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            TA Emma = new TA("Emma", 4);
           // Emma.SetName("Emma");
            Console.WriteLine(Emma.GetName());

            TA ta2 = new TA();
            ta2.SetName("Garrett");
            Console.WriteLine(ta2.GetName());
            TA.IncCount();

            Console.WriteLine(Emma.ToString());
            
        }
    }
}
