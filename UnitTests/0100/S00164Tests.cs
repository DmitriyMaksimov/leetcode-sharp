using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00164Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00164();
        Assert.That(sut.MaximumGap([3, 6, 9, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00164();
        Assert.That(sut.MaximumGap([10]), Is.EqualTo(0));
    }
}
