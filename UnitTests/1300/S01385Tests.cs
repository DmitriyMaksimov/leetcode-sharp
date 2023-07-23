using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01385Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01385();
        sut.FindTheDistanceValue(new[] {4, 5, 8}, new[] {10, 9, 1, 8}, 2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01385();
        sut.FindTheDistanceValue(new[] {1, 4, 2, 3}, new[] {-4, -3, 6, 10, 20, 30}, 3).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01385();
        sut.FindTheDistanceValue(new[] {2, 1, 100, 3}, new[] {-5, -2, 10, -3, 7}, 6).Should().Be(1);
    }
}