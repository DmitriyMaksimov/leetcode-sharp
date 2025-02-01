using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00403Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00403();
        var stones = new[] {0, 1, 3, 5, 6, 8, 12, 17};
        Assert.That(sut.CanCross(stones), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00403();
        var stones = new[] {0, 1, 2, 3, 4, 8, 9, 11};
        Assert.That(sut.CanCross(stones), Is.False);
    }
}
