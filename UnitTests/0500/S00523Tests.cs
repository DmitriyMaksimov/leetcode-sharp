using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00523Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00523();
        Assert.That(sut.CheckSubarraySum([23, 2, 4, 6, 7], 6), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00523();
        Assert.That(sut.CheckSubarraySum([23, 2, 6, 4, 7], 6), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00523();
        Assert.That(sut.CheckSubarraySum([23, 2, 6, 4, 7], 13), Is.False);
    }
}
