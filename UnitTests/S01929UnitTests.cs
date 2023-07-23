using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01929UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S01929();
        sut.GetConcatenation(new[] {1, 2, 1}).Should().Equal(1, 2, 1, 1, 2, 1);
    }

    [Test]
    public void Test2()
    {
        var sut = new S01929();
        sut.GetConcatenation(new[] {1, 3, 2, 1}).Should().Equal(1, 3, 2, 1, 1, 3, 2, 1);
    }
}