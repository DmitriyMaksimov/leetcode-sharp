using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02441Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02441();
        sut.FindMaxK(new[] {-1, 2, -3, 3}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02441();
        sut.FindMaxK(new[] {-1, 10, 6, 7, -7, 1}).Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S02441();
        sut.FindMaxK(new[] {-10, 8, 6, 7, -2, -3}).Should().Be(-1);
    }
}