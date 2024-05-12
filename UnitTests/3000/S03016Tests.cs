using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03016Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03016();
        sut.MinimumPushes("abcde").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S03016();
        sut.MinimumPushes("xyzxyzxyzxyz").Should().Be(12);
    }

    [Test]
    public void T3()
    {
        var sut = new S03016();
        sut.MinimumPushes("aabbccddeeffgghhiiiiii").Should().Be(24);
    }
}