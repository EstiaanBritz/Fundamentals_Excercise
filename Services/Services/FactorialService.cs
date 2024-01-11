using Services.Interfaces;

namespace Services.Services
{
    public class FactorialService : IFactorialService
    {
        public int Generatefactorial(int input)
        {
            for (int i = input; i >= 1; i--)
            {
                input *= i;
            }
            return input;
        }
    }
}
