using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00440Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00440();
        sut.FindKthNumber(13, 2).Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S00440();
        sut.FindKthNumber(1, 1).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00440();
        sut.FindKthNumber(681692778, 351251360).Should().Be(416126219);
    }

    [Test]
    public void T4()
    {
        var sut = new S00440();
        sut.FindKthNumber(304089173, 87099045).Should().Be(178389137);
    }
}
