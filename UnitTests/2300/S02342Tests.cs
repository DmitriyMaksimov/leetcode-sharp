using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02342Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02342();
        Assert.That(sut.MaximumSum([18, 43, 36, 13, 7]), Is.EqualTo(54));
    }

    [Test]
    public void T2()
    {
        var sut = new S02342();
        Assert.That(sut.MaximumSum([10, 12, 19, 14]), Is.EqualTo(-1));
    }
}
