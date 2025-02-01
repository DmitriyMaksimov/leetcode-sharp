using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02039Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02039();
        Assert.That(sut.NetworkBecomesIdle([[0, 1], [1, 2]], [0, 2, 1]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02039();
        Assert.That(sut.NetworkBecomesIdle([[0, 1], [0, 2], [1, 2]], [0, 10, 10]), Is.EqualTo(3));
    }
}
