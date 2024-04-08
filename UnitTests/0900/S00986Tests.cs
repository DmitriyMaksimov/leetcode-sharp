using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00986Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00986();
        sut.IntervalIntersection([[0, 2], [5, 10], [13, 23], [24, 25]], [[1, 5], [8, 12], [15, 24], [25, 26]])
            .Should().BeEquivalentTo([(int[])[1, 2], [5, 5], [8, 10], [15, 23], [24, 24], [25, 25]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S00986();
        sut.IntervalIntersection([[1, 3], [5, 9]], []).Should().BeEmpty();
    }
}