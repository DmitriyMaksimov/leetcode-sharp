using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02958Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02958();
        sut.MaxSubarrayLength([1, 2, 3, 1, 2, 3, 1, 2], 2).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02958();
        sut.MaxSubarrayLength([1, 2, 1, 2, 1, 2, 1, 2], 1).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02958();
        sut.MaxSubarrayLength([5, 5, 5, 5, 5, 5, 5], 4).Should().Be(4);
    }
}