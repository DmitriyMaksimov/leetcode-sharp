using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01187Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01187();
        sut.MakeArrayIncreasing(new[] {1, 5, 3, 6, 7}, new[] {1, 3, 2, 4}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01187();
        sut.MakeArrayIncreasing(new[] {1, 5, 3, 6, 7}, new[] {4, 3, 1}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01187();
        sut.MakeArrayIncreasing(new[] {1, 5, 3, 6, 7}, new[] {1, 6, 3, 3}).Should().Be(-1);
    }
}