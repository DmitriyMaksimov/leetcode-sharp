using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02180Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02180();
        sut.CountEven(4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02180();
        sut.CountEven(30).Should().Be(14);
    }
}