using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01005Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01005();
        sut.LargestSumAfterKNegations(new[] {4, 2, 3}, 1).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01005();
        sut.LargestSumAfterKNegations(new[] {3, -1, 0, 2}, 3).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S01005();
        sut.LargestSumAfterKNegations(new[] {2, -3, -1, 5, -4}, 2).Should().Be(13);
    }
}