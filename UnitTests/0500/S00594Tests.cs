using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00594Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00594();
        sut.FindLHS(new[] {1, 3, 2, 2, 5, 2, 3, 7}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00594();
        sut.FindLHS(new[] {1, 2, 3, 4}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00594();
        sut.FindLHS(new[] {1, 1, 1, 1}).Should().Be(0);
    }
}