using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00724Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00724();
        sut.PivotIndex(new[] {1, 7, 3, 6, 5, 6}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00724();
        sut.PivotIndex(new[] {1, 2, 3}).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00724();
        sut.PivotIndex(new[] {2, 1, -1}).Should().Be(0);
    }
}