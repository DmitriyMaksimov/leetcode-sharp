using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01848Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01848();
        sut.GetMinDistance(new[] {1, 2, 3, 4, 5}, 5, 3).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01848();
        sut.GetMinDistance(new[] {1}, 1, 0).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01848();
        sut.GetMinDistance(new[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, 1, 0).Should().Be(0);
    }
}