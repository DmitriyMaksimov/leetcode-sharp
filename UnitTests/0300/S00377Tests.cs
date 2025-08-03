using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00377Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00377();
        Assert.That(sut.CombinationSum4([1, 2, 3], 4), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S00377();
        Assert.That(sut.CombinationSum4([9], 3), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00377();
        Assert.That(sut.CombinationSum4([4, 2, 1], 32), Is.EqualTo(39882198));
    }
}