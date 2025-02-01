using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01717Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01717();
        Assert.That(sut.MaximumGain("cdbcbbaaabab", 4, 5), Is.EqualTo(19));
    }

    [Test]
    public void T2()
    {
        var sut = new S01717();
        Assert.That(sut.MaximumGain("aabbaaxybbaabb", 5, 4), Is.EqualTo(20));
    }
}