using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01937Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01937();
        Assert.That(sut.MaxPoints([[1, 2, 3], [1, 5, 1], [3, 1, 1]]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S01937();
        Assert.That(sut.MaxPoints([[1, 5], [2, 3], [4, 2]]), Is.EqualTo(11));
    }
}
