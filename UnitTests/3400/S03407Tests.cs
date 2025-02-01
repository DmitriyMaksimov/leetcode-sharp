using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03407Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03407();
        Assert.That(sut.HasMatch("leetcode", "ee*e"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03407();
        Assert.That(sut.HasMatch("car", "c*v"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03407();
        Assert.That(sut.HasMatch("luck", "u*"), Is.True);
    }
}
