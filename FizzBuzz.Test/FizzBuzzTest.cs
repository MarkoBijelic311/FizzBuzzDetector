namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Fact]
    public void Check_FizzBuzz_ReturnsCorrectResult() {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();
        string inputText = @"This is a test sentence with some words to check random functionality.";
        string expectedOutput = @"This is Fizz test Buzz Fizz some words Fizz Buzz random Fizz.

count: 6";

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings(inputText);

        Assert.Equal(expectedOutput, result.Sentence);
    }

    [Fact]
    public void Check_FizzBuzz_EmptyInput_ReturnsEmptyResult() {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();
        string inputText = "";

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings(inputText);

        Assert.Equal("", result.Sentence);
    }

    [Fact]
    public void Check_FizzBuzz_SpecialCharactersOnly_ReturnsEmptyResult() {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();
        string inputText = "!!! ??? ... ,,, ;;; :::";

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings(inputText);

        Assert.Equal("", result.Sentence);
    }

    [Fact]
    public void Check_FizzBuzz_MixedInput_ReturnsCorrectResult() {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();
        string inputText = @"Hello, world! This?!? is a test.... sentence with some words to check!!!! random functionality.";
        string expectedOutput = @"Hello, world! Fizz?!? is Buzz Fizz.... sentence with Fizz Buzz to Fizz!!!! random functionality.

count: 6";

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings(inputText);

        Assert.Equal(expectedOutput, result.Sentence);
    }

    [Fact]
    public void Check_FizzBuzz_NullInput_ReturnsEmptyResult()
    {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings(null);

        Assert.Equal("", result.Sentence);
    }

    [Fact]
    public void Check_FizzBuzz_15thWord_ReturnsFizzBuzz()
    {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();
        string inputText = "one two three four five six seven eight nine ten eleven twelve thirteen fourteen fifteen";

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings(inputText);

        Assert.Contains("FizzBuzz", result.Sentence);
    }

    [Fact]
    public void Check_FizzBuzz_MultipleLines_ReturnsCorrectResult()
    {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();
        string inputText = @"one two three
    four five six";
        string expectedOutput = @"one two Fizz
four Buzz Fizz

count: 3";

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings(inputText);

        Assert.Equal(expectedOutput, result.Sentence);
    }

    [Fact]
    public void Check_FizzBuzz_InputTooShort_ReturnsEmptyResult()
    {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings("abc");

        Assert.Equal("", result.Sentence);
    }

    [Fact]
    public void Check_FizzBuzz_OneObject_TwoCalls()
    {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();
        string inputText = @"This is a... test sentence with some";
        string otherText = @"words to check random functionality.";
        string expectedOutput = @"This is Fizz... test Buzz Fizz some

count: 3";
        string otherExpectedOutput = @"words to Fizz random Buzz.

count: 2";

        FizzBuzzObj result = fizzBuzzDetector.getOverlappings(inputText);
        FizzBuzzObj otherResult = fizzBuzzDetector.getOverlappings(otherText);

        Assert.Equal(expectedOutput, result.Sentence);
        Assert.Equal(otherExpectedOutput, otherResult.Sentence);
    }
}
