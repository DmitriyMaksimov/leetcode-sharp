using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01409Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01409();
        sut.ProcessQueries(new[] {3, 1, 2, 1}, 5).Should().Equal(2, 1, 2, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01409();
        sut.ProcessQueries(new[] {4, 1, 2, 2}, 4).Should().Equal(3, 1, 2, 0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01409();
        sut.ProcessQueries(new[] {7, 5, 5, 8, 3}, 8).Should().Equal(6, 5, 0, 7, 5);
    }
}