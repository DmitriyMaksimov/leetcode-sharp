using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03223Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03223();
        Assert.That(sut.MinimumLength("abaacbcbb"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03223();
        Assert.That(sut.MinimumLength("aa"), Is.EqualTo(2));
    }
}
