using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01893Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01893();
        Assert.That(sut.IsCovered([[1, 2], [3, 4], [5, 6]], 2, 5), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01893();
        Assert.That(sut.IsCovered([[1, 10], [10, 20]], 21, 21), Is.False);
    }
}
