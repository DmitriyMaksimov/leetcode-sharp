using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01791Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01791();
        Assert.That(sut.FindCenter([[1, 2], [2, 3], [4, 2]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01791();
        Assert.That(sut.FindCenter([[1, 2], [5, 1], [1, 3], [1, 4]]), Is.EqualTo(1));
    }
}