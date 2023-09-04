using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00896Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00896();
        sut.IsMonotonic(new[] {1, 2, 2, 3}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00896();
        sut.IsMonotonic(new[] {6, 5, 4, 4}).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S00896();
        sut.IsMonotonic(new[] {1, 3, 2}).Should().BeFalse();
    }
}