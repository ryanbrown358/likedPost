using System;
using System.Collections.Generic;
namespace likedPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            while(true)
            {
                System.Console.WriteLine("Type a name");
                
                var userInput = Console.ReadLine();
                if(String.IsNullOrWhiteSpace(userInput))
                {
                    break;
                }
                names.Add(userInput);

                if(names.Count > 2) {
                    System.Console.WriteLine("{0}, {1}, and {2} liked your post", names[0], names[1], names[2]);
                }
                else if(names.Count == 2){
                    System.Console.WriteLine("{0}, and {1} like your post", names[0], names[1]);
                }
                else if(names.Count == 1) {
                    System.Console.WriteLine("{0} like your post", names[0]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
