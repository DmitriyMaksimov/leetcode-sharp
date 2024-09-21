using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01227Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01227();
        sut.NthPersonGetsNthSeat(1).Should().Be(1.0);
    }

    [Test]
    public void T2()
    {
        var sut = new S01227();
        sut.NthPersonGetsNthSeat(2).Should().Be(0.5);
    }
}
