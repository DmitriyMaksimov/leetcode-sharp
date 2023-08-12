using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00041Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00041();
        sut.FirstMissingPositive(new[] {1, 2, 0}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00041();
        sut.FirstMissingPositive(new[] {3, 4, -1, 1}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00041();
        sut.FirstMissingPositive(new[] {7, 8, 9, 11, 12}).Should().Be(1);
    }
}