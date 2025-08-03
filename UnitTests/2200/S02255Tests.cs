using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02255Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02255();
        Assert.That(sut.CountPrefixes(["a", "b", "c", "ab", "bc", "abc"], "abc"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02255();
        Assert.That(sut.CountPrefixes(["a", "a"], "aa"), Is.EqualTo(2));
    }
}