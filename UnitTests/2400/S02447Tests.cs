using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02447Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02447();
        Assert.That(sut.SubarrayGCD([9, 3, 1, 2, 6, 3], 3), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02447();
        Assert.That(sut.SubarrayGCD([4], 7), Is.EqualTo(0));
    }
}
