public class FizzBuzzDetector {
    private readonly char[] _symbols = { 
        '.', ',', '!', '?', ';', ':'
    };

   public FizzBuzzObj getOverlappings(string text) {
        int _wordCount = 0;
        int _fizzBuzzCount = 0;
        List<List<string>> _wordsByLines = new List<List<string>>();

        if (text == null) {

            Console.WriteLine("The input text is null.");
            return new FizzBuzzObj();
        }

        string[] lines = text.Split("\n");

        if (text.Length < 7 || text.Length > 100) {

            Console.WriteLine("The input text must be between 7 and 100 characters.");
            return new FizzBuzzObj();
        }

        if (!text.Any(char.IsLetterOrDigit)) {

            Console.WriteLine("Input text does not contain any letters or digits.");
            return new FizzBuzzObj();
        }

        foreach (string line in lines) {

            List<string> newLine = new List<string>();
            string[] words = line.Split(
                " "
                , StringSplitOptions.RemoveEmptyEntries
            );
        
            foreach (string word in words) {

                string originalString = word;
                string substring = "";

                while (originalString.Any(c => _symbols.Contains(c))) {

                    substring = originalString[originalString.Length - 1] + substring;
                    originalString = originalString.Substring(0, originalString.Length - 1);
                }

                if (word.All(c => !char.IsLetterOrDigit(c))) {

                    newLine.Add(word);
                    continue;
                }
                _wordCount++;

                if (_wordCount % 15 == 0) {

                    newLine.Add("FizzBuzz" + substring);
                    _fizzBuzzCount++;
                } else if (_wordCount % 3 == 0) {

                    newLine.Add("Fizz" + substring);
                    _fizzBuzzCount++;
                } else if (_wordCount % 5 == 0) {

                    newLine.Add("Buzz" + substring);
                    _fizzBuzzCount++;
                } else {

                    newLine.Add(originalString + substring);
                }
            }

            _wordsByLines.Add(newLine);
        }

        List<string> lineSentence = new List<string>();

        foreach (List<string> line in _wordsByLines) {

            lineSentence.Add(string.Join(" ", line));
        }

        return new FizzBuzzObj {
            Sentence = string.Join("\n", lineSentence) + $"\n\ncount: {_fizzBuzzCount}"
        };
    }
}