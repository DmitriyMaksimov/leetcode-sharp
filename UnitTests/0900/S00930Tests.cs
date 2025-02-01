using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00930Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00930();
        Assert.That(sut.NumSubarraysWithSum([1, 0, 1, 0, 1], 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00930();
        Assert.That(sut.NumSubarraysWithSum([0, 0, 0, 0, 0], 0), Is.EqualTo(15));
    }
}