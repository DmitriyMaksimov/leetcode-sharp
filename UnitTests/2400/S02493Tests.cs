using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02493Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02493();
        Assert.That(sut.MagnificentSets(6, [[1, 2], [1, 4], [1, 5], [2, 6], [2, 3], [4, 6]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02493();
        Assert.That(sut.MagnificentSets(3, [[1, 2], [2, 3], [3, 1]]), Is.EqualTo(-1));
    }
}
