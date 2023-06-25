using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00461Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00461();
        sut.HammingDistance(1, 4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00461();
        sut.HammingDistance(3, 1).Should().Be(1);
    }
}