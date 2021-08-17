using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Addition = (param1, param2) => param1 + param2;
            int result = Addition(10, 30);
            Console.WriteLine("Addition is :" + result);

            //---------------------------------------------------

            Action<int, int> Multiplication = (param1, param2) => result = param1 * param2;
            Multiplication(6, 18);
            Console.WriteLine("Multiplication is :" + result);

            //----------------------------------------------------

            Predicate<string> Gender = (gender) =>
            {
                if (gender == "Male") return true;
                else return false;
            };
            bool resultG = Gender("female");
            if (resultG) Console.WriteLine("Gender is male");
            else Console.WriteLine("Gender is Femaale");


            Console.ReadLine();
        }
    }
}
