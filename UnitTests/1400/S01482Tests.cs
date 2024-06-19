using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01482Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01482();
        sut.MinDays([1, 10, 3, 10, 2], 3, 1).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01482();
        sut.MinDays([1, 10, 3, 10, 2], 3, 2).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01482();
        sut.MinDays([7, 7, 7, 7, 12, 7, 7], 2, 3).Should().Be(12);
    }
}