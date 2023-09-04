using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00868Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00868();
        sut.BinaryGap(22).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00868();
        sut.BinaryGap(8).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00868();
        sut.BinaryGap(5).Should().Be(2);
    }
}