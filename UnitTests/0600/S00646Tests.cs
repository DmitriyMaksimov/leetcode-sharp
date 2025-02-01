using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00646Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00646();
        Assert.That(sut.FindLongestChain(new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00646();
        Assert.That(sut.FindLongestChain(new[] {new[] {1, 2}, new[] {7, 8}, new[] {4, 5}}), Is.EqualTo(3));
    }
}