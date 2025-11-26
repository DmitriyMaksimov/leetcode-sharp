using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02435))]
public class S02435Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02435();
        Assert.That(sut.NumberOfPaths([[5, 2, 4], [3, 0, 5], [0, 7, 2]], 3), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02435();
        Assert.That(sut.NumberOfPaths([[0, 0]], 5), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02435();
        Assert.That(sut.NumberOfPaths([[7, 3, 4, 9], [2, 3, 6, 2], [2, 3, 7, 0]], 1), Is.EqualTo(10));
    }
}