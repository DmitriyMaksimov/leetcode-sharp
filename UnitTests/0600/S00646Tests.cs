using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00646Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00646();
        Assert.That(sut.FindLongestChain([[1, 2], [2, 3], [3, 4]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00646();
        Assert.That(sut.FindLongestChain([[1, 2], [7, 8], [4, 5]]), Is.EqualTo(3));
    }
}