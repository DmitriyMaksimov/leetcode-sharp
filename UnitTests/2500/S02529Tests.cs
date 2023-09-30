using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02529Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02529();
        sut.MaximumCount(new[] {-2, -1, -1, 1, 2, 3}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02529();
        sut.MaximumCount(new[] {-3, -2, -1, 0, 0, 1, 2}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02529();
        sut.MaximumCount(new[] {5, 20, 66, 1314}).Should().Be(4);
    }
}