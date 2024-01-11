using Services.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Services.Services
{
    public class SentenceReverseService : ISentenceReverseService
    {
        public string SentenceReverser(string input)
        {
            string output = string.Join(" ", input.Split(' ').Reverse());
            return output;
        }
        

    }
    
}


    

