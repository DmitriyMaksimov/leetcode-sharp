using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03016Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03016();
        Assert.That(sut.MinimumPushes("abcde"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03016();
        Assert.That(sut.MinimumPushes("xyzxyzxyzxyz"), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S03016();
        Assert.That(sut.MinimumPushes("aabbccddeeffgghhiiiiii"), Is.EqualTo(24));
    }
}