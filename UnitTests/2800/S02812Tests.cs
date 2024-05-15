using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02812Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02812();
        sut.MaximumSafenessFactor([[1, 0, 0], [0, 0, 0], [0, 0, 1]]).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02812();
        sut.MaximumSafenessFactor([[0, 0, 1], [0, 0, 0], [0, 0, 0]]).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02812();
        sut.MaximumSafenessFactor([[0, 0, 0, 1], [0, 0, 0, 0], [0, 0, 0, 0], [1, 0, 0, 0]]).Should().Be(2);
    }
}