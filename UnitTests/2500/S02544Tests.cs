using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02544Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02544();
        sut.AlternateDigitSum(521).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02544();
        sut.AlternateDigitSum(111).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02544();
        sut.AlternateDigitSum(886996).Should().Be(0);
    }
}