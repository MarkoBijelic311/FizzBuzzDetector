public class FizzBuzzDetector {
    private int _wordCount;
    private int _fizzBuzzCount;
    private List<string> _newSentence;
    private readonly char[] _symbols = { 
        '.', ',', '!', '?', ';', ':'
    };

    public FizzBuzzDetector() {
        _wordCount = 0;
        _fizzBuzzCount = 0;
        _newSentence = new List<string>();
    }

   public void getOverlappings(string text) {
        string[] words = text.Split(" ");

        if (text == null) {

            Console.WriteLine("The input text is null.");
            return;
        }

        if (text.Length < 7 || text.Length > 100) {

            Console.WriteLine("The input text must be between 7 and 100 characters.");
            return;
        }

        if (!text.Any(char.IsLetterOrDigit)) {

            Console.WriteLine("Input text does not contain any letters or digits.");
            return;
        }

        foreach (string word in words) {
            string originalString = word;
            string substring = "";

            while (originalString.Any(c => _symbols.Contains(c))) {

                substring = originalString[originalString.Length - 1] + substring;
                originalString = originalString.Substring(0, originalString.Length - 1);
            }

            if (word.All(c => !char.IsLetterOrDigit(c))) {

                _newSentence.Add(word);
                continue;
            }
            _wordCount++;

            if (_wordCount % 15 == 0) {

                _newSentence.Add("FizzBuzz" + substring);
                _fizzBuzzCount++;
            } else if (_wordCount % 3 == 0) {

                _newSentence.Add("Fizz" + substring);
                _fizzBuzzCount++;
            } else if (_wordCount % 5 == 0) {

                _newSentence.Add("Buzz" + substring);
                _fizzBuzzCount++;
            } else {

                _newSentence.Add(word + substring);
            }
        }

        foreach (string word in _newSentence) {

            Console.Write(word + " ");
        }

        Console.WriteLine("\n\ncount: " + _fizzBuzzCount);
    }
}