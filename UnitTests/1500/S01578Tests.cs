using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01578Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01578();
        sut.MinCost("abaac", new[] {1, 2, 3, 4, 5}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01578();
        sut.MinCost("abc", new[] {1, 2, 3}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01578();
        sut.MinCost("aabaa", new[] {1, 2, 3, 4, 1}).Should().Be(2);
    }
}