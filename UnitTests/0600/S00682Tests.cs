using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00682Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00682();
        sut.CalPoints(new[] {"5", "2", "C", "D", "+"}).Should().Be(30);
    }

    [Test]
    public void T2()
    {
        var sut = new S00682();
        sut.CalPoints(new[] {"5", "-2", "4", "C", "D", "9", "+", "+"}).Should().Be(27);
    }

    [Test]
    public void T3()
    {
        var sut = new S00682();
        sut.CalPoints(new[] {"1", "C"}).Should().Be(0);
    }
}