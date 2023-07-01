using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02305Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02305();
        sut.DistributeCookies(new[] {8, 15, 10, 20, 8}, 2).Should().Be(31);
    }

    [Test]
    public void T2()
    {
        var sut = new S02305();
        sut.DistributeCookies(new[] {6, 1, 3, 2, 2, 4, 1, 2}, 3).Should().Be(7);
    }
}