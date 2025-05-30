using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02577Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02577();
        Assert.That(sut.MinimumTime([[0, 1, 3, 2], [5, 1, 2, 5], [4, 3, 8, 6]]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02577();
        Assert.That(sut.MinimumTime([[0, 2, 4], [3, 2, 1], [1, 0, 4]]), Is.EqualTo(-1));
    }
}
