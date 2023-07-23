using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01480UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S01480();
        sut.RunningSum(new[] {1, 2, 3, 4}).Should().Equal(1, 3, 6, 10);
    }

    [Test]
    public void Test2()
    {
        var sut = new S01480();
        sut.RunningSum(new[] {1, 1, 1, 1, 1}).Should().Equal(1, 2, 3, 4, 5);
    }

    [Test]
    public void Test3()
    {
        var sut = new S01480();
        sut.RunningSum(new[] {3, 1, 2, 10, 1}).Should().Equal(3, 4, 6, 16, 17);
    }
}