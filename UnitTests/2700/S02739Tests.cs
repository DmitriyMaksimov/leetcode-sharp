using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02739Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02739();
        sut.DistanceTraveled(5, 10).Should().Be(60);
    }

    [Test]
    public void T2()
    {
        var sut = new S02739();
        sut.DistanceTraveled(1, 2).Should().Be(10);
    }
}