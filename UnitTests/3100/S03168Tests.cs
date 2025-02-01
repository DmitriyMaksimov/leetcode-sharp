using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03168Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03168();
        Assert.That(sut.MinimumChairs("EEEEEEE"), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S03168();
        Assert.That(sut.MinimumChairs("ELELEEL"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03168();
        Assert.That(sut.MinimumChairs("ELEELEELLL"), Is.EqualTo(3));
    }
}