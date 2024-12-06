using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00991Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00991();
        sut.BrokenCalc(2, 3).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00991();
        sut.BrokenCalc(5, 8).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00991();
        sut.BrokenCalc(3, 10).Should().Be(3);
    }
}
