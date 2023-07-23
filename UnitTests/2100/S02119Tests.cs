using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02119Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02119();
        sut.IsSameAfterReversals(526).Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02119();
        sut.IsSameAfterReversals(1800).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S02119();
        sut.IsSameAfterReversals(0).Should().BeTrue();
    }
}