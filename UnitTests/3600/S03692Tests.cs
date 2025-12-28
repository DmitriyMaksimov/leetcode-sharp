using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03692))]
public class S03692Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03692();
        Assert.That(sut.MajorityFrequencyGroup("aaabbbccdddde"), Is.EqualTo("ab"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03692();
        Assert.That(sut.MajorityFrequencyGroup("abcd"), Is.EqualTo("abcd"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03692();
        Assert.That(sut.MajorityFrequencyGroup("pfpfgi"), Is.EqualTo("pf"));
    }
}