using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02319Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02319();
        Assert.That(sut.CheckXMatrix([[2, 0, 0, 1], [0, 3, 1, 0], [0, 5, 2, 0], [4, 0, 0, 2]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02319();
        Assert.That(sut.CheckXMatrix([[5, 7, 0], [0, 3, 1], [0, 5, 0]]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02319();
        Assert.That(sut.CheckXMatrix([[0, 2, 1, 0], [1, 0, 0, 3], [4, 0, 0, 5], [0, 3, 3, 0]]), Is.False);
    }
}
