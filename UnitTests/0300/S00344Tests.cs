using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00344Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00344();
        var chars = new[] {'h', 'e', 'l', 'l', 'o'};
        sut.ReverseString(chars);
        chars.Should().Equal('o', 'l', 'l', 'e', 'h');
    }

    [Test]
    public void T2()
    {
        var sut = new S00344();
        var chars = new[] {'H', 'a', 'n', 'n', 'a', 'h'};
        sut.ReverseString(chars);
        chars.Should().Equal('h', 'a', 'n', 'n', 'a', 'H');
    }
}