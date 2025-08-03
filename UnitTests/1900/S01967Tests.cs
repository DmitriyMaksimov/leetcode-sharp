using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01967Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01967();
        Assert.That(sut.NumOfStrings(["a", "abc", "bc", "d"], "abc"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01967();
        Assert.That(sut.NumOfStrings(["a", "b", "c"], "aaaaabbbbb"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01967();
        Assert.That(sut.NumOfStrings(["a", "a", "a"], "ab"), Is.EqualTo(3));
    }
}