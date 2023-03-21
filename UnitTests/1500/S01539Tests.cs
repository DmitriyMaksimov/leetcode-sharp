using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01539Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01539();
        sut.FindKthPositive(new[] {2, 3, 4, 7, 11}, 5).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S01539();
        sut.FindKthPositive(new[] {1,2,3,4}, 2).Should().Be(6);
    }
}