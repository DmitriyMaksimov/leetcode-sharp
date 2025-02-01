using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00789Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00789();
        Assert.That(sut.EscapeGhosts([[1, 0], [0, 3]], [0, 1]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00789();
        Assert.That(sut.EscapeGhosts([[1, 0]], [2, 0]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00789();
        Assert.That(sut.EscapeGhosts([[2, 0]], [1, 0]), Is.False);
    }
}
