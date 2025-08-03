using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00830Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00830();
        Assert.That(sut.LargeGroupPositions("abbxxxxzzy"), Is.EquivalentTo([new[] {3, 6}]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00830();
        Assert.That(sut.LargeGroupPositions("abc"), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S00830();
        Assert.That(sut.LargeGroupPositions("abcdddeeeeaabbbcd"), Is.EquivalentTo([
            [3, 5], [6, 9], new[] {12, 14}
        ]));
    }
}