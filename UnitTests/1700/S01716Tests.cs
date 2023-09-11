using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01716Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01716();
        sut.TotalMoney(4).Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S01716();
        sut.TotalMoney(10).Should().Be(37);
    }

    [Test]
    public void T3()
    {
        var sut = new S01716();
        sut.TotalMoney(20).Should().Be(96);
    }
}