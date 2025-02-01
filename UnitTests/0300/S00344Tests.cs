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
        Assert.That(chars, Is.EqualTo((int[]) ['o', 'l', 'l', 'e', 'h']));
    }

    [Test]
    public void T2()
    {
        var sut = new S00344();
        var chars = new[] {'H', 'a', 'n', 'n', 'a', 'h'};
        sut.ReverseString(chars);
        Assert.That(chars, Is.EqualTo((int[]) ['h', 'a', 'n', 'n', 'a', 'H']));
    }
}