using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03578))]
public class S03578Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03578();
        Assert.That(sut.CountPartitions([9, 4, 1, 3, 7], 4), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03578();
        Assert.That(sut.CountPartitions([3, 3, 4], 0), Is.EqualTo(2));
    }
}