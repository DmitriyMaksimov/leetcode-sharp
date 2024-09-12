using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01492Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01492();
        sut.KthFactor(12, 3).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01492();
        sut.KthFactor(7, 2).Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S01492();
        sut.KthFactor(4, 4).Should().Be(-1);
    }
}
