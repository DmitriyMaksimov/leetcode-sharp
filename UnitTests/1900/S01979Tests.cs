using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01979Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01979();
        sut.FindGCD(new[] {2, 5, 6, 9, 10}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01979();
        sut.FindGCD(new[] {7, 5, 6, 8, 3}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01979();
        sut.FindGCD(new[] {3, 3}).Should().Be(3);
    }
}