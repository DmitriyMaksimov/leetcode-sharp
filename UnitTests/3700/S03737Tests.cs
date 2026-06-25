using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03737))]
public class S03737Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03737();
        Assert.That(sut.CountMajoritySubarrays([1, 2, 2, 3], 2), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03737();
        Assert.That(sut.CountMajoritySubarrays([1, 1, 1, 1], 1), Is.EqualTo(10));
    }

    [Test]
    public void T3()
    {
        var sut = new S03737();
        Assert.That(sut.CountMajoritySubarrays([1, 2, 3], 4), Is.Zero);
    }
}