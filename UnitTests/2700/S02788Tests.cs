using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02788Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02788();
        sut.SplitWordsBySeparator(new[] {"one.two.three", "four.five", "six"}, '.').Should()
            .Equal("one", "two", "three", "four", "five", "six");
    }

    [Test]
    public void T2()
    {
        var sut = new S02788();
        sut.SplitWordsBySeparator(new[] {"$easy$", "$problem$"}, '$').Should().Equal("easy", "problem");
    }

    [Test]
    public void T3()
    {
        var sut = new S02788();
        sut.SplitWordsBySeparator(new[] {"|||"}, '|').Should().BeEmpty();
    }
}