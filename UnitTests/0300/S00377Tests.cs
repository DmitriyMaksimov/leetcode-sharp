using leetcode_sharp._0300;

namespace UnitTests;

[TestFixture]
public class S00377Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00377();
        sut.CombinationSum4(new[] {1, 2, 3}, 4).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S00377();
        sut.CombinationSum4(new[] {9}, 3).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00377();
        sut.CombinationSum4(new[] {4, 2, 1}, 32).Should().Be(39882198);
    }
}