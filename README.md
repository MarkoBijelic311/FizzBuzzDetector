# FizzBuzzDetector
# FizzBuzz Detector

## Overview

FizzBuzz Detector is a .NET application that processes an input string and replaces:

* Every **3rd** alphanumeric word with **Fizz**
* Every **5th** alphanumeric word with **Buzz**
* Every **15th** alphanumeric word with **FizzBuzz**

The application preserves punctuation attached to words and returns both the transformed text and the total number of Fizz, Buzz, and FizzBuzz replacements.

---

## Requirements

* .NET 10 SDK
* xUnit (for unit tests)

---

## Project Structure

```text
FizzBuzz/
├── FizzBuzz.csproj
├── Program.cs
├── FizzBuzzDetector.cs
├── FizzBuzzObj.cs
└── FizzBuzz.Test/
    ├── FizzBuzz.Test.csproj
    └── FizzBuzzTest.cs
```

---

## Constraints

* Input string cannot be `null`.
* Input length must be between **7** and **100** characters.
* Only **alphanumeric words** are counted.
* Whitespaces and supported punctuation are ignored for counting purposes.

Supported punctuation:

```text
. , ! ? ; :
```

---

## Example

### Input

```text
Mary had a little lamb
Little lamb, little lamb
Mary had a little lamb
It's fleece was white as snow
```

### Output

```text
Mary had Fizz little Buzz
Fizz lamb, little Fizz
Buzz had Fizz little lamb
FizzBuzz fleece was Fizz as Buzz

count: 9
```

---

## Running the Application

Clone the repository:

```bash
git clone <repository-url>
cd FizzBuzz
```

Run the application:

```bash
dotnet run
```

---

## Running Unit Tests

Execute all tests:

```bash
dotnet test
```

---

## Technologies

* C#
* .NET 10
* xUnit

---

## Notes

The project was developed as a coding assignment with a focus on:

* Readable and maintainable code
* Input validation
* Unit testing
* Separation of application logic from tests
