using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02090Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02090();
        sut.GetAverages(new[] {7, 4, 3, 9, 1, 8, 5, 2, 6}, 3).Should().Equal(-1, -1, -1, 5, 4, 4, -1, -1, -1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02090();
        sut.GetAverages(new[] {100000}, 0).Should().Equal(100000);
    }

    [Test]
    public void T3()
    {
        var sut = new S02090();
        sut.GetAverages(new[] {8}, 100000).Should().Equal(-1);
    }
}