using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00560Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00560();
        Assert.That(sut.SubarraySum([1, 1, 1], 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00560();
        Assert.That(sut.SubarraySum([1, 2, 3], 3), Is.EqualTo(2));
    }
}