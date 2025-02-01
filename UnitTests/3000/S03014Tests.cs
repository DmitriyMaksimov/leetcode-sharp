using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03014Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03014();
        Assert.That(sut.MinimumPushes("abcde"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03014();
        Assert.That(sut.MinimumPushes("xycdefghij"), Is.EqualTo(12));
    }
}