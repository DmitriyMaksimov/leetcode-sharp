using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01137Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01137();

        sut.Tribonacci(4).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01137();

        sut.Tribonacci(25).Should().Be(1389537);
    }

    [Test]
    public void T3()
    {
        var sut = new S01137();

        sut.Tribonacci(37).Should().Be(2082876103);
    }
}