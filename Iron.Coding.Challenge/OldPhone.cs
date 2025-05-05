namespace Iron.Coding.Challenge;
public static class OldPhone
{
    private readonly static Dictionary<string, char> PadsCombinations = new()
    {
        { "1", '&' },
        { "11", '\'' },
        { "111", '(' },
        { "2", 'A' },
        { "22", 'B' },
        { "222", 'C' },
        { "3", 'D' },
        { "33", 'E' },
        { "333", 'F' },
        { "4", 'G' },
        { "44", 'H' },
        { "444", 'I' },
        { "5", 'J' },
        { "55", 'K' },
        { "555", 'L' },
        { "6", 'M' },
        { "66", 'N' },
        { "666", 'O' },
        { "7", 'P' },
        { "77", 'Q' },
        { "777", 'R' },
        { "7777", 'S' },
        { "8", 'T' },
        { "88", 'U' },
        { "888", 'V' },
        { "9", 'W' },
        { "99", 'X' },
        { "999", 'Y' },
        { "9999", 'Z' },
        { "0", ' ' }
    };

    private static readonly string DeleteMessageString = "*";

    public static string OldPhonePad(string input)
    {

        if (ContainsMultipleEnds(input))
            return "Input contains more than one send (#)";

        string result = string.Empty;
        string currentString = string.Empty;
        char previousChar = ' ';

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (IsSpaceChar(currentChar))
            {
                previousChar = ' ';
                continue;
            }

            if (currentChar != previousChar && !IsFirstValue(i))
            {
                if (string.IsNullOrEmpty(currentString))
                    continue;

                if (!PadsCombinations.TryGetValue(currentString, out char value) && !ShouldDeleteCurrentString(currentString))
                    return $"Input string contains unexpected values: {currentString}";

                if (ShouldDeleteCurrentString(currentString))
                {
                    var removedStringResult = result.Remove(result.Length - 1, 1);
                    result = removedStringResult;
                }
                else
                {
                    result += value;
                }
                currentString = string.Empty;

            }

            previousChar = currentChar;
            currentString += currentChar;
        }

        return result;
    }

    private static bool IsFirstValue(int value)
    {
        return value == 0;
    }

    private static bool ShouldDeleteCurrentString(string input)
    {
        return DeleteMessageString == input;
    }

    private static bool IsSpaceChar(char input)
    {
        return input == ' ';
    }

    private static bool ContainsMultipleEnds(string input)
    {
        string[] multipleEnds = input.Split('#');
        return multipleEnds.Length > 2;
    }
}