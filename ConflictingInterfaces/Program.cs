using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConflictingInterfaces
{
    class Program
    {
        //Imamo dva interfejsa koja imaju isti naziv metode
        //Klasa koja nasledjuje ta dva interfejsa prihvata taj metod
        //Ali u zavisnosti koji interfejs se instancira ta se metoda poziva
        static void Main(string[] args)
        {
            
            TestInterface1 obj1 = new TestClass();
            TestInterface2 obj2 = new TestClass();
            TestClass obj3 = new TestClass();

            obj1.Show();//Izvrsava metodu iz TestInterface1
            obj2.Show();//Izvrsava metodu iz TestInterface2
            obj3.Show();//Izvrsava se za klasu

           

        }
    }
}
