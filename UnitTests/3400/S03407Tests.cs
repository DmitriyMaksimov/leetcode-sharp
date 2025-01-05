using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03407Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03407();
        sut.HasMatch("leetcode", "ee*e").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03407();
        sut.HasMatch("car", "c*v").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S03407();
        sut.HasMatch("luck", "u*").Should().BeTrue();
    }
}
