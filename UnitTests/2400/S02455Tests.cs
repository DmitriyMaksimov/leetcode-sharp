using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02455Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02455();
        sut.AverageValue(new[] {1, 3, 6, 10, 12, 15}).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02455();
        sut.AverageValue(new[] {1, 2, 4, 7, 10}).Should().Be(0);
    }
}