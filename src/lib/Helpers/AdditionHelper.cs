using Kaleidocode.Katas.Libraries.Parsers;

namespace Kaleidocode.Katas.Libraries.Helpers;

public class AdditionHelper
{
    public static int Add(string numbers)
    {
        var values = StringParser.CollectNumbers(numbers);

        return values.Sum();
    }
}
