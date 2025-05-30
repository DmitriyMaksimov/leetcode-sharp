using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03310Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03310();
        Assert.That(sut.RemainingMethods(4, 1, [[1, 2], [0, 1], [3, 2]]), Is.EqualTo((int[]) [0, 1, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03310();
        Assert.That(sut.RemainingMethods(5, 0, [[1, 2], [0, 2], [0, 1], [3, 4]]), Is.EqualTo((int[]) [3, 4]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03310();
        Assert.That(sut.RemainingMethods(3, 2, [[1, 2], [0, 1], [2, 0]]), Is.Empty);
    }
}
