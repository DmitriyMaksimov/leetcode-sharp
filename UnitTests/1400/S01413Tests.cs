using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01413Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01413();
        sut.MinStartValue(new[] {-3, 2, -3, 4, 2}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01413();
        sut.MinStartValue(new[] {1, 2}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01413();
        sut.MinStartValue(new[] {1, -2, -3}).Should().Be(5);
    }
}