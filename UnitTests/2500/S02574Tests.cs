using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02574Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02574();
        sut.LeftRightDifference(new[] {10, 4, 8, 3}).Should().Equal(15, 1, 11, 22);
    }

    [Test]
    public void T2()
    {
        var sut = new S02574();
        sut.LeftRightDifference(new[] {1}).Should().Equal(0);
    }
}