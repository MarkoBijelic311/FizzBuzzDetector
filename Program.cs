namespace FizzBuzzz;

class Program
{
    static void Main(string[] args)
    {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();
        fizzBuzzDetector.getOverlappings("This is a... test sentence with some words to check random functionality.");
    }
}