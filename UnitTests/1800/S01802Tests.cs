using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01802Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01802();
        sut.MaxValue(4, 2, 6).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01802();
        sut.MaxValue(6, 1, 10).Should().Be(3);
    }
}