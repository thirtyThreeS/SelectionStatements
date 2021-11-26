// See https://aka.ms/new-console-template for more information

namespace SelectionStatements

    {

    class program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 32;

            Console.WriteLine("Guess my favorite number! Hint: Magic Johnson");
            int guessNumber = int.Parse(Console.ReadLine());



                if (guessNumber == 32)
                {
                Console.WriteLine("Congratulations! That is correct!");
                }
                else if (guessNumber > 32)
                {
                    Console.WriteLine("Too high of a guess! Try again!");
                  
                }
                else
                {
                    Console.WriteLine("Too low of a guess! Try again!");
                    
                }
            
        }
    }

}