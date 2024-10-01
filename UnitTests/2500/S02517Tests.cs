using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02517Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02517();
        sut.MaximumTastiness([13, 5, 1, 8, 21, 2], 3).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S02517();
        sut.MaximumTastiness([1, 3, 1], 2).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02517();
        sut.MaximumTastiness([7, 7, 7, 7], 2).Should().Be(0);
    }
}
