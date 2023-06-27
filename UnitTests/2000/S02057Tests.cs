using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02057Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02057();
        sut.SmallestEqual(new[] {0, 1, 2}).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02057();
        sut.SmallestEqual(new[] {4, 3, 2, 1}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02057();
        sut.SmallestEqual(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}).Should().Be(-1);
    }
}