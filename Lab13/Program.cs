using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                Building home = new Building("Москва, Красная площадь д.1", 100, 50, 30);
                home.Print();

                Console.WriteLine();

                MultiBuilding home2 = new MultiBuilding("Москва, Красная площадь д.1", 100, 50, 30, 10);
                home2.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
