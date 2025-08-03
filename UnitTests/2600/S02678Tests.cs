using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02678Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02678();
        Assert.That(sut.CountSeniors(["7868190130M7522", "5303914400F9211", "9273338290F4010"]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02678();
        Assert.That(sut.CountSeniors(["1313579440F2036", "2921522980M5644"]), Is.EqualTo(0));
    }
}