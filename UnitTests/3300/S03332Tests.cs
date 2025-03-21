using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03332Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03332();
        Assert.That(sut.MaxScore(2, 1, [[2, 3]], [[0, 2], [1, 0]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03332();
        Assert.That(sut.MaxScore(3, 2, [[3, 4, 2], [2, 1, 2]], [[0, 2, 1], [2, 0, 4], [3, 2, 0]]), Is.EqualTo(8));
    }
}
