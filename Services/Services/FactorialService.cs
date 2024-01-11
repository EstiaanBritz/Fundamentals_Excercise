using Services.Interfaces;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Services.Services
{
    public class FactorialService : IFactorialService
    {
        public int output;

        public int Generatefactorial(int input)
        {
            int Factorial = 1;
            for (int i = input; i >= 1; i--)
            {
                output = Factorial *= i;
            }

            return output;
        }
    }
}
