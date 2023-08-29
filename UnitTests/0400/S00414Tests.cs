using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00414Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00414();
        sut.ThirdMax(new[] {3, 2, 1}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00414();
        sut.ThirdMax(new[] {1, 2}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00414();
        sut.ThirdMax(new[] {2, 2, 3, 1}).Should().Be(1);
    }

    [Test]
    public void T4()
    {
        var sut = new S00414();
        sut.ThirdMax(new[] {1, 2, 2, 5, 3, 5}).Should().Be(2);
    }
}