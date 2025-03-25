using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03394Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03394();
        Assert.That(sut.CheckValidCuts(5, [[1, 0, 5, 2], [0, 2, 2, 4], [3, 2, 5, 3], [0, 4, 4, 5]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03394();
        Assert.That(sut.CheckValidCuts(4, [[0, 0, 1, 1], [2, 0, 3, 4], [0, 2, 2, 3], [3, 0, 4, 3]]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S03394();
        Assert.That(sut.CheckValidCuts(4, [[0, 2, 2, 4], [1, 0, 3, 2], [2, 2, 3, 4], [3, 0, 4, 2], [3, 2, 4, 4]]), Is.False);
    }
}
