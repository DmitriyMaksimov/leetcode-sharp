using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02155Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02155();
        sut.MaxScoreIndices([0, 0, 1, 0]).Should().Equal(2, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02155();
        sut.MaxScoreIndices([0, 0, 0]).Should().Equal(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02155();
        sut.MaxScoreIndices([1, 1]).Should().Equal(0);
    }
}
