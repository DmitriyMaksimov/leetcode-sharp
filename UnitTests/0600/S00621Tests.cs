using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00621Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00621();
        Assert.That(sut.LeastInterval(['A', 'A', 'A', 'B', 'B', 'B'], 2), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S00621();
        Assert.That(sut.LeastInterval(['A', 'C', 'A', 'B', 'D', 'B'], 1), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S00621();
        Assert.That(sut.LeastInterval(['A', 'A', 'A', 'B', 'B', 'B'], 3), Is.EqualTo(10));
    }
}