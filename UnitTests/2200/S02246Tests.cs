using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02246Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02246();
        Assert.That(sut.LongestPath([-1, 0, 0, 1, 1, 2], "abacbe"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02246();
        Assert.That(sut.LongestPath([-1, 0, 0, 0], "aabc"), Is.EqualTo(3));
    }
}