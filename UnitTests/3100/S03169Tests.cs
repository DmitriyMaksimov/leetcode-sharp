using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03169Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03169();
        Assert.That(sut.CountDays(10, [[5, 7], [1, 3], [9, 10]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03169();
        Assert.That(sut.CountDays(5, [[2, 4], [1, 3]]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03169();
        Assert.That(sut.CountDays(6, [[1, 6]]), Is.EqualTo(0));
    }
}
