using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01920UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S01920();
        sut.BuildArray(new[] {0, 2, 1, 5, 3, 4}).Should().Equal(0, 1, 2, 4, 5, 3);
    }

    [Test]
    public void Test2()
    {
        var sut = new S01920();
        sut.BuildArray(new[] {5, 0, 1, 2, 3, 4}).Should().Equal(4, 5, 0, 1, 2, 3);
    }
}