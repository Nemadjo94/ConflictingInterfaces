using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConflictingInterfaces
{
    class TestClass : TestInterface1, TestInterface2
    {
        //Zajednicka metoda za oba TestInterfejsa
        public void Show()
        {
            Console.WriteLine("For both of TestInterface");
        }

        //Ne mora se implementovati svaki interfejs posebno osim ako ne zelimo drugariji output za svaku metodu
        //Jer u metoda iznad je zajednicka i za interfejse i za klasu
        //Samo zavisi kako se instancira klasa ili interfejs
        //To jest metoda se poziva iz svog tipa, ako je interfejs1 pozvace se za interfejs1 itd... 

        void TestInterface1.Show()
        {
            Console.WriteLine("For TestInterface1");
        }

        void TestInterface2.Show()
        {
            Console.WriteLine("For TestInterface2");
        }
    }
}
