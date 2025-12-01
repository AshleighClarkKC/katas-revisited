using Kaleidocode.Katas.Libraries.Helpers;
using Kaleidocode.Katas.Libraries.Parsers;

namespace Kaleidocode.Katas.Tests;

public class AdditionTests
{
    [Theory]
    [InlineData("")]
    public void Addition_WhenInputIsEmpty_ReturnsZero(string input)
    {
        var values = StringParser.CollectNumbers(input);
        Assert.Equal<int>(
            expected: 0,
            actual: values.First()
        );
    }

    [Theory]
    [InlineData("12", 12)]
    [InlineData("12,9478", 9490)]
    [InlineData("19387\nsd029302\nse2013\nad972,127%\ran63à=192|1928&112", 54096)]
    public void Addition_WhenValuesProvided_ReturnsAddedNumber(string input, int expected)
    {
        var addedValue = AdditionHelper.Add(input);
        Assert.Equal<int>(
            expected, 
            actual: addedValue
            );
    }
}
