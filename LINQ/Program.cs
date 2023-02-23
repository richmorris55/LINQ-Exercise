using System.Collections.Generic;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a list of video game names
            var gameNames = new List<string>() { "Super Mario", "Zelda", "Street Fighter", "Halo", "God of War" };

            //Order the list of games by length of the game name.
            //Used the lambda expression.
            //Used Method Syntax.

            gameNames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
                   
        }


        


    }

    
    
    

    
}
