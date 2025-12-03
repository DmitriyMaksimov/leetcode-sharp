using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03623))]
public class S03623Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03623();
        Assert.That(sut.CountTrapezoids([[1, 0], [2, 0], [3, 0], [2, 2], [3, 2]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03623();
        Assert.That(sut.CountTrapezoids([[0, 0], [1, 0], [0, 1], [2, 1]]), Is.EqualTo(1));
    }
}