using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00406Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00406();
        sut.ReconstructQueue([[7, 0], [4, 4], [7, 1], [5, 0], [6, 1], [5, 2]]).Should()
            .BeEquivalentTo([(int[])[5, 0], [7, 0], [5, 2], [6, 1], [4, 4], [7, 1]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S00406();
        sut.ReconstructQueue([[6, 0], [5, 0], [4, 0], [3, 2], [2, 2], [1, 4]]).Should()
            .BeEquivalentTo([(int[])[4, 0], [5, 0], [2, 2], [3, 2], [1, 4], [6, 0]]);
    }
}