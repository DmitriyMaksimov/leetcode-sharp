using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01673Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01673();
        sut.MostCompetitive([3, 5, 2, 6], 2).Should().Equal(2, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01673();
        sut.MostCompetitive([2, 4, 3, 3, 5, 4, 9, 6], 4).Should().Equal(2, 3, 3, 4);
    }
}
