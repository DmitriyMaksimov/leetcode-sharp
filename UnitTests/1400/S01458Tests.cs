using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01458Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01458();
        sut.MaxDotProduct(new[] {2, 1, -2, 5}, new[] {3, 0, -6}).Should().Be(18);
    }

    [Test]
    public void T2()
    {
        var sut = new S01458();
        sut.MaxDotProduct(new[] {3, -2}, new[] {2, -6, 7}).Should().Be(21);
    }

    [Test]
    public void T3()
    {
        var sut = new S01458();
        sut.MaxDotProduct(new[] {-1, -1}, new[] {1, 1}).Should().Be(-1);
    }
}