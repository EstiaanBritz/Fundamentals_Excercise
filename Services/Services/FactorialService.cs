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
            if ((input >= 0) && input <= 19)
            {
                int Factorial = 1;

                for (int i = input; i >= 1; i--)
                {
                    output = Factorial *= i;
                }
                return output;
                
            }
            return 0;
            
        }

    }
}
