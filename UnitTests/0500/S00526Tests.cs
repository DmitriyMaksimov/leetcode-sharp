using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00526Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00526();
        sut.CountArrangement(2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00526();
        sut.CountArrangement(1).Should().Be(1);
    }
}
