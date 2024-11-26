using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00417Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00417();
        sut.PacificAtlantic([[1, 2, 2, 3, 5], [3, 2, 3, 4, 4], [2, 4, 5, 3, 1], [6, 7, 1, 4, 5], [5, 1, 1, 2, 4]]).Should()
            .BeEquivalentTo([(int[]) [0, 4], [1, 3], [1, 4], [2, 2], [3, 0], [3, 1], [4, 0]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S00417();
        sut.PacificAtlantic([[1]]).Should().BeEquivalentTo([(int[]) [0, 0]]);
    }
}
