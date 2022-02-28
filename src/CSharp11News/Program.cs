
/*****************************
- C#11 - String interpolation newLine
******************************/
using static System.Console;

var text = $"Article: {
    new System
.Text.
StringBuilder(
    string.Empty
    )
.Append(
    @"C# 11,
    what is come ?"
    )}";

WriteLine(text);


/*****************************
- C#11 - List Patterns
******************************/


static int CheckLetters(char[] values)
    => values switch
    {
        ['A', 'B', .., 'Z'] => 1,
        ['A', 'B'] => 2,
        ['A', _] => 3,
        ['A', ..] => 4,
        [..] => 50
    };

WriteLine(CheckLetters(new[] { 'A','B', 'Z' }));          // prints 1
WriteLine(CheckLetters(new[] { 'A', 'B', 'C', 'D', 'D', 'Z' })); // prints 1
WriteLine(CheckLetters(new[] { 'A', 'B' }));              // prints 2
WriteLine(CheckLetters(new[] { 'A', 'C' }));              // prints 3
WriteLine(CheckLetters(new[] { 'A', 'C', 'E' }));           // prints 4
WriteLine(CheckLetters(new[] { 'B', 'D', 'L', 'X' }));        // prints 50


/*****************************
- C#11 - Parameter null-checking
******************************/

static void PrintNameCSharp10(string name) {

    ArgumentNullException.ThrowIfNull(name);
    WriteLine(name);
}

static void PrintNameCsharp11(string name!!) => WriteLine(name);

PrintNameCSharp10("Júnior Porfirio");
PrintNameCsharp11(null);