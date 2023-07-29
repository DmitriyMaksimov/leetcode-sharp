using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00808Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00808();
        sut.SoupServings(50).Should().Be(0.625);
    }

    [Test]
    public void T2()
    {
        var sut = new S00808();
        sut.SoupServings(100).Should().Be(0.71875);
    }
}