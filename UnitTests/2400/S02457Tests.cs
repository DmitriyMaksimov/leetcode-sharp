using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02457Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02457();
        sut.MakeIntegerBeautiful(16, 6).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02457();
        sut.MakeIntegerBeautiful(467, 6).Should().Be(33);
    }

    [Test]
    public void T3()
    {
        var sut = new S02457();
        sut.MakeIntegerBeautiful(1, 1).Should().Be(0);
    }
}