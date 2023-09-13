using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02016Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02016();
        sut.MaximumDifference(new[] {7, 1, 5, 4}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02016();
        sut.MaximumDifference(new[] {9, 4, 3, 2}).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02016();
        sut.MaximumDifference(new[] {1, 5, 2, 10}).Should().Be(9);
    }
}