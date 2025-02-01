using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01967Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01967();
        Assert.That(sut.NumOfStrings(new[] {"a", "abc", "bc", "d"}, "abc"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01967();
        Assert.That(sut.NumOfStrings(new[] {"a", "b", "c"}, "aaaaabbbbb"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01967();
        Assert.That(sut.NumOfStrings(new[] {"a", "a", "a"}, "ab"), Is.EqualTo(3));
    }
}