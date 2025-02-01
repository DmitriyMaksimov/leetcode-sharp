using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00554Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00554();
        Assert.That(sut.LeastBricks([[1, 2, 2, 1], [3, 1, 2], [1, 3, 2], [2, 4], [3, 1, 2], [1, 3, 1, 1]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00554();
        Assert.That(sut.LeastBricks([[1], [1], [1]]), Is.EqualTo(3));
    }
}
